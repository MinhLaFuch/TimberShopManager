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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePW));
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
            pbInvisible_newPW = new PictureBox();
            pbInvisible_rePW = new PictureBox();
            pbVisible_newPW = new PictureBox();
            pbVisible_rePW = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pbInvisible_newPW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInvisible_rePW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVisible_newPW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVisible_rePW).BeginInit();
            pnCode.SuspendLayout();
            pnButton.SuspendLayout();
            pnGmail.SuspendLayout();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Location = new Point(170, 27);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(266, 20);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // txtNewPasswordAgain
            // 
            txtNewPasswordAgain.BackColor = Color.White;
            txtNewPasswordAgain.BorderStyle = BorderStyle.None;
            txtNewPasswordAgain.ForeColor = Color.FromArgb(59, 93, 79);
            txtNewPasswordAgain.Location = new Point(170, 97);
            txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            txtNewPasswordAgain.Size = new Size(266, 20);
            txtNewPasswordAgain.TabIndex = 4;
            // 
            // lbNewPasswordAgain
            // 
            lbNewPasswordAgain.AutoSize = true;
            lbNewPasswordAgain.ForeColor = Color.FromArgb(59, 93, 79);
            lbNewPasswordAgain.Location = new Point(23, 99);
            lbNewPasswordAgain.Name = "lbNewPasswordAgain";
            lbNewPasswordAgain.Size = new Size(130, 20);
            lbNewPasswordAgain.TabIndex = 3;
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
            btnSave.Location = new Point(562, 3);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(123, 29);
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
            btnCancel.Location = new Point(691, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.Size = new Size(123, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // lbNewPasswordWarning
            // 
            lbNewPasswordWarning.AutoSize = true;
            lbNewPasswordWarning.ForeColor = Color.Red;
            lbNewPasswordWarning.Location = new Point(170, 64);
            lbNewPasswordWarning.Name = "lbNewPasswordWarning";
            lbNewPasswordWarning.Size = new Size(70, 20);
            lbNewPasswordWarning.TabIndex = 2;
            lbNewPasswordWarning.Text = "cảnh báo";
            // 
            // lbNewPasswordAgainWarning
            // 
            lbNewPasswordAgainWarning.AutoSize = true;
            lbNewPasswordAgainWarning.ForeColor = Color.Red;
            lbNewPasswordAgainWarning.Location = new Point(170, 131);
            lbNewPasswordAgainWarning.Name = "lbNewPasswordAgainWarning";
            lbNewPasswordAgainWarning.Size = new Size(70, 20);
            lbNewPasswordAgainWarning.TabIndex = 5;
            lbNewPasswordAgainWarning.Text = "cảnh báo";
            // 
            // pnNewPassword
            // 
            pnNewPassword.Controls.Add(pbInvisible_newPW);
            pnNewPassword.Controls.Add(pbInvisible_rePW);
            pnNewPassword.Controls.Add(pbVisible_newPW);
            pnNewPassword.Controls.Add(txtNewPassword);
            pnNewPassword.Controls.Add(pbVisible_rePW);
            pnNewPassword.Controls.Add(lbNewPassword);
            pnNewPassword.Controls.Add(lbNewPasswordAgain);
            pnNewPassword.Controls.Add(lbNewPasswordAgainWarning);
            pnNewPassword.Controls.Add(txtNewPasswordAgain);
            pnNewPassword.Controls.Add(lbNewPasswordWarning);
            pnNewPassword.Location = new Point(0, 75);
            pnNewPassword.Name = "pnNewPassword";
            pnNewPassword.Size = new Size(817, 179);
            pnNewPassword.TabIndex = 2;
            // 
            // pbInvisible_newPW
            // 
            pbInvisible_newPW.Image = (Image)resources.GetObject("pbInvisible_newPW.Image");
            pbInvisible_newPW.Location = new Point(446, 27);
            pbInvisible_newPW.Name = "pbInvisible_newPW";
            pbInvisible_newPW.Size = new Size(58, 20);
            pbInvisible_newPW.SizeMode = PictureBoxSizeMode.Zoom;
            pbInvisible_newPW.TabIndex = 23;
            pbInvisible_newPW.TabStop = false;
            pbInvisible_newPW.Click += pbInvisible_newPW_Click;
            // 
            // pbInvisible_rePW
            // 
            pbInvisible_rePW.Image = (Image)resources.GetObject("pbInvisible_rePW.Image");
            pbInvisible_rePW.Location = new Point(446, 99);
            pbInvisible_rePW.Name = "pbInvisible_rePW";
            pbInvisible_rePW.Size = new Size(58, 20);
            pbInvisible_rePW.SizeMode = PictureBoxSizeMode.Zoom;
            pbInvisible_rePW.TabIndex = 25;
            pbInvisible_rePW.TabStop = false;
            pbInvisible_rePW.Click += pbInvisible_rePW_Click;
            // 
            // pbVisible_newPW
            // 
            pbVisible_newPW.Image = (Image)resources.GetObject("pbVisible_newPW.Image");
            pbVisible_newPW.Location = new Point(446, 27);
            pbVisible_newPW.Name = "pbVisible_newPW";
            pbVisible_newPW.Size = new Size(58, 20);
            pbVisible_newPW.SizeMode = PictureBoxSizeMode.Zoom;
            pbVisible_newPW.TabIndex = 24;
            pbVisible_newPW.TabStop = false;
            pbVisible_newPW.Click += pbVisible_newPW_Click;
            // 
            // pbVisible_rePW
            // 
            pbVisible_rePW.Image = (Image)resources.GetObject("pbVisible_rePW.Image");
            pbVisible_rePW.Location = new Point(446, 97);
            pbVisible_rePW.Name = "pbVisible_rePW";
            pbVisible_rePW.Size = new Size(58, 20);
            pbVisible_rePW.SizeMode = PictureBoxSizeMode.Zoom;
            pbVisible_rePW.TabIndex = 26;
            pbVisible_rePW.TabStop = false;
            pbVisible_rePW.Click += pbVisible_rePW_Click;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.ForeColor = Color.FromArgb(59, 93, 79);
            lbNewPassword.Location = new Point(18, 27);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(100, 20);
            lbNewPassword.TabIndex = 0;
            lbNewPassword.Text = "Mật khẩu mới";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.ForeColor = Color.FromArgb(59, 93, 79);
            txtCode.Location = new Point(174, 37);
            txtCode.MaxLength = 6;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(157, 20);
            txtCode.TabIndex = 1;
            txtCode.TextChanged += txtCode_TextChanged;
            txtCode.KeyPress += txtCode_KeyPress;
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.ForeColor = Color.FromArgb(59, 93, 79);
            lbCode.Location = new Point(23, 37);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(92, 20);
            lbCode.TabIndex = 0;
            lbCode.Text = "Mã xác nhận";
            // 
            // lbCodeWarning
            // 
            lbCodeWarning.AutoSize = true;
            lbCodeWarning.ForeColor = Color.Red;
            lbCodeWarning.Location = new Point(170, 79);
            lbCodeWarning.Name = "lbCodeWarning";
            lbCodeWarning.Size = new Size(70, 20);
            lbCodeWarning.TabIndex = 2;
            lbCodeWarning.Text = "cảnh báo";
            // 
            // pnCode
            // 
            pnCode.Controls.Add(txtCode);
            pnCode.Controls.Add(lbCode);
            pnCode.Controls.Add(lbCodeWarning);
            pnCode.Location = new Point(0, 75);
            pnCode.Name = "pnCode";
            pnCode.Size = new Size(817, 121);
            pnCode.TabIndex = 1;
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
            lbCodeCountdown.Location = new Point(174, 36);
            lbCodeCountdown.Name = "lbCodeCountdown";
            lbCodeCountdown.Size = new Size(83, 20);
            lbCodeCountdown.TabIndex = 4;
            lbCodeCountdown.Text = "countdown";
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnCancel);
            pnButton.Controls.Add(btnSave);
            pnButton.Dock = DockStyle.Bottom;
            pnButton.FlowDirection = FlowDirection.RightToLeft;
            pnButton.Location = new Point(0, 264);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(817, 44);
            pnButton.TabIndex = 3;
            // 
            // pnGmail
            // 
            pnGmail.Controls.Add(txtGmail);
            pnGmail.Controls.Add(lbGmail);
            pnGmail.Controls.Add(lbCodeCountdown);
            pnGmail.Controls.Add(btnSendEmail);
            pnGmail.Dock = DockStyle.Top;
            pnGmail.Location = new Point(0, 0);
            pnGmail.Name = "pnGmail";
            pnGmail.Size = new Size(817, 69);
            pnGmail.TabIndex = 0;
            // 
            // txtGmail
            // 
            txtGmail.BackColor = Color.White;
            txtGmail.BorderStyle = BorderStyle.None;
            txtGmail.ForeColor = Color.FromArgb(59, 93, 79);
            txtGmail.Location = new Point(174, 13);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(368, 20);
            txtGmail.TabIndex = 1;
            txtGmail.TextAlign = HorizontalAlignment.Right;
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.ForeColor = Color.FromArgb(59, 93, 79);
            lbGmail.Location = new Point(22, 13);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(48, 20);
            lbGmail.TabIndex = 0;
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
            btnSendEmail.Location = new Point(562, 12);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSendEmail.Size = new Size(155, 31);
            btnSendEmail.TabIndex = 2;
            btnSendEmail.Text = "Gửi mã xác thực";
            btnSendEmail.Click += btnSendEmail_Click;
            // 
            // frmChangePW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(817, 308);
            Controls.Add(pnGmail);
            Controls.Add(pnButton);
            Controls.Add(pnCode);
            Controls.Add(pnNewPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChangePW";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmChangePW";
            Load += frmChangePW_Load;
            pnNewPassword.ResumeLayout(false);
            pnNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbInvisible_newPW).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInvisible_rePW).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVisible_newPW).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVisible_rePW).EndInit();
            pnCode.ResumeLayout(false);
            pnCode.PerformLayout();
            pnButton.ResumeLayout(false);
            pnGmail.ResumeLayout(false);
            pnGmail.PerformLayout();
            ResumeLayout(false);
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
        private PictureBox pbInvisible_rePW;
        private PictureBox pbVisible_rePW;
        private PictureBox pbInvisible_newPW;
        private PictureBox pbVisible_newPW;
    }
}