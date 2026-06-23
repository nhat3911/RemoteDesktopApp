using RemoteHostApp.Helpers;
using RemoteViewerApp.Controls;
using RemoteViewerApp.DTOs;
using RemoteViewerApp.Helpers;
using RemoteViewerApp.Models;
using RemoteViewerApp.Services;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RemoteViewerApp.Forms;

public partial class MainForm : Form
{
    //  Services 
    private readonly SignalRViewerService _signalR;
    private readonly AppSettings _settings;

    //  State 
    private ActiveSession? _currentSession;
    private bool _isClosing;

    // Thống kê frame
    private int _frameCount;
    private DateTime _lastFpsCalc = DateTime.Now;
    private int _lastFrameCount;

    public MainForm(AppSettings settings, SignalRViewerService signalR)
    {
        _settings = settings;
        _signalR = signalR;

        InitializeComponent();
        SetupSignalREvents();
        SetupLogging();

        // Giá trị mặc định
        txtServerUrl.Text = settings.ServerUrl;
        txtViewerId.Text = $"VIEWER-{Environment.MachineName}-{Guid.NewGuid():N}".Substring(0, 28);
        txtViewerName.Text = $"Viewer@{Environment.MachineName}";
        txtUserId.Text = (!string.IsNullOrEmpty(AppSession.Uid)) ? ($"{AppSession.Username}-{AppSession.Uid}") : ($"VIEWER-{Environment.MachineName}");

        UpdateUI();
    }

    //  Logging 

    private void SetupLogging()
    {
        LoggingHelper.OnLog = (msg, level) =>
        {
            if (rtbLog == null || rtbLog.IsDisposed) return;
            if (rtbLog.InvokeRequired)
                rtbLog.BeginInvoke(() => AppendLog(msg, level));
            else
                AppendLog(msg, level);
        };
    }

    private void AppendLog(string msg, LogLevel level)
    {
        var color = level switch
        {
            LogLevel.Error => Color.OrangeRed,
            LogLevel.Warning => Color.Yellow,
            LogLevel.Debug => Color.DimGray,
            _ => Color.LightGreen
        };
        rtbLog.SelectionColor = color;
        rtbLog.AppendText(msg + Environment.NewLine);
        rtbLog.ScrollToCaret();

        if (rtbLog.Lines.Length > 2000)
            rtbLog.Lines = rtbLog.Lines.TakeLast(1500).ToArray();
    }

    //  SignalR events 

