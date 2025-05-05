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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            chkWindowAuthetication = new Guna.UI2.WinForms.Guna2CheckBox();
            gbServer = new Guna.UI2.WinForms.Guna2GroupBox();
            txtDatbaseName = new TextBox();
            label2 = new Label();
            lblConnectStatus = new Label();
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
            chkWindowAuthetication.Location = new Point(152, 136);
            chkWindowAuthetication.Name = "chkWindowAuthetication";
            chkWindowAuthetication.Size = new Size(179, 24);
            chkWindowAuthetication.TabIndex = 4;
            chkWindowAuthetication.Text = "Window Authetication";
            chkWindowAuthetication.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkWindowAuthetication.UncheckedState.BorderRadius = 0;
            chkWindowAuthetication.UncheckedState.BorderThickness = 0;
            chkWindowAuthetication.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chkWindowAuthetication.CheckedChanged += chbWindowAuthetication_CheckedChanged;
            // 
            // gbServer
            // 
            gbServer.Controls.Add(txtDatbaseName);
            gbServer.Controls.Add(label2);
            gbServer.Controls.Add(lblConnectStatus);
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
            gbServer.Location = new Point(14, 12);
            gbServer.Name = "gbServer";
            gbServer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gbServer.Size = new Size(529, 391);
            gbServer.TabIndex = 0;
            gbServer.Text = "Thông tin máy chủ";
            // 
            // txtDatbaseName
            // 
            txtDatbaseName.BorderStyle = BorderStyle.None;
            txtDatbaseName.ForeColor = Color.FromArgb(59, 93, 79);
            txtDatbaseName.Location = new Point(154, 105);
            txtDatbaseName.Name = "txtDatbaseName";
            txtDatbaseName.Size = new Size(345, 20);
            txtDatbaseName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(59, 93, 79);
            label2.Location = new Point(40, 107);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Database";
            // 
            // lblConnectStatus
            // 
            lblConnectStatus.AutoSize = true;
            lblConnectStatus.ForeColor = Color.Red;
            lblConnectStatus.Location = new Point(40, 332);
            lblConnectStatus.Name = "lblConnectStatus";
            lblConnectStatus.Size = new Size(148, 20);
            lblConnectStatus.TabIndex = 6;
            lblConnectStatus.Text = "Kết nối không tồn tại";
            lblConnectStatus.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(59, 93, 79);
            label1.Location = new Point(40, 72);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên máy chủ";
            // 
            // txtServer
            // 
            txtServer.BorderStyle = BorderStyle.None;
            txtServer.ForeColor = Color.FromArgb(59, 93, 79);
            txtServer.Location = new Point(154, 71);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(345, 20);
            txtServer.TabIndex = 1;
            // 
            // pnInfoButton
            // 
            pnInfoButton.Controls.Add(btnCancel);
            pnInfoButton.Controls.Add(btnConnect);
            pnInfoButton.FlowDirection = FlowDirection.RightToLeft;
            pnInfoButton.Location = new Point(237, 317);
            pnInfoButton.Name = "pnInfoButton";
            pnInfoButton.Size = new Size(279, 55);
            pnInfoButton.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(59, 93, 79);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(143, 4);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(59, 93, 79);
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 9F);
            btnConnect.ForeColor = SystemColors.ButtonFace;
            btnConnect.Location = new Point(4, 4);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(133, 40);
            btnConnect.TabIndex = 0;
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
            pnlSQLAuthentication.Location = new Point(40, 167);
            pnlSQLAuthentication.Name = "pnlSQLAuthentication";
            pnlSQLAuthentication.Size = new Size(472, 125);
            pnlSQLAuthentication.TabIndex = 5;
            // 
            // chkRememberPassword
            // 
            chkRememberPassword.AutoSize = true;
            chkRememberPassword.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkRememberPassword.CheckedState.BorderRadius = 0;
            chkRememberPassword.CheckedState.BorderThickness = 0;
            chkRememberPassword.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkRememberPassword.ForeColor = Color.FromArgb(59, 93, 79);
            chkRememberPassword.Location = new Point(112, 97);
            chkRememberPassword.Name = "chkRememberPassword";
            chkRememberPassword.Size = new Size(120, 24);
            chkRememberPassword.TabIndex = 4;
            chkRememberPassword.Text = "Lưu mật khẩu";
            chkRememberPassword.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkRememberPassword.UncheckedState.BorderRadius = 0;
            chkRememberPassword.UncheckedState.BorderThickness = 0;
            chkRememberPassword.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(59, 93, 79);
            txtPassword.Location = new Point(112, 61);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(345, 20);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.ForeColor = Color.FromArgb(59, 93, 79);
            lbUsername.Location = new Point(10, 15);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(97, 20);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Tên tài khoản";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.FromArgb(59, 93, 79);
            txtUsername.Location = new Point(112, 15);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(345, 20);
            txtUsername.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = Color.FromArgb(59, 93, 79);
            lbPassword.Location = new Point(10, 61);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Mật khẩu";
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 421);
            Controls.Add(gbServer);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label lblConnectStatus;
        private Guna.UI2.WinForms.Guna2CheckBox chkRememberPassword;
        private TextBox txtDatbaseName;
        private Label label2;
    }
}