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
            picAvatar = new PictureBox();
            lblUsername = new Label();
            lblRole = new Label();
            btnLogout = new Button();
            menuStrip = new MenuStrip();
            mnuFunction = new ToolStripMenuItem();
            mnuFunctionSale = new ToolStripMenuItem();
            mnuFunctionImport = new ToolStripMenuItem();
            mnuManage = new ToolStripMenuItem();
            mnuManageSupplier = new ToolStripMenuItem();
            mnuManageProduct = new ToolStripMenuItem();
            mnuManageCustomer = new ToolStripMenuItem();
            mnuManageAccount = new ToolStripMenuItem();
            mnuManageEmployee = new ToolStripMenuItem();
            mnuManageCatagory = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuManageExit = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tàiChínhToolStripMenuItem = new ToolStripMenuItem();
            thốngKếHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            tiềnLươngNhânViênToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            menuStrip.SuspendLayout();
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
            btnImport.Location = new Point(54, 307);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(309, 127);
            btnImport.TabIndex = 1;
            btnImport.Text = "Nhập hàng";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // picAvatar
            // 
            picAvatar.BackgroundImageLayout = ImageLayout.None;
            picAvatar.Location = new Point(54, 55);
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
            lblUsername.Location = new Point(115, 55);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(120, 20);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Hello, username";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(115, 87);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(99, 20);
            lblRole.TabIndex = 10;
            lblRole.Text = "Authorization";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(277, 55);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 31);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuFunction, mnuManage, báoCáoToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(401, 30);
            menuStrip.TabIndex = 13;
            menuStrip.Text = "menuStrip1";
            // 
            // mnuFunction
            // 
            mnuFunction.DropDownItems.AddRange(new ToolStripItem[] { mnuFunctionSale, mnuFunctionImport });
            mnuFunction.Name = "mnuFunction";
            mnuFunction.Size = new Size(93, 24);
            mnuFunction.Text = "Chức năng";
            // 
            // mnuFunctionSale
            // 
            mnuFunctionSale.Name = "mnuFunctionSale";
            mnuFunctionSale.ShortcutKeys = Keys.F1;
            mnuFunctionSale.Size = new Size(189, 26);
            mnuFunctionSale.Text = "Bán hàng";
            // 
            // mnuFunctionImport
            // 
            mnuFunctionImport.Name = "mnuFunctionImport";
            mnuFunctionImport.ShortcutKeys = Keys.F2;
            mnuFunctionImport.Size = new Size(189, 26);
            mnuFunctionImport.Text = "Nhập hàng";
            // 
            // mnuManage
            // 
            mnuManage.DropDownItems.AddRange(new ToolStripItem[] { mnuManageSupplier, mnuManageProduct, mnuManageCustomer, mnuManageAccount, mnuManageEmployee, mnuManageCatagory, toolStripMenuItem1, mnuManageExit });
            mnuManage.Name = "mnuManage";
            mnuManage.Size = new Size(90, 24);
            mnuManage.Text = "Danh mục";
            // 
            // mnuManageSupplier
            // 
            mnuManageSupplier.Name = "mnuManageSupplier";
            mnuManageSupplier.Size = new Size(183, 26);
            mnuManageSupplier.Text = "Nhà cung cấp";
            mnuManageSupplier.Click += mnuManageSupplier_Click;
            // 
            // mnuManageProduct
            // 
            mnuManageProduct.Name = "mnuManageProduct";
            mnuManageProduct.Size = new Size(183, 26);
            mnuManageProduct.Text = "Hàng hóa";
            mnuManageProduct.Click += mnuManageProduct_Click;
            // 
            // mnuManageCustomer
            // 
            mnuManageCustomer.Name = "mnuManageCustomer";
            mnuManageCustomer.Size = new Size(183, 26);
            mnuManageCustomer.Text = "Khách hàng";
            mnuManageCustomer.Click += mnuManageCustomer_Click;
            // 
            // mnuManageAccount
            // 
            mnuManageAccount.Name = "mnuManageAccount";
            mnuManageAccount.Size = new Size(183, 26);
            mnuManageAccount.Text = "Tài khoản";
            mnuManageAccount.Click += mnuManageAccount_Click;
            // 
            // mnuManageEmployee
            // 
            mnuManageEmployee.Name = "mnuManageEmployee";
            mnuManageEmployee.Size = new Size(183, 26);
            mnuManageEmployee.Text = "Nhân viên";
            mnuManageEmployee.Click += mnuManageEmployee_Click;
            // 
            // mnuManageCatagory
            // 
            mnuManageCatagory.Name = "mnuManageCatagory";
            mnuManageCatagory.Size = new Size(183, 26);
            mnuManageCatagory.Text = "Danh mục";
            mnuManageCatagory.Click += mnuManageCatagory_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 6);
            // 
            // mnuManageExit
            // 
            mnuManageExit.Name = "mnuManageExit";
            mnuManageExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuManageExit.Size = new Size(183, 26);
            mnuManageExit.Text = "Thoát";
            mnuManageExit.Click += thoátToolStripMenuItem_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tàiChínhToolStripMenuItem, thốngKếHóaĐơnToolStripMenuItem, tiềnLươngNhânViênToolStripMenuItem });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(77, 24);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tàiChínhToolStripMenuItem
            // 
            tàiChínhToolStripMenuItem.Name = "tàiChínhToolStripMenuItem";
            tàiChínhToolStripMenuItem.Size = new Size(230, 26);
            tàiChínhToolStripMenuItem.Text = "Tài chính";
            tàiChínhToolStripMenuItem.Click += tàiChínhToolStripMenuItem_Click;
            // 
            // thốngKếHóaĐơnToolStripMenuItem
            // 
            thốngKếHóaĐơnToolStripMenuItem.Name = "thốngKếHóaĐơnToolStripMenuItem";
            thốngKếHóaĐơnToolStripMenuItem.Size = new Size(230, 26);
            thốngKếHóaĐơnToolStripMenuItem.Text = "Thống kế hóa đơn";
            thốngKếHóaĐơnToolStripMenuItem.Click += thốngKếHóaĐơnToolStripMenuItem_Click;
            // 
            // tiềnLươngNhânViênToolStripMenuItem
            // 
            tiềnLươngNhânViênToolStripMenuItem.Name = "tiềnLươngNhânViênToolStripMenuItem";
            tiềnLươngNhânViênToolStripMenuItem.Size = new Size(230, 26);
            tiềnLươngNhânViênToolStripMenuItem.Text = "Tiền lương nhân viên";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 600);
            Controls.Add(btnLogout);
            Controls.Add(lblRole);
            Controls.Add(lblUsername);
            Controls.Add(picAvatar);
            Controls.Add(btnImport);
            Controls.Add(btnSale);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán hàng";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSale;
        private Button btnImport;
        private PictureBox picAvatar;
        private Label lblUsername;
        private Label lblRole;
        private Button btnLogout;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuManage;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuManageSupplier;
        private ToolStripMenuItem mnuManageProduct;
        private ToolStripMenuItem mnuManageCustomer;
        private ToolStripMenuItem mnuManageAccount;
        private ToolStripMenuItem mnuManageEmployee;
        private ToolStripMenuItem mnuManageCatagory;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuManageExit;
        private ToolStripMenuItem mnuFunction;
        private ToolStripMenuItem mnuFunctionSale;
        private ToolStripMenuItem mnuFunctionImport;
        private ToolStripMenuItem tàiChínhToolStripMenuItem;
        private ToolStripMenuItem thốngKếHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem tiềnLươngNhânViênToolStripMenuItem;
    }
}
