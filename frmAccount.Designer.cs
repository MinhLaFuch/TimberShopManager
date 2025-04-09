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
            dgvAccount = new DataGridView();
            btnAdd = new Button();
            gbAccInfo = new GroupBox();
            cbRole = new ComboBox();
            dtpDOB = new DateTimePicker();
            txtEmployeeID = new TextBox();
            txtIden = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lbEmployeeRole = new Label();
            lbEmployeeDOB = new Label();
            lbEmployeeAddress = new Label();
            lbEmployeeIden = new Label();
            lbEmployeeName = new Label();
            lbEmployeeID = new Label();
            btnSearch = new Button();
            cbSearch = new ComboBox();
            btnLock = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            gbAccInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAccount
            // 
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Location = new Point(195, 180);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(1073, 344);
            dgvAccount.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 81);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Tạo tài khoản";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbAccInfo
            // 
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
            gbAccInfo.Location = new Point(12, 12);
            gbAccInfo.Name = "gbAccInfo";
            gbAccInfo.Size = new Size(1256, 157);
            gbAccInfo.TabIndex = 0;
            gbAccInfo.TabStop = false;
            gbAccInfo.Text = "Thông tin";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(705, 123);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(327, 28);
            cbRole.TabIndex = 11;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(705, 67);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(327, 27);
            dtpDOB.TabIndex = 9;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(154, 16);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(345, 27);
            txtEmployeeID.TabIndex = 1;
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
            txtAddress.Size = new Size(531, 27);
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
            // btnSearch
            // 
            btnSearch.Location = new Point(1, 429);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(188, 95);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(1, 395);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(188, 28);
            cbSearch.TabIndex = 3;
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // btnLock
            // 
            btnLock.Location = new Point(1, 262);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(188, 81);
            btnLock.TabIndex = 2;
            btnLock.Text = "Khóa tài khoản";
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 536);
            Controls.Add(btnLock);
            Controls.Add(cbSearch);
            Controls.Add(btnSearch);
            Controls.Add(gbAccInfo);
            Controls.Add(btnAdd);
            Controls.Add(dgvAccount);
            Name = "frmAccount";
            Text = "frmAccount";
            Load += frmAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            gbAccInfo.ResumeLayout(false);
            gbAccInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAccount;
        private Button btnAdd;
        private GroupBox gbAccInfo;
        private Label lbEmployeeRole;
        private Label lbEmployeeDOB;
        private Label lbEmployeeAddress;
        private Label lbEmployeeIden;
        private Label lbEmployeeName;
        private Label lbEmployeeID;
        private Button btnSearch;
        private ComboBox cbSearch;
        private TextBox txtEmployeeID;
        private TextBox txtIden;
        private TextBox txtAddress;
        private TextBox txtName;
        private ComboBox cbRole;
        private DateTimePicker dtpDOB;
        private Button btnLock;
    }
}