    private void SetupSignalREvents()
    {
        _signalR.OnConnectionStatusChanged += status =>
            SafeInvoke(() => UpdateStatusLabel(status));

        _signalR.OnRegisterSuccess += viewerId =>
            SafeInvoke(() =>
            {
                UpdateStatusLabel("Registered");
                UpdateUI();
            });

        _signalR.OnRegisterFailed += err =>
            SafeInvoke(() =>
                MessageBox.Show($"Đăng ký Viewer thất bại:\n{err}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error));

        _signalR.OnControlRequestSent += sessionId =>
            SafeInvoke(() =>
            {
                _currentSession = new ActiveSession { SessionId = sessionId };
                UpdateStatusLabel("Waiting");
                LoggingHelper.Info($"Đang chờ Host phản hồi – session: {sessionId}");
            });

        _signalR.OnControlRequestFailed += err =>
            SafeInvoke(() =>
            {
                MessageBox.Show($"Yêu cầu điều khiển thất bại:\n{err}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _currentSession = null;
                UpdateUI();
            });

        _signalR.OnControlAccepted += (sessionId, hostId, viewerId) =>
            SafeInvoke(() =>
            {
                if (_currentSession != null)
                {
                    _currentSession.SessionId = sessionId;
                    _currentSession.HostId = hostId;
                    _currentSession.ViewerId = viewerId;
                    _currentSession.Status = "Accepted";
                    _currentSession.AcceptedAt = DateTime.Now;
                }

                // Kích hoạt screen control nhận input
                screenControl.Initialize(_signalR, sessionId);
                screenControl.Enabled = true;
                screenControl.TabStop = true;
                screenControl.Focus();
                screenControl.Select();

                // Ẩn hint label
                HideHint();

                UpdateStatusLabel("In Session");
                UpdateUI();
                LoggingHelper.Info($"Host đồng ý! Đang nhận màn hình – session: {sessionId}");
            });

        _signalR.OnControlRejected += (sessionId, reason) =>
            SafeInvoke(() =>
            {
                _currentSession = null;
                screenControl.Detach();
                UpdateStatusLabel("Registered");
                UpdateUI();
                ShowHint();
                MessageBox.Show(
                    $"Host đã từ chối yêu cầu điều khiển.\nLý do: {reason ?? "(không có)"}",
                    "Từ chối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });

        _signalR.OnControlEnded += sessionId =>
            SafeInvoke(() =>
            {
                if (_currentSession?.SessionId != sessionId) return;
                EndSessionUi();
                LoggingHelper.Info($"Phiên điều khiển đã kết thúc: {sessionId}");
            });

        _signalR.OnScreenFrameReceived += frame =>
            HandleScreenFrame(frame);
    }
 private void HandleScreenFrame(ScreenFrameDto frame)
    {
        if (string.IsNullOrEmpty(frame.ImageBase64)) return;

        try
        {
            var decrypted = CryptoHelper.Decrypt(frame.ImageBase64);
            var bytes = Convert.FromBase64String(decrypted);

            var ms = new MemoryStream(bytes, writable: false);
            var bitmap = new Bitmap(ms);

            _frameCount++;

            // UpdateFrame nhận bitmap và tự dispose bitmap cũ
            screenControl.UpdateFrame(
                bitmap,
                frame.ScreenWidth,
                frame.ScreenHeight,
                frame.MouseX,
                frame.MouseY);
        }
        catch (Exception ex)
        {
            LoggingHelper.Error($"Render frame lỗi: {ex.Message}");
        }
    }

    private void FpsTimer_Tick(object? sender, EventArgs e)
    {
        UpdateFps();
    }

    private void UpdateFps()
    {
        var now = DateTime.Now;
        var elapsed = (now - _lastFpsCalc).TotalSeconds;
        if (elapsed >= 1.0)
        {
            var fps = (_frameCount - _lastFrameCount) / elapsed;
            lblFps.Text = $"FPS: {fps:F0}";
            _lastFrameCount = _frameCount;
            _lastFpsCalc = now;
        }
    }

    //  Button handlers 

    private async void BtnConnect_Click(object? sender, EventArgs e)
    {
        btnConnect.Enabled = false;
        try
        {
            if (_signalR.IsConnected)
            {
                await _signalR.DisconnectAsync();
                btnConnect.Text = "🔌 Kết nối";
            }
            else
            {
                _settings.ServerUrl = txtServerUrl.Text.Trim();
                btnConnect.Text = "⏳ Đang kết nối...";
                await _signalR.ConnectAsync();
                btnConnect.Text = "⏏ Ngắt kết nối";
            }
        }
        catch (Exception ex)
        {
            LoggingHelper.Error($"Kết nối thất bại: {ex.Message}");
            MessageBox.Show($"Không thể kết nối:\n{ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnConnect.Text = "🔌 Kết nối";
        }
        finally
        {
            btnConnect.Enabled = true;
            UpdateUI();
        }
    }

    private async void BtnRegister_Click(object? sender, EventArgs e)
    {
        btnRegister.Enabled = false;
        try
        {
            var viewerId = txtViewerId.Text.Trim();
            var viewerName = txtViewerName.Text.Trim();
            var userId = txtUserId.Text.Trim();

            if (string.IsNullOrWhiteSpace(viewerId))
            {
                MessageBox.Show("Viewer ID không được trống!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("User ID không được trống! (server bắt buộc)", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await _signalR.RegisterViewer(new ViewerRegisterDto
            {
                ViewerId = viewerId,
                ViewerName = viewerName,
                UserId = userId
            });
        }
        catch (Exception ex)
        {
            LoggingHelper.Error($"Đăng ký thất bại: {ex.Message}");
            MessageBox.Show($"Đăng ký thất bại:\n{ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnRegister.Enabled = _signalR.IsConnected;
        }
    }

    private async void BtnRefreshHosts_Click(object? sender, EventArgs e)
    {
        btnRefreshHosts.Enabled = false;
        try
        {
            var hosts = await _signalR.GetOnlineHostsAsync();
            cmbHosts.Items.Clear();
            foreach (var h in hosts)
                cmbHosts.Items.Add(h);

            if (cmbHosts.Items.Count > 0)
            {
                cmbHosts.SelectedIndex = 0;
                UpdateUI();
            }

            LoggingHelper.Info($"Tìm thấy {hosts.Count} Host đang online.");
        }
        catch (Exception ex)
        {
            LoggingHelper.Error($"Lấy danh sách Host thất bại: {ex.Message}");
        }
        finally
        {
            btnRefreshHosts.Enabled = _signalR.IsConnected;
        }
    }

    private async void BtnRequestControl_Click(object? sender, EventArgs e)
    {
        if (cmbHosts.SelectedItem is not HostInfo host)
        {
            MessageBox.Show("Vui lòng chọn Host!", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        btnRequestControl.Enabled = false;
        try
        {
            var dto = new ControlRequestDto
            {
                HostId = host.Id,
                ViewerId = txtViewerId.Text.Trim(),
                ViewerName = txtViewerName.Text.Trim(),
                UserId = txtUserId.Text.Trim()
            };

            if (string.IsNullOrWhiteSpace(dto.UserId))
            {
                MessageBox.Show("User ID không được trống!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await _signalR.RequestControl(dto);
        }
        catch (Exception ex)
        {
            LoggingHelper.Error($"RequestControl thất bại: {ex.Message}");
            MessageBox.Show($"Gửi yêu cầu thất bại:\n{ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnRequestControl.Enabled = true;
        }
    }

    private async void BtnEndControl_Click(object? sender, EventArgs e)
    {
        if (_currentSession == null) return;
        try
        {
            await _signalR.EndControl(_currentSession.SessionId);
            EndSessionUi();
        }
        catch (Exception ex)
        {
            LoggingHelper.Error($"EndControl lỗi: {ex.Message}");
        }
    }

    private void BtnClearLog_Click(object? sender, EventArgs e)
    {
        rtbLog.Clear();
    }

    //  UI helpers 

    private void UpdateStatusLabel(string status)
    {
        (lblStatus.Text, lblStatus.ForeColor) = status switch
        {
            "Connected" => ("● Đã kết nối", Color.DodgerBlue),
            "Registered" => ("● Đã đăng ký", Color.LimeGreen),
            "Waiting" => ("⏳ Đang chờ Host...", Color.Orange),
            "In Session" => ("● Đang điều khiển", Color.Cyan),
            "Reconnecting" => ("⟳ Đang reconnect...", Color.Yellow),
            "Disconnected" => ("● Offline", Color.Gray),
            _ => ("● " + status, Color.Gray)
        };
    }

    private void UpdateUI()
    {
        bool connected = _signalR.IsConnected;
        bool hasSession = _currentSession != null;

        btnConnect.Text = connected ? "⏏ Ngắt kết nối" : "🔌 Kết nối";
        btnRegister.Enabled = connected && !hasSession;
        btnRefreshHosts.Enabled = connected && !hasSession;
        btnRequestControl.Enabled = connected && !hasSession && cmbHosts.Items.Count > 0;
        btnEndControl.Enabled = hasSession;

        txtViewerId.ReadOnly = connected;
        txtViewerName.ReadOnly = connected;
        txtUserId.ReadOnly = connected;
        txtServerUrl.ReadOnly = connected;
    }

    private void EndSessionUi()
    {
        _currentSession = null;
        screenControl.Detach();
        screenControl.Image = null;
        ShowHint();
        UpdateStatusLabel("Registered");
        UpdateUI();
        lblFps.Text = "FPS: –";
        lblResolution.Text = "–";
    }

    private void HideHint()
    {
        lblHint.Visible = false;
        lblHint.SendToBack();

        screenControl.BringToFront();
        screenControl.Enabled = true;
        screenControl.Focus();

        LoggingHelper.Info("[UI] screenControl focused");
    }

    private void ShowHint()
    {
        lblHint.Visible = true;
        lblHint.BringToFront();
    }

    private void SafeInvoke(Action action)
    {
        if (IsDisposed) return;
        if (InvokeRequired) BeginInvoke(action);
        else action();
    }

    //  Form closing 

    private async void OnFormClosing(object? sender, FormClosingEventArgs e)
    {
        if (_isClosing) return;
        e.Cancel = true;
        _isClosing = true;

        if (_currentSession != null)
        {
            try { await _signalR.EndControl(_currentSession.SessionId); } catch { }
        }
        await _signalR.DisconnectAsync();
        Close();
    }
}
