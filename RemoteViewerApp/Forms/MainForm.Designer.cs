namespace RemoteViewerApp.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitMain = new SplitContainer();
            pnlSidebar = new Panel();
            tabMain = new TabControl();
            tabConn = new TabPage();
            pnlConn = new Panel();
            btnRequestControl = new Button();
            cmbHosts = new ComboBox();
            btnRefreshHosts = new Button();
            lblHostsHeader = new Label();
            divider2 = new Panel();
            btnRegister = new Button();
            txtUserId = new TextBox();
            lblUserId = new Label();
            txtViewerName = new TextBox();
            lblViewerName = new Label();
            txtViewerId = new TextBox();
            lblViewerId = new Label();
            divider1 = new Panel();
            btnConnect = new Button();
            txtServerUrl = new TextBox();
            lblServerUrl = new Label();
            tabLog = new TabPage();
            rtbLog = new RichTextBox();
            btnClearLog = new Button();
            pnlScreen = new Panel();
            pnlScreenTop = new Panel();
            lblStatus = new Label();
            lblFps = new Label();
            lblResolution = new Label();
            btnEndControl = new Button();
            lblHint = new Label();
            screenControl = new RemoteViewerApp.Controls.RemoteScreenControl();
            fpsTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            pnlSidebar.SuspendLayout();
            tabMain.SuspendLayout();
            tabConn.SuspendLayout();
            pnlConn.SuspendLayout();
            tabLog.SuspendLayout();
            pnlScreen.SuspendLayout();
            pnlScreenTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)screenControl).BeginInit();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.FixedPanel = FixedPanel.Panel1;
            splitMain.Location = new Point(0, 0);
            splitMain.Margin = new Padding(3, 4, 3, 4);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(pnlSidebar);
            splitMain.Panel1MinSize = 260;
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(pnlScreen);
            splitMain.Panel2MinSize = 400;
            splitMain.Size = new Size(1371, 1000);
            splitMain.SplitterDistance = 343;
            splitMain.SplitterWidth = 5;
            splitMain.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(tabMain);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(9, 11, 9, 11);
            pnlSidebar.Size = new Size(343, 1000);
            pnlSidebar.TabIndex = 0;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabConn);
            tabMain.Controls.Add(tabLog);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(9, 11);
            tabMain.Margin = new Padding(3, 4, 3, 4);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(325, 978);
            tabMain.TabIndex = 0;
            // 
            // tabConn
            // 
            tabConn.Controls.Add(pnlConn);
            tabConn.Location = new Point(4, 29);
            tabConn.Margin = new Padding(3, 4, 3, 4);
            tabConn.Name = "tabConn";
            tabConn.Padding = new Padding(9, 11, 9, 11);
            tabConn.Size = new Size(317, 945);
            tabConn.TabIndex = 0;
            tabConn.Text = "🔌 Kết nối";
            tabConn.UseVisualStyleBackColor = true;
            // 
            // pnlConn
            // 
            pnlConn.AutoScroll = true;
            pnlConn.Controls.Add(btnRequestControl);
            pnlConn.Controls.Add(cmbHosts);
            pnlConn.Controls.Add(btnRefreshHosts);
            pnlConn.Controls.Add(lblHostsHeader);
            pnlConn.Controls.Add(divider2);
            pnlConn.Controls.Add(btnRegister);
            pnlConn.Controls.Add(txtUserId);
            pnlConn.Controls.Add(lblUserId);
            pnlConn.Controls.Add(txtViewerName);
            pnlConn.Controls.Add(lblViewerName);
            pnlConn.Controls.Add(txtViewerId);
            pnlConn.Controls.Add(lblViewerId);
            pnlConn.Controls.Add(divider1);
            pnlConn.Controls.Add(btnConnect);
            pnlConn.Controls.Add(txtServerUrl);
            pnlConn.Controls.Add(lblServerUrl);
            pnlConn.Dock = DockStyle.Fill;
            pnlConn.Location = new Point(9, 11);
            pnlConn.Margin = new Padding(3, 4, 3, 4);
            pnlConn.Name = "pnlConn";
            pnlConn.Size = new Size(299, 923);
            pnlConn.TabIndex = 0;
            // 
            // btnRequestControl
            // 
            btnRequestControl.BackColor = Color.FromArgb(100, 60, 180);
            btnRequestControl.Enabled = false;
            btnRequestControl.FlatStyle = FlatStyle.Flat;
            btnRequestControl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRequestControl.ForeColor = Color.White;
            btnRequestControl.Location = new Point(9, 457);
            btnRequestControl.Margin = new Padding(3, 4, 3, 4);
            btnRequestControl.Name = "btnRequestControl";
            btnRequestControl.Size = new Size(229, 48);
            btnRequestControl.TabIndex = 0;
            btnRequestControl.Text = "🖥 Yêu cầu điều khiển";
            btnRequestControl.UseVisualStyleBackColor = false;
            btnRequestControl.Click += BtnRequestControl_Click;
            // 
            // cmbHosts
            // 
            cmbHosts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHosts.Location = new Point(9, 415);
            cmbHosts.Margin = new Padding(3, 4, 3, 4);
            cmbHosts.Name = "cmbHosts";
            cmbHosts.Size = new Size(287, 28);
            cmbHosts.TabIndex = 1;
            // 
            // btnRefreshHosts
            // 
            btnRefreshHosts.BackColor = Color.FromArgb(60, 60, 60);
            btnRefreshHosts.Enabled = false;
            btnRefreshHosts.FlatStyle = FlatStyle.Flat;
            btnRefreshHosts.ForeColor = Color.White;
            btnRefreshHosts.Location = new Point(9, 367);
            btnRefreshHosts.Margin = new Padding(3, 4, 3, 4);
            btnRefreshHosts.Name = "btnRefreshHosts";
            btnRefreshHosts.Size = new Size(126, 37);
            btnRefreshHosts.TabIndex = 2;
            btnRefreshHosts.Text = "🔄 Làm mới";
            btnRefreshHosts.UseVisualStyleBackColor = false;
            btnRefreshHosts.Click += BtnRefreshHosts_Click;
            // 
            // lblHostsHeader
            // 
            lblHostsHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHostsHeader.Location = new Point(9, 337);
            lblHostsHeader.Name = "lblHostsHeader";
            lblHostsHeader.Size = new Size(171, 24);
            lblHostsHeader.TabIndex = 3;
            lblHostsHeader.Text = "Danh sách Host:";
            // 
            // divider2
            // 
            divider2.BackColor = Color.FromArgb(80, 80, 80);
            divider2.Location = new Point(0, 320);
            divider2.Margin = new Padding(3, 4, 3, 4);
            divider2.Name = "divider2";
            divider2.Size = new Size(320, 1);
            divider2.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(16, 124, 16);
            btnRegister.Enabled = false;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(9, 261);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(183, 43);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "📋 Đăng ký Viewer";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(114, 219);
            txtUserId.Margin = new Padding(3, 4, 3, 4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(182, 27);
            txtUserId.TabIndex = 6;
            // 
            // lblUserId
            // 
            lblUserId.Location = new Point(9, 223);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(114, 24);
            lblUserId.TabIndex = 7;
            lblUserId.Text = "User ID:";
            // 
            // txtViewerName
            // 
            txtViewerName.Location = new Point(114, 176);
            txtViewerName.Margin = new Padding(3, 4, 3, 4);
            txtViewerName.Name = "txtViewerName";
            txtViewerName.Size = new Size(182, 27);
            txtViewerName.TabIndex = 8;
            // 
            // lblViewerName
            // 
            lblViewerName.Location = new Point(9, 180);
            lblViewerName.Name = "lblViewerName";
            lblViewerName.Size = new Size(114, 24);
            lblViewerName.TabIndex = 9;
            lblViewerName.Text = "Tên Viewer:";
            // 
            // txtViewerId
            // 
            txtViewerId.Location = new Point(114, 133);
            txtViewerId.Margin = new Padding(3, 4, 3, 4);
            txtViewerId.Name = "txtViewerId";
            txtViewerId.Size = new Size(182, 27);
            txtViewerId.TabIndex = 10;
            // 
            // lblViewerId
            // 
            lblViewerId.Location = new Point(9, 137);
            lblViewerId.Name = "lblViewerId";
            lblViewerId.Size = new Size(114, 24);
            lblViewerId.TabIndex = 11;
            lblViewerId.Text = "Viewer ID:";
            // 
            // divider1
            // 
            divider1.BackColor = Color.FromArgb(80, 80, 80);
            divider1.Location = new Point(0, 112);
            divider1.Margin = new Padding(3, 4, 3, 4);
            divider1.Name = "divider1";
            divider1.Size = new Size(320, 1);
            divider1.TabIndex = 12;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(0, 120, 212);
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(9, 53);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(137, 43);
            btnConnect.TabIndex = 13;
            btnConnect.Text = "🔌 Kết nối";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += BtnConnect_Click;
            // 
            // txtServerUrl
            // 
            txtServerUrl.Location = new Point(114, 11);
            txtServerUrl.Margin = new Padding(3, 4, 3, 4);
            txtServerUrl.Name = "txtServerUrl";
            txtServerUrl.Size = new Size(182, 27);
            txtServerUrl.TabIndex = 14;
            // 
            // lblServerUrl
            // 
            lblServerUrl.Location = new Point(9, 15);
            lblServerUrl.Name = "lblServerUrl";
            lblServerUrl.Size = new Size(114, 24);
            lblServerUrl.TabIndex = 15;
            lblServerUrl.Text = "Server URL:";
            // 
            // tabLog
            // 
            tabLog.Controls.Add(rtbLog);
            tabLog.Controls.Add(btnClearLog);
            tabLog.Location = new Point(4, 29);
            tabLog.Margin = new Padding(3, 4, 3, 4);
            tabLog.Name = "tabLog";
            tabLog.Padding = new Padding(5, 5, 5, 5);
            tabLog.Size = new Size(202, 79);
            tabLog.TabIndex = 1;
            tabLog.Text = "📋 Log";
            tabLog.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            rtbLog.BackColor = Color.FromArgb(15, 15, 15);
            rtbLog.Dock = DockStyle.Fill;
            rtbLog.Font = new Font("Consolas", 8F);
            rtbLog.ForeColor = Color.LightGreen;
            rtbLog.Location = new Point(5, 5);
            rtbLog.Margin = new Padding(3, 4, 3, 4);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbLog.Size = new Size(192, 34);
            rtbLog.TabIndex = 0;
            rtbLog.Text = "";
            // 
            // btnClearLog
            // 
            btnClearLog.Dock = DockStyle.Bottom;
            btnClearLog.Location = new Point(5, 39);
            btnClearLog.Margin = new Padding(3, 4, 3, 4);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(192, 35);
            btnClearLog.TabIndex = 1;
            btnClearLog.Text = "Xoá log";
            btnClearLog.Click += BtnClearLog_Click;
            // 
            // pnlScreen
            // 
            pnlScreen.BackColor = Color.Black;
            pnlScreen.Controls.Add(pnlScreenTop);
            pnlScreen.Controls.Add(lblHint);
            pnlScreen.Controls.Add(screenControl);
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(0, 0);
            pnlScreen.Margin = new Padding(3, 4, 3, 4);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(1023, 1000);
            pnlScreen.TabIndex = 0;
            // 
            // pnlScreenTop
            // 
            pnlScreenTop.BackColor = Color.FromArgb(30, 30, 30);
            pnlScreenTop.Controls.Add(lblStatus);
            pnlScreenTop.Controls.Add(lblFps);
            pnlScreenTop.Controls.Add(lblResolution);
            pnlScreenTop.Controls.Add(btnEndControl);
            pnlScreenTop.Dock = DockStyle.Top;
            pnlScreenTop.Location = new Point(0, 0);
            pnlScreenTop.Margin = new Padding(3, 4, 3, 4);
            pnlScreenTop.Name = "pnlScreenTop";
            pnlScreenTop.Padding = new Padding(9, 0, 9, 0);
            pnlScreenTop.Size = new Size(1023, 48);
            pnlScreenTop.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Left;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(295, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(229, 48);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "● Offline";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFps
            // 
            lblFps.Dock = DockStyle.Left;
            lblFps.Font = new Font("Consolas", 8.5F);
            lblFps.ForeColor = Color.LightGray;
            lblFps.Location = new Point(192, 0);
            lblFps.Name = "lblFps";
            lblFps.Size = new Size(103, 48);
            lblFps.TabIndex = 1;
            lblFps.Text = "FPS: –";
            lblFps.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResolution
            // 
            lblResolution.Dock = DockStyle.Left;
            lblResolution.Font = new Font("Consolas", 8.5F);
            lblResolution.ForeColor = Color.LightGray;
            lblResolution.Location = new Point(9, 0);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new Size(183, 48);
            lblResolution.TabIndex = 2;
            lblResolution.Text = "–";
            lblResolution.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEndControl
            // 
            btnEndControl.BackColor = Color.FromArgb(200, 40, 40);
            btnEndControl.Dock = DockStyle.Right;
            btnEndControl.Enabled = false;
            btnEndControl.FlatStyle = FlatStyle.Flat;
            btnEndControl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEndControl.ForeColor = Color.White;
            btnEndControl.Location = new Point(865, 0);
            btnEndControl.Margin = new Padding(3, 4, 3, 4);
            btnEndControl.Name = "btnEndControl";
            btnEndControl.Size = new Size(149, 48);
            btnEndControl.TabIndex = 3;
            btnEndControl.Text = "\U0001f6d1 End Control";
            btnEndControl.UseVisualStyleBackColor = false;
            btnEndControl.Click += BtnEndControl_Click;
            // 
            // lblHint
            // 
            lblHint.Dock = DockStyle.Fill;
            lblHint.Font = new Font("Segoe UI", 12F);
            lblHint.ForeColor = Color.Gray;
            lblHint.Location = new Point(0, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(1023, 1000);
            lblHint.TabIndex = 1;
            lblHint.Text = "Chọn Host và nhấn \"Yêu cầu điều khiển\" để bắt đầu";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // screenControl
            // 
            screenControl.BackColor = Color.Black;
            screenControl.Dock = DockStyle.Fill;
            screenControl.Location = new Point(0, 0);
            screenControl.Margin = new Padding(3, 4, 3, 4);
            screenControl.Name = "screenControl";
            screenControl.Size = new Size(1023, 1000);
            screenControl.TabIndex = 0;
            // 
            // fpsTimer
            // 
            fpsTimer.Enabled = true;
            fpsTimer.Interval = 1000;
            fpsTimer.Tick += FpsTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 1000);
            Controls.Add(splitMain);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 784);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoteViewerApp – Remote Controller Viewer";
            FormClosing += OnFormClosing;
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabConn.ResumeLayout(false);
            pnlConn.ResumeLayout(false);
            pnlConn.PerformLayout();
            tabLog.ResumeLayout(false);
            pnlScreen.ResumeLayout(false);
            pnlScreenTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)screenControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabConn;
        private System.Windows.Forms.Panel pnlConn;
        private System.Windows.Forms.Label lblServerUrl;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel divider1;
        private System.Windows.Forms.Label lblViewerId;
        private System.Windows.Forms.TextBox txtViewerId;
        private System.Windows.Forms.Label lblViewerName;
        private System.Windows.Forms.TextBox txtViewerName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel divider2;
        private System.Windows.Forms.Label lblHostsHeader;
        private System.Windows.Forms.Button btnRefreshHosts;
        private System.Windows.Forms.ComboBox cmbHosts;
        private System.Windows.Forms.Button btnRequestControl;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.Panel pnlScreenTop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Button btnEndControl;
        private System.Windows.Forms.Label lblHint;
        private RemoteViewerApp.Controls.RemoteScreenControl screenControl;
        private System.Windows.Forms.Timer fpsTimer;
    }
}
