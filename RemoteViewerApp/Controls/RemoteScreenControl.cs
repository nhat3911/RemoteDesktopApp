using RemoteViewerApp.DTOs;
using RemoteViewerApp.Helpers;
using RemoteViewerApp.Services;

namespace RemoteViewerApp.Controls;

public sealed class RemoteScreenControl : PictureBox
{
    private SignalRViewerService? _signalR;
    private string _sessionId = string.Empty;
    private int _hostScreenWidth = 1920;
    private int _hostScreenHeight = 1080;

    // Vị trí chuột Host để vẽ cursor chồng lên ảnh
    private int _hostMouseX;
    private int _hostMouseY;

    // Throttle mouse move ~30fps
    private DateTime _lastMoveSent = DateTime.MinValue;
    private const int MoveThrottleMs = 33;

    // Frame hiện tại — Bitmap đã decode sẵn (không dùng stream lazy)
    private Bitmap? _frame;

    // Windows message constants
    private const int WM_KEYDOWN = 0x0100;
    private const int WM_KEYUP = 0x0101;
    private const int WM_SYSKEYDOWN = 0x0104;
    private const int WM_SYSKEYUP = 0x0105;

    public RemoteScreenControl()
    {
        SetStyle(ControlStyles.Selectable | ControlStyles.UserPaint
               | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        TabStop = true;
        BackColor = Color.Black;

        // Chuột
        MouseDown += OnMouseDown;
        MouseMove += OnMouseMove;
        MouseWheel += OnMouseWheel;
        MouseClick += OnMouseClick;
        MouseDoubleClick += OnMouseDoubleClick;

        // Focus khi click
        MouseDown += (_, _) => { if (!Focused) Focus(); };
    }

    //  Public API 

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
    /// Nhận Bitmap đã decode sẵn (không còn phụ thuộc stream).
    /// MainForm decode từ Base64 → Bitmap rồi gọi hàm này.
    /// </summary>
    public void UpdateFrame(Bitmap bitmap, int screenW, int screenH, int mouseX, int mouseY)
    {
        _hostScreenWidth = screenW;
        _hostScreenHeight = screenH;
        _hostMouseX = mouseX;
        _hostMouseY = mouseY;

        if (InvokeRequired)
            BeginInvoke(() => SwapFrame(bitmap));
        else
            SwapFrame(bitmap);
    }

    private void SwapFrame(Bitmap newBitmap)
    {
        var old = _frame;
        _frame = newBitmap;
        old?.Dispose();
        Invalidate();
    }

    private void ClearFrame()
    {
        if (InvokeRequired)
            BeginInvoke(ClearFrame);
        else
        {
            var old = _frame;
            _frame = null;
            old?.Dispose();
            Invalidate();
        }
    }

    //  Vẽ frame + cursor Host 

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.Clear(BackColor);

        if (_frame == null) return;

        // Vẽ ảnh scale vừa khít control, giữ tỉ lệ (letterbox)
        var destRect = CalcLetterboxRect(_frame.Width, _frame.Height, ClientSize.Width, ClientSize.Height);
        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        e.Graphics.DrawImage(_frame, destRect);

        // Vẽ cursor Host (chữ thập đỏ)
        var (cx, cy) = HostToControl(_hostMouseX, _hostMouseY, destRect);
        using var pen = new Pen(Color.Red, 2f);
        const int r = 7;
        e.Graphics.DrawLine(pen, cx - r, cy, cx + r, cy);
        e.Graphics.DrawLine(pen, cx, cy - r, cx, cy + r);
    }

    //  Tính tọa độ letterbox 
    
    private static Rectangle CalcLetterboxRect(int imgW, int imgH, int ctrlW, int ctrlH)
    {
        if (imgW == 0 || imgH == 0) return Rectangle.Empty;

        double scaleX = (double)ctrlW / imgW;
        double scaleY = (double)ctrlH / imgH;
        double scale = Math.Min(scaleX, scaleY);

        int w = (int)(imgW * scale);
        int h = (int)(imgH * scale);
        int x = (ctrlW - w) / 2;
        int y = (ctrlH - h) / 2;

        return new Rectangle(x, y, w, h);
    }

