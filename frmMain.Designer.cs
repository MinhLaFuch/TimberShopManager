namespace timber_shop_manager
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSale = new Button();
            btnImport = new Button();
            btnCategory = new Button();
            btnIncome = new Button();
            btnSystem = new Button();
            btnReport = new Button();
            picAvatar = new PictureBox();
            lblUsername = new Label();
            lblRole = new Label();
            btnLogout = new Button();
            btnAttend = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // btnSale
            // 
            btnSale.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSale.Location = new Point(54, 148);
            btnSale.Margin = new Padding(3, 4, 3, 4);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(309, 127);
            btnSale.TabIndex = 0;
            btnSale.Text = "Bán hàng";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(433, 148);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(309, 127);
            btnImport.TabIndex = 1;
            btnImport.Text = "Nhập hàng";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.Location = new Point(54, 315);
            btnCategory.Margin = new Padding(3, 4, 3, 4);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(309, 89);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Danh mục";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnIncome
            // 
            btnIncome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncome.Location = new Point(433, 315);
            btnIncome.Margin = new Padding(3, 4, 3, 4);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(309, 89);
            btnIncome.TabIndex = 3;
            btnIncome.Text = "Thu chi";
            btnIncome.UseVisualStyleBackColor = true;
            // 
            // btnSystem
            // 
            btnSystem.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSystem.Location = new Point(433, 440);
            btnSystem.Margin = new Padding(3, 4, 3, 4);
            btnSystem.Name = "btnSystem";
            btnSystem.Size = new Size(309, 89);
            btnSystem.TabIndex = 5;
            btnSystem.Text = "Hệ thống";
            btnSystem.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.Location = new Point(54, 440);
            btnReport.Margin = new Padding(3, 4, 3, 4);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(309, 89);
            btnReport.TabIndex = 4;
            btnReport.Text = "Báo cáo";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // picAvatar
            // 
            picAvatar.BackgroundImageLayout = ImageLayout.None;
            picAvatar.Location = new Point(54, 16);
            picAvatar.Margin = new Padding(3, 4, 3, 4);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(55, 64);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(115, 16);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(120, 20);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Hello, username";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(115, 48);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(99, 20);
            lblRole.TabIndex = 10;
            lblRole.Text = "Authorization";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(656, 16);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 31);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAttend
            // 
            btnAttend.Location = new Point(442, 559);
            btnAttend.Name = "btnAttend";
            btnAttend.Size = new Size(94, 29);
            btnAttend.TabIndex = 12;
            btnAttend.Text = "Chấm công";
            btnAttend.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 600);
            Controls.Add(btnAttend);
            Controls.Add(btnLogout);
            Controls.Add(lblRole);
            Controls.Add(lblUsername);
            Controls.Add(picAvatar);
            Controls.Add(btnReport);
            Controls.Add(btnSystem);
            Controls.Add(btnIncome);
            Controls.Add(btnCategory);
            Controls.Add(btnImport);
            Controls.Add(btnSale);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán hàng";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSale;
        private Button btnImport;
        private Button btnCategory;
        private Button btnIncome;
        private Button btnSystem;
        private Button btnReport;
        private PictureBox picAvatar;
        private Label lblUsername;
        private Label lblRole;
        private Button btnLogout;
        private Button btnAttend;
    }
}
