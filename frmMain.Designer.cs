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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnSale = new Button();
            pbUser = new PictureBox();
            pnMenu = new FlowLayoutPanel();
            pnUser = new Panel();
            pbMenu = new PictureBox();
            btnImport = new Button();
            btnAttend = new Button();
            pnManage = new FlowLayoutPanel();
            btnManage = new Button();
            btnAccount = new Button();
            btnEmployee = new Button();
            btnSupplier = new Button();
            btnCustomer = new Button();
            btnProduct = new Button();
            btnCategory = new Button();
            pnReport = new FlowLayoutPanel();
            btnReport = new Button();
            btnFinancialReport = new Button();
            btnSalary = new Button();
            btnInvoice = new Button();
            pbLogout = new ReaLTaiizor.Controls.HopePictureBox();
            pnTop = new Panel();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            manageTransistion = new System.Windows.Forms.Timer(components);
            menuTransistion = new System.Windows.Forms.Timer(components);
            reportTransistion = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            pnMenu.SuspendLayout();
            pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
            pnManage.SuspendLayout();
            pnReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            pnTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.FromArgb(59, 93, 79);
            btnSale.FlatAppearance.BorderColor = Color.White;
            btnSale.FlatAppearance.BorderSize = 0;
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSale.Image = (Image)resources.GetObject("btnSale.Image");
            btnSale.ImageAlign = ContentAlignment.TopLeft;
            btnSale.Location = new Point(0, 59);
            btnSale.Margin = new Padding(0);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(271, 66);
            btnSale.TabIndex = 0;
            btnSale.Text = "        Bán hàng";
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            // 
            // pbUser
            // 
            pbUser.BackColor = Color.Transparent;
            pbUser.BackgroundImageLayout = ImageLayout.Zoom;
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(1110, 0);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(45, 59);
            pbUser.TabIndex = 16;
            pbUser.TabStop = false;
            pbUser.Click += pbUser_Click;
            // 
            // pnMenu
            // 
            pnMenu.AutoScroll = true;
            pnMenu.AutoSize = true;
            pnMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnMenu.BackColor = Color.FromArgb(59, 93, 79);
            pnMenu.Controls.Add(pnUser);
            pnMenu.Controls.Add(btnSale);
            pnMenu.Controls.Add(btnImport);
            pnMenu.Controls.Add(btnAttend);
            pnMenu.Controls.Add(pnManage);
            pnMenu.Controls.Add(pnReport);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.FlowDirection = FlowDirection.TopDown;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(271, 771);
            pnMenu.TabIndex = 17;
            pnMenu.WrapContents = false;
            // 
            // pnUser
            // 
            pnUser.BackColor = Color.FromArgb(59, 93, 79);
            pnUser.Controls.Add(pbMenu);
            pnUser.Location = new Point(0, 0);
            pnUser.Margin = new Padding(0);
            pnUser.Name = "pnUser";
            pnUser.Size = new Size(271, 59);
            pnUser.TabIndex = 22;
            // 
            // pbMenu
            // 
            pbMenu.Image = (Image)resources.GetObject("pbMenu.Image");
            pbMenu.Location = new Point(0, 0);
            pbMenu.Name = "pbMenu";
            pbMenu.Size = new Size(72, 59);
            pbMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pbMenu.TabIndex = 27;
            pbMenu.TabStop = false;
            pbMenu.Click += pbMenu_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.FromArgb(59, 93, 79);
            btnImport.FlatAppearance.BorderColor = Color.White;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.Image = (Image)resources.GetObject("btnImport.Image");
            btnImport.ImageAlign = ContentAlignment.TopLeft;
            btnImport.Location = new Point(0, 125);
            btnImport.Margin = new Padding(0);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(271, 66);
            btnImport.TabIndex = 23;
            btnImport.Text = "        Nhập hàng";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnAttend
            // 
            btnAttend.BackColor = Color.FromArgb(59, 93, 79);
            btnAttend.FlatAppearance.BorderColor = Color.White;
            btnAttend.FlatAppearance.BorderSize = 0;
            btnAttend.FlatStyle = FlatStyle.Flat;
            btnAttend.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttend.Image = (Image)resources.GetObject("btnAttend.Image");
            btnAttend.ImageAlign = ContentAlignment.TopLeft;
            btnAttend.Location = new Point(0, 191);
            btnAttend.Margin = new Padding(0);
            btnAttend.Name = "btnAttend";
            btnAttend.Size = new Size(271, 66);
            btnAttend.TabIndex = 25;
            btnAttend.Text = "        Chấm công";
            btnAttend.UseVisualStyleBackColor = false;
            // 
            // pnManage
            // 
            pnManage.Controls.Add(btnManage);
            pnManage.Controls.Add(btnAccount);
            pnManage.Controls.Add(btnEmployee);
            pnManage.Controls.Add(btnSupplier);
            pnManage.Controls.Add(btnCustomer);
            pnManage.Controls.Add(btnProduct);
            pnManage.Controls.Add(btnCategory);
            pnManage.Location = new Point(3, 260);
            pnManage.Name = "pnManage";
            pnManage.Size = new Size(247, 461);
            pnManage.TabIndex = 25;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.FromArgb(59, 93, 79);
            btnManage.FlatAppearance.BorderColor = Color.White;
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManage.Image = (Image)resources.GetObject("btnManage.Image");
            btnManage.ImageAlign = ContentAlignment.TopLeft;
            btnManage.Location = new Point(0, 0);
            btnManage.Margin = new Padding(0);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(271, 66);
            btnManage.TabIndex = 24;
            btnManage.Text = "        Quản lý";
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(59, 93, 60);
            btnAccount.FlatAppearance.BorderColor = Color.White;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.ImageAlign = ContentAlignment.TopLeft;
            btnAccount.Location = new Point(0, 66);
            btnAccount.Margin = new Padding(0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(271, 66);
            btnAccount.TabIndex = 25;
            btnAccount.Text = "        Tài khoản";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(59, 93, 60);
            btnEmployee.FlatAppearance.BorderColor = Color.White;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.TopLeft;
            btnEmployee.Location = new Point(0, 132);
            btnEmployee.Margin = new Padding(0);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(271, 66);
            btnEmployee.TabIndex = 26;
            btnEmployee.Text = "        Nhân viên";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.FromArgb(59, 93, 60);
            btnSupplier.FlatAppearance.BorderColor = Color.White;
            btnSupplier.FlatAppearance.BorderSize = 0;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplier.Image = (Image)resources.GetObject("btnSupplier.Image");
            btnSupplier.ImageAlign = ContentAlignment.TopLeft;
            btnSupplier.Location = new Point(0, 198);
            btnSupplier.Margin = new Padding(0);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(271, 66);
            btnSupplier.TabIndex = 27;
            btnSupplier.Text = "        Nhà cung cấp";
            btnSupplier.UseVisualStyleBackColor = false;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(59, 93, 60);
            btnCustomer.FlatAppearance.BorderColor = Color.White;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.TopLeft;
            btnCustomer.Location = new Point(0, 264);
            btnCustomer.Margin = new Padding(0);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(271, 66);
            btnCustomer.TabIndex = 28;
            btnCustomer.Text = "        Khách hàng";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(59, 93, 60);
            btnProduct.FlatAppearance.BorderColor = Color.White;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.TopLeft;
            btnProduct.Location = new Point(0, 330);
            btnProduct.Margin = new Padding(0);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(271, 66);
            btnProduct.TabIndex = 29;
            btnProduct.Text = "        Sản phẩm";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.FromArgb(59, 93, 60);
            btnCategory.FlatAppearance.BorderColor = Color.White;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.TopLeft;
            btnCategory.Location = new Point(0, 396);
            btnCategory.Margin = new Padding(0);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(271, 66);
            btnCategory.TabIndex = 30;
            btnCategory.Text = "        Danh mục";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // pnReport
            // 
            pnReport.Controls.Add(btnReport);
            pnReport.Controls.Add(btnFinancialReport);
            pnReport.Controls.Add(btnSalary);
            pnReport.Controls.Add(btnInvoice);
            pnReport.Location = new Point(3, 727);
            pnReport.Name = "pnReport";
            pnReport.Size = new Size(247, 258);
            pnReport.TabIndex = 32;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(59, 93, 79);
            btnReport.FlatAppearance.BorderColor = Color.White;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.TopLeft;
            btnReport.Location = new Point(0, 0);
            btnReport.Margin = new Padding(0);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(271, 66);
            btnReport.TabIndex = 31;
            btnReport.Text = "        Báo cáo";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnFinancialReport
            // 
            btnFinancialReport.BackColor = Color.FromArgb(59, 93, 60);
            btnFinancialReport.FlatAppearance.BorderColor = Color.White;
            btnFinancialReport.FlatAppearance.BorderSize = 0;
            btnFinancialReport.FlatStyle = FlatStyle.Flat;
            btnFinancialReport.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinancialReport.Image = (Image)resources.GetObject("btnFinancialReport.Image");
            btnFinancialReport.ImageAlign = ContentAlignment.TopLeft;
            btnFinancialReport.Location = new Point(0, 66);
            btnFinancialReport.Margin = new Padding(0);
            btnFinancialReport.Name = "btnFinancialReport";
            btnFinancialReport.Size = new Size(271, 66);
            btnFinancialReport.TabIndex = 32;
            btnFinancialReport.Text = "        Tài chính";
            btnFinancialReport.UseVisualStyleBackColor = false;
            btnFinancialReport.Click += btnFinancialReport_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.FromArgb(59, 93, 60);
            btnSalary.FlatAppearance.BorderColor = Color.White;
            btnSalary.FlatAppearance.BorderSize = 0;
            btnSalary.FlatStyle = FlatStyle.Flat;
            btnSalary.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalary.Image = (Image)resources.GetObject("btnSalary.Image");
            btnSalary.ImageAlign = ContentAlignment.TopLeft;
            btnSalary.Location = new Point(0, 132);
            btnSalary.Margin = new Padding(0);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(271, 66);
            btnSalary.TabIndex = 33;
            btnSalary.Text = "        Tiền lương";
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.BackColor = Color.FromArgb(59, 93, 60);
            btnInvoice.FlatAppearance.BorderColor = Color.White;
            btnInvoice.FlatAppearance.BorderSize = 0;
            btnInvoice.FlatStyle = FlatStyle.Flat;
            btnInvoice.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvoice.Image = (Image)resources.GetObject("btnInvoice.Image");
            btnInvoice.ImageAlign = ContentAlignment.TopLeft;
            btnInvoice.Location = new Point(0, 198);
            btnInvoice.Margin = new Padding(0);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(271, 66);
            btnInvoice.TabIndex = 34;
            btnInvoice.Text = "        Hóa đơn";
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // pbLogout
            // 
            pbLogout.BackColor = Color.FromArgb(192, 196, 204);
            pbLogout.Image = (Image)resources.GetObject("pbLogout.Image");
            pbLogout.Location = new Point(947, 16);
            pbLogout.Name = "pbLogout";
            pbLogout.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pbLogout.Size = new Size(46, 43);
            pbLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogout.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pbLogout.TabIndex = 19;
            pbLogout.TabStop = false;
            pbLogout.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            pbLogout.Click += pbLogout_Click;
            // 
            // pnTop
            // 
            pnTop.Controls.Add(headerLabel1);
            pnTop.Controls.Add(pbLogout);
            pnTop.Controls.Add(pbUser);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(271, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1172, 59);
            pnTop.TabIndex = 26;
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = SystemColors.Control;
            headerLabel1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            headerLabel1.ForeColor = Color.Black;
            headerLabel1.Location = new Point(999, 0);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(105, 24);
            headerLabel1.TabIndex = 22;
            headerLabel1.Text = "Username";
            headerLabel1.TextAlign = ContentAlignment.TopRight;
            // 
            // manageTransistion
            // 
            manageTransistion.Interval = 10;
            manageTransistion.Tick += manageTransistion_Tick;
            // 
            // menuTransistion
            // 
            menuTransistion.Interval = 10;
            menuTransistion.Tick += menuTransistion_Tick;
            // 
            // reportTransistion
            // 
            reportTransistion.Interval = 10;
            reportTransistion.Tick += reportTransistion_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1443, 771);
            Controls.Add(pnTop);
            Controls.Add(pnMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán hàng";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            pnMenu.ResumeLayout(false);
            pnUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMenu).EndInit();
            pnManage.ResumeLayout(false);
            pnReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSale;
        private Label lblUsername;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox;
        private PictureBox pbUser;
        private FlowLayoutPanel pnMenu;
        private Panel pnUser;
        private ReaLTaiizor.Controls.HopePictureBox pbLogout;
        private Button btnImprot;
        private PictureBox pbMenu;
        private Button btnImport;
        private Button btnManage;
        private Button btnAttend;
        private FlowLayoutPanel pnManage;
        private Button btnAccount;
        private Button btnEmployee;
        private Button btnSupplier;
        private Button btnCustomer;
        private Button btnProduct;
        private Button btnCategory;
        private Panel pnTop;
        private System.Windows.Forms.Timer manageTransistion;
        private System.Windows.Forms.Timer menuTransistion;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private Button btnReport;
        private FlowLayoutPanel pnReport;
        private Button btnFinancialReport;
        private Button btnSalary;
        private Button btnInvoice;
        private System.Windows.Forms.Timer reportTransistion;
    }
}
