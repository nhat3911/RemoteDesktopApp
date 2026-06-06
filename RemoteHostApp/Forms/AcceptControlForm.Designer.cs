namespace RemoteHostApp.Forms
{
    partial class AcceptControlForm
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
            lblMessage = new System.Windows.Forms.Label();
            lblReasonHint = new System.Windows.Forms.Label();
            txtRejectReason = new System.Windows.Forms.TextBox();
            btnAccept = new System.Windows.Forms.Button();
            btnReject = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Bounds = new System.Drawing.Rectangle(16, 16, 380, 60);
            lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblMessage.Name = "lblMessage";
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReasonHint
            // 
            lblReasonHint.Bounds = new System.Drawing.Rectangle(16, 86, 200, 20);
            lblReasonHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblReasonHint.Name = "lblReasonHint";
            lblReasonHint.Text = "Lý do từ chối (tuỳ chọn):";
            // 
            // txtRejectReason
            // 
            txtRejectReason.Bounds = new System.Drawing.Rectangle(16, 108, 380, 24);
            txtRejectReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtRejectReason.Name = "txtRejectReason";
            txtRejectReason.PlaceholderText = "Nhập lý do (nếu muốn từ chối)...";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = System.Drawing.Color.FromArgb(0, 150, 80);
            btnAccept.Bounds = new System.Drawing.Rectangle(16, 150, 130, 40);
            btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAccept.ForeColor = System.Drawing.Color.White;
            btnAccept.Name = "btnAccept";
            btnAccept.Text = "✔ Chấp nhận";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += BtnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = System.Drawing.Color.FromArgb(200, 40, 40);
            btnReject.Bounds = new System.Drawing.Rectangle(160, 150, 130, 40);
            btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnReject.ForeColor = System.Drawing.Color.White;
            btnReject.Name = "btnReject";
            btnReject.Text = "✘ Từ chối";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += BtnReject_Click;
            // 
            // AcceptControlForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(420, 210);
            Controls.Add(lblMessage);
            Controls.Add(lblReasonHint);
            Controls.Add(txtRejectReason);
            Controls.Add(btnAccept);
            Controls.Add(btnReject);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AcceptControlForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Yêu cầu điều khiển từ xa";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblReasonHint;
        private System.Windows.Forms.TextBox txtRejectReason;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
    }
}
