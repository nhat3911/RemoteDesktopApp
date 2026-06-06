namespace RemoteAuthApp.Forms;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlCard = new Panel();
        lblTitle = new Label();
        lblUsernameOrEmail = new Label();
        txtUsernameOrEmail = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        chkShowPassword = new CheckBox();
        lblError = new Label();
        btnLogin = new Button();
        btnGoRegister = new Button();
        pnlCard.SuspendLayout();
        SuspendLayout();
        // 
        // pnlCard
        // 
        pnlCard.BackColor = Color.White;
        pnlCard.BorderStyle = BorderStyle.FixedSingle;
        pnlCard.Controls.Add(lblTitle);
        pnlCard.Controls.Add(lblUsernameOrEmail);
        pnlCard.Controls.Add(txtUsernameOrEmail);
        pnlCard.Controls.Add(lblPassword);
        pnlCard.Controls.Add(txtPassword);
        pnlCard.Controls.Add(chkShowPassword);
        pnlCard.Controls.Add(lblError);
        pnlCard.Controls.Add(btnLogin);
        pnlCard.Controls.Add(btnGoRegister);
        pnlCard.Location = new Point(10, 10);
        pnlCard.Name = "pnlCard";
        pnlCard.Size = new Size(380, 360);
        pnlCard.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
        lblTitle.Location = new Point(0, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(378, 40);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "🔐  Đăng nhập";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblUsernameOrEmail
        // 
        lblUsernameOrEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblUsernameOrEmail.ForeColor = Color.FromArgb(80, 80, 80);
        lblUsernameOrEmail.Location = new Point(30, 72);
        lblUsernameOrEmail.Name = "lblUsernameOrEmail";
        lblUsernameOrEmail.Size = new Size(220, 18);
        lblUsernameOrEmail.TabIndex = 1;
        lblUsernameOrEmail.Text = "Email";
        // 
        // txtUsernameOrEmail
        // 
        txtUsernameOrEmail.BackColor = Color.FromArgb(250, 250, 250);
        txtUsernameOrEmail.BorderStyle = BorderStyle.FixedSingle;
        txtUsernameOrEmail.Font = new Font("Segoe UI", 10F);
        txtUsernameOrEmail.Location = new Point(30, 94);
        txtUsernameOrEmail.Name = "txtUsernameOrEmail";
        txtUsernameOrEmail.PlaceholderText = "Nhập email...";
        txtUsernameOrEmail.Size = new Size(318, 30);
        txtUsernameOrEmail.TabIndex = 2;
        // 
        // lblPassword
        // 
        lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPassword.ForeColor = Color.FromArgb(80, 80, 80);
        lblPassword.Location = new Point(30, 136);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(120, 18);
        lblPassword.TabIndex = 3;
        lblPassword.Text = "Mật khẩu";
        // 
        // txtPassword
        // 
        txtPassword.BackColor = Color.FromArgb(250, 250, 250);
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Segoe UI", 10F);
        txtPassword.Location = new Point(30, 158);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '●';
        txtPassword.PlaceholderText = "Nhập mật khẩu...";
        txtPassword.Size = new Size(318, 30);
        txtPassword.TabIndex = 4;
        // 
        // chkShowPassword
        // 
        chkShowPassword.Font = new Font("Segoe UI", 9F);
        chkShowPassword.ForeColor = Color.Gray;
        chkShowPassword.Location = new Point(30, 196);
        chkShowPassword.Name = "chkShowPassword";
        chkShowPassword.Size = new Size(160, 22);
        chkShowPassword.TabIndex = 5;
        chkShowPassword.Text = "Hiện mật khẩu";
        chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        // 
        // lblError
        // 
        lblError.Font = new Font("Segoe UI", 9F);
        lblError.ForeColor = Color.Crimson;
        lblError.Location = new Point(30, 224);
        lblError.Name = "lblError";
        lblError.Size = new Size(318, 22);
        lblError.TabIndex = 6;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(37, 99, 235);
        btnLogin.Cursor = Cursors.Hand;
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(30, 252);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(318, 36);
        btnLogin.TabIndex = 7;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // btnGoRegister
        // 
        btnGoRegister.BackColor = Color.Transparent;
        btnGoRegister.Cursor = Cursors.Hand;
        btnGoRegister.FlatAppearance.BorderSize = 0;
        btnGoRegister.FlatStyle = FlatStyle.Flat;
        btnGoRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
        btnGoRegister.ForeColor = Color.SteelBlue;
        btnGoRegister.Location = new Point(30, 298);
        btnGoRegister.Name = "btnGoRegister";
        btnGoRegister.Size = new Size(318, 26);
        btnGoRegister.TabIndex = 8;
        btnGoRegister.Text = "Chưa có tài khoản? Đăng ký ngay";
        btnGoRegister.UseVisualStyleBackColor = false;
        btnGoRegister.Click += btnGoRegister_Click;
        // 
        // LoginForm
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(400, 380);
        Controls.Add(pnlCard);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng nhập — RemoteAuthApp";
        pnlCard.ResumeLayout(false);
        pnlCard.PerformLayout();
        ResumeLayout(false);
    }

    //  Control declarations 
    private System.Windows.Forms.Panel    pnlCard;
    private System.Windows.Forms.Label    lblTitle;
    private System.Windows.Forms.Label    lblUsernameOrEmail;
    private System.Windows.Forms.TextBox  txtUsernameOrEmail;
    private System.Windows.Forms.Label    lblPassword;
    private System.Windows.Forms.TextBox  txtPassword;
    private System.Windows.Forms.CheckBox chkShowPassword;
    private System.Windows.Forms.Label    lblError;
    private System.Windows.Forms.Button   btnLogin;
    private System.Windows.Forms.Button   btnGoRegister;
}
