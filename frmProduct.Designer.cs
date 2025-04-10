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
            txtName = new TextBox();
            lbCatagory = new Label();
            lbWarranty = new Label();
            lbPriceQuotation = new Label();
            lbName = new Label();
            lbID = new Label();
            gbInfo = new GroupBox();
            txtCalUnit = new TextBox();
            txtDescription = new RichTextBox();
            lbDescription = new Label();
            nudQuantity = new NumericUpDown();
            nudWarranty = new NumericUpDown();
            lbMonth = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            lbQuantity = new Label();
            lbVND = new Label();
            btnAdd = new Button();
            dgvProduct = new DataGridView();
            btnDel = new Button();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWarranty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // btnMod
            // 
            btnMod.Location = new Point(0, 384);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(204, 58);
            btnMod.TabIndex = 8;
            btnMod.Text = "Sửa sản phẩm";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(6, 509);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(204, 95);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbCatagory
            // 
            cbCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Location = new Point(154, 126);
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
            txtPriceQuotation.Location = new Point(154, 93);
            txtPriceQuotation.Name = "txtPriceQuotation";
            txtPriceQuotation.Size = new Size(273, 27);
            txtPriceQuotation.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 27);
            txtName.TabIndex = 3;
            // 
            // lbCatagory
            // 
            lbCatagory.AutoSize = true;
            lbCatagory.Location = new Point(0, 126);
            lbCatagory.Name = "lbCatagory";
            lbCatagory.Size = new Size(105, 20);
            lbCatagory.TabIndex = 10;
            lbCatagory.Text = "Loại sản phẩm";
            // 
            // lbWarranty
            // 
            lbWarranty.AutoSize = true;
            lbWarranty.Location = new Point(12, 167);
            lbWarranty.Name = "lbWarranty";
            lbWarranty.Size = new Size(102, 20);
            lbWarranty.TabIndex = 6;
            lbWarranty.Text = "Hạn bảo hành";
            // 
            // lbPriceQuotation
            // 
            lbPriceQuotation.AutoSize = true;
            lbPriceQuotation.Location = new Point(38, 93);
            lbPriceQuotation.Name = "lbPriceQuotation";
            lbPriceQuotation.Size = new Size(62, 20);
            lbPriceQuotation.TabIndex = 4;
            lbPriceQuotation.Text = "Đơn giá";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(25, 56);
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
            // gbInfo
            // 
            gbInfo.Controls.Add(txtCalUnit);
            gbInfo.Controls.Add(txtDescription);
            gbInfo.Controls.Add(lbDescription);
            gbInfo.Controls.Add(nudQuantity);
            gbInfo.Controls.Add(nudWarranty);
            gbInfo.Controls.Add(lbMonth);
            gbInfo.Controls.Add(btnCancel);
            gbInfo.Controls.Add(btnSave);
            gbInfo.Controls.Add(lbQuantity);
            gbInfo.Controls.Add(lbVND);
            gbInfo.Controls.Add(cbCatagory);
            gbInfo.Controls.Add(txtID);
            gbInfo.Controls.Add(txtPriceQuotation);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(lbCatagory);
            gbInfo.Controls.Add(lbWarranty);
            gbInfo.Controls.Add(lbPriceQuotation);
            gbInfo.Controls.Add(lbName);
            gbInfo.Controls.Add(lbID);
            gbInfo.Location = new Point(0, 5);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(1312, 262);
            gbInfo.TabIndex = 6;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin";
            // 
            // txtCalUnit
            // 
            txtCalUnit.Location = new Point(328, 208);
            txtCalUnit.Name = "txtCalUnit";
            txtCalUnit.Size = new Size(125, 27);
            txtCalUnit.TabIndex = 24;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(771, 16);
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            txtDescription.Size = new Size(498, 171);
            txtDescription.TabIndex = 22;
            txtDescription.Text = "";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(653, 38);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(48, 20);
            lbDescription.TabIndex = 21;
            lbDescription.Text = "Mô tả";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(154, 209);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(150, 27);
            nudQuantity.TabIndex = 20;
            // 
            // nudWarranty
            // 
            nudWarranty.Location = new Point(154, 160);
            nudWarranty.Name = "nudWarranty";
            nudWarranty.Size = new Size(150, 27);
            nudWarranty.TabIndex = 19;
            // 
            // lbMonth
            // 
            lbMonth.AutoSize = true;
            lbMonth.Location = new Point(328, 167);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new Size(47, 20);
            lbMonth.TabIndex = 18;
            lbMonth.Text = "tháng";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1195, 220);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1095, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(31, 211);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(69, 20);
            lbQuantity.TabIndex = 14;
            lbQuantity.Text = "Số lượng";
            // 
            // lbVND
            // 
            lbVND.AutoSize = true;
            lbVND.Location = new Point(459, 100);
            lbVND.Name = "lbVND";
            lbVND.Size = new Size(40, 20);
            lbVND.TabIndex = 12;
            lbVND.Text = "VND";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 311);
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
            dgvProduct.Location = new Point(210, 260);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1102, 344);
            dgvProduct.TabIndex = 11;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(6, 448);
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
            ClientSize = new Size(1311, 631);
            Controls.Add(btnDel);
            Controls.Add(btnMod);
            Controls.Add(btnSearch);
            Controls.Add(gbInfo);
            Controls.Add(btnAdd);
            Controls.Add(dgvProduct);
            Name = "frmProduct";
            Text = "Sản phẩm";
            Load += frmProduct_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWarranty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMod;
        private Button btnSearch;
        private ComboBox cbCatagory;
        private TextBox txtID;
        private TextBox txtPriceQuotation;
        private TextBox txtName;
        private Label lbCatagory;
        private Label lbWarranty;
        private Label lbPriceQuotation;
        private Label lbName;
        private Label lbID;
        private GroupBox gbInfo;
        private Button btnAdd;
        private DataGridView dgvProduct;
        private Label lbVND;
        private Label lbQuantity;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDel;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudWarranty;
        private Label lbMonth;
        private RichTextBox txtDescription;
        private Label lbDescription;
        private TextBox txtCalUnit;
    }
}