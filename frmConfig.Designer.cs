namespace timber_shop_manager
{
    partial class frmConfig
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            chkWindowAuthetication = new Guna.UI2.WinForms.Guna2CheckBox();
            gbServer = new Guna.UI2.WinForms.Guna2GroupBox();
            lbConnectStatus = new Label();
            label1 = new Label();
            txtServer = new TextBox();
            pnInfoButton = new FlowLayoutPanel();
            btnCancel = new Button();
            btnConnect = new Button();
            pnlSQLAuthentication = new Panel();
            chkRememberPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            txtPassword = new TextBox();
            lbUsername = new Label();
            txtUsername = new TextBox();
            lbPassword = new Label();
            gbServer.SuspendLayout();
            pnInfoButton.SuspendLayout();
            pnlSQLAuthentication.SuspendLayout();
            SuspendLayout();
            // 
            // chkWindowAuthetication
            // 
            chkWindowAuthetication.AutoSize = true;
            chkWindowAuthetication.Checked = true;
            chkWindowAuthetication.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkWindowAuthetication.CheckedState.BorderRadius = 0;
            chkWindowAuthetication.CheckedState.BorderThickness = 0;
            chkWindowAuthetication.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkWindowAuthetication.CheckState = CheckState.Checked;
            chkWindowAuthetication.ForeColor = Color.FromArgb(59, 93, 79);
            chkWindowAuthetication.Location = new Point(134, 83);
            chkWindowAuthetication.Margin = new Padding(3, 2, 3, 2);
            chkWindowAuthetication.Name = "chkWindowAuthetication";
            chkWindowAuthetication.Size = new Size(145, 19);
            chkWindowAuthetication.TabIndex = 2;
            chkWindowAuthetication.Text = "Window Authetication";
            chkWindowAuthetication.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkWindowAuthetication.UncheckedState.BorderRadius = 0;
            chkWindowAuthetication.UncheckedState.BorderThickness = 0;
            chkWindowAuthetication.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chkWindowAuthetication.CheckedChanged += chbWindowAuthetication_CheckedChanged;
            // 
            // gbServer
            // 
            gbServer.Controls.Add(lbConnectStatus);
            gbServer.Controls.Add(label1);
            gbServer.Controls.Add(chkWindowAuthetication);
            gbServer.Controls.Add(txtServer);
            gbServer.Controls.Add(pnInfoButton);
            gbServer.Controls.Add(pnlSQLAuthentication);
            gbServer.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbServer.CustomizableEdges = customizableEdges1;
            gbServer.FillColor = SystemColors.Control;
            gbServer.Font = new Font("Segoe UI", 9F);
            gbServer.ForeColor = Color.White;
            gbServer.Location = new Point(12, 9);
            gbServer.Margin = new Padding(3, 2, 3, 2);
            gbServer.Name = "gbServer";
            gbServer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gbServer.Size = new Size(463, 278);
            gbServer.TabIndex = 12;
            gbServer.Text = "Thông tin máy chủ";
            // 
            // lbConnectStatus
            // 
            lbConnectStatus.AutoSize = true;
            lbConnectStatus.ForeColor = Color.Red;
            lbConnectStatus.Location = new Point(12, 242);
            lbConnectStatus.Name = "lbConnectStatus";
            lbConnectStatus.Size = new Size(118, 15);
            lbConnectStatus.TabIndex = 18;
            lbConnectStatus.Text = "Kết nối không tồn tại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(59, 93, 79);
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 4;
            label1.Text = "Tên máy chủ";
            // 
            // txtServer
            // 
            txtServer.BackColor = SystemColors.InactiveCaption;
            txtServer.BorderStyle = BorderStyle.None;
            txtServer.ForeColor = Color.FromArgb(59, 93, 79);
            txtServer.Location = new Point(135, 53);
            txtServer.Margin = new Padding(3, 2, 3, 2);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(302, 16);
            txtServer.TabIndex = 5;
            // 
            // pnInfoButton
            // 
            pnInfoButton.Controls.Add(btnCancel);
            pnInfoButton.Controls.Add(btnConnect);
            pnInfoButton.FlowDirection = FlowDirection.RightToLeft;
            pnInfoButton.Location = new Point(207, 224);
            pnInfoButton.Margin = new Padding(3, 2, 3, 2);
            pnInfoButton.Name = "pnInfoButton";
            pnInfoButton.Size = new Size(244, 41);
            pnInfoButton.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(59, 93, 79);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(125, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(59, 93, 79);
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 9F);
            btnConnect.ForeColor = SystemColors.ButtonFace;
            btnConnect.Location = new Point(3, 3);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(116, 30);
            btnConnect.TabIndex = 10;
            btnConnect.Text = "Kết nối";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // pnlSQLAuthentication
            // 
            pnlSQLAuthentication.Controls.Add(chkRememberPassword);
            pnlSQLAuthentication.Controls.Add(txtPassword);
            pnlSQLAuthentication.Controls.Add(lbUsername);
            pnlSQLAuthentication.Controls.Add(txtUsername);
            pnlSQLAuthentication.Controls.Add(lbPassword);
            pnlSQLAuthentication.Location = new Point(38, 106);
            pnlSQLAuthentication.Margin = new Padding(3, 2, 3, 2);
            pnlSQLAuthentication.Name = "pnlSQLAuthentication";
            pnlSQLAuthentication.Size = new Size(413, 94);
            pnlSQLAuthentication.TabIndex = 17;
            // 
            // chkRememberPassword
            // 
            chkRememberPassword.AutoSize = true;
            chkRememberPassword.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkRememberPassword.CheckedState.BorderRadius = 0;
            chkRememberPassword.CheckedState.BorderThickness = 0;
            chkRememberPassword.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkRememberPassword.ForeColor = Color.FromArgb(59, 93, 79);
            chkRememberPassword.Location = new Point(98, 73);
            chkRememberPassword.Margin = new Padding(3, 2, 3, 2);
            chkRememberPassword.Name = "chkRememberPassword";
            chkRememberPassword.Size = new Size(99, 19);
            chkRememberPassword.TabIndex = 19;
            chkRememberPassword.Text = "Lưu mật khẩu";
            chkRememberPassword.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkRememberPassword.UncheckedState.BorderRadius = 0;
            chkRememberPassword.UncheckedState.BorderThickness = 0;
            chkRememberPassword.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ActiveCaption;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(59, 93, 79);
            txtPassword.Location = new Point(98, 46);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(302, 16);
            txtPassword.TabIndex = 3;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.ForeColor = Color.FromArgb(59, 93, 79);
            lbUsername.Location = new Point(9, 11);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(77, 15);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Tên tài khoản";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ActiveCaption;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.FromArgb(59, 93, 79);
            txtUsername.Location = new Point(98, 11);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(302, 16);
            txtUsername.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = Color.FromArgb(59, 93, 79);
            lbPassword.Location = new Point(9, 46);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Mật khẩu";
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 301);
            Controls.Add(gbServer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConfig";
            Load += frmConfig_Load;
            gbServer.ResumeLayout(false);
            gbServer.PerformLayout();
            pnInfoButton.ResumeLayout(false);
            pnlSQLAuthentication.ResumeLayout(false);
            pnlSQLAuthentication.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox chkWindowAuthetication;
        private Guna.UI2.WinForms.Guna2GroupBox gbServer;
        private Label label1;
        private TextBox txtServer;
        private FlowLayoutPanel pnInfoButton;
        private Button btnCancel;
        private Button btnConnect;
        private Panel pnlSQLAuthentication;
        private TextBox txtPassword;
        private Label lbUsername;
        private TextBox txtUsername;
        private Label lbPassword;
        private Label lbConnectStatus;
        private Guna.UI2.WinForms.Guna2CheckBox chkRememberPassword;
    }
}