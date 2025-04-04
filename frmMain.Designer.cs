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
            label1 = new Label();
            label2 = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // btnSale
            // 
            btnSale.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSale.Location = new Point(47, 111);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(270, 95);
            btnSale.TabIndex = 0;
            btnSale.Text = "Bán hàng";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(379, 111);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(270, 95);
            btnImport.TabIndex = 1;
            btnImport.Text = "Nhập hàng";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.Location = new Point(47, 236);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(270, 67);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Danh mục";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnIncome
            // 
            btnIncome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncome.Location = new Point(379, 236);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(270, 67);
            btnIncome.TabIndex = 3;
            btnIncome.Text = "Thu chi";
            btnIncome.UseVisualStyleBackColor = true;
            // 
            // btnSystem
            // 
            btnSystem.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSystem.Location = new Point(379, 330);
            btnSystem.Name = "btnSystem";
            btnSystem.Size = new Size(270, 67);
            btnSystem.TabIndex = 5;
            btnSystem.Text = "Hệ thống";
            btnSystem.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.Location = new Point(47, 330);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(270, 67);
            btnReport.TabIndex = 4;
            btnReport.Text = "Báo cáo";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // picAvatar
            // 
            picAvatar.BackgroundImageLayout = ImageLayout.None;
            picAvatar.Location = new Point(47, 12);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(48, 48);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 12);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 9;
            label1.Text = "Hello, username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 36);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 10;
            label2.Text = "Authorization";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(574, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(btnLogout);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picAvatar);
            Controls.Add(btnReport);
            Controls.Add(btnSystem);
            Controls.Add(btnIncome);
            Controls.Add(btnCategory);
            Controls.Add(btnImport);
            Controls.Add(btnSale);
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
        private Label label1;
        private Label label2;
        private Button btnLogout;
    }
}
