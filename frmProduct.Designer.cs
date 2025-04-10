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
            btnSearch = new Button();
            cbCatagory = new ComboBox();
            txtID = new TextBox();
            txtPriceQuotation = new TextBox();
            txtWarranty = new TextBox();
            txtName = new TextBox();
            lbCatagory = new Label();
            lbWarranty = new Label();
            lbPriceQuotation = new Label();
            lbName = new Label();
            lbID = new Label();
            gbAccInfo = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            lbCalUnit = new Label();
            lbQuantity = new Label();
            txtQuantity = new TextBox();
            lbVND = new Label();
            btnAdd = new Button();
            dgvProduct = new DataGridView();
            btnDel = new Button();
            gbAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
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
            btnMod.Click += btnMod_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(0, 420);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(204, 95);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbCatagory
            // 
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Location = new Point(705, 114);
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(221, 28);
            cbCatagory.TabIndex = 11;
            // 
            // txtID
            // 
            txtID.Location = new Point(154, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(345, 27);
            txtID.TabIndex = 1;
            // 
            // txtPriceQuotation
            // 
            txtPriceQuotation.Location = new Point(154, 117);
            txtPriceQuotation.Name = "txtPriceQuotation";
            txtPriceQuotation.Size = new Size(273, 27);
            txtPriceQuotation.TabIndex = 5;
            // 
            // txtWarranty
            // 
            txtWarranty.Location = new Point(705, 13);
            txtWarranty.Name = "txtWarranty";
            txtWarranty.Size = new Size(601, 27);
            txtWarranty.TabIndex = 7;
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
            // lbWarranty
            // 
            lbWarranty.AutoSize = true;
            lbWarranty.Location = new Point(568, 16);
            lbWarranty.Name = "lbWarranty";
            lbWarranty.Size = new Size(102, 20);
            lbWarranty.TabIndex = 6;
            lbWarranty.Text = "Hạn bảo hành";
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
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(27, 23);
            lbID.Name = "lbID";
            lbID.Size = new Size(98, 20);
            lbID.TabIndex = 0;
            lbID.Text = "Mã sản phẩm";
            // 
            // gbAccInfo
            // 
            gbAccInfo.Controls.Add(btnCancel);
            gbAccInfo.Controls.Add(btnSave);
            gbAccInfo.Controls.Add(lbCalUnit);
            gbAccInfo.Controls.Add(lbQuantity);
            gbAccInfo.Controls.Add(txtQuantity);
            gbAccInfo.Controls.Add(lbVND);
            gbAccInfo.Controls.Add(cbCatagory);
            gbAccInfo.Controls.Add(txtID);
            gbAccInfo.Controls.Add(txtPriceQuotation);
            gbAccInfo.Controls.Add(txtWarranty);
            gbAccInfo.Controls.Add(txtName);
            gbAccInfo.Controls.Add(lbCatagory);
            gbAccInfo.Controls.Add(lbWarranty);
            gbAccInfo.Controls.Add(lbPriceQuotation);
            gbAccInfo.Controls.Add(lbName);
            gbAccInfo.Controls.Add(lbID);
            gbAccInfo.Location = new Point(0, 5);
            gbAccInfo.Name = "gbAccInfo";
            gbAccInfo.Size = new Size(1312, 155);
            gbAccInfo.TabIndex = 6;
            gbAccInfo.TabStop = false;
            gbAccInfo.Text = "Thông tin";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1189, 115);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1087, 117);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(594, 74);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(69, 20);
            lbQuantity.TabIndex = 14;
            lbQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(705, 69);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(165, 27);
            txtQuantity.TabIndex = 13;
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
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 171);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(204, 58);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm sản phẩm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(210, 171);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1102, 344);
            dgvProduct.TabIndex = 11;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(0, 299);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(204, 55);
            btnDel.TabIndex = 12;
            btnDel.Text = "Xóa sản phẩm";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 529);
            Controls.Add(btnDel);
            Controls.Add(btnMod);
            Controls.Add(btnSearch);
            Controls.Add(gbAccInfo);
            Controls.Add(btnAdd);
            Controls.Add(dgvProduct);
            Name = "frmProduct";
            Text = "Sản phẩm";
            Load += frmProduct_Load;
            gbAccInfo.ResumeLayout(false);
            gbAccInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMod;
        private Button btnSearch;
        private ComboBox cbCatagory;
        private TextBox txtID;
        private TextBox txtPriceQuotation;
        private TextBox txtWarranty;
        private TextBox txtName;
        private Label lbCatagory;
        private Label lbWarranty;
        private Label lbPriceQuotation;
        private Label lbName;
        private Label lbID;
        private GroupBox gbAccInfo;
        private Button btnAdd;
        private DataGridView dgvProduct;
        private Label lbVND;
        private Label lbQuantity;
        private TextBox txtQuantity;
        private Label lbCalUnit;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDel;
    }
}