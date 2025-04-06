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
            picAvatar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(72, 12);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(116, 118);
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 152);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 242);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(14, 170);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(14, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(87, 302);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 377);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picAvatar);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvatar;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}