namespace RemoteAuthApp.Forms;

partial class RegisterForm
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
        this.pnlCard     = new System.Windows.Forms.Panel();
        this.lblTitle    = new System.Windows.Forms.Label();
        this.lblUsername = new System.Windows.Forms.Label();
        this.txtUsername = new System.Windows.Forms.TextBox();
        this.lblEmail    = new System.Windows.Forms.Label();
        this.txtEmail    = new System.Windows.Forms.TextBox();
        this.lblPassword = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.lblConfirm  = new System.Windows.Forms.Label();
        this.txtConfirm  = new System.Windows.Forms.TextBox();
        this.lblError    = new System.Windows.Forms.Label();
        this.btnRegister = new System.Windows.Forms.Button();
        this.btnCancel   = new System.Windows.Forms.Button();
        this.pnlCard.SuspendLayout();
        this.SuspendLayout();

        //  pnlCard 
        this.pnlCard.BackColor   = System.Drawing.Color.White;
        this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlCard.Controls.Add(this.lblTitle);
        this.pnlCard.Controls.Add(this.lblUsername);
        this.pnlCard.Controls.Add(this.txtUsername);
        this.pnlCard.Controls.Add(this.lblEmail);
        this.pnlCard.Controls.Add(this.txtEmail);
        this.pnlCard.Controls.Add(this.lblPassword);
        this.pnlCard.Controls.Add(this.txtPassword);
        this.pnlCard.Controls.Add(this.lblConfirm);
        this.pnlCard.Controls.Add(this.txtConfirm);
        this.pnlCard.Controls.Add(this.lblError);
        this.pnlCard.Controls.Add(this.btnRegister);
        this.pnlCard.Controls.Add(this.btnCancel);
        this.pnlCard.Location    = new System.Drawing.Point(10, 10);
        this.pnlCard.Name        = "pnlCard";
        this.pnlCard.Size        = new System.Drawing.Size(380, 430);
        this.pnlCard.TabIndex    = 0;

        //  lblTitle 
        this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
        this.lblTitle.Location  = new System.Drawing.Point(0, 16);
        this.lblTitle.Name      = "lblTitle";
        this.lblTitle.Size      = new System.Drawing.Size(378, 40);
        this.lblTitle.TabIndex  = 0;
        this.lblTitle.Text      = "📝  Đăng ký";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        //  lblUsername 
        this.lblUsername.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
        this.lblUsername.Location  = new System.Drawing.Point(30, 68);
        this.lblUsername.Name      = "lblUsername";
        this.lblUsername.Size      = new System.Drawing.Size(120, 18);
        this.lblUsername.TabIndex  = 1;
        this.lblUsername.Text      = "Username";

        //  txtUsername 
        this.txtUsername.BackColor       = System.Drawing.Color.FromArgb(250, 250, 250);
        this.txtUsername.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtUsername.Font            = new System.Drawing.Font("Segoe UI", 10F);
        this.txtUsername.Location        = new System.Drawing.Point(30, 90);
        this.txtUsername.Name            = "txtUsername";
        this.txtUsername.PlaceholderText = "Tối thiểu 3 ký tự";
        this.txtUsername.Size            = new System.Drawing.Size(318, 28);
        this.txtUsername.TabIndex        = 2;

        //  lblEmail 
        this.lblEmail.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
        this.lblEmail.Location  = new System.Drawing.Point(30, 132);
        this.lblEmail.Name      = "lblEmail";
        this.lblEmail.Size      = new System.Drawing.Size(120, 18);
        this.lblEmail.TabIndex  = 3;
        this.lblEmail.Text      = "Email";

        //  txtEmail 
        this.txtEmail.BackColor       = System.Drawing.Color.FromArgb(250, 250, 250);
        this.txtEmail.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtEmail.Font            = new System.Drawing.Font("Segoe UI", 10F);
        this.txtEmail.Location        = new System.Drawing.Point(30, 154);
        this.txtEmail.Name            = "txtEmail";
        this.txtEmail.PlaceholderText = "example@email.com";
        this.txtEmail.Size            = new System.Drawing.Size(318, 28);
        this.txtEmail.TabIndex        = 4;

        //  lblPassword 
        this.lblPassword.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
        this.lblPassword.Location  = new System.Drawing.Point(30, 196);
        this.lblPassword.Name      = "lblPassword";
        this.lblPassword.Size      = new System.Drawing.Size(120, 18);
        this.lblPassword.TabIndex  = 5;
        this.lblPassword.Text      = "Mật khẩu";

        //  txtPassword 
        this.txtPassword.BackColor       = System.Drawing.Color.FromArgb(250, 250, 250);
        this.txtPassword.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPassword.Font            = new System.Drawing.Font("Segoe UI", 10F);
        this.txtPassword.Location        = new System.Drawing.Point(30, 218);
        this.txtPassword.Name            = "txtPassword";
        this.txtPassword.PasswordChar    = '●';
        this.txtPassword.PlaceholderText = "Tối thiểu 6 ký tự";
        this.txtPassword.Size            = new System.Drawing.Size(318, 28);
        this.txtPassword.TabIndex        = 6;

        //  lblConfirm 
        this.lblConfirm.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
        this.lblConfirm.Location  = new System.Drawing.Point(30, 260);
        this.lblConfirm.Name      = "lblConfirm";
        this.lblConfirm.Size      = new System.Drawing.Size(200, 18);
        this.lblConfirm.TabIndex  = 7;
        this.lblConfirm.Text      = "Xác nhận mật khẩu";

        //  txtConfirm 
        this.txtConfirm.BackColor       = System.Drawing.Color.FromArgb(250, 250, 250);
        this.txtConfirm.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtConfirm.Font            = new System.Drawing.Font("Segoe UI", 10F);
        this.txtConfirm.Location        = new System.Drawing.Point(30, 282);
        this.txtConfirm.Name            = "txtConfirm";
        this.txtConfirm.PasswordChar    = '●';
        this.txtConfirm.PlaceholderText = "Nhập lại mật khẩu";
        this.txtConfirm.Size            = new System.Drawing.Size(318, 28);
        this.txtConfirm.TabIndex        = 8;

        //  lblError 
        this.lblError.Font      = new System.Drawing.Font("Segoe UI", 9F);
        this.lblError.ForeColor = System.Drawing.Color.Crimson;
        this.lblError.Location  = new System.Drawing.Point(30, 320);
        this.lblError.Name      = "lblError";
        this.lblError.Size      = new System.Drawing.Size(318, 22);
        this.lblError.TabIndex  = 9;
        this.lblError.Text      = "";

        //  btnRegister 
        this.btnRegister.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        this.btnRegister.Cursor    = System.Windows.Forms.Cursors.Hand;
        this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRegister.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnRegister.ForeColor = System.Drawing.Color.White;
        this.btnRegister.Location  = new System.Drawing.Point(30, 350);
        this.btnRegister.Name      = "btnRegister";
        this.btnRegister.Size      = new System.Drawing.Size(220, 36);
        this.btnRegister.TabIndex  = 10;
        this.btnRegister.Text      = "Đăng ký";
        this.btnRegister.UseVisualStyleBackColor = false;
        this.btnRegister.FlatAppearance.BorderSize = 0;
        this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

        //  btnCancel 
        this.btnCancel.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnCancel.Cursor    = System.Windows.Forms.Cursors.Hand;
        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancel.Font      = new System.Drawing.Font("Segoe UI", 10F);
        this.btnCancel.ForeColor = System.Drawing.Color.Black;
        this.btnCancel.Location  = new System.Drawing.Point(260, 350);
        this.btnCancel.Name      = "btnCancel";
        this.btnCancel.Size      = new System.Drawing.Size(88, 36);
        this.btnCancel.TabIndex  = 11;
        this.btnCancel.Text      = "Huỷ";
        this.btnCancel.UseVisualStyleBackColor = false;
        this.btnCancel.FlatAppearance.BorderSize = 0;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

        //  RegisterForm 
        this.AcceptButton        = this.btnRegister;
        this.CancelButton        = this.btnCancel;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
        this.ClientSize          = new System.Drawing.Size(400, 450);
        this.Controls.Add(this.pnlCard);
        this.Font                = new System.Drawing.Font("Segoe UI", 10F);
        this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox         = false;
        this.MinimizeBox         = false;
        this.Name                = "RegisterForm";
        this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text                = "Đăng ký tài khoản — RemoteAuthApp";

        this.pnlCard.ResumeLayout(false);
        this.pnlCard.PerformLayout();
        this.ResumeLayout(false);
    }

    //  Control declarations 
    private System.Windows.Forms.Panel   pnlCard;
    private System.Windows.Forms.Label   lblTitle;
    private System.Windows.Forms.Label   lblUsername;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label   lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label   lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label   lblConfirm;
    private System.Windows.Forms.TextBox txtConfirm;
    private System.Windows.Forms.Label   lblError;
    private System.Windows.Forms.Button  btnRegister;
    private System.Windows.Forms.Button  btnCancel;
}
