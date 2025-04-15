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
            gbAccInfo = new GroupBox();
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
            dgvAccount = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnAdd = new Button();
            btnLock = new Button();
            btnSearch = new Button();
            gbAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // gbAccInfo
            // 
            gbAccInfo.Controls.Add(cbRole);
            gbAccInfo.Controls.Add(txtEmployeeID);
            gbAccInfo.Controls.Add(dtpDOB);
            gbAccInfo.Controls.Add(txtIden);
            gbAccInfo.Controls.Add(txtAddress);
            gbAccInfo.Controls.Add(txtName);
            gbAccInfo.Controls.Add(lbEmployeeRole);
            gbAccInfo.Controls.Add(lbEmployeeDOB);
            gbAccInfo.Controls.Add(lbEmployeeAddress);
            gbAccInfo.Controls.Add(lbEmployeeIden);
            gbAccInfo.Controls.Add(lbEmployeeName);
            gbAccInfo.Controls.Add(lbEmployeeID);
            gbAccInfo.Location = new Point(1, 0);
            gbAccInfo.Name = "gbAccInfo";
            gbAccInfo.Size = new Size(1276, 169);
            gbAccInfo.TabIndex = 0;
            gbAccInfo.TabStop = false;
            gbAccInfo.Text = "Thông tin";
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
            cbRole.Location = new Point(705, 109);
            cbRole.Name = "cbRole";
            cbRole.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbRole.Size = new Size(250, 36);
            cbRole.TabIndex = 9;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.BorderStyle = BorderStyle.None;
            txtEmployeeID.Location = new Point(154, 16);
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
            dtpDOB.Location = new Point(705, 58);
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
            txtIden.Location = new Point(154, 117);
            txtIden.Name = "txtIden";
            txtIden.Size = new Size(345, 20);
            txtIden.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Location = new Point(705, 23);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(531, 20);
            txtAddress.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(154, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 20);
            txtName.TabIndex = 3;
            // 
            // lbEmployeeRole
            // 
            lbEmployeeRole.AutoSize = true;
            lbEmployeeRole.Location = new Point(581, 120);
            lbEmployeeRole.Name = "lbEmployeeRole";
            lbEmployeeRole.Size = new Size(61, 20);
            lbEmployeeRole.TabIndex = 10;
            lbEmployeeRole.Text = "Chức vụ";
            // 
            // lbEmployeeDOB
            // 
            lbEmployeeDOB.AutoSize = true;
            lbEmployeeDOB.Location = new Point(581, 72);
            lbEmployeeDOB.Name = "lbEmployeeDOB";
            lbEmployeeDOB.Size = new Size(74, 20);
            lbEmployeeDOB.TabIndex = 8;
            lbEmployeeDOB.Text = "Ngày sinh";
            // 
            // lbEmployeeAddress
            // 
            lbEmployeeAddress.AutoSize = true;
            lbEmployeeAddress.Location = new Point(596, 23);
            lbEmployeeAddress.Name = "lbEmployeeAddress";
            lbEmployeeAddress.Size = new Size(46, 20);
            lbEmployeeAddress.TabIndex = 6;
            lbEmployeeAddress.Text = "Nơi ở";
            // 
            // lbEmployeeIden
            // 
            lbEmployeeIden.AutoSize = true;
            lbEmployeeIden.Location = new Point(27, 117);
            lbEmployeeIden.Name = "lbEmployeeIden";
            lbEmployeeIden.Size = new Size(68, 20);
            lbEmployeeIden.TabIndex = 4;
            lbEmployeeIden.Text = "Số CCCD";
            // 
            // lbEmployeeName
            // 
            lbEmployeeName.AutoSize = true;
            lbEmployeeName.Location = new Point(27, 72);
            lbEmployeeName.Name = "lbEmployeeName";
            lbEmployeeName.Size = new Size(121, 20);
            lbEmployeeName.TabIndex = 2;
            lbEmployeeName.Text = "Họ tên nhân viên";
            // 
            // lbEmployeeID
            // 
            lbEmployeeID.AutoSize = true;
            lbEmployeeID.Location = new Point(27, 23);
            lbEmployeeID.Name = "lbEmployeeID";
            lbEmployeeID.Size = new Size(97, 20);
            lbEmployeeID.TabIndex = 0;
            lbEmployeeID.Text = "Mã nhân viên";
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToResizeRows = false;
            dgvAccount.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvAccount.BorderStyle = BorderStyle.None;
            dgvAccount.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAccount.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAccount.EnableHeadersVisualStyles = false;
            dgvAccount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvAccount.GridColor = Color.FromArgb(255, 255, 255);
            dgvAccount.Location = new Point(256, 213);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccount.Size = new Size(1012, 311);
            dgvAccount.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(59, 93, 79);
            btnAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(12, 237);
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
            btnLock.Location = new Point(12, 336);
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
            btnSearch.Location = new Point(12, 439);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(196, 40);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 712);
            Controls.Add(btnSearch);
            Controls.Add(btnLock);
            Controls.Add(btnAdd);
            Controls.Add(dgvAccount);
            Controls.Add(gbAccInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccount";
            Text = "frmAccount";
            Load += frmAccount_Load;
            gbAccInfo.ResumeLayout(false);
            gbAccInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private GroupBox gbAccInfo;
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
        private ReaLTaiizor.Controls.PoisonDataGridView dgvAccount;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private Guna.UI2.WinForms.Guna2ComboBox cbRole;
    }
}