using RemoteViewerApp.DTOs;
using RemoteViewerApp.Helpers;
using RemoteViewerApp.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RemoteViewerApp.Controls;

public sealed class RemoteScreenControl : PictureBox
{
    private SignalRViewerService? _signalR;
    private string _sessionId = string.Empty;
    private int _hostScreenWidth = 1920;
    private int _hostScreenHeight = 1080;
    private int _hostMouseX, _hostMouseY;

    private Bitmap? _frame;
    // Bitmap chờ để swap — SignalR thread ghi, UI thread đọc
    private Bitmap? _pendingFrame;

    private DateTime _lastMoveSent = DateTime.MinValue;
    private const int MoveThrottleMs = 33;

    private const int WM_KEYDOWN = 0x0100;
    private const int WM_KEYUP = 0x0101;
    private const int WM_SYSKEYDOWN = 0x0104;
    private const int WM_SYSKEYUP = 0x0105;

    public RemoteScreenControl()
    {
        SetStyle(ControlStyles.Selectable
               | ControlStyles.UserPaint
               | ControlStyles.AllPaintingInWmPaint
               | ControlStyles.OptimizedDoubleBuffer, true);
        TabStop = true;
        BackColor = Color.Black;

        MouseDown += (_, _) => { if (!Focused) Focus(); };
        MouseMove += OnMouseMove;
        MouseWheel += OnMouseWheel;
        MouseClick += OnMouseClick;
        MouseDoubleClick += OnMouseDoubleClick;
    }

    public void Initialize(SignalRViewerService signalR, string sessionId)
    {
        _signalR = signalR;
        _sessionId = sessionId;
    }

    public void Detach()
    {
        _signalR = null;
        _sessionId = string.Empty;
        ClearFrame();
    }

    /// <summary>
    /// Gọi từ SignalR thread — KHÔNG BeginInvoke nữa.
    /// Chỉ swap _pendingFrame rồi gọi Invalidate() (thread-safe).
    /// UI thread sẽ apply frame trong OnPaint lần tới.
    /// </summary>
    public void UpdateFrame(Bitmap bitmap, int screenW, int screenH, int mouseX, int mouseY)
    {
        _hostScreenWidth = screenW;
        _hostScreenHeight = screenH;
        _hostMouseX = mouseX;
        _hostMouseY = mouseY;

        // Swap pending — dispose frame cũ nếu UI chưa kịp vẽ
        var old = System.Threading.Interlocked.Exchange(ref _pendingFrame, bitmap);
        old?.Dispose();

        // Invalidate thread-safe — WinForms cho phép gọi từ bất kỳ thread nào
        Invalidate();
    }

    private void ClearFrame()
    {
        var old = System.Threading.Interlocked.Exchange(ref _pendingFrame, null);
        old?.Dispose();

        old = System.Threading.Interlocked.Exchange(ref _frame, null);
        old?.Dispose();

        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // Apply pending frame trên UI thread (không cần lock — Interlocked đủ)
        var pending = System.Threading.Interlocked.Exchange(ref _pendingFrame, null);
        if (pending != null)
        {
            var old = _frame;
            _frame = pending;
            old?.Dispose();
        }

        e.Graphics.Clear(BackColor);
        if (_frame == null) return;

        var destRect = CalcLetterboxRect(
            _frame.Width, _frame.Height,
            ClientSize.Width, ClientSize.Height);

        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        e.Graphics.DrawImage(_frame, destRect);

        // Cursor Host
        var (cx, cy) = HostToControl(_hostMouseX, _hostMouseY, destRect);
        using var pen = new Pen(Color.Red, 2f);
        const int r = 7;
        e.Graphics.DrawLine(pen, cx - r, cy, cx + r, cy);
        e.Graphics.DrawLine(pen, cx, cy - r, cx, cy + r);
    }

    // ── Coordinate helpers ────────────────────────────────────────────────────

    private static Rectangle CalcLetterboxRect(int imgW, int imgH, int ctrlW, int ctrlH)
    {
        if (imgW == 0 || imgH == 0) return Rectangle.Empty;
        double scale = Math.Min((double)ctrlW / imgW, (double)ctrlH / imgH);
        int w = (int)(imgW * scale), h = (int)(imgH * scale);
        return new Rectangle((ctrlW - w) / 2, (ctrlH - h) / 2, w, h);
    }

    private (int hx, int hy) ControlToHost(int px, int py)
    {
        if (_frame == null || _hostScreenWidth == 0) return (px, py);
        var r = CalcLetterboxRect(_frame.Width, _frame.Height, ClientSize.Width, ClientSize.Height);
        if (r.Width == 0) return (0, 0);
        double fx = Math.Clamp((double)(px - r.X) / r.Width, 0, 1);
        double fy = Math.Clamp((double)(py - r.Y) / r.Height, 0, 1);
        return ((int)(fx * _hostScreenWidth), (int)(fy * _hostScreenHeight));
    }

