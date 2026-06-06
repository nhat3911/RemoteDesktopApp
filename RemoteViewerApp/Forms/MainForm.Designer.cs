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
            splitMain = new System.Windows.Forms.SplitContainer();
            pnlSidebar = new System.Windows.Forms.Panel();
            tabMain = new System.Windows.Forms.TabControl();
            tabConn = new System.Windows.Forms.TabPage();
            pnlConn = new System.Windows.Forms.Panel();
            btnRequestControl = new System.Windows.Forms.Button();
            cmbHosts = new System.Windows.Forms.ComboBox();
            btnRefreshHosts = new System.Windows.Forms.Button();
            lblHostsHeader = new System.Windows.Forms.Label();
            divider2 = new System.Windows.Forms.Panel();
            btnRegister = new System.Windows.Forms.Button();
            txtUserId = new System.Windows.Forms.TextBox();
            lblUserId = new System.Windows.Forms.Label();
            txtViewerName = new System.Windows.Forms.TextBox();
            lblViewerName = new System.Windows.Forms.Label();
            txtViewerId = new System.Windows.Forms.TextBox();
            lblViewerId = new System.Windows.Forms.Label();
            divider1 = new System.Windows.Forms.Panel();
            btnConnect = new System.Windows.Forms.Button();
            txtServerUrl = new System.Windows.Forms.TextBox();
            lblServerUrl = new System.Windows.Forms.Label();
            tabLog = new System.Windows.Forms.TabPage();
            rtbLog = new System.Windows.Forms.RichTextBox();
            btnClearLog = new System.Windows.Forms.Button();
            pnlScreen = new System.Windows.Forms.Panel();
            pnlScreenTop = new System.Windows.Forms.Panel();
            lblStatus = new System.Windows.Forms.Label();
            lblFps = new System.Windows.Forms.Label();
            lblResolution = new System.Windows.Forms.Label();
            btnEndControl = new System.Windows.Forms.Button();
            lblHint = new System.Windows.Forms.Label();
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
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitMain.Name = "splitMain";
            splitMain.Panel1.Controls.Add(pnlSidebar);
            splitMain.Panel1MinSize = 260;
            splitMain.Panel2.Controls.Add(pnlScreen);
            splitMain.Panel2MinSize = 400;
            splitMain.Size = new System.Drawing.Size(1200, 750);
            splitMain.SplitterDistance = 300;
            splitMain.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(tabMain);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new System.Windows.Forms.Padding(8);
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabConn);
            tabMain.Controls.Add(tabLog);
            tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.TabIndex = 0;
            // 
            // tabConn
            // 
            tabConn.Controls.Add(pnlConn);
            tabConn.Name = "tabConn";
            tabConn.Padding = new System.Windows.Forms.Padding(8);
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
            pnlConn.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlConn.Name = "pnlConn";
            // 
            // lblServerUrl
            // 
            lblServerUrl.Bounds = new System.Drawing.Rectangle(8, 11, 100, 18);
            lblServerUrl.Name = "lblServerUrl";
            lblServerUrl.Text = "Server URL:";
            // 
            // txtServerUrl
            // 
            txtServerUrl.Bounds = new System.Drawing.Rectangle(100, 8, 160, 24);
            txtServerUrl.Name = "txtServerUrl";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            btnConnect.Bounds = new System.Drawing.Rectangle(8, 40, 120, 32);
            btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConnect.ForeColor = System.Drawing.Color.White;
            btnConnect.Name = "btnConnect";
            btnConnect.Text = "🔌 Kết nối";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += BtnConnect_Click;
            // 
            // divider1
            // 
            divider1.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            divider1.Bounds = new System.Drawing.Rectangle(0, 84, 280, 1);
            divider1.Name = "divider1";
            // 
            // lblViewerId
            // 
            lblViewerId.Bounds = new System.Drawing.Rectangle(8, 103, 100, 18);
            lblViewerId.Name = "lblViewerId";
            lblViewerId.Text = "Viewer ID:";
            // 
            // txtViewerId
            // 
            txtViewerId.Bounds = new System.Drawing.Rectangle(100, 100, 160, 24);
            txtViewerId.Name = "txtViewerId";
            // 
            // lblViewerName
            // 
            lblViewerName.Bounds = new System.Drawing.Rectangle(8, 135, 100, 18);
            lblViewerName.Name = "lblViewerName";
            lblViewerName.Text = "Tên Viewer:";
            // 
            // txtViewerName
            // 
            txtViewerName.Bounds = new System.Drawing.Rectangle(100, 132, 160, 24);
            txtViewerName.Name = "txtViewerName";
            // 
            // lblUserId
            // 
            lblUserId.Bounds = new System.Drawing.Rectangle(8, 167, 100, 18);
            lblUserId.Name = "lblUserId";
            lblUserId.Text = "User ID:";
            // 
            // txtUserId
            // 
            txtUserId.Bounds = new System.Drawing.Rectangle(100, 164, 160, 24);
            txtUserId.Name = "txtUserId";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            btnRegister.Bounds = new System.Drawing.Rectangle(8, 196, 160, 32);
            btnRegister.Enabled = false;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.ForeColor = System.Drawing.Color.White;
            btnRegister.Name = "btnRegister";
            btnRegister.Text = "📋 Đăng ký Viewer";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // divider2
            // 
            divider2.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            divider2.Bounds = new System.Drawing.Rectangle(0, 240, 280, 1);
            divider2.Name = "divider2";
            // 
            // lblHostsHeader
            // 
            lblHostsHeader.Bounds = new System.Drawing.Rectangle(8, 253, 150, 18);
            lblHostsHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblHostsHeader.Name = "lblHostsHeader";
            lblHostsHeader.Text = "Danh sách Host:";
            // 
            // btnRefreshHosts
            // 
            btnRefreshHosts.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnRefreshHosts.Bounds = new System.Drawing.Rectangle(8, 275, 110, 28);
            btnRefreshHosts.Enabled = false;
            btnRefreshHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshHosts.ForeColor = System.Drawing.Color.White;
            btnRefreshHosts.Name = "btnRefreshHosts";
            btnRefreshHosts.Text = "🔄 Làm mới";
            btnRefreshHosts.UseVisualStyleBackColor = false;
            btnRefreshHosts.Click += BtnRefreshHosts_Click;
            // 
            // cmbHosts
            // 
            cmbHosts.Bounds = new System.Drawing.Rectangle(8, 311, 252, 24);
            cmbHosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbHosts.Name = "cmbHosts";
            // 
            // btnRequestControl
            // 
            btnRequestControl.BackColor = System.Drawing.Color.FromArgb(100, 60, 180);
            btnRequestControl.Bounds = new System.Drawing.Rectangle(8, 343, 200, 36);
            btnRequestControl.Enabled = false;
            btnRequestControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRequestControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnRequestControl.ForeColor = System.Drawing.Color.White;
            btnRequestControl.Name = "btnRequestControl";
            btnRequestControl.Text = "🖥 Yêu cầu điều khiển";
            btnRequestControl.UseVisualStyleBackColor = false;
            btnRequestControl.Click += BtnRequestControl_Click;
            // 
            // tabLog
            // 
            tabLog.Controls.Add(rtbLog);
            tabLog.Controls.Add(btnClearLog);
            tabLog.Name = "tabLog";
            tabLog.Padding = new System.Windows.Forms.Padding(4);
            tabLog.Text = "📋 Log";
            tabLog.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            rtbLog.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            rtbLog.Font = new System.Drawing.Font("Consolas", 8F);
            rtbLog.ForeColor = System.Drawing.Color.LightGreen;
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            rtbLog.Text = "";
            // 
            // btnClearLog
            // 
            btnClearLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnClearLog.Height = 26;
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Text = "Xoá log";
            btnClearLog.Click += BtnClearLog_Click;
            // 
            // pnlScreen
            // 
            pnlScreen.BackColor = System.Drawing.Color.Black;
            pnlScreen.Controls.Add(pnlScreenTop);
            pnlScreen.Controls.Add(lblHint);
            pnlScreen.Controls.Add(screenControl);
            pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlScreen.Name = "pnlScreen";
            // 
            // pnlScreenTop
            // 
            pnlScreenTop.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            pnlScreenTop.Controls.Add(lblStatus);
            pnlScreenTop.Controls.Add(lblFps);
            pnlScreenTop.Controls.Add(lblResolution);
            pnlScreenTop.Controls.Add(btnEndControl);
            pnlScreenTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlScreenTop.Height = 36;
            pnlScreenTop.Name = "pnlScreenTop";
            pnlScreenTop.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = false;
            lblStatus.Dock = System.Windows.Forms.DockStyle.Left;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.Gray;
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "● Offline";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblStatus.Width = 200;
            // 
            // lblFps
            // 
            lblFps.AutoSize = false;
            lblFps.Dock = System.Windows.Forms.DockStyle.Left;
            lblFps.Font = new System.Drawing.Font("Consolas", 8.5F);
            lblFps.ForeColor = System.Drawing.Color.LightGray;
            lblFps.Name = "lblFps";
            lblFps.Text = "FPS: –";
            lblFps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblFps.Width = 90;
            // 
            // lblResolution
            // 
            lblResolution.AutoSize = false;
            lblResolution.Dock = System.Windows.Forms.DockStyle.Left;
            lblResolution.Font = new System.Drawing.Font("Consolas", 8.5F);
            lblResolution.ForeColor = System.Drawing.Color.LightGray;
            lblResolution.Name = "lblResolution";
            lblResolution.Text = "–";
            lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblResolution.Width = 160;
            // 
            // btnEndControl
            // 
            btnEndControl.BackColor = System.Drawing.Color.FromArgb(200, 40, 40);
            btnEndControl.Dock = System.Windows.Forms.DockStyle.Right;
            btnEndControl.Enabled = false;
            btnEndControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEndControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnEndControl.ForeColor = System.Drawing.Color.White;
            btnEndControl.Name = "btnEndControl";
            btnEndControl.Text = "🛑 End Control";
            btnEndControl.UseVisualStyleBackColor = false;
            btnEndControl.Width = 130;
            btnEndControl.Click += BtnEndControl_Click;
            // 
            // lblHint
            // 
            lblHint.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHint.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblHint.ForeColor = System.Drawing.Color.Gray;
            lblHint.Name = "lblHint";
            lblHint.Text = "Chọn Host và nhấn \"Yêu cầu điều khiển\" để bắt đầu";
            lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // screenControl
            // 
            screenControl.Dock = System.Windows.Forms.DockStyle.Fill;
            screenControl.Name = "screenControl";
            screenControl.TabIndex = 0;
            // 
            // fpsTimer
            // 
            fpsTimer.Interval = 1000;
            fpsTimer.Tick += FpsTimer_Tick;
            fpsTimer.Start();
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 750);
            Controls.Add(splitMain);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MinimumSize = new System.Drawing.Size(900, 600);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
