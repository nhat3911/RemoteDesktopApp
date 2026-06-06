namespace RemoteHostApp.Forms
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
            pnlTop = new TableLayoutPanel();
            lblHostId = new Label();
            txtHostId = new TextBox();
            lblComputerName = new Label();
            txtComputerName = new TextBox();
            lblUserId = new Label();
            txtUserId = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            btnConnect = new Button();
            btnRegister = new Button();
            btnStartStop = new Button();
            btnEndControl = new Button();
            txtServerUrl = new TextBox();
            lblServerUrl = new Label();
            pnlStatus = new Panel();
            lblStatus = new Label();
            pnlLog = new Panel();
            rtbLog = new RichTextBox();
            btnClearLog = new Button();
            lblLog = new Label();
            pnlTop.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlStatus.SuspendLayout();
            pnlLog.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.ColumnCount = 2;
            pnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            pnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTop.Controls.Add(lblHostId, 0, 1);
            pnlTop.Controls.Add(txtHostId, 1, 1);
            pnlTop.Controls.Add(lblComputerName, 0, 2);
            pnlTop.Controls.Add(txtComputerName, 1, 2);
            pnlTop.Controls.Add(lblUserId, 0, 3);
            pnlTop.Controls.Add(txtUserId, 1, 3);
            pnlTop.Controls.Add(pnlButtons, 0, 4);
            pnlTop.Controls.Add(txtServerUrl, 1, 0);
            pnlTop.Controls.Add(lblServerUrl, 0, 0);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(11, 13, 11, 13);
            pnlTop.RowCount = 5;
            pnlTop.RowStyles.Add(new RowStyle());
            pnlTop.RowStyles.Add(new RowStyle());
            pnlTop.RowStyles.Add(new RowStyle());
            pnlTop.RowStyles.Add(new RowStyle());
            pnlTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTop.Size = new Size(800, 253);
            pnlTop.TabIndex = 0;
            // 
            // lblHostId
            // 
            lblHostId.AutoSize = true;
            lblHostId.Location = new Point(14, 48);
            lblHostId.Name = "lblHostId";
            lblHostId.Size = new Size(62, 20);
            lblHostId.TabIndex = 2;
            lblHostId.Text = "Host ID:";
            // 
            // txtHostId
            // 
            txtHostId.Dock = DockStyle.Fill;
            txtHostId.Location = new Point(128, 52);
            txtHostId.Margin = new Padding(3, 4, 3, 4);
            txtHostId.Name = "txtHostId";
            txtHostId.Size = new Size(658, 27);
            txtHostId.TabIndex = 3;
            // 
            // lblComputerName
            // 
            lblComputerName.AutoSize = true;
            lblComputerName.Location = new Point(14, 83);
            lblComputerName.Name = "lblComputerName";
            lblComputerName.Size = new Size(78, 20);
            lblComputerName.TabIndex = 4;
            lblComputerName.Text = "Computer:";
            // 
            // txtComputerName
            // 
            txtComputerName.Dock = DockStyle.Fill;
            txtComputerName.Location = new Point(128, 87);
            txtComputerName.Margin = new Padding(3, 4, 3, 4);
            txtComputerName.Name = "txtComputerName";
            txtComputerName.Size = new Size(658, 27);
            txtComputerName.TabIndex = 5;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(14, 118);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(60, 20);
            lblUserId.TabIndex = 6;
            lblUserId.Text = "User ID:";
            // 
            // txtUserId
            // 
            txtUserId.Dock = DockStyle.Fill;
            txtUserId.Location = new Point(128, 122);
            txtUserId.Margin = new Padding(3, 4, 3, 4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(658, 27);
            txtUserId.TabIndex = 7;
            // 
            // pnlButtons
            // 
            pnlTop.SetColumnSpan(pnlButtons, 2);
            pnlButtons.Controls.Add(btnConnect);
            pnlButtons.Controls.Add(btnRegister);
            pnlButtons.Controls.Add(btnStartStop);
            pnlButtons.Controls.Add(btnEndControl);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(14, 174);
            pnlButtons.Margin = new Padding(3, 4, 3, 4);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(11, 7, 11, 7);
            pnlButtons.Size = new Size(772, 62);
            pnlButtons.TabIndex = 8;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(0, 120, 212);
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(14, 11);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(137, 43);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "🔌 Kết nối";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += BtnConnect_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(16, 124, 16);
            btnRegister.Enabled = false;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(157, 11);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(160, 43);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "📋 Đăng ký Host";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.BackColor = Color.FromArgb(100, 100, 200);
            btnStartStop.Enabled = false;
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.ForeColor = Color.White;
            btnStartStop.Location = new Point(323, 11);
            btnStartStop.Margin = new Padding(3, 4, 3, 4);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(160, 43);
            btnStartStop.TabIndex = 2;
            btnStartStop.Text = "▶ Start Stream";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += BtnStartStop_Click;
            // 
            // btnEndControl
            // 
            btnEndControl.BackColor = Color.FromArgb(200, 40, 40);
            btnEndControl.Enabled = false;
            btnEndControl.FlatStyle = FlatStyle.Flat;
            btnEndControl.ForeColor = Color.White;
            btnEndControl.Location = new Point(489, 11);
            btnEndControl.Margin = new Padding(3, 4, 3, 4);
            btnEndControl.Name = "btnEndControl";
            btnEndControl.Size = new Size(149, 43);
            btnEndControl.TabIndex = 3;
            btnEndControl.Text = "\U0001f6d1 End Control";
            btnEndControl.UseVisualStyleBackColor = false;
            btnEndControl.Click += BtnEndControl_Click;
            // 
            // txtServerUrl
            // 
            txtServerUrl.Dock = DockStyle.Fill;
            txtServerUrl.Location = new Point(128, 17);
            txtServerUrl.Margin = new Padding(3, 4, 3, 4);
            txtServerUrl.Name = "txtServerUrl";
            txtServerUrl.Size = new Size(658, 27);
            txtServerUrl.TabIndex = 1;
            // 
            // lblServerUrl
            // 
            lblServerUrl.AutoSize = true;
            lblServerUrl.Location = new Point(14, 13);
            lblServerUrl.Name = "lblServerUrl";
            lblServerUrl.Size = new Size(83, 20);
            lblServerUrl.TabIndex = 0;
            lblServerUrl.Text = "Server URL:";
            lblServerUrl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.FromArgb(240, 240, 240);
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Dock = DockStyle.Top;
            pnlStatus.Location = new Point(0, 253);
            pnlStatus.Margin = new Padding(3, 4, 3, 4);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(800, 40);
            pnlStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(11, 0, 0, 0);
            lblStatus.Size = new Size(800, 40);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "● Offline";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLog
            // 
            pnlLog.Controls.Add(rtbLog);
            pnlLog.Controls.Add(btnClearLog);
            pnlLog.Controls.Add(lblLog);
            pnlLog.Dock = DockStyle.Fill;
            pnlLog.Location = new Point(0, 293);
            pnlLog.Margin = new Padding(3, 4, 3, 4);
            pnlLog.Name = "pnlLog";
            pnlLog.Padding = new Padding(11, 13, 11, 13);
            pnlLog.Size = new Size(800, 507);
            pnlLog.TabIndex = 0;
            // 
            // rtbLog
            // 
            rtbLog.BackColor = Color.FromArgb(20, 20, 20);
            rtbLog.Dock = DockStyle.Fill;
            rtbLog.Font = new Font("Consolas", 8.5F);
            rtbLog.ForeColor = Color.LightGreen;
            rtbLog.Location = new Point(11, 40);
            rtbLog.Margin = new Padding(3, 4, 3, 4);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbLog.Size = new Size(778, 417);
            rtbLog.TabIndex = 0;
            rtbLog.Text = "";
            // 
            // btnClearLog
            // 
            btnClearLog.Dock = DockStyle.Bottom;
            btnClearLog.Location = new Point(11, 457);
            btnClearLog.Margin = new Padding(3, 4, 3, 4);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(778, 37);
            btnClearLog.TabIndex = 1;
            btnClearLog.Text = "Xoá log";
            btnClearLog.Click += BtnClearLog_Click;
            // 
            // lblLog
            // 
            lblLog.Dock = DockStyle.Top;
            lblLog.Location = new Point(11, 13);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(778, 27);
            lblLog.TabIndex = 2;
            lblLog.Text = "Log:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(pnlLog);
            Controls.Add(pnlStatus);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(683, 651);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoteHostApp – Remote Controller";
            FormClosing += MainForm_FormClosing;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlStatus.ResumeLayout(false);
            pnlLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.Label lblServerUrl;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Label lblHostId;
        private System.Windows.Forms.TextBox txtHostId;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnEndControl;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}
