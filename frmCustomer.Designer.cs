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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            lbAddress = new Label();
            lbName = new Label();
            lbPhoneNumber = new Label();
            dgvCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            gbInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            pnInfo = new Panel();
            pnButton = new FlowLayoutPanel();
            pnFeatureButton = new FlowLayoutPanel();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            btnMod = new Guna.UI2.WinForms.Guna2Button();
            pnInfoButton = new FlowLayoutPanel();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            gbPurchaseHistory = new Guna.UI2.WinForms.Guna2GroupBox();
            pnPurchase = new Panel();
            txtCreateDate = new TextBox();
            lbCreateDate = new Label();
            txtCategory = new TextBox();
            lbInvoiceQuantity = new Label();
            lbCategory = new Label();
            txtInvoiceQuantity = new TextBox();
            dgvPurchase = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            gbInfo.SuspendLayout();
            pnInfo.SuspendLayout();
            pnButton.SuspendLayout();
            pnFeatureButton.SuspendLayout();
            pnInfoButton.SuspendLayout();
            gbPurchaseHistory.SuspendLayout();
            pnPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchase).BeginInit();
            SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.ForeColor = Color.FromArgb(59, 93, 79);
            txtPhoneNumber.Location = new Point(176, 7);
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
            txtName.Location = new Point(176, 51);
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
            txtAddress.Location = new Point(176, 95);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(372, 20);
            txtAddress.TabIndex = 3;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.ForeColor = Color.FromArgb(59, 93, 79);
            lbAddress.Location = new Point(15, 95);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(55, 20);
            lbAddress.TabIndex = 2;
            lbAddress.Text = "Địa chỉ";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.FromArgb(59, 93, 79);
            lbName.Location = new Point(15, 51);
            lbName.Name = "lbName";
            lbName.Size = new Size(111, 20);
            lbName.TabIndex = 1;
            lbName.Text = "Tên khách hàng";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.ForeColor = Color.FromArgb(59, 93, 79);
            lbPhoneNumber.Location = new Point(15, 7);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(97, 20);
            lbPhoneNumber.TabIndex = 0;
            lbPhoneNumber.Text = "Số điện thoại";
            // 
            // dgvCustomer
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomer.ColumnHeadersHeight = 4;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomer.GridColor = Color.FromArgb(231, 229, 255);
            dgvCustomer.Location = new Point(12, 259);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(708, 380);
            dgvCustomer.TabIndex = 4;
            dgvCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCustomer.ThemeStyle.BackColor = Color.White;
            dgvCustomer.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCustomer.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCustomer.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCustomer.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvCustomer.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCustomer.ThemeStyle.HeaderStyle.Height = 4;
            dgvCustomer.ThemeStyle.ReadOnly = false;
            dgvCustomer.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCustomer.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomer.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvCustomer.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCustomer.ThemeStyle.RowsStyle.Height = 29;
            dgvCustomer.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCustomer.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(pnInfo);
            gbInfo.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbInfo.CustomizableEdges = customizableEdges1;
            gbInfo.FillColor = SystemColors.Control;
            gbInfo.Font = new Font("Segoe UI", 9F);
            gbInfo.ForeColor = Color.White;
            gbInfo.Location = new Point(12, 8);
            gbInfo.Name = "gbInfo";
            gbInfo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gbInfo.Size = new Size(711, 241);
            gbInfo.TabIndex = 6;
            gbInfo.Text = "Thông tin";
            // 
            // pnInfo
            // 
            pnInfo.Controls.Add(txtName);
            pnInfo.Controls.Add(txtAddress);
            pnInfo.Controls.Add(lbAddress);
            pnInfo.Controls.Add(lbName);
            pnInfo.Controls.Add(txtPhoneNumber);
            pnInfo.Controls.Add(lbPhoneNumber);
            pnInfo.Location = new Point(12, 50);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(634, 124);
            pnInfo.TabIndex = 13;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(pnFeatureButton);
            pnButton.Controls.Add(pnInfoButton);
            pnButton.FlowDirection = FlowDirection.RightToLeft;
            pnButton.Location = new Point(238, 259);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(324, 125);
            pnButton.TabIndex = 14;
            // 
            // pnFeatureButton
            // 
            pnFeatureButton.Controls.Add(btnSearch);
            pnFeatureButton.Controls.Add(btnMod);
            pnFeatureButton.FlowDirection = FlowDirection.RightToLeft;
            pnFeatureButton.Location = new Point(28, 3);
            pnFeatureButton.Name = "pnFeatureButton";
            pnFeatureButton.Size = new Size(293, 53);
            pnFeatureButton.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.CustomizableEdges = customizableEdges3;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(59, 93, 79);
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(152, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearch.Size = new Size(138, 38);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnMod
            // 
            btnMod.CustomizableEdges = customizableEdges5;
            btnMod.DisabledState.BorderColor = Color.DarkGray;
            btnMod.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMod.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMod.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMod.FillColor = Color.FromArgb(59, 93, 79);
            btnMod.Font = new Font("Segoe UI", 9F);
            btnMod.ForeColor = Color.White;
            btnMod.Location = new Point(8, 3);
            btnMod.Name = "btnMod";
            btnMod.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMod.Size = new Size(138, 38);
            btnMod.TabIndex = 10;
            btnMod.Text = "Sửa";
            btnMod.Click += btnMod_Click;
            // 
            // pnInfoButton
            // 
            pnInfoButton.Controls.Add(btnSave);
            pnInfoButton.Controls.Add(btnCancel);
            pnInfoButton.FlowDirection = FlowDirection.RightToLeft;
            pnInfoButton.Location = new Point(28, 62);
            pnInfoButton.Name = "pnInfoButton";
            pnInfoButton.Size = new Size(293, 48);
            pnInfoButton.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges7;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(59, 93, 79);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(152, 3);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSave.Size = new Size(138, 38);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.CustomizableEdges = customizableEdges9;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(59, 93, 79);
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(8, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancel.Size = new Size(138, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy";
            // 
            // gbPurchaseHistory
            // 
            gbPurchaseHistory.Controls.Add(pnPurchase);
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
            // pnPurchase
            // 
            pnPurchase.Controls.Add(txtCreateDate);
            pnPurchase.Controls.Add(lbCreateDate);
            pnPurchase.Controls.Add(txtCategory);
            pnPurchase.Controls.Add(lbInvoiceQuantity);
            pnPurchase.Controls.Add(lbCategory);
            pnPurchase.Controls.Add(txtInvoiceQuantity);
            pnPurchase.Location = new Point(16, 50);
            pnPurchase.Name = "pnPurchase";
            pnPurchase.Size = new Size(448, 183);
            pnPurchase.TabIndex = 19;
            // 
            // txtCreateDate
            // 
            txtCreateDate.BorderStyle = BorderStyle.None;
            txtCreateDate.ForeColor = Color.FromArgb(59, 93, 79);
            txtCreateDate.Location = new Point(177, 51);
            txtCreateDate.Margin = new Padding(3, 4, 3, 4);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.Size = new Size(237, 20);
            txtCreateDate.TabIndex = 23;
            // 
            // lbCreateDate
            // 
            lbCreateDate.AutoSize = true;
            lbCreateDate.ForeColor = Color.FromArgb(59, 93, 79);
            lbCreateDate.Location = new Point(16, 51);
            lbCreateDate.Name = "lbCreateDate";
            lbCreateDate.Size = new Size(132, 20);
            lbCreateDate.TabIndex = 20;
            lbCreateDate.Text = "Ngày bắt đầu mua";
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.None;
            txtCategory.ForeColor = Color.FromArgb(59, 93, 79);
            txtCategory.Location = new Point(177, 95);
            txtCategory.Margin = new Padding(3, 4, 3, 4);
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(237, 82);
            txtCategory.TabIndex = 22;
            // 
            // lbInvoiceQuantity
            // 
            lbInvoiceQuantity.AutoSize = true;
            lbInvoiceQuantity.ForeColor = Color.FromArgb(59, 93, 79);
            lbInvoiceQuantity.Location = new Point(16, 7);
            lbInvoiceQuantity.Name = "lbInvoiceQuantity";
            lbInvoiceQuantity.Size = new Size(85, 20);
            lbInvoiceQuantity.TabIndex = 19;
            lbInvoiceQuantity.Text = "Số hóa đơn";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.ForeColor = Color.FromArgb(59, 93, 79);
            lbCategory.Location = new Point(16, 95);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(161, 20);
            lbCategory.TabIndex = 21;
            lbCategory.Text = "Danh mục thường mua";
            // 
            // txtInvoiceQuantity
            // 
            txtInvoiceQuantity.BorderStyle = BorderStyle.None;
            txtInvoiceQuantity.ForeColor = Color.FromArgb(59, 93, 79);
            txtInvoiceQuantity.Location = new Point(177, 7);
            txtInvoiceQuantity.Margin = new Padding(3, 4, 3, 4);
            txtInvoiceQuantity.Name = "txtInvoiceQuantity";
            txtInvoiceQuantity.Size = new Size(237, 20);
            txtInvoiceQuantity.TabIndex = 24;
            // 
            // dgvPurchase
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvPurchase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPurchase.ColumnHeadersHeight = 4;
            dgvPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPurchase.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPurchase.GridColor = Color.FromArgb(231, 229, 255);
            dgvPurchase.Location = new Point(729, 255);
            dgvPurchase.Name = "dgvPurchase";
            dgvPurchase.RowHeadersVisible = false;
            dgvPurchase.RowHeadersWidth = 51;
            dgvPurchase.Size = new Size(476, 384);
            dgvPurchase.TabIndex = 8;
            dgvPurchase.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPurchase.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPurchase.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPurchase.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPurchase.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPurchase.ThemeStyle.BackColor = Color.White;
            dgvPurchase.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvPurchase.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvPurchase.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPurchase.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvPurchase.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPurchase.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPurchase.ThemeStyle.HeaderStyle.Height = 4;
            dgvPurchase.ThemeStyle.ReadOnly = false;
            dgvPurchase.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPurchase.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPurchase.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPurchase.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvPurchase.ThemeStyle.RowsStyle.Height = 29;
            dgvPurchase.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvPurchase.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(pnButton);
            Controls.Add(dgvPurchase);
            Controls.Add(gbPurchaseHistory);
            Controls.Add(gbInfo);
            Controls.Add(dgvCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Khách hàng";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            gbInfo.ResumeLayout(false);
            pnInfo.ResumeLayout(false);
            pnInfo.PerformLayout();
            pnButton.ResumeLayout(false);
            pnFeatureButton.ResumeLayout(false);
            pnInfoButton.ResumeLayout(false);
            gbPurchaseHistory.ResumeLayout(false);
            pnPurchase.ResumeLayout(false);
            pnPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchase).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private TextBox txtAddress;
        private Label lbAddress;
        private Label lbName;
        private Label lbPhoneNumber;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomer;
        private Guna.UI2.WinForms.Guna2GroupBox gbInfo;
        private FlowLayoutPanel pnInfoButton;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnMod;
        private FlowLayoutPanel pnFeatureButton;
        private Guna.UI2.WinForms.Guna2GroupBox gbPurchaseHistory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPurchase;
        private FlowLayoutPanel pnButton;
        private Panel pnInfo;
        private Panel pnPurchase;
        private TextBox txtCreateDate;
        private Label lbCreateDate;
        private TextBox txtCategory;
        private Label lbInvoiceQuantity;
        private Label lbCategory;
        private TextBox txtInvoiceQuantity;
    }
}