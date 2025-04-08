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
            btnView = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            gbAccInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAccount
            // 
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Location = new Point(195, 184);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(1073, 344);
            dgvAccount.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 81);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Tạo tài khoản";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(1, 271);
            btnView.Name = "btnView";
            btnView.Size = new Size(188, 96);
            btnView.TabIndex = 4;
            btnView.Text = "Xem thông tin nhân viên";
            btnView.UseVisualStyleBackColor = true;
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
            gbAccInfo.TabIndex = 5;
            gbAccInfo.TabStop = false;
            gbAccInfo.Text = "Thông tin";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(809, 117);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(151, 28);
            cbRole.TabIndex = 13;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(809, 72);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 12;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(154, 16);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(345, 27);
            txtEmployeeID.TabIndex = 11;
            // 
            // txtIden
            // 
            txtIden.Location = new Point(154, 117);
            txtIden.Name = "txtIden";
            txtIden.Size = new Size(345, 27);
            txtIden.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(809, 23);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 27);
            txtName.TabIndex = 6;
            // 
            // lbEmployeeRole
            // 
            lbEmployeeRole.AutoSize = true;
            lbEmployeeRole.Location = new Point(729, 120);
            lbEmployeeRole.Name = "lbEmployeeRole";
            lbEmployeeRole.Size = new Size(61, 20);
            lbEmployeeRole.TabIndex = 5;
            lbEmployeeRole.Text = "Chức vụ";
            // 
            // lbEmployeeDOB
            // 
            lbEmployeeDOB.AutoSize = true;
            lbEmployeeDOB.Location = new Point(729, 72);
            lbEmployeeDOB.Name = "lbEmployeeDOB";
            lbEmployeeDOB.Size = new Size(74, 20);
            lbEmployeeDOB.TabIndex = 4;
            lbEmployeeDOB.Text = "Ngày sinh";
            // 
            // lbEmployeeAddress
            // 
            lbEmployeeAddress.AutoSize = true;
            lbEmployeeAddress.Location = new Point(729, 23);
            lbEmployeeAddress.Name = "lbEmployeeAddress";
            lbEmployeeAddress.Size = new Size(46, 20);
            lbEmployeeAddress.TabIndex = 3;
            lbEmployeeAddress.Text = "Nơi ở";
            // 
            // lbEmployeeIden
            // 
            lbEmployeeIden.AutoSize = true;
            lbEmployeeIden.Location = new Point(27, 117);
            lbEmployeeIden.Name = "lbEmployeeIden";
            lbEmployeeIden.Size = new Size(68, 20);
            lbEmployeeIden.TabIndex = 2;
            lbEmployeeIden.Text = "Số CCCD";
            // 
            // lbEmployeeName
            // 
            lbEmployeeName.AutoSize = true;
            lbEmployeeName.Location = new Point(27, 72);
            lbEmployeeName.Name = "lbEmployeeName";
            lbEmployeeName.Size = new Size(121, 20);
            lbEmployeeName.TabIndex = 1;
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
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(1, 395);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(151, 28);
            cbSearch.TabIndex = 7;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 536);
            Controls.Add(cbSearch);
            Controls.Add(btnSearch);
            Controls.Add(gbAccInfo);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Controls.Add(dgvAccount);
            Name = "frmAccount";
            Text = "frmAccount";
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            gbAccInfo.ResumeLayout(false);
            gbAccInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAccount;
        private Button btnAdd;
        private Button btnMod;
        private Button btnView;
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
    }
}