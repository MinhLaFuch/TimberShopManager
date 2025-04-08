namespace timber_shop_manager
{
    partial class frmProduct
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
            btnMod = new Button();
            cbSearch = new ComboBox();
            btnSearch = new Button();
            cbRole = new ComboBox();
            txtEmployeeID = new TextBox();
            txtIden = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lbCatagory = new Label();
            lbCustomerWarranty = new Label();
            lbPriceQuotation = new Label();
            lbName = new Label();
            lbProductID = new Label();
            gbAccInfo = new GroupBox();
            btnAdd = new Button();
            dgvAccount = new DataGridView();
            lbVND = new Label();
            textBox1 = new TextBox();
            lbQuantity = new Label();
            lbCalUnit = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            btnDel = new Button();
            gbAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // btnMod
            // 
            btnMod.Location = new Point(0, 235);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(204, 58);
            btnMod.TabIndex = 8;
            btnMod.Text = "Sửa sản phẩm";
            btnMod.UseVisualStyleBackColor = true;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(0, 386);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(200, 28);
            cbSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(0, 420);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(204, 95);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(705, 114);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(221, 28);
            cbRole.TabIndex = 11;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(154, 16);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(345, 27);
            txtEmployeeID.TabIndex = 1;
            // 
            // txtIden
            // 
            txtIden.Location = new Point(154, 117);
            txtIden.Name = "txtIden";
            txtIden.Size = new Size(273, 27);
            txtIden.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(705, 13);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(601, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 27);
            txtName.TabIndex = 3;
            // 
            // lbCatagory
            // 
            lbCatagory.AutoSize = true;
            lbCatagory.Location = new Point(568, 122);
            lbCatagory.Name = "lbCatagory";
            lbCatagory.Size = new Size(105, 20);
            lbCatagory.TabIndex = 10;
            lbCatagory.Text = "Loại sản phẩm";
            // 
            // lbCustomerWarranty
            // 
            lbCustomerWarranty.AutoSize = true;
            lbCustomerWarranty.Location = new Point(568, 16);
            lbCustomerWarranty.Name = "lbCustomerWarranty";
            lbCustomerWarranty.Size = new Size(102, 20);
            lbCustomerWarranty.TabIndex = 6;
            lbCustomerWarranty.Text = "Hạn bảo hành";
            // 
            // lbPriceQuotation
            // 
            lbPriceQuotation.AutoSize = true;
            lbPriceQuotation.Location = new Point(36, 117);
            lbPriceQuotation.Name = "lbPriceQuotation";
            lbPriceQuotation.Size = new Size(62, 20);
            lbPriceQuotation.TabIndex = 4;
            lbPriceQuotation.Text = "Đơn giá";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(27, 72);
            lbName.Name = "lbName";
            lbName.Size = new Size(100, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Tên sản phẩm";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(27, 23);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(98, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "Mã sản phẩm";
            // 
            // gbAccInfo
            // 
            gbAccInfo.Controls.Add(btnCancel);
            gbAccInfo.Controls.Add(btnSave);
            gbAccInfo.Controls.Add(lbCalUnit);
            gbAccInfo.Controls.Add(lbQuantity);
            gbAccInfo.Controls.Add(textBox1);
            gbAccInfo.Controls.Add(lbVND);
            gbAccInfo.Controls.Add(cbRole);
            gbAccInfo.Controls.Add(txtEmployeeID);
            gbAccInfo.Controls.Add(txtIden);
            gbAccInfo.Controls.Add(txtAddress);
            gbAccInfo.Controls.Add(txtName);
            gbAccInfo.Controls.Add(lbCatagory);
            gbAccInfo.Controls.Add(lbCustomerWarranty);
            gbAccInfo.Controls.Add(lbPriceQuotation);
            gbAccInfo.Controls.Add(lbName);
            gbAccInfo.Controls.Add(lbProductID);
            gbAccInfo.Location = new Point(0, 5);
            gbAccInfo.Name = "gbAccInfo";
            gbAccInfo.Size = new Size(1312, 155);
            gbAccInfo.TabIndex = 6;
            gbAccInfo.TabStop = false;
            gbAccInfo.Text = "Thông tin";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 171);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(204, 58);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm sản phẩm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvAccount
            // 
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Location = new Point(210, 171);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(1102, 344);
            dgvAccount.TabIndex = 11;
            // 
            // lbVND
            // 
            lbVND.AutoSize = true;
            lbVND.Location = new Point(455, 122);
            lbVND.Name = "lbVND";
            lbVND.Size = new Size(40, 20);
            lbVND.TabIndex = 12;
            lbVND.Text = "VND";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(705, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 13;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(594, 74);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(69, 20);
            lbQuantity.TabIndex = 14;
            lbQuantity.Text = "Số lượng";
            // 
            // lbCalUnit
            // 
            lbCalUnit.AutoSize = true;
            lbCalUnit.Location = new Point(904, 71);
            lbCalUnit.Name = "lbCalUnit";
            lbCalUnit.Size = new Size(15, 20);
            lbCalUnit.TabIndex = 15;
            lbCalUnit.Text = "_";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1087, 117);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1189, 115);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(0, 299);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(204, 55);
            btnDel.TabIndex = 12;
            btnDel.Text = "Xóa sản phẩm";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 529);
            Controls.Add(btnDel);
            Controls.Add(btnMod);
            Controls.Add(cbSearch);
            Controls.Add(btnSearch);
            Controls.Add(gbAccInfo);
            Controls.Add(btnAdd);
            Controls.Add(dgvAccount);
            Name = "frmProduct";
            Text = "frmProduct";
            gbAccInfo.ResumeLayout(false);
            gbAccInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMod;
        private ComboBox cbSearch;
        private Button btnSearch;
        private ComboBox cbRole;
        private TextBox txtEmployeeID;
        private TextBox txtIden;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label lbCatagory;
        private Label lbCustomerWarranty;
        private Label lbPriceQuotation;
        private Label lbName;
        private Label lbProductID;
        private GroupBox gbAccInfo;
        private Button btnAdd;
        private DataGridView dgvAccount;
        private Label lbVND;
        private Label lbQuantity;
        private TextBox textBox1;
        private Label lbCalUnit;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDel;
    }
}