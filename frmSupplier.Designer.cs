namespace timber_shop_manager
{
    partial class frmSupplier
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
            dgvSupplier = new DataGridView();
            btnAdd = new Button();
            btnDel = new Button();
            btnMod = new Button();
            btnSearch = new Button();
            gbInfo = new GroupBox();
            lbID = new Label();
            txtID = new TextBox();
            txtPhoneNumber = new TextBox();
            lbPhoneNumber = new Label();
            btnSave = new Button();
            txtName = new TextBox();
            btnCancel = new Button();
            lbName = new Label();
            lbAddress = new Label();
            txtWebsite = new TextBox();
            txtAddress = new TextBox();
            lbEmail = new Label();
            lbWebsite = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            gbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSupplier
            // 
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(204, 187);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(806, 340);
            dgvSupplier.TabIndex = 0;
            dgvSupplier.CellContentClick += dgvSupplier_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(2, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(197, 55);
            btnAdd.TabIndex = 1;
            btnAdd.Text = " Thêm nhà cung cấp";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(1, 260);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(197, 29);
            btnDel.TabIndex = 2;
            btnDel.Text = "Xóa nhà cung cấp";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(1, 308);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(197, 29);
            btnMod.TabIndex = 3;
            btnMod.Text = "Sửa nhà cung cấp";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(2, 386);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(197, 55);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lbID);
            gbInfo.Controls.Add(txtID);
            gbInfo.Controls.Add(txtPhoneNumber);
            gbInfo.Controls.Add(lbPhoneNumber);
            gbInfo.Controls.Add(btnSave);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(btnCancel);
            gbInfo.Controls.Add(lbName);
            gbInfo.Controls.Add(lbAddress);
            gbInfo.Controls.Add(txtWebsite);
            gbInfo.Controls.Add(txtAddress);
            gbInfo.Controls.Add(lbEmail);
            gbInfo.Controls.Add(lbWebsite);
            gbInfo.Controls.Add(txtEmail);
            gbInfo.Location = new Point(2, 3);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(1008, 189);
            gbInfo.TabIndex = 5;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin nhà cung cấp";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(32, 33);
            lbID.Name = "lbID";
            lbID.Size = new Size(122, 20);
            lbID.TabIndex = 6;
            lbID.Text = "Mã nhà cung cấp";
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 7;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(150, 141);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 19;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(32, 155);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(97, 20);
            lbPhoneNumber.TabIndex = 18;
            lbPhoneNumber.Text = "Số điện thoại";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(828, 158);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(76, 25);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 17;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(910, 158);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 25);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(-1, 91);
            lbName.Name = "lbName";
            lbName.Size = new Size(124, 20);
            lbName.TabIndex = 16;
            lbName.Text = "Tên nhà cung cấp";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(420, 33);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(55, 20);
            lbAddress.TabIndex = 10;
            lbAddress.Text = "Địa chỉ";
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(543, 134);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(125, 27);
            txtWebsite.TabIndex = 15;
            txtWebsite.TextChanged += txtWebsite_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(543, 26);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 11;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(429, 84);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 14;
            lbEmail.Text = "Email";
            // 
            // lbWebsite
            // 
            lbWebsite.AutoSize = true;
            lbWebsite.Location = new Point(420, 141);
            lbWebsite.Name = "lbWebsite";
            lbWebsite.Size = new Size(62, 20);
            lbWebsite.TabIndex = 12;
            lbWebsite.Text = "Website";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(543, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 13;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1012, 522);
            Controls.Add(gbInfo);
            Controls.Add(btnSearch);
            Controls.Add(btnMod);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(dgvSupplier);
            Name = "frmSupplier";
            Text = "frmSupplier";
            Load += frmSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSupplier;
        private Button btnAdd;
        private Button btnDel;
        private Button btnMod;
        private Button btnSearch;
        private GroupBox gbInfo;
        private Label lbID;
        private TextBox txtID;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtAddress;
        private Label lbAddress;
        private TextBox txtEmail;
        private Label lbWebsite;
        private TextBox txtWebsite;
        private Label lbEmail;
        private TextBox txtName;
        private Label lbName;
        private TextBox txtPhoneNumber;
        private Label lbPhoneNumber;
    }
}