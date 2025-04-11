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
            txtName = new TextBox();
            lbCatagory = new Label();
            lbWarranty = new Label();
            lbPriceQuotation = new Label();
            lbName = new Label();
            lbID = new Label();
            gbInfo = new GroupBox();
            nudPrice = new NumericUpDown();
            nudQuantity = new NumericUpDown();
            groupBox1 = new GroupBox();
            txtDescription = new RichTextBox();
            cbCalUnit = new ComboBox();
            nudWarranty = new NumericUpDown();
            lbMonth = new Label();
            lbQuantity = new Label();
            lbVND = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            dgvProduct = new DataGridView();
            btnDel = new Button();
            groupBox2 = new GroupBox();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWarranty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMod
            // 
            btnMod.Location = new Point(351, 21);
            btnMod.Margin = new Padding(3, 2, 3, 2);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(82, 22);
            btnMod.TabIndex = 8;
            btnMod.Text = "Sửa";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(684, 21);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbCatagory
            // 
            cbCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Location = new Point(135, 98);
            cbCatagory.Margin = new Padding(3, 2, 3, 2);
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(302, 23);
            cbCatagory.TabIndex = 11;
            // 
            // txtID
            // 
            txtID.Location = new Point(135, 12);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(302, 23);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 40);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(302, 23);
            txtName.TabIndex = 3;
            // 
            // lbCatagory
            // 
            lbCatagory.AutoSize = true;
            lbCatagory.Location = new Point(24, 102);
            lbCatagory.Name = "lbCatagory";
            lbCatagory.Size = new Size(29, 15);
            lbCatagory.TabIndex = 10;
            lbCatagory.Text = "Loại";
            // 
            // lbWarranty
            // 
            lbWarranty.AutoSize = true;
            lbWarranty.Location = new Point(24, 132);
            lbWarranty.Name = "lbWarranty";
            lbWarranty.Size = new Size(82, 15);
            lbWarranty.TabIndex = 6;
            lbWarranty.Text = "Hạn bảo hành";
            // 
            // lbPriceQuotation
            // 
            lbPriceQuotation.AutoSize = true;
            lbPriceQuotation.Location = new Point(24, 74);
            lbPriceQuotation.Name = "lbPriceQuotation";
            lbPriceQuotation.Size = new Size(48, 15);
            lbPriceQuotation.TabIndex = 4;
            lbPriceQuotation.Text = "Đơn giá";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(24, 45);
            lbName.Name = "lbName";
            lbName.Size = new Size(26, 15);
            lbName.TabIndex = 2;
            lbName.Text = "Tên";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(24, 16);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 15);
            lbID.TabIndex = 0;
            lbID.Text = "Mã";
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(nudPrice);
            gbInfo.Controls.Add(nudQuantity);
            gbInfo.Controls.Add(groupBox1);
            gbInfo.Controls.Add(cbCalUnit);
            gbInfo.Controls.Add(nudWarranty);
            gbInfo.Controls.Add(lbMonth);
            gbInfo.Controls.Add(lbQuantity);
            gbInfo.Controls.Add(lbVND);
            gbInfo.Controls.Add(cbCatagory);
            gbInfo.Controls.Add(txtID);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(lbCatagory);
            gbInfo.Controls.Add(lbWarranty);
            gbInfo.Controls.Add(lbPriceQuotation);
            gbInfo.Controls.Add(lbName);
            gbInfo.Controls.Add(lbID);
            gbInfo.Location = new Point(5, 4);
            gbInfo.Margin = new Padding(3, 2, 3, 2);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(3, 2, 3, 2);
            gbInfo.Size = new Size(954, 196);
            gbInfo.TabIndex = 6;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin";
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(135, 70);
            nudPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(242, 23);
            nudPrice.TabIndex = 29;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(135, 160);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(242, 23);
            nudQuantity.TabIndex = 28;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Location = new Point(443, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 169);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(6, 21);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            txtDescription.Size = new Size(497, 143);
            txtDescription.TabIndex = 22;
            txtDescription.Text = "";
            // 
            // cbCalUnit
            // 
            cbCalUnit.FormattingEnabled = true;
            cbCalUnit.Location = new Point(383, 158);
            cbCalUnit.Margin = new Padding(3, 2, 3, 2);
            cbCalUnit.Name = "cbCalUnit";
            cbCalUnit.Size = new Size(54, 23);
            cbCalUnit.TabIndex = 26;
            // 
            // nudWarranty
            // 
            nudWarranty.Location = new Point(135, 128);
            nudWarranty.Margin = new Padding(3, 2, 3, 2);
            nudWarranty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudWarranty.Name = "nudWarranty";
            nudWarranty.Size = new Size(242, 23);
            nudWarranty.TabIndex = 19;
            // 
            // lbMonth
            // 
            lbMonth.BackColor = SystemColors.ControlLightLight;
            lbMonth.BorderStyle = BorderStyle.Fixed3D;
            lbMonth.Location = new Point(383, 128);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new Size(54, 23);
            lbMonth.TabIndex = 18;
            lbMonth.Text = "tháng";
            lbMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(24, 162);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(54, 15);
            lbQuantity.TabIndex = 14;
            lbQuantity.Text = "Số lượng";
            // 
            // lbVND
            // 
            lbVND.BackColor = SystemColors.ControlLightLight;
            lbVND.BorderStyle = BorderStyle.Fixed3D;
            lbVND.Location = new Point(383, 70);
            lbVND.Name = "lbVND";
            lbVND.Size = new Size(54, 23);
            lbVND.TabIndex = 12;
            lbVND.Text = "VND";
            lbVND.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(462, 21);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(240, 21);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(129, 21);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(5, 268);
            dgvProduct.Margin = new Padding(3, 2, 3, 2);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(954, 326);
            dgvProduct.TabIndex = 11;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(573, 21);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(82, 22);
            btnDel.TabIndex = 12;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(btnDel);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(btnMod);
            groupBox2.Controls.Add(btnCancel);
            groupBox2.Location = new Point(5, 205);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(954, 58);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 605);
            Controls.Add(groupBox2);
            Controls.Add(gbInfo);
            Controls.Add(dgvProduct);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sản phẩm";
            Load += frmProduct_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudWarranty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMod;
        private Button btnSearch;
        private ComboBox cbCatagory;
        private TextBox txtID;
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
        private NumericUpDown nudWarranty;
        private Label lbMonth;
        private RichTextBox txtDescription;
        private ComboBox cbCalUnit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudPrice;
    }
}