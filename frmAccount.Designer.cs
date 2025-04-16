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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            txtID = new TextBox();
            dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtUsername = new TextBox();
            txtName = new TextBox();
            lbEmployeeRole = new Label();
            lbEmployeeDOB = new Label();
            lbEmployeeAddress = new Label();
            lbUsername = new Label();
            lbName = new Label();
            lbID = new Label();
            btnAdd = new Button();
            btnLock = new Button();
            btnSearch = new Button();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            gbInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            lbGmail = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btnCancel = new Button();
            txtAddress = new TextBox();
            pnButton = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            gbInfo.SuspendLayout();
            pnButton.SuspendLayout();
            SuspendLayout();
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.FromArgb(59, 93, 79);
            cbRole.BorderColor = Color.FromArgb(59, 93, 79);
            cbRole.CustomizableEdges = customizableEdges7;
            cbRole.DrawMode = DrawMode.OwnerDrawFixed;
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FocusedColor = Color.FromArgb(94, 148, 255);
            cbRole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbRole.Font = new Font("Segoe UI", 10F);
            cbRole.ForeColor = Color.FromArgb(68, 88, 112);
            cbRole.ItemHeight = 30;
            cbRole.Items.AddRange(new object[] { "Quản lý cửa hàng", "Quản trị viên", "Nhân viên bán hàng", "Nhân viên kế toán" });
            cbRole.Location = new Point(678, 196);
            cbRole.Name = "cbRole";
            cbRole.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            dtpDOB.CustomizableEdges = customizableEdges9;
            dtpDOB.FillColor = Color.FromArgb(59, 93, 79);
            dtpDOB.Font = new Font("Segoe UI", 9F);
            dtpDOB.ForeColor = SystemColors.ButtonFace;
            dtpDOB.Format = DateTimePickerFormat.Long;
            dtpDOB.Location = new Point(678, 153);
            dtpDOB.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDOB.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dtpDOB.Size = new Size(250, 31);
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
            lbEmployeeRole.Location = new Point(589, 212);
            lbEmployeeRole.Name = "lbEmployeeRole";
            lbEmployeeRole.Size = new Size(61, 20);
            lbEmployeeRole.TabIndex = 10;
            lbEmployeeRole.Text = "Chức vụ";
            // 
            // lbEmployeeDOB
            // 
            lbEmployeeDOB.AutoSize = true;
            lbEmployeeDOB.ForeColor = Color.FromArgb(59, 93, 79);
            lbEmployeeDOB.Location = new Point(589, 155);
            lbEmployeeDOB.Name = "lbEmployeeDOB";
            lbEmployeeDOB.Size = new Size(74, 20);
            lbEmployeeDOB.TabIndex = 8;
            lbEmployeeDOB.Text = "Ngày sinh";
            // 
            // lbEmployeeAddress
            // 
            lbEmployeeAddress.AutoSize = true;
            lbEmployeeAddress.ForeColor = Color.FromArgb(59, 93, 79);
            lbEmployeeAddress.Location = new Point(589, 115);
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(59, 93, 79);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(56, 4);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Tạo tài khoản";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnLock
            // 
            btnLock.BackColor = Color.FromArgb(59, 93, 79);
            btnLock.FlatStyle = FlatStyle.Flat;
            btnLock.Font = new Font("Segoe UI", 9F);
            btnLock.ForeColor = SystemColors.ButtonFace;
            btnLock.Location = new Point(194, 4);
            btnLock.Margin = new Padding(3, 4, 3, 4);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(132, 40);
            btnLock.TabIndex = 7;
            btnLock.Text = "Khóa tài khoản";
            btnLock.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(59, 93, 79);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(332, 4);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 40);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgv
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv.ColumnHeadersHeight = 4;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle6;
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.Location = new Point(22, 319);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1183, 309);
            dgv.TabIndex = 10;
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
            gbInfo.Controls.Add(pnButton);
            gbInfo.Controls.Add(lbGmail);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(textBox2);
            gbInfo.Controls.Add(label1);
            gbInfo.Controls.Add(textBox1);
            gbInfo.Controls.Add(cbRole);
            gbInfo.Controls.Add(lbName);
            gbInfo.Controls.Add(dtpDOB);
            gbInfo.Controls.Add(txtAddress);
            gbInfo.Controls.Add(txtID);
            gbInfo.Controls.Add(lbEmployeeRole);
            gbInfo.Controls.Add(lbID);
            gbInfo.Controls.Add(lbEmployeeDOB);
            gbInfo.Controls.Add(lbUsername);
            gbInfo.Controls.Add(lbEmployeeAddress);
            gbInfo.Controls.Add(txtUsername);
            gbInfo.Controls.Add(txtName);
            gbInfo.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbInfo.CustomizableEdges = customizableEdges11;
            gbInfo.FillColor = SystemColors.Control;
            gbInfo.Font = new Font("Segoe UI", 9F);
            gbInfo.ForeColor = Color.White;
            gbInfo.Location = new Point(22, 12);
            gbInfo.Name = "gbInfo";
            gbInfo.ShadowDecoration.CustomizableEdges = customizableEdges12;
            gbInfo.Size = new Size(1183, 301);
            gbInfo.TabIndex = 11;
            gbInfo.Text = "Thông tin";
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
            label1.Location = new Point(589, 71);
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
            textBox1.Size = new Size(444, 20);
            textBox1.TabIndex = 12;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(59, 93, 79);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(470, 4);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.ForeColor = Color.FromArgb(59, 93, 79);
            txtAddress.Location = new Point(678, 115);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(444, 20);
            txtAddress.TabIndex = 7;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnLock);
            pnButton.Controls.Add(btnAdd);
            pnButton.Controls.Add(btnSearch);
            pnButton.Controls.Add(btnCancel);
            pnButton.Location = new Point(572, 250);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(611, 48);
            pnButton.TabIndex = 16;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(gbInfo);
            Controls.Add(dgv);
            ForeColor = Color.FromArgb(59, 93, 79);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccount";
            Text = "frmAccount";
            Load += frmAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            pnButton.ResumeLayout(false);
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
        private TextBox txtName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private Guna.UI2.WinForms.Guna2ComboBox cbRole;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2GroupBox gbInfo;
        private Button btnAdd;
        private Button btnLock;
        private Button btnSearch;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label lbGmail;
        private Button btnCancel;
        private TextBox txtAddress;
        private Panel pnButton;
    }
}