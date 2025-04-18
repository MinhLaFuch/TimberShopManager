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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUserError = new Label();
            lblPassError = new Label();
            controlBox = new ReaLTaiizor.Controls.NightControlBox();
            lbLogin_1 = new ReaLTaiizor.Controls.BigLabel();
            pnLogin = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            lbFooter = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnForgotPassword = new Button();
            btnConfig = new Button();
            pnLogin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(59, 93, 79);
            label1.Location = new Point(340, 141);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(59, 93, 79);
            label2.Location = new Point(340, 201);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.GradientInactiveCaption;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.FromArgb(59, 93, 79);
            txtUsername.Location = new Point(340, 162);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 16);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.GradientInactiveCaption;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(59, 93, 79);
            txtPassword.Location = new Point(340, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 16);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(59, 93, 79);
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(370, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(168, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUserError
            // 
            lblUserError.AutoSize = true;
            lblUserError.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblUserError.ForeColor = Color.Red;
            lblUserError.Location = new Point(340, 180);
            lblUserError.Name = "lblUserError";
            lblUserError.RightToLeft = RightToLeft.No;
            lblUserError.Size = new Size(71, 17);
            lblUserError.TabIndex = 6;
            lblUserError.Text = "user error";
            // 
            // lblPassError
            // 
            lblPassError.AutoSize = true;
            lblPassError.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblPassError.ForeColor = Color.Red;
            lblPassError.Location = new Point(340, 240);
            lblPassError.Name = "lblPassError";
            lblPassError.RightToLeft = RightToLeft.No;
            lblPassError.Size = new Size(73, 17);
            lblPassError.TabIndex = 7;
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
            controlBox.Location = new Point(462, 0);
            controlBox.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            controlBox.MaximizeHoverForeColor = Color.White;
            controlBox.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            controlBox.MinimizeHoverForeColor = Color.White;
            controlBox.Name = "controlBox";
            controlBox.Size = new Size(139, 31);
            controlBox.TabIndex = 10;
            // 
            // lbLogin_1
            // 
            lbLogin_1.BackColor = Color.Transparent;
            lbLogin_1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            lbLogin_1.ForeColor = Color.White;
            lbLogin_1.Location = new Point(24, 9);
            lbLogin_1.Name = "lbLogin_1";
            lbLogin_1.Size = new Size(291, 116);
            lbLogin_1.TabIndex = 11;
            lbLogin_1.Text = "CỬA HÀNG ĐỒ GỖ";
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.FromArgb(59, 93, 79);
            pnLogin.Controls.Add(panel1);
            pnLogin.Controls.Add(pictureBox1);
            pnLogin.Controls.Add(lbLogin_1);
            pnLogin.Dock = DockStyle.Left;
            pnLogin.Location = new Point(0, 0);
            pnLogin.Margin = new Padding(3, 2, 3, 2);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(332, 387);
            pnLogin.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbFooter);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 329);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 58);
            panel1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 39);
            label3.Name = "label3";
            label3.Size = new Size(237, 15);
            label3.TabIndex = 1;
            label3.Text = "All rights reserved. | Privacy Policy | Contact";
            // 
            // lbFooter
            // 
            lbFooter.AutoSize = true;
            lbFooter.ForeColor = Color.White;
            lbFooter.Location = new Point(6, 23);
            lbFooter.Name = "lbFooter";
            lbFooter.Size = new Size(165, 15);
            lbFooter.TabIndex = 0;
            lbFooter.Text = "© 2025 Timber Shop Manager";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 125);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 200);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(332, 25);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(255, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = Color.FromArgb(59, 93, 79);
            btnForgotPassword.Font = new Font("Microsoft Sans Serif", 12F);
            btnForgotPassword.ForeColor = SystemColors.ButtonFace;
            btnForgotPassword.Location = new Point(370, 299);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(168, 30);
            btnForgotPassword.TabIndex = 15;
            btnForgotPassword.Text = "Quên mật khẩu?";
            btnForgotPassword.UseVisualStyleBackColor = false;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // btnConfig
            // 
            btnConfig.AutoSize = true;
            btnConfig.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfig.BackColor = Color.FromArgb(59, 93, 79);
            btnConfig.Font = new Font("Microsoft Sans Serif", 12F);
            btnConfig.ForeColor = SystemColors.ButtonFace;
            btnConfig.Location = new Point(508, 352);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(65, 30);
            btnConfig.TabIndex = 16;
            btnConfig.Text = "Config";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(585, 387);
            Controls.Add(btnConfig);
            Controls.Add(btnForgotPassword);
            Controls.Add(pictureBox2);
            Controls.Add(pnLogin);
            Controls.Add(controlBox);
            Controls.Add(lblPassError);
            Controls.Add(lblUserError);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmLogin_Load;
            pnLogin.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUserError;
        private Label lblPassError;
        private ReaLTaiizor.Controls.NightControlBox controlBox;
        private ReaLTaiizor.Controls.BigLabel lbLogin_1;
        private Panel pnLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lbFooter;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnForgotPassword;
        private Button btnConfig;
    }
}