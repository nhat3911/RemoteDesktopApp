namespace RemoteAuthApp.Forms;

partial class RoleSelectionForm
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
        pnlHeader = new Panel();
        lblWelcome = new Label();
        lblSubtitle = new Label();
        pnlInfo = new Panel();
        lblKeyUsername = new Label();
        lblValueUsername = new Label();
        lblKeyEmail = new Label();
        lblValueEmail = new Label();
        lblKeyId = new Label();
        lblValueId = new Label();
        lblKeyLoginAt = new Label();
        lblValueLoginAt = new Label();
        lblKeyCreatedAt = new Label();
        lblValueCreatedAt = new Label();
        pnlDivider = new Panel();
        lblChooseRole = new Label();
        btnHost = new Button();
        btnViewer = new Button();
        btnLogout = new Button();
        pnlCard.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlInfo.SuspendLayout();
        SuspendLayout();
        // 
        // pnlCard
        // 
        pnlCard.BackColor = Color.White;
        pnlCard.BorderStyle = BorderStyle.FixedSingle;
        pnlCard.Controls.Add(pnlHeader);
        pnlCard.Controls.Add(pnlInfo);
        pnlCard.Controls.Add(pnlDivider);
        pnlCard.Controls.Add(lblChooseRole);
        pnlCard.Controls.Add(btnHost);
        pnlCard.Controls.Add(btnViewer);
        pnlCard.Controls.Add(btnLogout);
        pnlCard.Location = new Point(10, 10);
        pnlCard.Name = "pnlCard";
        pnlCard.Size = new Size(440, 462);
        pnlCard.TabIndex = 0;
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(37, 99, 235);
        pnlHeader.Controls.Add(lblWelcome);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(438, 70);
        pnlHeader.TabIndex = 0;
        // 
        // lblWelcome
        // 
        lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblWelcome.ForeColor = Color.White;
        lblWelcome.Location = new Point(16, 10);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(406, 28);
        lblWelcome.TabIndex = 0;
        lblWelcome.Text = "Xin chào!";
        // 
        // lblSubtitle
        // 
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = Color.FromArgb(180, 210, 255);
        lblSubtitle.Location = new Point(16, 42);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(300, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Vui lòng chọn vai trò để tiếp tục";
        // 
        // pnlInfo
        // 
        pnlInfo.BackColor = Color.FromArgb(248, 250, 255);
        pnlInfo.Controls.Add(lblKeyUsername);
        pnlInfo.Controls.Add(lblValueUsername);
        pnlInfo.Controls.Add(lblKeyEmail);
        pnlInfo.Controls.Add(lblValueEmail);
        pnlInfo.Controls.Add(lblKeyId);
        pnlInfo.Controls.Add(lblValueId);
        pnlInfo.Controls.Add(lblKeyLoginAt);
        pnlInfo.Controls.Add(lblValueLoginAt);
        pnlInfo.Controls.Add(lblKeyCreatedAt);
        pnlInfo.Controls.Add(lblValueCreatedAt);
        pnlInfo.Location = new Point(0, 70);
        pnlInfo.Name = "pnlInfo";
        pnlInfo.Size = new Size(438, 152);
        pnlInfo.TabIndex = 1;
        // 
        // lblKeyUsername
        // 
        lblKeyUsername.Location = new Point(0, 0);
        lblKeyUsername.Name = "lblKeyUsername";
        lblKeyUsername.Size = new Size(100, 23);
        lblKeyUsername.TabIndex = 0;
        // 
        // lblValueUsername
        // 
        lblValueUsername.Location = new Point(0, 0);
        lblValueUsername.Name = "lblValueUsername";
        lblValueUsername.Size = new Size(100, 23);
        lblValueUsername.TabIndex = 1;
        // 
        // lblKeyEmail
        // 
        lblKeyEmail.Location = new Point(0, 0);
        lblKeyEmail.Name = "lblKeyEmail";
        lblKeyEmail.Size = new Size(100, 23);
        lblKeyEmail.TabIndex = 2;
        // 
        // lblValueEmail
        // 
        lblValueEmail.Location = new Point(0, 0);
        lblValueEmail.Name = "lblValueEmail";
        lblValueEmail.Size = new Size(100, 23);
        lblValueEmail.TabIndex = 3;
        // 
        // lblKeyId
        // 
        lblKeyId.Location = new Point(0, 0);
        lblKeyId.Name = "lblKeyId";
        lblKeyId.Size = new Size(100, 23);
        lblKeyId.TabIndex = 4;
        // 
        // lblValueId
        // 
        lblValueId.Location = new Point(0, 0);
        lblValueId.Name = "lblValueId";
        lblValueId.Size = new Size(100, 23);
        lblValueId.TabIndex = 5;
        // 
        // lblKeyLoginAt
        // 
        lblKeyLoginAt.Location = new Point(0, 0);
        lblKeyLoginAt.Name = "lblKeyLoginAt";
        lblKeyLoginAt.Size = new Size(100, 23);
        lblKeyLoginAt.TabIndex = 6;
        // 
        // lblValueLoginAt
        // 
        lblValueLoginAt.Location = new Point(0, 0);
        lblValueLoginAt.Name = "lblValueLoginAt";
        lblValueLoginAt.Size = new Size(100, 23);
        lblValueLoginAt.TabIndex = 7;
        // 
        // lblKeyCreatedAt
        // 
        lblKeyCreatedAt.Location = new Point(0, 0);
        lblKeyCreatedAt.Name = "lblKeyCreatedAt";
        lblKeyCreatedAt.Size = new Size(100, 23);
        lblKeyCreatedAt.TabIndex = 8;
        // 
        // lblValueCreatedAt
        // 
        lblValueCreatedAt.Location = new Point(0, 0);
        lblValueCreatedAt.Name = "lblValueCreatedAt";
        lblValueCreatedAt.Size = new Size(100, 23);
        lblValueCreatedAt.TabIndex = 9;
        // 
        // pnlDivider
        // 
        pnlDivider.BackColor = Color.FromArgb(220, 220, 220);
        pnlDivider.Location = new Point(16, 234);
        pnlDivider.Name = "pnlDivider";
        pnlDivider.Size = new Size(406, 1);
        pnlDivider.TabIndex = 2;
        // 
        // lblChooseRole
        // 
        lblChooseRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblChooseRole.ForeColor = Color.FromArgb(60, 60, 60);
        lblChooseRole.Location = new Point(16, 244);
        lblChooseRole.Name = "lblChooseRole";
        lblChooseRole.Size = new Size(200, 22);
        lblChooseRole.TabIndex = 3;
        lblChooseRole.Text = "Chọn vai trò:";
        // 
        // btnHost
        // 
        btnHost.BackColor = Color.FromArgb(22, 163, 74);
        btnHost.Cursor = Cursors.Hand;
        btnHost.FlatAppearance.BorderSize = 0;
        btnHost.FlatStyle = FlatStyle.Flat;
        btnHost.ForeColor = Color.White;
        btnHost.Location = new Point(16, 272);
        btnHost.Name = "btnHost";
        btnHost.Size = new Size(196, 120);
        btnHost.TabIndex = 4;
        btnHost.UseVisualStyleBackColor = false;
        btnHost.Click += btnHost_Click;
        btnHost.Paint += btnHost_Paint;
        btnHost.MouseEnter += btnHost_MouseEnter;
        btnHost.MouseLeave += btnHost_MouseLeave;
        // 
        // btnViewer
        // 
        btnViewer.BackColor = Color.FromArgb(37, 99, 235);
        btnViewer.Cursor = Cursors.Hand;
        btnViewer.FlatAppearance.BorderSize = 0;
        btnViewer.FlatStyle = FlatStyle.Flat;
        btnViewer.ForeColor = Color.White;
        btnViewer.Location = new Point(226, 272);
        btnViewer.Name = "btnViewer";
        btnViewer.Size = new Size(196, 120);
        btnViewer.TabIndex = 5;
        btnViewer.UseVisualStyleBackColor = false;
        btnViewer.Click += btnViewer_Click;
        btnViewer.Paint += btnViewer_Paint;
        btnViewer.MouseEnter += btnViewer_MouseEnter;
        btnViewer.MouseLeave += btnViewer_MouseLeave;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = Color.FromArgb(239, 68, 68);
        btnLogout.Cursor = Cursors.Hand;
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.Font = new Font("Segoe UI", 10F);
        btnLogout.ForeColor = Color.White;
        btnLogout.Location = new Point(16, 404);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(406, 36);
        btnLogout.TabIndex = 6;
        btnLogout.Text = "⏏  Đăng xuất";
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Click += btnLogout_Click;
        // 
        // RoleSelectionForm
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(460, 482);
        Controls.Add(pnlCard);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "RoleSelectionForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Chọn vai trò";
        pnlCard.ResumeLayout(false);
        pnlHeader.ResumeLayout(false);
        pnlInfo.ResumeLayout(false);
        ResumeLayout(false);
    }

    /// <summary>Helper cấu hình cặp Label key/value trong pnlInfo.</summary>
    private static void SetInfoRow(
        System.Windows.Forms.Label lblKey, string keyText,
        System.Windows.Forms.Label lblVal, string valText, int y)
    {
        lblKey.AutoSize  = false;
        lblKey.Font      = new System.Drawing.Font("Segoe UI", 9F);
        lblKey.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
        lblKey.Location  = new System.Drawing.Point(20, y);
        lblKey.Size      = new System.Drawing.Size(160, 20);
        lblKey.Text      = keyText;

        lblVal.AutoSize  = false;
        lblVal.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
        lblVal.Location  = new System.Drawing.Point(185, y);
        lblVal.Size      = new System.Drawing.Size(240, 20);
        lblVal.Text      = valText;
    }

    //  Control declarations 
    private System.Windows.Forms.Panel  pnlCard;
    private System.Windows.Forms.Panel  pnlHeader;
    private System.Windows.Forms.Label  lblWelcome;
    private System.Windows.Forms.Label  lblSubtitle;
    private System.Windows.Forms.Panel  pnlInfo;
    private System.Windows.Forms.Label  lblKeyUsername;
    private System.Windows.Forms.Label  lblValueUsername;
    private System.Windows.Forms.Label  lblKeyEmail;
    private System.Windows.Forms.Label  lblValueEmail;
    private System.Windows.Forms.Label  lblKeyId;
    private System.Windows.Forms.Label  lblValueId;
    private System.Windows.Forms.Label  lblKeyLoginAt;
    private System.Windows.Forms.Label  lblValueLoginAt;
    private System.Windows.Forms.Label  lblKeyCreatedAt;
    private System.Windows.Forms.Label  lblValueCreatedAt;
    private System.Windows.Forms.Panel  pnlDivider;
    private System.Windows.Forms.Label  lblChooseRole;
    private System.Windows.Forms.Button btnHost;
    private System.Windows.Forms.Button btnViewer;
    private System.Windows.Forms.Button btnLogout;
}
