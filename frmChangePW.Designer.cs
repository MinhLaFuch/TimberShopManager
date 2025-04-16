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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            lbPlaceholder = new Label();
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
            txtNewPassword.Location = new Point(174, 40);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(157, 20);
            txtNewPassword.TabIndex = 5;
            // 
            // txtNewPasswordAgain
            // 
            txtNewPasswordAgain.BorderStyle = BorderStyle.None;
            txtNewPasswordAgain.Location = new Point(174, 99);
            txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            txtNewPasswordAgain.Size = new Size(157, 20);
            txtNewPasswordAgain.TabIndex = 7;
            // 
            // lbNewPasswordAgain
            // 
            lbNewPasswordAgain.AutoSize = true;
            lbNewPasswordAgain.ForeColor = Color.FromArgb(59, 93, 79);
            lbNewPasswordAgain.Location = new Point(19, 99);
            lbNewPasswordAgain.Name = "lbNewPasswordAgain";
            lbNewPasswordAgain.Size = new Size(130, 20);
            lbNewPasswordAgain.TabIndex = 6;
            lbNewPasswordAgain.Text = "Nhập lại mật khẩu";
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges7;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(59, 93, 79);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(441, 3);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSave.Size = new Size(123, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.CustomizableEdges = customizableEdges9;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(59, 93, 79);
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(570, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancel.Size = new Size(123, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // lbNewPasswordWarning
            // 
            lbNewPasswordWarning.AutoSize = true;
            lbNewPasswordWarning.ForeColor = Color.Red;
            lbNewPasswordWarning.Location = new Point(337, 40);
            lbNewPasswordWarning.Name = "lbNewPasswordWarning";
            lbNewPasswordWarning.Size = new Size(70, 20);
            lbNewPasswordWarning.TabIndex = 10;
            lbNewPasswordWarning.Text = "cảnh báo";
            // 
            // lbNewPasswordAgainWarning
            // 
            lbNewPasswordAgainWarning.AutoSize = true;
            lbNewPasswordAgainWarning.ForeColor = Color.Red;
            lbNewPasswordAgainWarning.Location = new Point(337, 99);
            lbNewPasswordAgainWarning.Name = "lbNewPasswordAgainWarning";
            lbNewPasswordAgainWarning.Size = new Size(70, 20);
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
            pnNewPassword.Location = new Point(3, 75);
            pnNewPassword.Name = "pnNewPassword";
            pnNewPassword.Size = new Size(697, 150);
            pnNewPassword.TabIndex = 15;
            pnNewPassword.Paint += pnNewPassword_Paint;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.ForeColor = Color.FromArgb(59, 93, 79);
            lbNewPassword.Location = new Point(22, 40);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(100, 20);
            lbNewPassword.TabIndex = 4;
            lbNewPassword.Text = "Mật khẩu mới";
            // 
            // txtCode
            // 
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Location = new Point(174, 37);
            txtCode.MaxLength = 6;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(157, 20);
            txtCode.TabIndex = 13;
            txtCode.TextChanged += txtCode_TextChanged;
            txtCode.KeyPress += txtCode_KeyPress;
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.ForeColor = Color.FromArgb(59, 93, 79);
            lbCode.Location = new Point(25, 37);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(92, 20);
            lbCode.TabIndex = 12;
            lbCode.Text = "Mã xác nhận";
            // 
            // lbCodeWarning
            // 
            lbCodeWarning.AutoSize = true;
            lbCodeWarning.ForeColor = Color.Red;
            lbCodeWarning.Location = new Point(340, 37);
            lbCodeWarning.Name = "lbCodeWarning";
            lbCodeWarning.Size = new Size(70, 20);
            lbCodeWarning.TabIndex = 14;
            lbCodeWarning.Text = "cảnh báo";
            // 
            // pnCode
            // 
            pnCode.Controls.Add(txtCode);
            pnCode.Controls.Add(lbCode);
            pnCode.Controls.Add(lbCodeWarning);
            pnCode.Location = new Point(0, 75);
            pnCode.Name = "pnCode";
            pnCode.Size = new Size(697, 78);
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
            lbCodeCountdown.Location = new Point(174, 38);
            lbCodeCountdown.Name = "lbCodeCountdown";
            lbCodeCountdown.Size = new Size(0, 20);
            lbCodeCountdown.TabIndex = 15;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnCancel);
            pnButton.Controls.Add(btnSave);
            pnButton.Dock = DockStyle.Bottom;
            pnButton.FlowDirection = FlowDirection.RightToLeft;
            pnButton.Location = new Point(0, 236);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(696, 44);
            pnButton.TabIndex = 12;
            // 
            // pnGmail
            // 
            pnGmail.Controls.Add(lbPlaceholder);
            pnGmail.Controls.Add(txtGmail);
            pnGmail.Controls.Add(lbGmail);
            pnGmail.Controls.Add(btnSendEmail);
            pnGmail.Dock = DockStyle.Top;
            pnGmail.Location = new Point(0, 0);
            pnGmail.Name = "pnGmail";
            pnGmail.Size = new Size(696, 66);
            pnGmail.TabIndex = 16;
            // 
            // lbPlaceholder
            // 
            lbPlaceholder.AutoSize = true;
            lbPlaceholder.ForeColor = Color.FromArgb(59, 93, 79);
            lbPlaceholder.Location = new Point(576, 5);
            lbPlaceholder.Name = "lbPlaceholder";
            lbPlaceholder.Size = new Size(93, 20);
            lbPlaceholder.TabIndex = 18;
            lbPlaceholder.Text = "@gmail.com";
            // 
            // txtGmail
            // 
            txtGmail.BorderStyle = BorderStyle.None;
            txtGmail.Location = new Point(175, 5);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(401, 20);
            txtGmail.TabIndex = 17;
            txtGmail.TextAlign = HorizontalAlignment.Right;
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.ForeColor = Color.FromArgb(59, 93, 79);
            lbGmail.Location = new Point(23, 5);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(48, 20);
            lbGmail.TabIndex = 16;
            lbGmail.Text = "Gmail";
            // 
            // btnSendEmail
            // 
            btnSendEmail.CustomizableEdges = customizableEdges11;
            btnSendEmail.DisabledState.BorderColor = Color.DarkGray;
            btnSendEmail.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSendEmail.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSendEmail.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSendEmail.FillColor = Color.FromArgb(59, 93, 79);
            btnSendEmail.Font = new Font("Segoe UI", 9F);
            btnSendEmail.ForeColor = Color.White;
            btnSendEmail.Location = new Point(175, 31);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSendEmail.Size = new Size(206, 31);
            btnSendEmail.TabIndex = 15;
            btnSendEmail.Text = "Gửi mã xác thực";
            // 
            // frmChangePW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 280);
            Controls.Add(pnGmail);
            Controls.Add(pnButton);
            Controls.Add(lbCodeCountdown);
            Controls.Add(pnCode);
            Controls.Add(pnNewPassword);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label lbPlaceholder;
        private TextBox txtGmail;
        private Label lbGmail;
        private Guna.UI2.WinForms.Guna2Button btnSendEmail;
    }
}