    private static (int cx, int cy) HostToControl(int hx, int hy, Rectangle imgRect)
    {
        if (imgRect.Width == 0) return (0, 0);
        return (imgRect.X + hx * imgRect.Width / Math.Max(1, imgRect.Width),
                imgRect.Y + hy * imgRect.Height / Math.Max(1, imgRect.Height));
    }

    // ── Keyboard ──────────────────────────────────────────────────────────────

    public override bool PreProcessMessage(ref Message msg)
    {
        if (_signalR == null || string.IsNullOrEmpty(_sessionId))
            return base.PreProcessMessage(ref msg);

        if (msg.Msg == WM_KEYDOWN || msg.Msg == WM_SYSKEYDOWN)
        {
            SendKey("KeyDown", (Keys)(int)msg.WParam & Keys.KeyCode, ModifierKeys);
            return true;
        }
        if (msg.Msg == WM_KEYUP || msg.Msg == WM_SYSKEYUP)
        {
            SendKey("KeyUp", (Keys)(int)msg.WParam & Keys.KeyCode, ModifierKeys);
            return true;
        }
        return base.PreProcessMessage(ref msg);
    }

    private void SendKey(string action, Keys keyCode, Keys mods)
    {
        var (keyName, code) = KeyMapper.Map(keyCode);
        _ = _signalR!.SendKeyboardEvent(new KeyboardEventDto
        {
            SessionId = _sessionId,
            Action = action,
            Key = keyName,
            Code = code,
            CtrlKey = mods.HasFlag(Keys.Control),
            ShiftKey = mods.HasFlag(Keys.Shift),
            AltKey = mods.HasFlag(Keys.Alt),
            SentAt = DateTime.UtcNow
        });
    }

    protected override bool IsInputKey(Keys keyData) => true;
    protected override bool IsInputChar(char charCode) => true;

    // ── Mouse ─────────────────────────────────────────────────────────────────

    private void OnMouseMove(object? sender, MouseEventArgs e)
    {
        if (_signalR == null || string.IsNullOrEmpty(_sessionId)) return;
        if ((DateTime.Now - _lastMoveSent).TotalMilliseconds < MoveThrottleMs) return;
        _lastMoveSent = DateTime.Now;
        var (hx, hy) = ControlToHost(e.X, e.Y);
        _ = _signalR.SendMouseEvent(new MouseEventDto
        {
            SessionId = _sessionId,
            Action = "Move",
            X = hx,
            Y = hy,
            ScreenWidth = _hostScreenWidth,
            ScreenHeight = _hostScreenHeight,
            SentAt = DateTime.UtcNow
        });
    }

    private void OnMouseClick(object? sender, MouseEventArgs e)
    {
        if (_signalR == null || string.IsNullOrEmpty(_sessionId)) return;
        var (hx, hy) = ControlToHost(e.X, e.Y);
        string? action = e.Button switch
        {
            MouseButtons.Left => "LeftClick",
            MouseButtons.Right => "RightClick",
            MouseButtons.Middle => "MiddleClick",
            _ => null
        };
        if (action == null) return;
        _ = _signalR.SendMouseEvent(new MouseEventDto
        {
            SessionId = _sessionId,
            Action = action,
            X = hx,
            Y = hy,
            ScreenWidth = _hostScreenWidth,
            ScreenHeight = _hostScreenHeight,
            Button = e.Button == MouseButtons.Right ? 2 : e.Button == MouseButtons.Middle ? 1 : 0,
            SentAt = DateTime.UtcNow
        });
    }

    private void OnMouseDoubleClick(object? sender, MouseEventArgs e)
    {
        if (_signalR == null || e.Button != MouseButtons.Left) return;
        var (hx, hy) = ControlToHost(e.X, e.Y);
        _ = _signalR.SendMouseEvent(new MouseEventDto
        {
            SessionId = _sessionId,
            Action = "DoubleClick",
            X = hx,
            Y = hy,
            ScreenWidth = _hostScreenWidth,
            ScreenHeight = _hostScreenHeight,
            SentAt = DateTime.UtcNow
        });
    }

    private void OnMouseWheel(object? sender, MouseEventArgs e)
    {
        if (_signalR == null || string.IsNullOrEmpty(_sessionId)) return;
        var (hx, hy) = ControlToHost(e.X, e.Y);
        _ = _signalR.SendMouseEvent(new MouseEventDto
        {
            SessionId = _sessionId,
            Action = "Scroll",
            X = hx,
            Y = hy,
            ScreenWidth = _hostScreenWidth,
            ScreenHeight = _hostScreenHeight,
            Delta = e.Delta / 120,
            SentAt = DateTime.UtcNow
        });
    }
}