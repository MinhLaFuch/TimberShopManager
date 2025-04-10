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
            gbAccInfo = new GroupBox();
            nudQuantity = new NumericUpDown();
            nudWarranty = new NumericUpDown();
            lbMonth = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            lbCalUnit = new Label();
            lbQuantity = new Label();
            lbVND = new Label();
            btnAdd = new Button();
            dgvProduct = new DataGridView();
            btnDel = new Button();
            lbDescription = new Label();
            richTextBox1 = new RichTextBox();
            gbAccInfo.SuspendLayout();
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
            // gbAccInfo
            // 
            gbAccInfo.Controls.Add(richTextBox1);
            gbAccInfo.Controls.Add(lbDescription);
            gbAccInfo.Controls.Add(nudQuantity);
            gbAccInfo.Controls.Add(nudWarranty);
            gbAccInfo.Controls.Add(lbMonth);
            gbAccInfo.Controls.Add(btnCancel);
            gbAccInfo.Controls.Add(btnSave);
            gbAccInfo.Controls.Add(lbCalUnit);
            gbAccInfo.Controls.Add(lbQuantity);
            gbAccInfo.Controls.Add(lbVND);
            gbAccInfo.Controls.Add(cbCatagory);
            gbAccInfo.Controls.Add(txtID);
            gbAccInfo.Controls.Add(txtPriceQuotation);
            gbAccInfo.Controls.Add(txtName);
            gbAccInfo.Controls.Add(lbCatagory);
            gbAccInfo.Controls.Add(lbWarranty);
            gbAccInfo.Controls.Add(lbPriceQuotation);
            gbAccInfo.Controls.Add(lbName);
            gbAccInfo.Controls.Add(lbID);
            gbAccInfo.Location = new Point(0, 5);
            gbAccInfo.Name = "gbAccInfo";
            gbAccInfo.Size = new Size(1312, 262);
            gbAccInfo.TabIndex = 6;
            gbAccInfo.TabStop = false;
            gbAccInfo.Text = "Thông tin";
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
            // lbCalUnit
            // 
            lbCalUnit.AutoSize = true;
            lbCalUnit.Location = new Point(328, 211);
            lbCalUnit.Name = "lbCalUnit";
            lbCalUnit.Size = new Size(50, 20);
            lbCalUnit.TabIndex = 15;
            lbCalUnit.Text = "đơn vị";
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
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(653, 38);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(48, 20);
            lbDescription.TabIndex = 21;
            lbDescription.Text = "Mô tả";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(771, 16);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(498, 171);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 631);
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
        private GroupBox gbAccInfo;
        private Button btnAdd;
        private DataGridView dgvProduct;
        private Label lbVND;
        private Label lbQuantity;
        private Label lbCalUnit;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDel;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudWarranty;
        private Label lbMonth;
        private RichTextBox richTextBox1;
        private Label lbDescription;
    }
}