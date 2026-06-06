using RemoteAuthApp.Helpers;
using System.Diagnostics;

namespace RemoteAuthApp.Forms;

/// <summary>
/// Màn hình chọn vai trò sau khi đăng nhập.
/// Hiển thị thông tin tài khoản, nút Host / Viewer / Logout.
/// </summary>
public partial class RoleSelectionForm : Form
{
    public RoleSelectionForm()
    {
        InitializeComponent();
        PopulateUserInfo();
    }

    /// <summary>Điền thông tin user vào các Label sau khi InitializeComponent.</summary>
    private void PopulateUserInfo()
    {
        string username = !string.IsNullOrWhiteSpace(AuthSession.DisplayName)
            ? AuthSession.DisplayName
            : AuthSession.Username;

        this.Text = $"Chọn vai trò — {username}";
        lblWelcome.Text = $"Xin chào, {username}!";
        lblValueUsername.Text = username;
        lblValueEmail.Text = AuthSession.Email;
        lblValueId.Text = AuthSession.Uid;
        lblValueLoginAt.Text = AuthSession.LoginAt.ToString("dd/MM/yyyy  HH:mm:ss");
        lblValueCreatedAt.Text = "Firebase Auth";
    }

    //  Event handlers 

    private void btnHost_Click(object sender, EventArgs e)
    {
        StartApp("RemoteHostApp", "RemoteHostApp.exe");
    }

    private void btnViewer_Click(object sender, EventArgs e)
    {
        StartApp("RemoteViewerApp", "RemoteViewerApp.exe");
    }

    private void StartApp(string projectName, string exeName)
    {
        string authBaseDir = AppDomain.CurrentDomain.BaseDirectory;

        string buildOutputDir = Directory.GetParent(authBaseDir)!.Parent!.Parent!.FullName;

        string exePath = Path.Combine(
            buildOutputDir,
            projectName,
            "net8.0-windows",
            exeName
        );

        if (!File.Exists(exePath))
        {
            MessageBox.Show($"Không tìm thấy file:\n{exePath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string args = $"--uid {AuthSession.Uid} " + $"--username \"{AuthSession.Username}\"";

        Process.Start(new ProcessStartInfo
        {
            FileName = exePath,
            WorkingDirectory = Path.GetDirectoryName(exePath),
            Arguments = args,
            UseShellExecute = true
        });
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        var res = MessageBox.Show(
            "Bạn có chắc muốn đăng xuất không?",
            "Xác nhận đăng xuất",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (res == DialogResult.Yes)
        {
            AuthSession.Clear();
            Close();
        }
    }

    //  Custom paint: nút Host/Viewer với icon lớn 
    private void btnHost_Paint(object sender, PaintEventArgs e)
        => PaintRoleButton(e, "🖥", "HOST", "Chia sẻ màn hình\ncủa bạn cho người khác",
                           System.Drawing.Color.FromArgb(22, 163, 74));

    private void btnViewer_Paint(object sender, PaintEventArgs e)
        => PaintRoleButton(e, "👁", "VIEWER", "Xem và điều khiển\nmàn hình máy từ xa",
                           System.Drawing.Color.FromArgb(37, 99, 235));

    private static void PaintRoleButton(PaintEventArgs e, string icon, string title,
                                         string desc, System.Drawing.Color color)
    {
        var g   = e.Graphics;
        var btn = (System.Drawing.Rectangle)e.ClipRectangle;

        g.Clear(color);

        using var fIcon  = new System.Drawing.Font("Segoe UI Emoji", 22F);
        using var fTitle = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        using var fDesc  = new System.Drawing.Font("Segoe UI", 8F);
        var brush = System.Drawing.Brushes.White;
        var sfCenter = new System.Drawing.StringFormat { Alignment = System.Drawing.StringAlignment.Center };

        g.DrawString(icon,  fIcon,  brush, new System.Drawing.RectangleF(0,  10, btn.Width, 36), sfCenter);
        g.DrawString(title, fTitle, brush, new System.Drawing.RectangleF(0,  52, btn.Width, 26), sfCenter);
        sfCenter.LineAlignment = System.Drawing.StringAlignment.Near;
        g.DrawString(desc,  fDesc,  brush, new System.Drawing.RectangleF(8,  82, btn.Width - 16, 36), sfCenter);
    }

    private void btnHost_MouseEnter(object sender, EventArgs e)
        => btnHost.BackColor = System.Drawing.Color.FromArgb(34, 183, 94);
    private void btnHost_MouseLeave(object sender, EventArgs e)
        => btnHost.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);

    private void btnViewer_MouseEnter(object sender, EventArgs e)
        => btnViewer.BackColor = System.Drawing.Color.FromArgb(57, 119, 255);
    private void btnViewer_MouseLeave(object sender, EventArgs e)
        => btnViewer.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
}
