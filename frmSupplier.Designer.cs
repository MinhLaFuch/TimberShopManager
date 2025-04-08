namespace timber_shop_manager
{
    partial class frmSupplier
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
            btnCancel = new Button();
            btnViewWorkHour = new Button();
            btnLock = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            cbRole = new ComboBox();
            dtpDOB = new DateTimePicker();
            txtIden = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lbEmployeeDOB = new Label();
            lbEmployeeAddress = new Label();
            lbEmployeeIden = new Label();
            lbEmployeeName = new Label();
            lbEmployeeID = new Label();
            gbAccInfo = new GroupBox();
            txtEmployeeID = new TextBox();
            lbEmployeeRole = new Label();
            dgvEmployee = new DataGridView();
            gbAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1173, 122);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnViewWorkHour
            // 
            btnViewWorkHour.Location = new Point(21, 338);
            btnViewWorkHour.Name = "btnViewWorkHour";
            btnViewWorkHour.Size = new Size(188, 81);
            btnViewWorkHour.TabIndex = 15;
            btnViewWorkHour.Text = "Xem chấm công";
            btnViewWorkHour.UseVisualStyleBackColor = true;
            // 
            // btnLock
            // 
            btnLock.Location = new Point(21, 251);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(188, 81);
            btnLock.TabIndex = 13;
            btnLock.Text = "Xóa nhân viên";
            btnLock.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(21, 427);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(188, 95);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 164);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 81);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm nhân viên mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1073, 122);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(1085, 66);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(182, 28);
            cbRole.TabIndex = 11;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(705, 67);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 9;
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
            txtAddress.Location = new Point(705, 13);
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
            // lbEmployeeDOB
            // 
            lbEmployeeDOB.AutoSize = true;
            lbEmployeeDOB.Location = new Point(568, 67);
            lbEmployeeDOB.Name = "lbEmployeeDOB";
            lbEmployeeDOB.Size = new Size(74, 20);
            lbEmployeeDOB.TabIndex = 8;
            lbEmployeeDOB.Text = "Ngày sinh";
            // 
            // lbEmployeeAddress
            // 
            lbEmployeeAddress.AutoSize = true;
            lbEmployeeAddress.Location = new Point(581, 16);
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
            // gbAccInfo
            // 
            gbAccInfo.Controls.Add(btnCancel);
            gbAccInfo.Controls.Add(btnSave);
            gbAccInfo.Controls.Add(cbRole);
            gbAccInfo.Controls.Add(dtpDOB);
            gbAccInfo.Controls.Add(txtEmployeeID);
            gbAccInfo.Controls.Add(txtIden);
            gbAccInfo.Controls.Add(txtAddress);
            gbAccInfo.Controls.Add(txtName);
            gbAccInfo.Controls.Add(lbEmployeeRole);
            gbAccInfo.Controls.Add(lbEmployeeDOB);
            gbAccInfo.Controls.Add(lbEmployeeAddress);
            gbAccInfo.Controls.Add(lbEmployeeIden);
            gbAccInfo.Controls.Add(lbEmployeeName);
            gbAccInfo.Controls.Add(lbEmployeeID);
            gbAccInfo.Location = new Point(21, 1);
            gbAccInfo.Name = "gbAccInfo";
            gbAccInfo.Size = new Size(1273, 157);
            gbAccInfo.TabIndex = 11;
            gbAccInfo.TabStop = false;
            gbAccInfo.Text = "Thông tin";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(154, 16);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(345, 27);
            txtEmployeeID.TabIndex = 1;
            // 
            // lbEmployeeRole
            // 
            lbEmployeeRole.AutoSize = true;
            lbEmployeeRole.Location = new Point(989, 67);
            lbEmployeeRole.Name = "lbEmployeeRole";
            lbEmployeeRole.Size = new Size(61, 20);
            lbEmployeeRole.TabIndex = 10;
            lbEmployeeRole.Text = "Chức vụ";
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(219, 164);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(1075, 358);
            dgvEmployee.TabIndex = 10;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 522);
            Controls.Add(btnViewWorkHour);
            Controls.Add(btnLock);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(gbAccInfo);
            Controls.Add(dgvEmployee);
            Name = "frmSupplier";
            Text = "frmSupplier";
            gbAccInfo.ResumeLayout(false);
            gbAccInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnViewWorkHour;
        private Button btnLock;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnSave;
        private ComboBox cbRole;
        private DateTimePicker dtpDOB;
        private TextBox txtIden;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label lbEmployeeDOB;
        private Label lbEmployeeAddress;
        private Label lbEmployeeIden;
        private Label lbEmployeeName;
        private Label lbEmployeeID;
        private GroupBox gbAccInfo;
        private TextBox txtEmployeeID;
        private Label lbEmployeeRole;
        private DataGridView dgvEmployee;
    }
}