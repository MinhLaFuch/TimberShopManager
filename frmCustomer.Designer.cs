namespace timber_shop_manager
{
    partial class frmCustomer
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lbPhoneNumber = new Label();
            bindingSource1 = new BindingSource(components);
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            gbInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            pnInfoButton = new FlowLayoutPanel();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            pnButton = new FlowLayoutPanel();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            btnMod = new Guna.UI2.WinForms.Guna2Button();
            gbPurchaseHistory = new Guna.UI2.WinForms.Guna2GroupBox();
            txtCreateDate = new TextBox();
            lbCustomerCreateDate = new Label();
            txtCategory = new TextBox();
            lbInvoiceQuantity = new Label();
            lbCategory = new Label();
            txtInvoiceQuantity = new TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            gbInfo.SuspendLayout();
            pnInfoButton.SuspendLayout();
            pnButton.SuspendLayout();
            gbPurchaseHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.ForeColor = Color.FromArgb(59, 93, 79);
            txtPhoneNumber.Location = new Point(188, 59);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(372, 20);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.ForeColor = Color.FromArgb(59, 93, 79);
            txtName.Location = new Point(188, 103);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(372, 20);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.ForeColor = Color.FromArgb(59, 93, 79);
            txtAddress.Location = new Point(188, 147);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(372, 20);
            txtAddress.TabIndex = 3;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(59, 93, 79);
            label3.Location = new Point(27, 147);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(59, 93, 79);
            label2.Location = new Point(27, 103);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.ForeColor = Color.FromArgb(59, 93, 79);
            lbPhoneNumber.Location = new Point(27, 59);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(97, 20);
            lbPhoneNumber.TabIndex = 0;
            lbPhoneNumber.Text = "Số điện thoại";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeight = 4;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle3;
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.Location = new Point(12, 255);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(711, 384);
            dgv.TabIndex = 4;
            dgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv.ThemeStyle.BackColor = Color.White;
            dgv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ThemeStyle.HeaderStyle.Height = 4;
            dgv.ThemeStyle.ReadOnly = false;
            dgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgv.ThemeStyle.RowsStyle.Height = 29;
            dgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(pnInfoButton);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(lbPhoneNumber);
            gbInfo.Controls.Add(txtPhoneNumber);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(txtAddress);
            gbInfo.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbInfo.CustomizableEdges = customizableEdges9;
            gbInfo.FillColor = SystemColors.Control;
            gbInfo.Font = new Font("Segoe UI", 9F);
            gbInfo.ForeColor = Color.White;
            gbInfo.Location = new Point(12, 8);
            gbInfo.Name = "gbInfo";
            gbInfo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            gbInfo.Size = new Size(711, 241);
            gbInfo.TabIndex = 6;
            gbInfo.Text = "Thông tin";
            // 
            // pnInfoButton
            // 
            pnInfoButton.Controls.Add(pnButton);
            pnInfoButton.Controls.Add(btnSave);
            pnInfoButton.Controls.Add(btnCancel);
            pnInfoButton.Location = new Point(366, 181);
            pnInfoButton.Name = "pnInfoButton";
            pnInfoButton.Size = new Size(301, 48);
            pnInfoButton.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges5;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(59, 93, 79);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(3, 62);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSave.Size = new Size(138, 38);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu";
            // 
            // btnCancel
            // 
            btnCancel.CustomizableEdges = customizableEdges7;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(59, 93, 79);
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(147, 62);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCancel.Size = new Size(138, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy";
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnSearch);
            pnButton.Controls.Add(btnMod);
            pnButton.Location = new Point(3, 3);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(293, 53);
            pnButton.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.CustomizableEdges = customizableEdges1;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(59, 93, 79);
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSearch.Size = new Size(138, 38);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            // 
            // btnMod
            // 
            btnMod.CustomizableEdges = customizableEdges3;
            btnMod.DisabledState.BorderColor = Color.DarkGray;
            btnMod.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMod.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMod.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMod.FillColor = Color.FromArgb(59, 93, 79);
            btnMod.Font = new Font("Segoe UI", 9F);
            btnMod.ForeColor = Color.White;
            btnMod.Location = new Point(147, 3);
            btnMod.Name = "btnMod";
            btnMod.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMod.Size = new Size(138, 38);
            btnMod.TabIndex = 10;
            btnMod.Text = "Sửa";
            // 
            // gbPurchaseHistory
            // 
            gbPurchaseHistory.Controls.Add(txtCreateDate);
            gbPurchaseHistory.Controls.Add(lbCustomerCreateDate);
            gbPurchaseHistory.Controls.Add(txtCategory);
            gbPurchaseHistory.Controls.Add(lbInvoiceQuantity);
            gbPurchaseHistory.Controls.Add(lbCategory);
            gbPurchaseHistory.Controls.Add(txtInvoiceQuantity);
            gbPurchaseHistory.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbPurchaseHistory.CustomizableEdges = customizableEdges11;
            gbPurchaseHistory.Enabled = false;
            gbPurchaseHistory.FillColor = SystemColors.Control;
            gbPurchaseHistory.Font = new Font("Segoe UI", 9F);
            gbPurchaseHistory.ForeColor = Color.White;
            gbPurchaseHistory.Location = new Point(729, 8);
            gbPurchaseHistory.Name = "gbPurchaseHistory";
            gbPurchaseHistory.ShadowDecoration.CustomizableEdges = customizableEdges12;
            gbPurchaseHistory.Size = new Size(476, 241);
            gbPurchaseHistory.TabIndex = 7;
            gbPurchaseHistory.Text = "Lịch sử thanh toán";
            // 
            // txtCreateDate
            // 
            txtCreateDate.BorderStyle = BorderStyle.None;
            txtCreateDate.ForeColor = Color.FromArgb(59, 93, 79);
            txtCreateDate.Location = new Point(180, 103);
            txtCreateDate.Margin = new Padding(3, 4, 3, 4);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.Size = new Size(169, 20);
            txtCreateDate.TabIndex = 17;
            // 
            // lbCustomerCreateDate
            // 
            lbCustomerCreateDate.AutoSize = true;
            lbCustomerCreateDate.ForeColor = Color.FromArgb(59, 93, 79);
            lbCustomerCreateDate.Location = new Point(19, 103);
            lbCustomerCreateDate.Name = "lbCustomerCreateDate";
            lbCustomerCreateDate.Size = new Size(132, 20);
            lbCustomerCreateDate.TabIndex = 14;
            lbCustomerCreateDate.Text = "Ngày bắt đầu mua";
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.None;
            txtCategory.ForeColor = Color.FromArgb(59, 93, 79);
            txtCategory.Location = new Point(180, 147);
            txtCategory.Margin = new Padding(3, 4, 3, 4);
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(169, 82);
            txtCategory.TabIndex = 16;
            // 
            // lbInvoiceQuantity
            // 
            lbInvoiceQuantity.AutoSize = true;
            lbInvoiceQuantity.ForeColor = Color.FromArgb(59, 93, 79);
            lbInvoiceQuantity.Location = new Point(19, 59);
            lbInvoiceQuantity.Name = "lbInvoiceQuantity";
            lbInvoiceQuantity.Size = new Size(85, 20);
            lbInvoiceQuantity.TabIndex = 13;
            lbInvoiceQuantity.Text = "Số hóa đơn";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.ForeColor = Color.FromArgb(59, 93, 79);
            lbCategory.Location = new Point(19, 147);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(161, 20);
            lbCategory.TabIndex = 15;
            lbCategory.Text = "Danh mục thường mua";
            // 
            // txtInvoiceQuantity
            // 
            txtInvoiceQuantity.BorderStyle = BorderStyle.None;
            txtInvoiceQuantity.ForeColor = Color.FromArgb(59, 93, 79);
            txtInvoiceQuantity.Location = new Point(180, 59);
            txtInvoiceQuantity.Margin = new Padding(3, 4, 3, 4);
            txtInvoiceQuantity.Name = "txtInvoiceQuantity";
            txtInvoiceQuantity.Size = new Size(169, 20);
            txtInvoiceQuantity.TabIndex = 18;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(729, 255);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(476, 384);
            guna2DataGridView1.TabIndex = 8;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(guna2DataGridView1);
            Controls.Add(gbPurchaseHistory);
            Controls.Add(gbInfo);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Khách hàng";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            pnInfoButton.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            gbPurchaseHistory.ResumeLayout(false);
            gbPurchaseHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private TextBox txtAddress;
        private Label label3;
        private Label label2;
        private Label lbPhoneNumber;
        private BindingSource bindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2GroupBox gbInfo;
        private FlowLayoutPanel pnInfoButton;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnMod;
        private FlowLayoutPanel pnButton;
        private Guna.UI2.WinForms.Guna2GroupBox gbPurchaseHistory;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private TextBox txtCreateDate;
        private Label lbCustomerCreateDate;
        private TextBox txtCategory;
        private Label lbInvoiceQuantity;
        private Label lbCategory;
        private TextBox txtInvoiceQuantity;
    }
}