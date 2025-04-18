namespace timber_shop_manager
{
    partial class frmChangePW
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtNewPassword = new TextBox();
            txtNewPasswordAgain = new TextBox();
            lbNewPasswordAgain = new Label();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            lbNewPasswordWarning = new Label();
            lbNewPasswordAgainWarning = new Label();
            pnNewPassword = new Panel();
            lbNewPassword = new Label();
            txtCode = new TextBox();
            lbCode = new Label();
            lbCodeWarning = new Label();
            pnCode = new Panel();
            codeExpiration = new System.Windows.Forms.Timer(components);
            lbCodeCountdown = new Label();
            pnButton = new FlowLayoutPanel();
            pnGmail = new Panel();
            txtGmail = new TextBox();
            lbGmail = new Label();
            btnSendEmail = new Guna.UI2.WinForms.Guna2Button();
            pnNewPassword.SuspendLayout();
            pnCode.SuspendLayout();
            pnButton.SuspendLayout();
            pnGmail.SuspendLayout();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Location = new Point(152, 30);
            txtNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(137, 16);
            txtNewPassword.TabIndex = 5;
            // 
            // txtNewPasswordAgain
            // 
            txtNewPasswordAgain.BackColor = SystemColors.ActiveCaption;
            txtNewPasswordAgain.BorderStyle = BorderStyle.None;
            txtNewPasswordAgain.Location = new Point(149, 73);
            txtNewPasswordAgain.Margin = new Padding(3, 2, 3, 2);
            txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            txtNewPasswordAgain.Size = new Size(137, 16);
            txtNewPasswordAgain.TabIndex = 7;
            // 
            // lbNewPasswordAgain
            // 
            lbNewPasswordAgain.AutoSize = true;
            lbNewPasswordAgain.ForeColor = Color.FromArgb(59, 93, 79);
            lbNewPasswordAgain.Location = new Point(20, 74);
            lbNewPasswordAgain.Name = "lbNewPasswordAgain";
            lbNewPasswordAgain.Size = new Size(104, 15);
            lbNewPasswordAgain.TabIndex = 6;
            lbNewPasswordAgain.Text = "Nhập lại mật khẩu";
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges1;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(59, 93, 79);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(153, 2);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(108, 22);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.CustomizableEdges = customizableEdges3;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(59, 93, 79);
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(267, 2);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.Size = new Size(108, 22);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // lbNewPasswordWarning
            // 
            lbNewPasswordWarning.AutoSize = true;
            lbNewPasswordWarning.ForeColor = Color.Red;
            lbNewPasswordWarning.Location = new Point(295, 30);
            lbNewPasswordWarning.Name = "lbNewPasswordWarning";
            lbNewPasswordWarning.Size = new Size(56, 15);
            lbNewPasswordWarning.TabIndex = 10;
            lbNewPasswordWarning.Text = "cảnh báo";
            // 
            // lbNewPasswordAgainWarning
            // 
            lbNewPasswordAgainWarning.AutoSize = true;
            lbNewPasswordAgainWarning.ForeColor = Color.Red;
            lbNewPasswordAgainWarning.Location = new Point(295, 74);
            lbNewPasswordAgainWarning.Name = "lbNewPasswordAgainWarning";
            lbNewPasswordAgainWarning.Size = new Size(56, 15);
            lbNewPasswordAgainWarning.TabIndex = 11;
            lbNewPasswordAgainWarning.Text = "cảnh báo";
            // 
            // pnNewPassword
            // 
            pnNewPassword.Controls.Add(txtNewPassword);
            pnNewPassword.Controls.Add(lbNewPassword);
            pnNewPassword.Controls.Add(lbNewPasswordAgain);
            pnNewPassword.Controls.Add(lbNewPasswordAgainWarning);
            pnNewPassword.Controls.Add(txtNewPasswordAgain);
            pnNewPassword.Controls.Add(lbNewPasswordWarning);
            pnNewPassword.Location = new Point(3, 56);
            pnNewPassword.Margin = new Padding(3, 2, 3, 2);
            pnNewPassword.Name = "pnNewPassword";
            pnNewPassword.Size = new Size(371, 112);
            pnNewPassword.TabIndex = 15;
            pnNewPassword.Paint += pnNewPassword_Paint;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.ForeColor = Color.FromArgb(59, 93, 79);
            lbNewPassword.Location = new Point(19, 30);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(81, 15);
            lbNewPassword.TabIndex = 4;
            lbNewPassword.Text = "Mật khẩu mới";
            // 
            // txtCode
            // 
            txtCode.BackColor = SystemColors.ActiveCaption;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Location = new Point(152, 28);
            txtCode.Margin = new Padding(3, 2, 3, 2);
            txtCode.MaxLength = 6;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(137, 16);
            txtCode.TabIndex = 13;
            txtCode.TextChanged += txtCode_TextChanged;
            txtCode.KeyPress += txtCode_KeyPress;
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.ForeColor = Color.FromArgb(59, 93, 79);
            lbCode.Location = new Point(20, 28);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(75, 15);
            lbCode.TabIndex = 12;
            lbCode.Text = "Mã xác nhận";
            // 
            // lbCodeWarning
            // 
            lbCodeWarning.AutoSize = true;
            lbCodeWarning.ForeColor = Color.Red;
            lbCodeWarning.Location = new Point(298, 28);
            lbCodeWarning.Name = "lbCodeWarning";
            lbCodeWarning.Size = new Size(56, 15);
            lbCodeWarning.TabIndex = 14;
            lbCodeWarning.Text = "cảnh báo";
            // 
            // pnCode
            // 
            pnCode.Controls.Add(txtCode);
            pnCode.Controls.Add(lbCode);
            pnCode.Controls.Add(lbCodeWarning);
            pnCode.Location = new Point(0, 56);
            pnCode.Margin = new Padding(3, 2, 3, 2);
            pnCode.Name = "pnCode";
            pnCode.Size = new Size(374, 58);
            pnCode.TabIndex = 12;
            // 
            // codeExpiration
            // 
            codeExpiration.Interval = 1000;
            codeExpiration.Tick += codeExpiration_Tick;
            // 
            // lbCodeCountdown
            // 
            lbCodeCountdown.AutoSize = true;
            lbCodeCountdown.Font = new Font("Segoe UI", 9F);
            lbCodeCountdown.ForeColor = Color.Red;
            lbCodeCountdown.Location = new Point(152, 28);
            lbCodeCountdown.Name = "lbCodeCountdown";
            lbCodeCountdown.Size = new Size(0, 15);
            lbCodeCountdown.TabIndex = 15;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnCancel);
            pnButton.Controls.Add(btnSave);
            pnButton.Dock = DockStyle.Bottom;
            pnButton.FlowDirection = FlowDirection.RightToLeft;
            pnButton.Location = new Point(0, 177);
            pnButton.Margin = new Padding(3, 2, 3, 2);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(378, 33);
            pnButton.TabIndex = 12;
            // 
            // pnGmail
            // 
            pnGmail.Controls.Add(txtGmail);
            pnGmail.Controls.Add(lbGmail);
            pnGmail.Controls.Add(btnSendEmail);
            pnGmail.Dock = DockStyle.Top;
            pnGmail.Location = new Point(0, 0);
            pnGmail.Margin = new Padding(3, 2, 3, 2);
            pnGmail.Name = "pnGmail";
            pnGmail.Size = new Size(378, 50);
            pnGmail.TabIndex = 16;
            // 
            // txtGmail
            // 
            txtGmail.BackColor = SystemColors.ActiveCaption;
            txtGmail.BorderStyle = BorderStyle.None;
            txtGmail.Location = new Point(152, 4);
            txtGmail.Margin = new Padding(3, 2, 3, 2);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(222, 16);
            txtGmail.TabIndex = 17;
            txtGmail.TextAlign = HorizontalAlignment.Right;
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.ForeColor = Color.FromArgb(59, 93, 79);
            lbGmail.Location = new Point(20, 8);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(38, 15);
            lbGmail.TabIndex = 16;
            lbGmail.Text = "Gmail";
            // 
            // btnSendEmail
            // 
            btnSendEmail.CustomizableEdges = customizableEdges5;
            btnSendEmail.DisabledState.BorderColor = Color.DarkGray;
            btnSendEmail.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSendEmail.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSendEmail.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSendEmail.FillColor = Color.FromArgb(59, 93, 79);
            btnSendEmail.Font = new Font("Segoe UI", 9F);
            btnSendEmail.ForeColor = Color.White;
            btnSendEmail.Location = new Point(152, 24);
            btnSendEmail.Margin = new Padding(3, 2, 3, 2);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSendEmail.Size = new Size(116, 23);
            btnSendEmail.TabIndex = 15;
            btnSendEmail.Text = "Gửi mã xác thực";
            // 
            // frmChangePW
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(378, 210);
            Controls.Add(pnGmail);
            Controls.Add(pnButton);
            Controls.Add(lbCodeCountdown);
            Controls.Add(pnCode);
            Controls.Add(pnNewPassword);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmChangePW";
            Text = "frmChangePW";
            Load += frmChangePW_Load;
            pnNewPassword.ResumeLayout(false);
            pnNewPassword.PerformLayout();
            pnCode.ResumeLayout(false);
            pnCode.PerformLayout();
            pnButton.ResumeLayout(false);
            pnGmail.ResumeLayout(false);
            pnGmail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNewPassword;
        private TextBox txtNewPasswordAgain;
        private Label lbNewPasswordAgain;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Label lbNewPasswordWarning;
        private Label lbNewPasswordAgainWarning;
        private Panel pnNewPassword;
        private Label lbNewPassword;
        private TextBox txtCode;
        private Label lbCode;
        private Label lbCodeWarning;
        private Panel pnCode;
        private System.Windows.Forms.Timer codeExpiration;
        private Label lbCodeCountdown;
        private FlowLayoutPanel pnButton;
        private Panel pnGmail;
        private TextBox txtGmail;
        private Label lbGmail;
        private Guna.UI2.WinForms.Guna2Button btnSendEmail;
    }
}