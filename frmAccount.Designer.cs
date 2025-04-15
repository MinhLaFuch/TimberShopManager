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
            txtID = new TextBox();
            dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtUsername = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lbEmployeeRole = new Label();
            lbEmployeeDOB = new Label();
            lbEmployeeAddress = new Label();
            lbUsername = new Label();
            lbName = new Label();
            lbID = new Label();
            pnButton = new FlowLayoutPanel();
            btnAdd = new Button();
            btnLock = new Button();
            btnSearch = new Button();
            dgvAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            gbAccInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            lbGmail = new Label();
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
            cbRole.Location = new Point(678, 201);
            cbRole.Name = "cbRole";
            cbRole.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbRole.Size = new Size(250, 36);
            cbRole.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.ForeColor = Color.FromArgb(59, 93, 79);
            txtID.Location = new Point(152, 71);
            txtID.Name = "txtID";
            txtID.Size = new Size(345, 20);
            txtID.TabIndex = 1;
            // 
            // dtpDOB
            // 
            dtpDOB.Checked = true;
            dtpDOB.CustomizableEdges = customizableEdges3;
            dtpDOB.FillColor = Color.FromArgb(59, 93, 79);
            dtpDOB.Font = new Font("Segoe UI", 9F);
            dtpDOB.ForeColor = SystemColors.ButtonFace;
            dtpDOB.Format = DateTimePickerFormat.Long;
            dtpDOB.Location = new Point(678, 150);
            dtpDOB.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDOB.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpDOB.Size = new Size(250, 45);
            dtpDOB.TabIndex = 9;
            dtpDOB.Value = new DateTime(2025, 4, 14, 10, 37, 8, 863);
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.FromArgb(59, 93, 79);
            txtUsername.Location = new Point(152, 164);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(243, 20);
            txtUsername.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.ForeColor = Color.FromArgb(59, 93, 79);
            txtAddress.Location = new Point(678, 115);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(493, 20);
            txtAddress.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.ForeColor = Color.FromArgb(59, 93, 79);
            txtName.Location = new Point(152, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 20);
            txtName.TabIndex = 3;
            // 
            // lbEmployeeRole
            // 
            lbEmployeeRole.AutoSize = true;
            lbEmployeeRole.ForeColor = Color.FromArgb(59, 93, 79);
            lbEmployeeRole.Location = new Point(595, 208);
            lbEmployeeRole.Name = "lbEmployeeRole";
            lbEmployeeRole.Size = new Size(61, 20);
            lbEmployeeRole.TabIndex = 10;
            lbEmployeeRole.Text = "Chức vụ";
            // 
            // lbEmployeeDOB
            // 
            lbEmployeeDOB.AutoSize = true;
            lbEmployeeDOB.ForeColor = Color.FromArgb(59, 93, 79);
            lbEmployeeDOB.Location = new Point(595, 161);
            lbEmployeeDOB.Name = "lbEmployeeDOB";
            lbEmployeeDOB.Size = new Size(74, 20);
            lbEmployeeDOB.TabIndex = 8;
            lbEmployeeDOB.Text = "Ngày sinh";
            // 
            // lbEmployeeAddress
            // 
            lbEmployeeAddress.AutoSize = true;
            lbEmployeeAddress.ForeColor = Color.FromArgb(59, 93, 79);
            lbEmployeeAddress.Location = new Point(595, 115);
            lbEmployeeAddress.Name = "lbEmployeeAddress";
            lbEmployeeAddress.Size = new Size(46, 20);
            lbEmployeeAddress.TabIndex = 6;
            lbEmployeeAddress.Text = "Nơi ở";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.ForeColor = Color.FromArgb(59, 93, 79);
            lbUsername.Location = new Point(25, 164);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(68, 20);
            lbUsername.TabIndex = 4;
            lbUsername.Text = "Số CCCD";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.FromArgb(59, 93, 79);
            lbName.Location = new Point(25, 117);
            lbName.Name = "lbName";
            lbName.Size = new Size(121, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Họ tên nhân viên";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.ForeColor = Color.FromArgb(59, 93, 79);
            lbID.Location = new Point(25, 71);
            lbID.Name = "lbID";
            lbID.Size = new Size(97, 20);
            lbID.TabIndex = 0;
            lbID.Text = "Mã nhân viên";
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnAdd);
            pnButton.Controls.Add(btnLock);
            pnButton.Controls.Add(btnSearch);
            pnButton.Location = new Point(1, 286);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(208, 353);
            pnButton.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(59, 93, 79);
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(3, 4);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 70);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Tạo tài khoản";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnLock
            // 
            btnLock.BackColor = Color.FromArgb(59, 93, 79);
            btnLock.Font = new Font("Segoe UI", 9F);
            btnLock.ForeColor = SystemColors.ButtonFace;
            btnLock.Location = new Point(3, 82);
            btnLock.Margin = new Padding(3, 4, 3, 4);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(196, 70);
            btnLock.TabIndex = 7;
            btnLock.Text = "Khóa tài khoản";
            btnLock.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(59, 93, 79);
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(3, 160);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(196, 70);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
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
            dgvAccount.Location = new Point(226, 286);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersVisible = false;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(979, 353);
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
            gbAccInfo.Controls.Add(lbGmail);
            gbAccInfo.Controls.Add(label2);
            gbAccInfo.Controls.Add(textBox2);
            gbAccInfo.Controls.Add(label1);
            gbAccInfo.Controls.Add(textBox1);
            gbAccInfo.Controls.Add(cbRole);
            gbAccInfo.Controls.Add(lbName);
            gbAccInfo.Controls.Add(dtpDOB);
            gbAccInfo.Controls.Add(txtAddress);
            gbAccInfo.Controls.Add(txtID);
            gbAccInfo.Controls.Add(lbEmployeeRole);
            gbAccInfo.Controls.Add(lbID);
            gbAccInfo.Controls.Add(lbEmployeeDOB);
            gbAccInfo.Controls.Add(lbUsername);
            gbAccInfo.Controls.Add(lbEmployeeAddress);
            gbAccInfo.Controls.Add(txtUsername);
            gbAccInfo.Controls.Add(txtName);
            gbAccInfo.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbAccInfo.CustomizableEdges = customizableEdges5;
            gbAccInfo.FillColor = SystemColors.Control;
            gbAccInfo.Font = new Font("Segoe UI", 9F);
            gbAccInfo.ForeColor = Color.White;
            gbAccInfo.Location = new Point(12, 12);
            gbAccInfo.Name = "gbAccInfo";
            gbAccInfo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gbAccInfo.Size = new Size(1193, 268);
            gbAccInfo.TabIndex = 11;
            gbAccInfo.Text = "Thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(59, 93, 79);
            label2.Location = new Point(25, 212);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 13;
            label2.Text = "Số CCCD";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.FromArgb(59, 93, 79);
            textBox2.Location = new Point(152, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 20);
            textBox2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(59, 93, 79);
            label1.Location = new Point(595, 71);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 11;
            label1.Text = "Số CCCD";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.FromArgb(59, 93, 79);
            textBox1.Location = new Point(678, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 20);
            textBox1.TabIndex = 12;
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.ForeColor = Color.FromArgb(59, 93, 79);
            lbGmail.Location = new Point(404, 164);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(93, 20);
            lbGmail.TabIndex = 15;
            lbGmail.Text = "@gmail.com";
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(gbAccInfo);
            Controls.Add(dgvAccount);
            Controls.Add(pnButton);
            ForeColor = Color.FromArgb(59, 93, 79);
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
        private Label lbEmployeeRole;
        private Label lbEmployeeDOB;
        private Label lbEmployeeAddress;
        private Label lbUsername;
        private Label lbName;
        private Label lbID;
        private TextBox txtID;
        private TextBox txtUsername;
        private TextBox txtAddress;
        private TextBox txtName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private Guna.UI2.WinForms.Guna2ComboBox cbRole;
        private FlowLayoutPanel pnButton;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAccount;
        private Guna.UI2.WinForms.Guna2GroupBox gbAccInfo;
        private Button btnAdd;
        private Button btnLock;
        private Button btnSearch;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label lbGmail;
    }
}