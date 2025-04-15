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
            pnMenu = new FlowLayoutPanel();
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
            pnTop = new Panel();
            pbConfig = new PictureBox();
            pbLogout = new PictureBox();
            lbUsername = new ReaLTaiizor.Controls.HeaderLabel();
            pbUser = new PictureBox();
            manageTransistion = new System.Windows.Forms.Timer(components);
            reportTransistion = new System.Windows.Forms.Timer(components);
            pnMDI = new Panel();
            pnMenu.SuspendLayout();
            pnManage.SuspendLayout();
            pnReport.SuspendLayout();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.FromArgb(59, 93, 79);
            btnSale.FlatAppearance.BorderColor = Color.White;
            btnSale.FlatAppearance.BorderSize = 0;
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSale.ForeColor = Color.FromArgb(59, 93, 79);
            btnSale.Image = (Image)resources.GetObject("btnSale.Image");
            btnSale.Location = new Point(0, 0);
            btnSale.Margin = new Padding(0);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(141, 66);
            btnSale.TabIndex = 0;
            btnSale.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            btnSale.MouseHover += btnSale_MouseHover;
            // 
            // pnMenu
            // 
            pnMenu.AutoScroll = true;
            pnMenu.AutoSize = true;
            pnMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnMenu.BackColor = Color.FromArgb(59, 93, 79);
            pnMenu.Controls.Add(btnSale);
            pnMenu.Controls.Add(btnImport);
            pnMenu.Controls.Add(btnAttend);
            pnMenu.Controls.Add(pnManage);
            pnMenu.Controls.Add(pnReport);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.FlowDirection = FlowDirection.TopDown;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(162, 710);
            pnMenu.TabIndex = 17;
            pnMenu.WrapContents = false;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.FromArgb(59, 93, 79);
            btnImport.FlatAppearance.BorderColor = Color.White;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.Image = (Image)resources.GetObject("btnImport.Image");
            btnImport.Location = new Point(0, 66);
            btnImport.Margin = new Padding(0);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(141, 66);
            btnImport.TabIndex = 23;
            btnImport.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            btnImport.MouseHover += btnImport_MouseHover;
            // 
            // btnAttend
            // 
            btnAttend.BackColor = Color.FromArgb(59, 93, 79);
            btnAttend.FlatAppearance.BorderColor = Color.White;
            btnAttend.FlatAppearance.BorderSize = 0;
            btnAttend.FlatStyle = FlatStyle.Flat;
            btnAttend.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttend.ForeColor = SystemColors.ButtonFace;
            btnAttend.Image = (Image)resources.GetObject("btnAttend.Image");
            btnAttend.Location = new Point(0, 132);
            btnAttend.Margin = new Padding(0);
            btnAttend.Name = "btnAttend";
            btnAttend.Size = new Size(141, 66);
            btnAttend.TabIndex = 25;
            btnAttend.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAttend.UseVisualStyleBackColor = false;
            btnAttend.Click += btnAttend_Click;
            btnAttend.MouseHover += btnAttend_MouseHover;
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
            pnManage.Location = new Point(3, 201);
            pnManage.Name = "pnManage";
            pnManage.Size = new Size(138, 461);
            pnManage.TabIndex = 25;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.FromArgb(59, 93, 79);
            btnManage.FlatAppearance.BorderColor = Color.White;
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManage.ForeColor = SystemColors.ButtonFace;
            btnManage.Image = (Image)resources.GetObject("btnManage.Image");
            btnManage.Location = new Point(0, 0);
            btnManage.Margin = new Padding(0);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(138, 66);
            btnManage.TabIndex = 24;
            btnManage.TextImageRelation = TextImageRelation.ImageAboveText;
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            btnManage.MouseHover += btnManage_MouseHover;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(59, 93, 60);
            btnAccount.FlatAppearance.BorderColor = Color.White;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccount.ForeColor = SystemColors.ButtonFace;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.Location = new Point(0, 66);
            btnAccount.Margin = new Padding(0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(138, 66);
            btnAccount.TabIndex = 25;
            btnAccount.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            btnAccount.MouseHover += btnAccount_MouseHover;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(59, 93, 60);
            btnEmployee.FlatAppearance.BorderColor = Color.White;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = SystemColors.ButtonFace;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.Location = new Point(0, 132);
            btnEmployee.Margin = new Padding(0);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(138, 66);
            btnEmployee.TabIndex = 26;
            btnEmployee.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            btnEmployee.MouseHover += btnEmployee_MouseHover;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.FromArgb(59, 93, 60);
            btnSupplier.FlatAppearance.BorderColor = Color.White;
            btnSupplier.FlatAppearance.BorderSize = 0;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplier.ForeColor = SystemColors.ButtonFace;
            btnSupplier.Image = (Image)resources.GetObject("btnSupplier.Image");
            btnSupplier.Location = new Point(0, 198);
            btnSupplier.Margin = new Padding(0);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(138, 66);
            btnSupplier.TabIndex = 27;
            btnSupplier.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSupplier.UseVisualStyleBackColor = false;
            btnSupplier.Click += btnSupplier_Click;
            btnSupplier.MouseHover += btnSupplier_MouseHover;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(59, 93, 60);
            btnCustomer.FlatAppearance.BorderColor = Color.White;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = SystemColors.ButtonFace;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.Location = new Point(0, 264);
            btnCustomer.Margin = new Padding(0);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(138, 66);
            btnCustomer.TabIndex = 28;
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            btnCustomer.MouseHover += btnCustomer_MouseHover;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(59, 93, 60);
            btnProduct.FlatAppearance.BorderColor = Color.White;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = SystemColors.ButtonFace;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.Location = new Point(0, 330);
            btnProduct.Margin = new Padding(0);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(138, 66);
            btnProduct.TabIndex = 29;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            btnProduct.MouseHover += btnProduct_MouseHover;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.FromArgb(59, 93, 60);
            btnCategory.FlatAppearance.BorderColor = Color.White;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.ForeColor = SystemColors.ButtonFace;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.Location = new Point(0, 396);
            btnCategory.Margin = new Padding(0);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(138, 66);
            btnCategory.TabIndex = 30;
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            btnCategory.MouseHover += btnCategory_MouseHover;
            // 
            // pnReport
            // 
            pnReport.Controls.Add(btnReport);
            pnReport.Controls.Add(btnFinancialReport);
            pnReport.Controls.Add(btnSalary);
            pnReport.Controls.Add(btnInvoice);
            pnReport.Location = new Point(3, 668);
            pnReport.Name = "pnReport";
            pnReport.Size = new Size(156, 258);
            pnReport.TabIndex = 32;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(59, 93, 79);
            btnReport.FlatAppearance.BorderColor = Color.White;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = SystemColors.ButtonFace;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.Location = new Point(0, 0);
            btnReport.Margin = new Padding(0);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(138, 66);
            btnReport.TabIndex = 31;
            btnReport.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            btnReport.MouseHover += btnReport_MouseHover;
            // 
            // btnFinancialReport
            // 
            btnFinancialReport.BackColor = Color.FromArgb(59, 93, 60);
            btnFinancialReport.FlatAppearance.BorderColor = Color.White;
            btnFinancialReport.FlatAppearance.BorderSize = 0;
            btnFinancialReport.FlatStyle = FlatStyle.Flat;
            btnFinancialReport.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinancialReport.ForeColor = SystemColors.ButtonFace;
            btnFinancialReport.Image = (Image)resources.GetObject("btnFinancialReport.Image");
            btnFinancialReport.Location = new Point(0, 66);
            btnFinancialReport.Margin = new Padding(0);
            btnFinancialReport.Name = "btnFinancialReport";
            btnFinancialReport.Size = new Size(138, 66);
            btnFinancialReport.TabIndex = 32;
            btnFinancialReport.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFinancialReport.UseVisualStyleBackColor = false;
            btnFinancialReport.Click += btnFinancialReport_Click;
            btnFinancialReport.MouseHover += btnFinancialReport_MouseHover;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.FromArgb(59, 93, 60);
            btnSalary.FlatAppearance.BorderColor = Color.White;
            btnSalary.FlatAppearance.BorderSize = 0;
            btnSalary.FlatStyle = FlatStyle.Flat;
            btnSalary.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalary.ForeColor = SystemColors.ButtonFace;
            btnSalary.Image = (Image)resources.GetObject("btnSalary.Image");
            btnSalary.Location = new Point(0, 132);
            btnSalary.Margin = new Padding(0);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(138, 66);
            btnSalary.TabIndex = 33;
            btnSalary.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            btnSalary.MouseHover += btnSalary_MouseHover;
            // 
            // btnInvoice
            // 
            btnInvoice.BackColor = Color.FromArgb(59, 93, 60);
            btnInvoice.FlatAppearance.BorderColor = Color.White;
            btnInvoice.FlatAppearance.BorderSize = 0;
            btnInvoice.FlatStyle = FlatStyle.Flat;
            btnInvoice.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvoice.ForeColor = SystemColors.ButtonFace;
            btnInvoice.Image = (Image)resources.GetObject("btnInvoice.Image");
            btnInvoice.Location = new Point(0, 198);
            btnInvoice.Margin = new Padding(0);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(138, 66);
            btnInvoice.TabIndex = 34;
            btnInvoice.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnInvoice_Click;
            btnInvoice.MouseHover += btnInvoice_MouseHover;
            // 
            // pnTop
            // 
            pnTop.Controls.Add(pbConfig);
            pnTop.Controls.Add(pbLogout);
            pnTop.Controls.Add(lbUsername);
            pnTop.Controls.Add(pbUser);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(162, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1217, 59);
            pnTop.TabIndex = 26;
            // 
            // pbConfig
            // 
            pbConfig.BackColor = Color.Transparent;
            pbConfig.BackgroundImageLayout = ImageLayout.Zoom;
            pbConfig.Dock = DockStyle.Right;
            pbConfig.Image = (Image)resources.GetObject("pbConfig.Image");
            pbConfig.Location = new Point(1092, 0);
            pbConfig.Margin = new Padding(3, 3, 300, 3);
            pbConfig.Name = "pbConfig";
            pbConfig.Size = new Size(80, 59);
            pbConfig.TabIndex = 24;
            pbConfig.TabStop = false;
            pbConfig.Click += pbConfig_Click;
            // 
            // pbLogout
            // 
            pbLogout.BackColor = Color.Transparent;
            pbLogout.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogout.Dock = DockStyle.Right;
            pbLogout.Image = (Image)resources.GetObject("pbLogout.Image");
            pbLogout.Location = new Point(1172, 0);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(45, 59);
            pbLogout.TabIndex = 23;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = SystemColors.Control;
            lbUsername.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lbUsername.ForeColor = Color.Black;
            lbUsername.Location = new Point(51, 35);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(105, 24);
            lbUsername.TabIndex = 22;
            lbUsername.Text = "Username";
            lbUsername.TextAlign = ContentAlignment.TopRight;
            // 
            // pbUser
            // 
            pbUser.BackColor = Color.Transparent;
            pbUser.BackgroundImageLayout = ImageLayout.Zoom;
            pbUser.Dock = DockStyle.Left;
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(0, 0);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(45, 59);
            pbUser.TabIndex = 16;
            pbUser.TabStop = false;
            pbUser.Click += pbUser_Click;
            // 
            // manageTransistion
            // 
            manageTransistion.Interval = 10;
            manageTransistion.Tick += manageTransistion_Tick;
            // 
            // reportTransistion
            // 
            reportTransistion.Interval = 10;
            reportTransistion.Tick += reportTransistion_Tick;
            // 
            // pnMDI
            // 
            pnMDI.Dock = DockStyle.Fill;
            pnMDI.Location = new Point(162, 59);
            pnMDI.Name = "pnMDI";
            pnMDI.Size = new Size(1217, 651);
            pnMDI.TabIndex = 27;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1379, 710);
            Controls.Add(pnMDI);
            Controls.Add(pnTop);
            Controls.Add(pnMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán hàng";
            Load += frmMain_Load;
            pnMenu.ResumeLayout(false);
            pnManage.ResumeLayout(false);
            pnReport.ResumeLayout(false);
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSale;
        private FlowLayoutPanel pnMenu;
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
        private ReaLTaiizor.Controls.HeaderLabel lbUsername;
        private Button btnReport;
        private FlowLayoutPanel pnReport;
        private Button btnFinancialReport;
        private Button btnSalary;
        private Button btnInvoice;
        private System.Windows.Forms.Timer reportTransistion;
        private Panel pnMDI;
        private PictureBox pbLogout;
        private PictureBox pbUser;
        private PictureBox pbConfig;
    }
}
