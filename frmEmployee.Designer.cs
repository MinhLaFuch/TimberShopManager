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
            lbCurrency = new Label();
            txtSalary = new TextBox();
            lbSalary = new Label();
            txtPhoneNumber = new TextBox();
            lbPhoneNumber = new Label();
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
            btnMod = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            gbAccInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(210, 206);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(977, 358);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // gbAccInfo
            // 
            gbAccInfo.Controls.Add(lbCurrency);
            gbAccInfo.Controls.Add(txtSalary);
            gbAccInfo.Controls.Add(lbSalary);
            gbAccInfo.Controls.Add(txtPhoneNumber);
            gbAccInfo.Controls.Add(lbPhoneNumber);
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
            gbAccInfo.Size = new Size(1182, 192);
            gbAccInfo.TabIndex = 0;
            gbAccInfo.TabStop = false;
            gbAccInfo.Text = "Thông tin";
            // 
            // lbCurrency
            // 
            lbCurrency.AutoSize = true;
            lbCurrency.Location = new Point(810, 150);
            lbCurrency.Name = "lbCurrency";
            lbCurrency.Size = new Size(122, 20);
            lbCurrency.TabIndex = 16;
            lbCurrency.Text = "VND/ Ngày công";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(608, 147);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(187, 27);
            txtSalary.TabIndex = 15;
            txtSalary.TextChanged += txtSalary_TextChanged;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // lbSalary
            // 
            lbSalary.AutoSize = true;
            lbSalary.Location = new Point(528, 150);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(51, 20);
            lbSalary.TabIndex = 14;
            lbSalary.Text = "Lương";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(154, 143);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(345, 27);
            txtPhoneNumber.TabIndex = 7;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(7, 146);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(97, 20);
            lbPhoneNumber.TabIndex = 6;
            lbPhoneNumber.Text = "Số điện thoại";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1076, 157);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(976, 157);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Manager", "Administrator", "Sale Agent", "Accountant" });
            cbRole.Location = new Point(608, 99);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(250, 28);
            cbRole.TabIndex = 13;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(608, 58);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 11;
            dtpDOB.ValueChanged += dtpDOB_ValueChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(154, 16);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(345, 27);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtIden
            // 
            txtIden.Location = new Point(154, 100);
            txtIden.Name = "txtIden";
            txtIden.Size = new Size(345, 27);
            txtIden.TabIndex = 5;
            txtIden.TextChanged += txtIden_TextChanged;
            txtIden.KeyPress += txtIden_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(608, 19);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(562, 27);
            txtAddress.TabIndex = 9;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 27);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // lbEmployeeRole
            // 
            lbEmployeeRole.AutoSize = true;
            lbEmployeeRole.Location = new Point(528, 103);
            lbEmployeeRole.Name = "lbEmployeeRole";
            lbEmployeeRole.Size = new Size(61, 20);
            lbEmployeeRole.TabIndex = 12;
            lbEmployeeRole.Text = "Chức vụ";
            // 
            // lbEmployeeDOB
            // 
            lbEmployeeDOB.AutoSize = true;
            lbEmployeeDOB.Location = new Point(528, 62);
            lbEmployeeDOB.Name = "lbEmployeeDOB";
            lbEmployeeDOB.Size = new Size(74, 20);
            lbEmployeeDOB.TabIndex = 10;
            lbEmployeeDOB.Text = "Ngày sinh";
            // 
            // lbEmployeeAddress
            // 
            lbEmployeeAddress.AutoSize = true;
            lbEmployeeAddress.Location = new Point(528, 19);
            lbEmployeeAddress.Name = "lbEmployeeAddress";
            lbEmployeeAddress.Size = new Size(46, 20);
            lbEmployeeAddress.TabIndex = 8;
            lbEmployeeAddress.Text = "Nơi ở";
            // 
            // lbEmployeeIden
            // 
            lbEmployeeIden.AutoSize = true;
            lbEmployeeIden.Location = new Point(7, 107);
            lbEmployeeIden.Name = "lbEmployeeIden";
            lbEmployeeIden.Size = new Size(68, 20);
            lbEmployeeIden.TabIndex = 4;
            lbEmployeeIden.Text = "Số CCCD";
            // 
            // lbEmployeeName
            // 
            lbEmployeeName.AutoSize = true;
            lbEmployeeName.Location = new Point(7, 65);
            lbEmployeeName.Name = "lbEmployeeName";
            lbEmployeeName.Size = new Size(121, 20);
            lbEmployeeName.TabIndex = 2;
            lbEmployeeName.Text = "Họ tên nhân viên";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(6, 23);
            lbID.Name = "lbID";
            lbID.Size = new Size(97, 20);
            lbID.TabIndex = 0;
            lbID.Text = "Mã nhân viên";
            // 
            // btnDel
            // 
            btnDel.Location = new Point(5, 285);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(188, 37);
            btnDel.TabIndex = 6;
            btnDel.Text = "Xóa nhân viên";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(5, 453);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(188, 49);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(5, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 44);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm nhân viên mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnViewWorkHour
            // 
            btnViewWorkHour.Location = new Point(5, 328);
            btnViewWorkHour.Name = "btnViewWorkHour";
            btnViewWorkHour.Size = new Size(188, 45);
            btnViewWorkHour.TabIndex = 9;
            btnViewWorkHour.Text = "Xem chấm công";
            btnViewWorkHour.UseVisualStyleBackColor = true;
            btnViewWorkHour.Click += btnViewWorkHour_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(5, 393);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(188, 29);
            btnMod.TabIndex = 10;
            btnMod.Text = "Sửa thông tin";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1194, 564);
            Controls.Add(btnMod);
            Controls.Add(btnViewWorkHour);
            Controls.Add(btnDel);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(gbAccInfo);
            Controls.Add(dgvEmployee);
            Name = "frmEmployee";
            Text = "Danh sách nhân viên";
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
        private TextBox txtSalary;
        private Label lbSalary;
        private TextBox txtPhoneNumber;
        private Label lbPhoneNumber;
        private Label lbCurrency;
        private Button btnMod;
    }
}