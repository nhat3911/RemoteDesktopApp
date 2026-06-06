using RemoteAuthApp.Helpers;
using RemoteAuthApp.Services;

namespace RemoteAuthApp.Forms;

public partial class LoginForm : Form
{
    private readonly AuthService _firebaseAuthService;

    public LoginForm(AuthService firebaseAuthService)
    {
        InitializeComponent();
        _firebaseAuthService = firebaseAuthService;
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        lblError.Text = string.Empty;

        var email = txtUsernameOrEmail.Text.Trim();
        var password = txtPassword.Text;

        if (ValidationHelper.IsNullOrWhiteSpace(email, password))
        {
            lblError.Text = "Vui lòng nhập đầy đủ thông tin.";
            return;
        }

        if (!ValidationHelper.IsValidEmail(email))
        {
            lblError.Text = "Địa chỉ email không hợp lệ.";
            txtUsernameOrEmail.Focus();
            return;
        }

        btnLogin.Enabled = false;
        btnLogin.Text = "Đang đăng nhập...";

        try
        {
            var user = await _firebaseAuthService.LoginAsync(email, password);
            if (user == null)
            {
                lblError.Text = "Sai email hoặc mật khẩu.";
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            AuthSession.Uid = user.localId;
            AuthSession.Email = user.email;
            AuthSession.DisplayName = string.IsNullOrWhiteSpace(user.displayName)
                ? user.email.Split('@')[0]
                : user.displayName;
            AuthSession.Username = AuthSession.DisplayName;
            AuthSession.IdToken = user.idToken;
            AuthSession.RefreshToken = user.refreshToken;
            AuthSession.LoginAt = DateTime.Now;

            var roleForm = new RoleSelectionForm();
            roleForm.FormClosed += (_, _) =>
            {
                txtUsernameOrEmail.Clear();
                txtPassword.Clear();
                lblError.Text = string.Empty;
                Show();
            };

            Hide();
            roleForm.Show();
        }
        finally
        {
            btnLogin.Enabled = true;
            btnLogin.Text = "Đăng nhập";
        }
    }

    private void btnGoRegister_Click(object sender, EventArgs e)
    {
        var registerForm = new RegisterForm(_firebaseAuthService);
        registerForm.ShowDialog(this);

        if (registerForm.Tag is string email)
            txtUsernameOrEmail.Text = email;
    }

    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
    }
}