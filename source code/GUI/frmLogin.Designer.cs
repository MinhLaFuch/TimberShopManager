namespace timber_shop_manager
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lbUsername = new Label();
            lbPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUserError = new Label();
            lblPassError = new Label();
            controlBox = new ReaLTaiizor.Controls.NightControlBox();
            lbTitle = new ReaLTaiizor.Controls.BigLabel();
            pnLogin = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            lbFooter = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnForgotPassword = new Button();
            btnConfig = new Button();
            pbInvisible = new PictureBox();
            pbVisible = new PictureBox();
            pnLogin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInvisible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVisible).BeginInit();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.FromArgb(59, 93, 79);
            lbUsername.Location = new Point(389, 188);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(145, 25);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Tên đăng nhập";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.FromArgb(59, 93, 79);
            lbPassword.Location = new Point(389, 268);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(93, 25);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.FromArgb(59, 93, 79);
            txtUsername.Location = new Point(389, 216);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(299, 20);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(59, 93, 79);
            txtPassword.Location = new Point(389, 296);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(299, 20);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(59, 93, 79);
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(421, 368);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(249, 53);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUserError
            // 
            lblUserError.AutoSize = true;
            lblUserError.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblUserError.ForeColor = Color.Red;
            lblUserError.Location = new Point(389, 240);
            lblUserError.Name = "lblUserError";
            lblUserError.RightToLeft = RightToLeft.No;
            lblUserError.Size = new Size(83, 20);
            lblUserError.TabIndex = 2;
            lblUserError.Text = "user error";
            // 
            // lblPassError
            // 
            lblPassError.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblPassError.ForeColor = Color.Red;
            lblPassError.Location = new Point(389, 320);
            lblPassError.Name = "lblPassError";
            lblPassError.RightToLeft = RightToLeft.No;
            lblPassError.Size = new Size(320, 61);
            lblPassError.TabIndex = 5;
            lblPassError.Text = "pass error";
            // 
            // controlBox
            // 
            controlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBox.BackColor = Color.Transparent;
            controlBox.CloseHoverColor = Color.FromArgb(199, 80, 80);
            controlBox.CloseHoverForeColor = Color.White;
            controlBox.DefaultLocation = true;
            controlBox.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            controlBox.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            controlBox.EnableCloseColor = Color.FromArgb(160, 160, 160);
            controlBox.EnableMaximizeButton = true;
            controlBox.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            controlBox.EnableMinimizeButton = true;
            controlBox.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            controlBox.Location = new Point(632, 0);
            controlBox.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            controlBox.MaximizeHoverForeColor = Color.White;
            controlBox.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            controlBox.MinimizeHoverForeColor = Color.White;
            controlBox.Name = "controlBox";
            controlBox.Size = new Size(139, 31);
            controlBox.TabIndex = 9;
            // 
            // lbTitle
            // 
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(-5, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(377, 155);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "CỬA HÀNG ĐỒ GỖ";
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.FromArgb(59, 93, 79);
            pnLogin.Controls.Add(panel1);
            pnLogin.Controls.Add(pictureBox1);
            pnLogin.Controls.Add(lbTitle);
            pnLogin.Dock = DockStyle.Left;
            pnLogin.Location = new Point(0, 0);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(379, 516);
            pnLogin.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbFooter);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 439);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 77);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 52);
            label3.Name = "label3";
            label3.Size = new Size(294, 20);
            label3.TabIndex = 1;
            label3.Text = "All rights reserved. | Privacy Policy | Contact";
            // 
            // lbFooter
            // 
            lbFooter.AutoSize = true;
            lbFooter.ForeColor = Color.White;
            lbFooter.Location = new Point(7, 31);
            lbFooter.Name = "lbFooter";
            lbFooter.Size = new Size(210, 20);
            lbFooter.TabIndex = 0;
            lbFooter.Text = "© 2025 Timber Shop Manager";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 267);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(379, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(392, 147);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = Color.FromArgb(59, 93, 79);
            btnForgotPassword.Font = new Font("Microsoft Sans Serif", 11F);
            btnForgotPassword.ForeColor = SystemColors.ButtonFace;
            btnForgotPassword.Location = new Point(421, 429);
            btnForgotPassword.Margin = new Padding(3, 4, 3, 4);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(249, 44);
            btnForgotPassword.TabIndex = 7;
            btnForgotPassword.Text = "Quên mật khẩu?";
            btnForgotPassword.UseVisualStyleBackColor = false;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // btnConfig
            // 
            btnConfig.AutoSize = true;
            btnConfig.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfig.BackColor = Color.Transparent;
            btnConfig.Font = new Font("Microsoft Sans Serif", 12F);
            btnConfig.ForeColor = SystemColors.ButtonFace;
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.Location = new Point(715, 460);
            btnConfig.Margin = new Padding(3, 4, 3, 4);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(56, 56);
            btnConfig.TabIndex = 8;
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // pbInvisible
            // 
            pbInvisible.Image = (Image)resources.GetObject("pbInvisible.Image");
            pbInvisible.Location = new Point(694, 296);
            pbInvisible.Name = "pbInvisible";
            pbInvisible.Size = new Size(58, 20);
            pbInvisible.SizeMode = PictureBoxSizeMode.Zoom;
            pbInvisible.TabIndex = 19;
            pbInvisible.TabStop = false;
            pbInvisible.Click += pbInvisible_Click;
            // 
            // pbVisible
            // 
            pbVisible.Image = (Image)resources.GetObject("pbVisible.Image");
            pbVisible.Location = new Point(694, 296);
            pbVisible.Name = "pbVisible";
            pbVisible.Size = new Size(58, 20);
            pbVisible.SizeMode = PictureBoxSizeMode.Zoom;
            pbVisible.TabIndex = 20;
            pbVisible.TabStop = false;
            pbVisible.Click += pbVisible_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(773, 516);
            Controls.Add(pbVisible);
            Controls.Add(pbInvisible);
            Controls.Add(btnConfig);
            Controls.Add(btnForgotPassword);
            Controls.Add(pictureBox2);
            Controls.Add(pnLogin);
            Controls.Add(controlBox);
            Controls.Add(lblUserError);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(lblPassError);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += frmLogin_FormClosing;
            Load += frmLogin_Load;
            pnLogin.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInvisible).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVisible).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PbInvisible_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUserError;
        private Label lblPassError;
        private ReaLTaiizor.Controls.NightControlBox controlBox;
        private ReaLTaiizor.Controls.BigLabel lbTitle;
        private Panel pnLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lbFooter;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnForgotPassword;
        private Button btnConfig;
        private PictureBox pbInvisible;
        private PictureBox pbVisible;
    }
}