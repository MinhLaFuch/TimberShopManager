namespace timber_shop_manager
{
    partial class frmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            grbInvoice = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            txtInvoiceId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmployee = new TextBox();
            grbCustomer = new GroupBox();
            btnClear = new Button();
            btnSearchCustomer = new Button();
            txtPhoneNumber = new TextBox();
            txtCustomerName = new TextBox();
            txtAddress = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            grbCost = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnComfirm = new Button();
            btnCancel = new Button();
            btnCreate = new Button();
            label7 = new Label();
            btnAddProduct = new Button();
            cbbSearch = new ComboBox();
            nudQuantity = new NumericUpDown();
            lblUnit = new Label();
            pnlSearch = new Panel();
            grbInvoice.SuspendLayout();
            grbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // grbInvoice
            // 
            grbInvoice.Controls.Add(dateTimePicker1);
            grbInvoice.Controls.Add(txtInvoiceId);
            grbInvoice.Controls.Add(label3);
            grbInvoice.Controls.Add(label2);
            grbInvoice.Controls.Add(label1);
            grbInvoice.Controls.Add(txtEmployee);
            grbInvoice.Enabled = false;
            grbInvoice.Location = new Point(4, 12);
            grbInvoice.Name = "grbInvoice";
            grbInvoice.Size = new Size(260, 124);
            grbInvoice.TabIndex = 0;
            grbInvoice.TabStop = false;
            grbInvoice.Text = "Hóa đơn";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(80, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(174, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.Enabled = false;
            txtInvoiceId.Location = new Point(80, 17);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.ReadOnly = true;
            txtInvoiceId.Size = new Size(174, 23);
            txtInvoiceId.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 72);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Ngày lập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 1;
            label1.Text = "Số";
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(80, 69);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.ReadOnly = true;
            txtEmployee.Size = new Size(174, 23);
            txtEmployee.TabIndex = 0;
            // 
            // grbCustomer
            // 
            grbCustomer.Controls.Add(btnClear);
            grbCustomer.Controls.Add(btnSearchCustomer);
            grbCustomer.Controls.Add(txtPhoneNumber);
            grbCustomer.Controls.Add(txtCustomerName);
            grbCustomer.Controls.Add(txtAddress);
            grbCustomer.Controls.Add(label4);
            grbCustomer.Controls.Add(label6);
            grbCustomer.Controls.Add(label5);
            grbCustomer.Location = new Point(270, 12);
            grbCustomer.Name = "grbCustomer";
            grbCustomer.Size = new Size(260, 124);
            grbCustomer.TabIndex = 1;
            grbCustomer.TabStop = false;
            grbCustomer.Text = "Khách hàng";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(143, 93);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 27);
            btnClear.TabIndex = 13;
            btnClear.Text = "Làm sạch";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackgroundImage = (Image)resources.GetObject("btnSearchCustomer.BackgroundImage");
            btnSearchCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchCustomer.Location = new Point(224, 93);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(27, 27);
            btnSearchCustomer.TabIndex = 12;
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(80, 17);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(174, 23);
            txtPhoneNumber.TabIndex = 11;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(80, 43);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(174, 23);
            txtCustomerName.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(80, 69);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(174, 23);
            txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 72);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 21);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 7;
            label6.Text = "SĐT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 47);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 8;
            label5.Text = "Tên";
            // 
            // grbCost
            // 
            grbCost.Location = new Point(536, 12);
            grbCost.Name = "grbCost";
            grbCost.Size = new Size(260, 124);
            grbCost.TabIndex = 1;
            grbCost.TabStop = false;
            grbCost.Text = "Chi phí";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(792, 322);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnComfirm);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Location = new Point(4, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(792, 65);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnComfirm
            // 
            btnComfirm.Location = new Point(266, 22);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(84, 23);
            btnComfirm.TabIndex = 2;
            btnComfirm.Text = "Lập hoá đơn";
            btnComfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(170, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Hủy phiếu";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(80, 22);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(84, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Tạo phiếu";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 10);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 4;
            label7.Text = "Tìm kiếm";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(707, 6);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 5;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // cbbSearch
            // 
            cbbSearch.AllowDrop = true;
            cbbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbSearch.FormattingEnabled = true;
            cbbSearch.Location = new Point(69, 6);
            cbbSearch.Name = "cbbSearch";
            cbbSearch.Size = new Size(506, 23);
            cbbSearch.TabIndex = 6;
            cbbSearch.SelectedValueChanged += cbbSearch_SelectedValueChanged;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(581, 6);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(55, 23);
            nudQuantity.TabIndex = 7;
            // 
            // lblUnit
            // 
            lblUnit.BorderStyle = BorderStyle.Fixed3D;
            lblUnit.Location = new Point(642, 6);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(55, 23);
            lblUnit.TabIndex = 8;
            lblUnit.Text = "unit";
            lblUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(cbbSearch);
            pnlSearch.Controls.Add(lblUnit);
            pnlSearch.Controls.Add(label7);
            pnlSearch.Controls.Add(nudQuantity);
            pnlSearch.Controls.Add(btnAddProduct);
            pnlSearch.Location = new Point(4, 211);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(792, 32);
            pnlSearch.TabIndex = 9;
            // 
            // frmSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(pnlSearch);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(grbCost);
            Controls.Add(grbCustomer);
            Controls.Add(grbInvoice);
            Name = "frmSale";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSale";
            Load += frmSale_Load;
            grbInvoice.ResumeLayout(false);
            grbInvoice.PerformLayout();
            grbCustomer.ResumeLayout(false);
            grbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInvoice;
        private GroupBox grbCustomer;
        private GroupBox grbCost;
        private DataGridView dataGridView1;
        private TextBox txtInvoiceId;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmployee;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPhoneNumber;
        private TextBox txtCustomerName;
        private TextBox txtAddress;
        private Label label4;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnComfirm;
        private Button btnCancel;
        private Button btnCreate;
        private Button btnSearchCustomer;
        private Label label7;
        private Button btnAddProduct;
        private ComboBox cbbSearch;
        private NumericUpDown nudQuantity;
        private Label lblUnit;
        private Panel pnlSearch;
        private Button btnClear;
    }
}