    private (int cx, int cy) ControlToHost(int px, int py)
    {
        if (_frame == null || _hostScreenWidth == 0 || _hostScreenHeight == 0)
            return (px, py);

        var r = CalcLetterboxRect(_frame.Width, _frame.Height, ClientSize.Width, ClientSize.Height);
        if (r.Width == 0 || r.Height == 0) return (0, 0);

        // Tọa độ trong ảnh frame (pixel frame)
        double fx = Math.Clamp((double)(px - r.X) / r.Width, 0, 1);
        double fy = Math.Clamp((double)(py - r.Y) / r.Height, 0, 1);

        // Tọa độ thực trên màn hình Host
        return ((int)(fx * (_hostScreenWidth - 1)), (int)(fy * (_hostScreenHeight - 1)));
    }

    private (int cx, int cy) HostToControl(int hx, int hy, Rectangle imgRect)
    {
        int cx = imgRect.X + (int)((double)hx / _hostScreenWidth * imgRect.Width);
        int cy = imgRect.Y + (int)((double)hy / _hostScreenHeight * imgRect.Height);

        return (cx, cy);
    }

    public override bool PreProcessMessage(ref Message msg)
    {
        if (_signalR == null || string.IsNullOrEmpty(_sessionId))
            return base.PreProcessMessage(ref msg);

        if (msg.Msg == WM_KEYDOWN || msg.Msg == WM_SYSKEYDOWN)
        {
            var keyCode = (Keys)(int)msg.WParam & Keys.KeyCode;
            var mods = ModifierKeys;
            SendKey("KeyDown", keyCode, mods);
            return true; // đã xử lý, không truyền tiếp
        }

        if (msg.Msg == WM_KEYUP || msg.Msg == WM_SYSKEYUP)
        {
            var keyCode = (Keys)(int)msg.WParam & Keys.KeyCode;
            var mods = ModifierKeys;
            SendKey("KeyUp", keyCode, mods);
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
        LoggingHelper.Debug($"{action}: Key={keyName} Code={code} Ctrl={mods.HasFlag(Keys.Control)} Shift={mods.HasFlag(Keys.Shift)}");
    }

    // IsInputKey và IsInputChar — cho phép control nhận TẤT CẢ phím
    protected override bool IsInputKey(Keys keyData) => true;
    protected override bool IsInputChar(char charCode) => true;

    //  Mouse events 

    private void OnMouseDown(object? sender, MouseEventArgs e) { /* handled via MouseClick */ }

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
            Button = 0,
            Delta = 0,
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

        int btn = e.Button switch
        {
            MouseButtons.Right => 2,
            MouseButtons.Middle => 1,
            _ => 0
        };

        _ = _signalR.SendMouseEvent(new MouseEventDto
        {
            SessionId = _sessionId,
            Action = action,
            X = hx,
            Y = hy,
            ScreenWidth = _hostScreenWidth,
            ScreenHeight = _hostScreenHeight,
            Button = btn,
            Delta = 0,
            SentAt = DateTime.UtcNow
        });
        LoggingHelper.Debug($"Mouse {action} @ host({hx},{hy})");
    }

    private void OnMouseDoubleClick(object? sender, MouseEventArgs e)
    {
        if (_signalR == null || string.IsNullOrEmpty(_sessionId)) return;
        if (e.Button != MouseButtons.Left) return;

        var (hx, hy) = ControlToHost(e.X, e.Y);
        _ = _signalR.SendMouseEvent(new MouseEventDto
        {
            SessionId = _sessionId,
            Action = "DoubleClick",
            X = hx,
            Y = hy,
            ScreenWidth = _hostScreenWidth,
            ScreenHeight = _hostScreenHeight,
            Button = 0,
            Delta = 0,
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
            Button = 0,
            Delta = e.Delta / 120,
            SentAt = DateTime.UtcNow
        });
    }
}