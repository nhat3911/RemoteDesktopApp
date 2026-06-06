using RemoteAuthApp.Helpers;
using RemoteAuthApp.Services;

namespace RemoteAuthApp.Forms;

/// <summary>
/// Form đăng ký tài khoản mới.
/// Gọi ShowDialog() từ LoginForm. Sau khi thành công, Tag = username.
/// </summary>
public partial class RegisterForm : Form
{
    private readonly AuthService _firebaseAuthService;

    public RegisterForm(AuthService firebaseAuthService)
    {
        InitializeComponent();
        _firebaseAuthService = firebaseAuthService;
    }

    //  Event handlers 

    private async void btnRegister_Click(object sender, EventArgs e)
    {
        lblError.Text = string.Empty;

        var username = txtUsername.Text.Trim();
        var email    = txtEmail.Text.Trim();
        var password = txtPassword.Text;
        var confirm  = txtConfirm.Text;

        if (ValidationHelper.IsNullOrWhiteSpace(username, email, password, confirm))
        {
            lblError.Text = "Vui lòng điền đầy đủ tất cả các trường."; return;
        }
        if (username.Length < 3)
        {
            lblError.Text = "Username phải có ít nhất 3 ký tự.";
            txtUsername.Focus(); return;
        }
        if (!ValidationHelper.IsValidEmail(email))
        {
            lblError.Text = "Email không hợp lệ.";
            txtEmail.Focus(); return;
        }
        if (password.Length < 6)
        {
            lblError.Text = "Mật khẩu phải có ít nhất 6 ký tự.";
            txtPassword.Focus(); return;
        }
        if (password != confirm)
        {
            lblError.Text = "Mật khẩu và xác nhận không khớp.";
            txtConfirm.Clear(); txtConfirm.Focus(); return;
        }

        btnRegister.Enabled = false;
        btnRegister.Text    = "Đang đăng ký...";

        (bool success, string error) result;
        try
        {
            var user = await _firebaseAuthService.RegisterAsync(username, email, password);

            if (user == null)
            {
                lblError.Text = "Đăng ký thất bại.";
                return;
            }

            MessageBox.Show(
                $"Đăng ký thành công!\nEmail: {email}\nBạn có thể đăng nhập ngay.",
                "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Tag = email;
            Close();
        }
        catch (Exception ex)
        {
            lblError.Text = "Lỗi đăng ký: " + ex.Message;
        }
        finally
        {
            btnRegister.Enabled = true;
            btnRegister.Text = "Đăng ký";
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) => Close();
}
