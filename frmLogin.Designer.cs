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
            lbLogin_2 = new ReaLTaiizor.Controls.BigLabel();
            pnLogin = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            lbFooter = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnForgotPassword = new Button();
            lbGmail = new Label();
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
            label1.Location = new Point(385, 217);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(59, 93, 79);
            label2.Location = new Point(385, 297);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.MenuBar;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(388, 246);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(266, 20);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.MenuBar;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(388, 326);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(266, 20);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(59, 93, 79);
            btnLogin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(490, 405);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 40);
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
            lblUserError.Location = new Point(385, 270);
            lblUserError.Name = "lblUserError";
            lblUserError.RightToLeft = RightToLeft.No;
            lblUserError.Size = new Size(83, 20);
            lblUserError.TabIndex = 6;
            lblUserError.Text = "user error";
            // 
            // lblPassError
            // 
            lblPassError.AutoSize = true;
            lblPassError.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblPassError.ForeColor = Color.Red;
            lblPassError.Location = new Point(388, 350);
            lblPassError.Name = "lblPassError";
            lblPassError.RightToLeft = RightToLeft.No;
            lblPassError.Size = new Size(86, 20);
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
            controlBox.Location = new Point(661, 0);
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
            lbLogin_1.AutoSize = true;
            lbLogin_1.BackColor = Color.Transparent;
            lbLogin_1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            lbLogin_1.ForeColor = Color.White;
            lbLogin_1.Location = new Point(0, 9);
            lbLogin_1.Name = "lbLogin_1";
            lbLogin_1.Size = new Size(353, 69);
            lbLogin_1.TabIndex = 11;
            lbLogin_1.Text = "CỬA HÀNG";
            // 
            // lbLogin_2
            // 
            lbLogin_2.AutoSize = true;
            lbLogin_2.BackColor = Color.Transparent;
            lbLogin_2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            lbLogin_2.ForeColor = Color.White;
            lbLogin_2.Location = new Point(0, 81);
            lbLogin_2.Name = "lbLogin_2";
            lbLogin_2.Size = new Size(235, 69);
            lbLogin_2.TabIndex = 12;
            lbLogin_2.Text = "ĐỒ GỖ";
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.FromArgb(59, 93, 79);
            pnLogin.Controls.Add(panel1);
            pnLogin.Controls.Add(pictureBox1);
            pnLogin.Controls.Add(lbLogin_2);
            pnLogin.Controls.Add(lbLogin_1);
            pnLogin.Dock = DockStyle.Left;
            pnLogin.Location = new Point(0, 0);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(379, 503);
            pnLogin.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbFooter);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 425);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 78);
            panel1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 58);
            label3.Name = "label3";
            label3.Size = new Size(294, 20);
            label3.TabIndex = 1;
            label3.Text = "All rights reserved. | Privacy Policy | Contact";
            // 
            // lbFooter
            // 
            lbFooter.AutoSize = true;
            lbFooter.Location = new Point(0, 38);
            lbFooter.Name = "lbFooter";
            lbFooter.Size = new Size(210, 20);
            lbFooter.TabIndex = 0;
            lbFooter.Text = "© 2025 Timber Shop Manager";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 266);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(379, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(421, 147);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = Color.FromArgb(59, 93, 79);
            btnForgotPassword.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnForgotPassword.ForeColor = SystemColors.ButtonFace;
            btnForgotPassword.Location = new Point(660, 317);
            btnForgotPassword.Margin = new Padding(3, 4, 3, 4);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(139, 41);
            btnForgotPassword.TabIndex = 15;
            btnForgotPassword.Text = "Quên mật khẩu?";
            btnForgotPassword.UseVisualStyleBackColor = false;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGmail.ForeColor = Color.FromArgb(59, 93, 79);
            lbGmail.Location = new Point(661, 241);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(102, 20);
            lbGmail.TabIndex = 16;
            lbGmail.Text = "@gmail.com";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(801, 503);
            Controls.Add(lbGmail);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmLogin_Load;
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
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
        private ReaLTaiizor.Controls.BigLabel lbLogin_2;
        private Panel pnLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lbFooter;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnForgotPassword;
        private Label lbGmail;
    }
}