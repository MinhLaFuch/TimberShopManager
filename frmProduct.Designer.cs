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
            dgvProduct = new DataGridView();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWarranty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // cbCatagory
            // 
            cbCatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Location = new Point(154, 131);
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(345, 28);
            cbCatagory.TabIndex = 11;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(154, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(345, 20);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(154, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 20);
            txtName.TabIndex = 3;
            // 
            // lbCatagory
            // 
            lbCatagory.AutoSize = true;
            lbCatagory.Location = new Point(27, 136);
            lbCatagory.Name = "lbCatagory";
            lbCatagory.Size = new Size(37, 20);
            lbCatagory.TabIndex = 10;
            lbCatagory.Text = "Loại";
            // 
            // lbWarranty
            // 
            lbWarranty.AutoSize = true;
            lbWarranty.Location = new Point(27, 176);
            lbWarranty.Name = "lbWarranty";
            lbWarranty.Size = new Size(102, 20);
            lbWarranty.TabIndex = 6;
            lbWarranty.Text = "Hạn bảo hành";
            // 
            // lbPriceQuotation
            // 
            lbPriceQuotation.AutoSize = true;
            lbPriceQuotation.Location = new Point(27, 99);
            lbPriceQuotation.Name = "lbPriceQuotation";
            lbPriceQuotation.Size = new Size(62, 20);
            lbPriceQuotation.TabIndex = 4;
            lbPriceQuotation.Text = "Đơn giá";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(27, 60);
            lbName.Name = "lbName";
            lbName.Size = new Size(32, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Tên";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(27, 21);
            lbID.Name = "lbID";
            lbID.Size = new Size(30, 20);
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
            gbInfo.Location = new Point(6, 5);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(1090, 261);
            gbInfo.TabIndex = 6;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin";
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(154, 93);
            nudPrice.Margin = new Padding(3, 4, 3, 4);
            nudPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(277, 27);
            nudPrice.TabIndex = 29;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(154, 213);
            nudQuantity.Margin = new Padding(3, 4, 3, 4);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(277, 27);
            nudQuantity.TabIndex = 28;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Location = new Point(506, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(582, 225);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(7, 28);
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            txtDescription.Size = new Size(567, 189);
            txtDescription.TabIndex = 22;
            txtDescription.Text = "";
            // 
            // cbCalUnit
            // 
            cbCalUnit.FormattingEnabled = true;
            cbCalUnit.Location = new Point(438, 211);
            cbCalUnit.Name = "cbCalUnit";
            cbCalUnit.Size = new Size(61, 28);
            cbCalUnit.TabIndex = 26;
            // 
            // nudWarranty
            // 
            nudWarranty.Location = new Point(154, 171);
            nudWarranty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudWarranty.Name = "nudWarranty";
            nudWarranty.Size = new Size(277, 27);
            nudWarranty.TabIndex = 19;
            // 
            // lbMonth
            // 
            lbMonth.BackColor = Color.Transparent;
            lbMonth.Location = new Point(438, 171);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new Size(62, 31);
            lbMonth.TabIndex = 18;
            lbMonth.Text = "tháng";
            lbMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(27, 216);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(69, 20);
            lbQuantity.TabIndex = 14;
            lbQuantity.Text = "Số lượng";
            // 
            // lbVND
            // 
            lbVND.BackColor = Color.Transparent;
            lbVND.Location = new Point(437, 88);
            lbVND.Name = "lbVND";
            lbVND.Size = new Size(62, 31);
            lbVND.TabIndex = 12;
            lbVND.Text = "VND";
            lbVND.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(3, 357);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1093, 449);
            dgvProduct.TabIndex = 11;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 807);
            Controls.Add(gbInfo);
            Controls.Add(dgvProduct);
            FormBorderStyle = FormBorderStyle.None;
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
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbCatagory;
        private TextBox txtID;
        private TextBox txtName;
        private Label lbCatagory;
        private Label lbWarranty;
        private Label lbPriceQuotation;
        private Label lbName;
        private Label lbID;
        private GroupBox gbInfo;
        private Label lbVND;
        private Label lbQuantity;
        private NumericUpDown nudWarranty;
        private Label lbMonth;
        private RichTextBox txtDescription;
        private ComboBox cbCalUnit;
        private GroupBox groupBox1;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudPrice;
        private DataGridView dgvProduct;
    }
}