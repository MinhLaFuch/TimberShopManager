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
            chbWindowAuthetication = new Guna.UI2.WinForms.Guna2CheckBox();
            gbServer = new Guna.UI2.WinForms.Guna2GroupBox();
            pnInfoButton = new FlowLayoutPanel();
            btnCancel = new Button();
            pnInfo = new Panel();
            txtPassword = new TextBox();
            lbUsername = new Label();
            txtUsername = new TextBox();
            lbPassword = new Label();
            btnConnect = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            lbConnectStatus = new Label();
            chbRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            gbServer.SuspendLayout();
            pnInfoButton.SuspendLayout();
            pnInfo.SuspendLayout();
            SuspendLayout();
            // 
            // chbWindowAuthetication
            // 
            chbWindowAuthetication.AutoSize = true;
            chbWindowAuthetication.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chbWindowAuthetication.CheckedState.BorderRadius = 0;
            chbWindowAuthetication.CheckedState.BorderThickness = 0;
            chbWindowAuthetication.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chbWindowAuthetication.ForeColor = Color.FromArgb(59, 93, 79);
            chbWindowAuthetication.Location = new Point(181, 103);
            chbWindowAuthetication.Name = "chbWindowAuthetication";
            chbWindowAuthetication.Size = new Size(179, 24);
            chbWindowAuthetication.TabIndex = 2;
            chbWindowAuthetication.Text = "Window Authetication";
            chbWindowAuthetication.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chbWindowAuthetication.UncheckedState.BorderRadius = 0;
            chbWindowAuthetication.UncheckedState.BorderThickness = 0;
            chbWindowAuthetication.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chbWindowAuthetication.CheckedChanged += chbWindowAuthetication_CheckedChanged;
            // 
            // gbServer
            // 
            gbServer.Controls.Add(lbConnectStatus);
            gbServer.Controls.Add(label1);
            gbServer.Controls.Add(chbWindowAuthetication);
            gbServer.Controls.Add(textBox1);
            gbServer.Controls.Add(pnInfoButton);
            gbServer.Controls.Add(pnInfo);
            gbServer.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbServer.CustomizableEdges = customizableEdges1;
            gbServer.FillColor = SystemColors.Control;
            gbServer.Font = new Font("Segoe UI", 9F);
            gbServer.ForeColor = Color.White;
            gbServer.Location = new Point(12, 12);
            gbServer.Name = "gbServer";
            gbServer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gbServer.Size = new Size(1193, 429);
            gbServer.TabIndex = 12;
            gbServer.Text = "Thông tin máy chủ";
            // 
            // pnInfoButton
            // 
            pnInfoButton.Controls.Add(btnCancel);
            pnInfoButton.Controls.Add(btnConnect);
            pnInfoButton.FlowDirection = FlowDirection.RightToLeft;
            pnInfoButton.Location = new Point(574, 342);
            pnInfoButton.Name = "pnInfoButton";
            pnInfoButton.Size = new Size(388, 55);
            pnInfoButton.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(59, 93, 79);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(253, 4);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnInfo
            // 
            pnInfo.Controls.Add(chbRememberMe);
            pnInfo.Controls.Add(txtPassword);
            pnInfo.Controls.Add(lbUsername);
            pnInfo.Controls.Add(txtUsername);
            pnInfo.Controls.Add(lbPassword);
            pnInfo.Location = new Point(181, 155);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(781, 126);
            pnInfo.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(59, 93, 79);
            txtPassword.Location = new Point(140, 61);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(345, 20);
            txtPassword.TabIndex = 3;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.ForeColor = Color.FromArgb(59, 93, 79);
            lbUsername.Location = new Point(13, 15);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(97, 20);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Tên tài khoản";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.FromArgb(59, 93, 79);
            txtUsername.Location = new Point(140, 15);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(345, 20);
            txtUsername.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = Color.FromArgb(59, 93, 79);
            lbPassword.Location = new Point(13, 61);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Mật khẩu";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(59, 93, 79);
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 9F);
            btnConnect.ForeColor = SystemColors.ButtonFace;
            btnConnect.Location = new Point(115, 4);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(132, 40);
            btnConnect.TabIndex = 10;
            btnConnect.Text = "Kết nối";
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(59, 93, 79);
            label1.Location = new Point(181, 57);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên máy chủ";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.FromArgb(59, 93, 79);
            textBox1.Location = new Point(321, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 20);
            textBox1.TabIndex = 5;
            // 
            // lbConnectStatus
            // 
            lbConnectStatus.AutoSize = true;
            lbConnectStatus.ForeColor = Color.FromArgb(59, 93, 79);
            lbConnectStatus.Location = new Point(181, 367);
            lbConnectStatus.Name = "lbConnectStatus";
            lbConnectStatus.Size = new Size(148, 20);
            lbConnectStatus.TabIndex = 18;
            lbConnectStatus.Text = "Kết nối không tồn tại";
            // 
            // chbRememberMe
            // 
            chbRememberMe.AutoSize = true;
            chbRememberMe.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chbRememberMe.CheckedState.BorderRadius = 0;
            chbRememberMe.CheckedState.BorderThickness = 0;
            chbRememberMe.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chbRememberMe.ForeColor = Color.FromArgb(59, 93, 79);
            chbRememberMe.Location = new Point(13, 99);
            chbRememberMe.Name = "chbRememberMe";
            chbRememberMe.Size = new Size(120, 24);
            chbRememberMe.TabIndex = 19;
            chbRememberMe.Text = "Lưu tài khoản";
            chbRememberMe.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chbRememberMe.UncheckedState.BorderRadius = 0;
            chbRememberMe.UncheckedState.BorderThickness = 0;
            chbRememberMe.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(gbServer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConfig";
            Text = "frmConfig";
            gbServer.ResumeLayout(false);
            gbServer.PerformLayout();
            pnInfoButton.ResumeLayout(false);
            pnInfo.ResumeLayout(false);
            pnInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox chbWindowAuthetication;
        private Guna.UI2.WinForms.Guna2GroupBox gbServer;
        private Label label1;
        private TextBox textBox1;
        private FlowLayoutPanel pnInfoButton;
        private Button btnCancel;
        private Button btnConnect;
        private Panel pnInfo;
        private TextBox txtPassword;
        private Label lbUsername;
        private TextBox txtUsername;
        private Label lbPassword;
        private Label lbConnectStatus;
        private Guna.UI2.WinForms.Guna2CheckBox chbRememberMe;
    }
}