namespace timber_shop_manager
{
    partial class frmEmployee
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
            dgvEmployee = new DataGridView();
            gbAccInfo = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            cbRole = new ComboBox();
            dtpDOB = new DateTimePicker();
            txtID = new TextBox();
            txtIden = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lbEmployeeRole = new Label();
            lbEmployeeDOB = new Label();
            lbEmployeeAddress = new Label();
            lbEmployeeIden = new Label();
            lbEmployeeName = new Label();
            lbID = new Label();
            btnDel = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            btnViewWorkHour = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            gbAccInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(210, 174);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(977, 358);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // gbAccInfo
            // 
            gbAccInfo.Controls.Add(btnCancel);
            gbAccInfo.Controls.Add(btnSave);
            gbAccInfo.Controls.Add(cbRole);
            gbAccInfo.Controls.Add(dtpDOB);
            gbAccInfo.Controls.Add(txtID);
            gbAccInfo.Controls.Add(txtIden);
            gbAccInfo.Controls.Add(txtAddress);
            gbAccInfo.Controls.Add(txtName);
            gbAccInfo.Controls.Add(lbEmployeeRole);
            gbAccInfo.Controls.Add(lbEmployeeDOB);
            gbAccInfo.Controls.Add(lbEmployeeAddress);
            gbAccInfo.Controls.Add(lbEmployeeIden);
            gbAccInfo.Controls.Add(lbEmployeeName);
            gbAccInfo.Controls.Add(lbID);
            gbAccInfo.Location = new Point(5, 11);
            gbAccInfo.Name = "gbAccInfo";
            gbAccInfo.Size = new Size(1182, 157);
            gbAccInfo.TabIndex = 3;
            gbAccInfo.TabStop = false;
            gbAccInfo.Text = "Thông tin";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1085, 122);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(975, 122);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(988, 68);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(182, 28);
            cbRole.TabIndex = 11;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(608, 69);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(154, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(345, 27);
            txtID.TabIndex = 1;
            // 
            // txtIden
            // 
            txtIden.Location = new Point(154, 117);
            txtIden.Name = "txtIden";
            txtIden.Size = new Size(345, 27);
            txtIden.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(608, 19);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(562, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 27);
            txtName.TabIndex = 3;
            // 
            // lbEmployeeRole
            // 
            lbEmployeeRole.AutoSize = true;
            lbEmployeeRole.Location = new Point(901, 74);
            lbEmployeeRole.Name = "lbEmployeeRole";
            lbEmployeeRole.Size = new Size(61, 20);
            lbEmployeeRole.TabIndex = 10;
            lbEmployeeRole.Text = "Chức vụ";
            // 
            // lbEmployeeDOB
            // 
            lbEmployeeDOB.AutoSize = true;
            lbEmployeeDOB.Location = new Point(523, 72);
            lbEmployeeDOB.Name = "lbEmployeeDOB";
            lbEmployeeDOB.Size = new Size(74, 20);
            lbEmployeeDOB.TabIndex = 8;
            lbEmployeeDOB.Text = "Ngày sinh";
            // 
            // lbEmployeeAddress
            // 
            lbEmployeeAddress.AutoSize = true;
            lbEmployeeAddress.Location = new Point(538, 19);
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
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(27, 23);
            lbID.Name = "lbID";
            lbID.Size = new Size(97, 20);
            lbID.TabIndex = 0;
            lbID.Text = "Mã nhân viên";
            // 
            // btnDel
            // 
            btnDel.Location = new Point(12, 261);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(188, 81);
            btnDel.TabIndex = 6;
            btnDel.Text = "Xóa nhân viên";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnLock_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 437);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(188, 95);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 174);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 81);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm nhân viên mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnViewWorkHour
            // 
            btnViewWorkHour.Location = new Point(12, 348);
            btnViewWorkHour.Name = "btnViewWorkHour";
            btnViewWorkHour.Size = new Size(188, 81);
            btnViewWorkHour.TabIndex = 9;
            btnViewWorkHour.Text = "Xem chấm công";
            btnViewWorkHour.UseVisualStyleBackColor = true;
            btnViewWorkHour.Click += btnViewWorkHour_Click;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 539);
            Controls.Add(btnViewWorkHour);
            Controls.Add(btnDel);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(gbAccInfo);
            Controls.Add(dgvEmployee);
            Name = "frmEmployee";
            Text = "frmEmployee";
            Load += frmEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            gbAccInfo.ResumeLayout(false);
            gbAccInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployee;
        private GroupBox gbAccInfo;
        private ComboBox cbRole;
        private DateTimePicker dtpDOB;
        private TextBox txtID;
        private TextBox txtIden;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label lbEmployeeRole;
        private Label lbEmployeeDOB;
        private Label lbEmployeeAddress;
        private Label lbEmployeeIden;
        private Label lbEmployeeName;
        private Label lbID;
        private Button btnDel;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnViewWorkHour;
        private Button btnCancel;
        private Button btnSave;
    }
}