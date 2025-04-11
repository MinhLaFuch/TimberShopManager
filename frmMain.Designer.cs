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
            thuChiToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            menuStrip.SuspendLayout();
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
            btnImport.Location = new Point(47, 230);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(270, 95);
            btnImport.TabIndex = 1;
            btnImport.Text = "Nhập hàng";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // picAvatar
            // 
            picAvatar.BackgroundImageLayout = ImageLayout.None;
            picAvatar.Location = new Point(47, 41);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(48, 48);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(101, 41);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(93, 15);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Hello, username";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(101, 65);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(79, 15);
            lblRole.TabIndex = 10;
            lblRole.Text = "Authorization";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(242, 41);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuFunction, mnuManage, thuChiToolStripMenuItem, báoCáoToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(351, 24);
            menuStrip.TabIndex = 13;
            menuStrip.Text = "menuStrip1";
            // 
            // mnuFunction
            // 
            mnuFunction.DropDownItems.AddRange(new ToolStripItem[] { mnuFunctionSale, mnuFunctionImport });
            mnuFunction.Name = "mnuFunction";
            mnuFunction.Size = new Size(77, 20);
            mnuFunction.Text = "Chức năng";
            // 
            // mnuFunctionSale
            // 
            mnuFunctionSale.Name = "mnuFunctionSale";
            mnuFunctionSale.ShortcutKeys = Keys.F1;
            mnuFunctionSale.Size = new Size(180, 22);
            mnuFunctionSale.Text = "Bán hàng";
            // 
            // mnuFunctionImport
            // 
            mnuFunctionImport.Name = "mnuFunctionImport";
            mnuFunctionImport.ShortcutKeys = Keys.F2;
            mnuFunctionImport.Size = new Size(180, 22);
            mnuFunctionImport.Text = "Nhập hàng";
            // 
            // mnuManage
            // 
            mnuManage.DropDownItems.AddRange(new ToolStripItem[] { mnuManageSupplier, mnuManageProduct, mnuManageCustomer, mnuManageAccount, mnuManageEmployee, mnuManageCatagory, toolStripMenuItem1, mnuManageExit });
            mnuManage.Name = "mnuManage";
            mnuManage.Size = new Size(74, 20);
            mnuManage.Text = "Danh mục";
            // 
            // mnuManageSupplier
            // 
            mnuManageSupplier.Name = "mnuManageSupplier";
            mnuManageSupplier.Size = new Size(148, 22);
            mnuManageSupplier.Text = "Nhà cung cấp";
            mnuManageSupplier.Click += mnuManageSupplier_Click;
            // 
            // mnuManageProduct
            // 
            mnuManageProduct.Name = "mnuManageProduct";
            mnuManageProduct.Size = new Size(148, 22);
            mnuManageProduct.Text = "Hàng hóa";
            mnuManageProduct.Click += mnuManageProduct_Click;
            // 
            // mnuManageCustomer
            // 
            mnuManageCustomer.Name = "mnuManageCustomer";
            mnuManageCustomer.Size = new Size(148, 22);
            mnuManageCustomer.Text = "Khách hàng";
            mnuManageCustomer.Click += mnuManageCustomer_Click;
            // 
            // mnuManageAccount
            // 
            mnuManageAccount.Name = "mnuManageAccount";
            mnuManageAccount.Size = new Size(148, 22);
            mnuManageAccount.Text = "Tài khoản";
            mnuManageAccount.Click += mnuManageAccount_Click;
            // 
            // mnuManageEmployee
            // 
            mnuManageEmployee.Name = "mnuManageEmployee";
            mnuManageEmployee.Size = new Size(148, 22);
            mnuManageEmployee.Text = "Nhân viên";
            mnuManageEmployee.Click += mnuManageEmployee_Click;
            // 
            // mnuManageCatagory
            // 
            mnuManageCatagory.Name = "mnuManageCatagory";
            mnuManageCatagory.Size = new Size(148, 22);
            mnuManageCatagory.Text = "Danh mục";
            mnuManageCatagory.Click += mnuManageCatagory_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(145, 6);
            // 
            // mnuManageExit
            // 
            mnuManageExit.Name = "mnuManageExit";
            mnuManageExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuManageExit.Size = new Size(148, 22);
            mnuManageExit.Text = "Thoát";
            mnuManageExit.Click += thoátToolStripMenuItem_Click;
            // 
            // thuChiToolStripMenuItem
            // 
            thuChiToolStripMenuItem.Name = "thuChiToolStripMenuItem";
            thuChiToolStripMenuItem.Size = new Size(59, 20);
            thuChiToolStripMenuItem.Text = "Thu chi";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(61, 20);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 450);
            Controls.Add(btnLogout);
            Controls.Add(lblRole);
            Controls.Add(lblUsername);
            Controls.Add(picAvatar);
            Controls.Add(btnImport);
            Controls.Add(btnSale);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
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
        private ToolStripMenuItem thuChiToolStripMenuItem;
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
    }
}
