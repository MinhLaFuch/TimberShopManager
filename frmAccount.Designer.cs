namespace timber_shop_manager
{
    partial class frmAccount
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            txtEmployeeID = new TextBox();
            dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtIden = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lbEmployeeRole = new Label();
            lbEmployeeDOB = new Label();
            lbEmployeeAddress = new Label();
            lbEmployeeIden = new Label();
            lbEmployeeName = new Label();
            lbEmployeeID = new Label();
            btnAdd = new Button();
            btnLock = new Button();
            btnSearch = new Button();
            pnButton = new FlowLayoutPanel();
            dgvAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            gbAccInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            gbAccInfo.SuspendLayout();
            SuspendLayout();
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.FromArgb(59, 93, 79);
            cbRole.BorderColor = Color.FromArgb(59, 93, 79);
            cbRole.CustomizableEdges = customizableEdges1;
            cbRole.DrawMode = DrawMode.OwnerDrawFixed;
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FocusedColor = Color.FromArgb(94, 148, 255);
            cbRole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbRole.Font = new Font("Segoe UI", 10F);
            cbRole.ForeColor = Color.FromArgb(68, 88, 112);
            cbRole.ItemHeight = 30;
            cbRole.Items.AddRange(new object[] { "Quản lý cửa hàng", "Quản trị viên", "Nhân viên bán hàng", "Nhân viên kế toán" });
            cbRole.Location = new Point(815, 187);
            cbRole.Name = "cbRole";
            cbRole.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbRole.Size = new Size(250, 36);
            cbRole.TabIndex = 9;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.BorderStyle = BorderStyle.None;
            txtEmployeeID.Location = new Point(190, 71);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(345, 20);
            txtEmployeeID.TabIndex = 1;
            // 
            // dtpDOB
            // 
            dtpDOB.Checked = true;
            dtpDOB.CustomizableEdges = customizableEdges3;
            dtpDOB.FillColor = Color.FromArgb(59, 93, 79);
            dtpDOB.Font = new Font("Segoe UI", 9F);
            dtpDOB.ForeColor = SystemColors.ButtonFace;
            dtpDOB.Format = DateTimePickerFormat.Long;
            dtpDOB.Location = new Point(815, 130);
            dtpDOB.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDOB.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpDOB.Size = new Size(250, 45);
            dtpDOB.TabIndex = 9;
            dtpDOB.Value = new DateTime(2025, 4, 14, 10, 37, 8, 863);
            // 
            // txtIden
            // 
            txtIden.BorderStyle = BorderStyle.None;
            txtIden.Location = new Point(152, 185);
            txtIden.Name = "txtIden";
            txtIden.Size = new Size(345, 20);
            txtIden.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Location = new Point(728, 71);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(493, 20);
            txtAddress.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(152, 135);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 20);
            txtName.TabIndex = 3;
            // 
            // lbEmployeeRole
            // 
            lbEmployeeRole.AutoSize = true;
            lbEmployeeRole.Location = new Point(666, 203);
            lbEmployeeRole.Name = "lbEmployeeRole";
            lbEmployeeRole.Size = new Size(61, 20);
            lbEmployeeRole.TabIndex = 10;
            lbEmployeeRole.Text = "Chức vụ";
            // 
            // lbEmployeeDOB
            // 
            lbEmployeeDOB.AutoSize = true;
            lbEmployeeDOB.Location = new Point(666, 135);
            lbEmployeeDOB.Name = "lbEmployeeDOB";
            lbEmployeeDOB.Size = new Size(74, 20);
            lbEmployeeDOB.TabIndex = 8;
            lbEmployeeDOB.Text = "Ngày sinh";
            // 
            // lbEmployeeAddress
            // 
            lbEmployeeAddress.AutoSize = true;
            lbEmployeeAddress.Location = new Point(649, 82);
            lbEmployeeAddress.Name = "lbEmployeeAddress";
            lbEmployeeAddress.Size = new Size(46, 20);
            lbEmployeeAddress.TabIndex = 6;
            lbEmployeeAddress.Text = "Nơi ở";
            // 
            // lbEmployeeIden
            // 
            lbEmployeeIden.AutoSize = true;
            lbEmployeeIden.Location = new Point(25, 180);
            lbEmployeeIden.Name = "lbEmployeeIden";
            lbEmployeeIden.Size = new Size(68, 20);
            lbEmployeeIden.TabIndex = 4;
            lbEmployeeIden.Text = "Số CCCD";
            // 
            // lbEmployeeName
            // 
            lbEmployeeName.AutoSize = true;
            lbEmployeeName.Location = new Point(25, 130);
            lbEmployeeName.Name = "lbEmployeeName";
            lbEmployeeName.Size = new Size(121, 20);
            lbEmployeeName.TabIndex = 2;
            lbEmployeeName.Text = "Họ tên nhân viên";
            // 
            // lbEmployeeID
            // 
            lbEmployeeID.AutoSize = true;
            lbEmployeeID.Location = new Point(25, 82);
            lbEmployeeID.Name = "lbEmployeeID";
            lbEmployeeID.Size = new Size(97, 20);
            lbEmployeeID.TabIndex = 0;
            lbEmployeeID.Text = "Mã nhân viên";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(59, 93, 79);
            btnAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(3, 4);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Tạo tài khoản";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnLock
            // 
            btnLock.BackColor = Color.FromArgb(59, 93, 79);
            btnLock.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLock.ForeColor = SystemColors.ButtonFace;
            btnLock.Location = new Point(3, 52);
            btnLock.Margin = new Padding(3, 4, 3, 4);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(196, 40);
            btnLock.TabIndex = 7;
            btnLock.Text = "Khóa tài khoản";
            btnLock.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(59, 93, 79);
            btnSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(3, 100);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(196, 40);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnAdd);
            pnButton.Controls.Add(btnLock);
            pnButton.Controls.Add(btnSearch);
            pnButton.Location = new Point(1, 335);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(208, 145);
            pnButton.TabIndex = 9;
            // 
            // dgvAccount
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAccount.ColumnHeadersHeight = 4;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAccount.GridColor = Color.FromArgb(231, 229, 255);
            dgvAccount.Location = new Point(226, 241);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersVisible = false;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(979, 398);
            dgvAccount.TabIndex = 10;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAccount.ThemeStyle.BackColor = Color.White;
            dgvAccount.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAccount.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAccount.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAccount.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvAccount.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAccount.ThemeStyle.HeaderStyle.Height = 4;
            dgvAccount.ThemeStyle.ReadOnly = false;
            dgvAccount.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAccount.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAccount.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvAccount.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvAccount.ThemeStyle.RowsStyle.Height = 29;
            dgvAccount.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAccount.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // gbAccInfo
            // 
            gbAccInfo.Controls.Add(cbRole);
            gbAccInfo.Controls.Add(lbEmployeeName);
            gbAccInfo.Controls.Add(dtpDOB);
            gbAccInfo.Controls.Add(txtAddress);
            gbAccInfo.Controls.Add(txtEmployeeID);
            gbAccInfo.Controls.Add(lbEmployeeRole);
            gbAccInfo.Controls.Add(lbEmployeeID);
            gbAccInfo.Controls.Add(lbEmployeeDOB);
            gbAccInfo.Controls.Add(lbEmployeeIden);
            gbAccInfo.Controls.Add(lbEmployeeAddress);
            gbAccInfo.Controls.Add(txtIden);
            gbAccInfo.Controls.Add(txtName);
            gbAccInfo.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbAccInfo.CustomizableEdges = customizableEdges5;
            gbAccInfo.FillColor = SystemColors.Control;
            gbAccInfo.Font = new Font("Segoe UI", 9F);
            gbAccInfo.ForeColor = Color.White;
            gbAccInfo.Location = new Point(12, 12);
            gbAccInfo.Name = "gbAccInfo";
            gbAccInfo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gbAccInfo.Size = new Size(1193, 223);
            gbAccInfo.TabIndex = 11;
            gbAccInfo.Text = "Thông tin";
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(gbAccInfo);
            Controls.Add(dgvAccount);
            Controls.Add(pnButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccount";
            Text = "frmAccount";
            Load += frmAccount_Load;
            pnButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            gbAccInfo.ResumeLayout(false);
            gbAccInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Label lbEmployeeRole;
        private Label lbEmployeeDOB;
        private Label lbEmployeeAddress;
        private Label lbEmployeeIden;
        private Label lbEmployeeName;
        private Label lbEmployeeID;
        private Button btnSearch;
        private TextBox txtEmployeeID;
        private TextBox txtIden;
        private TextBox txtAddress;
        private TextBox txtName;
        private Button btnLock;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private Guna.UI2.WinForms.Guna2ComboBox cbRole;
        private FlowLayoutPanel pnButton;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAccount;
        private Guna.UI2.WinForms.Guna2GroupBox gbAccInfo;
    }
}