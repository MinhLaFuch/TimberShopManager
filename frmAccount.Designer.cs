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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            txtID = new TextBox();
            txtUsername = new TextBox();
            txtName = new TextBox();
            lbRole = new Label();
            lbUsername = new Label();
            lbName = new Label();
            lbID = new Label();
            btnAdd = new Button();
            btnLock = new Button();
            btnSearch = new Button();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            gbInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            pnInfo = new Panel();
            lbGmail = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            pnButton = new FlowLayoutPanel();
            pnFeatureButton = new FlowLayoutPanel();
            pnInfoButton = new FlowLayoutPanel();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            gbInfo.SuspendLayout();
            pnInfo.SuspendLayout();
            pnButton.SuspendLayout();
            pnFeatureButton.SuspendLayout();
            pnInfoButton.SuspendLayout();
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
            cbRole.Location = new Point(670, 92);
            cbRole.Name = "cbRole";
            cbRole.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbRole.Size = new Size(250, 36);
            cbRole.TabIndex = 9;
            cbRole.SelectedValueChanged += cbRole_SelectedValueChanged;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.ForeColor = Color.FromArgb(59, 93, 79);
            txtID.Location = new Point(140, 15);
            txtID.Name = "txtID";
            txtID.Size = new Size(345, 20);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.FromArgb(59, 93, 79);
            txtUsername.Location = new Point(670, 15);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(243, 20);
            txtUsername.TabIndex = 5;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.ForeColor = Color.FromArgb(59, 93, 79);
            txtName.Location = new Point(140, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 20);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.ForeColor = Color.FromArgb(59, 93, 79);
            lbRole.Location = new Point(561, 108);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(61, 20);
            lbRole.TabIndex = 10;
            lbRole.Text = "Chức vụ";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.ForeColor = Color.FromArgb(59, 93, 79);
            lbUsername.Location = new Point(541, 15);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(97, 20);
            lbUsername.TabIndex = 4;
            lbUsername.Text = "Tên tài khoản";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.FromArgb(59, 93, 79);
            lbName.Location = new Point(13, 61);
            lbName.Name = "lbName";
            lbName.Size = new Size(121, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Họ tên nhân viên";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.ForeColor = Color.FromArgb(59, 93, 79);
            lbID.Location = new Point(13, 15);
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
            btnAdd.Location = new Point(33, 4);
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
            btnLock.Location = new Point(171, 4);
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
            btnSearch.Location = new Point(309, 4);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 40);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeight = 4;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(59, 93, 79);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle3;
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.Location = new Point(25, 278);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1180, 341);
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
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(pnButton);
            gbInfo.Controls.Add(pnInfo);
            gbInfo.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbInfo.CustomizableEdges = customizableEdges3;
            gbInfo.FillColor = SystemColors.Control;
            gbInfo.Font = new Font("Segoe UI", 9F);
            gbInfo.ForeColor = Color.White;
            gbInfo.Location = new Point(25, 12);
            gbInfo.Name = "gbInfo";
            gbInfo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gbInfo.Size = new Size(1180, 256);
            gbInfo.TabIndex = 11;
            gbInfo.Text = "Thông tin";
            // 
            // pnInfo
            // 
            pnInfo.Controls.Add(txtUsername);
            pnInfo.Controls.Add(lbGmail);
            pnInfo.Controls.Add(cbRole);
            pnInfo.Controls.Add(txtName);
            pnInfo.Controls.Add(label2);
            pnInfo.Controls.Add(lbUsername);
            pnInfo.Controls.Add(lbRole);
            pnInfo.Controls.Add(txtPassword);
            pnInfo.Controls.Add(lbID);
            pnInfo.Controls.Add(txtID);
            pnInfo.Controls.Add(lbName);
            pnInfo.Location = new Point(14, 43);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(1160, 148);
            pnInfo.TabIndex = 17;
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.ForeColor = Color.FromArgb(59, 93, 79);
            lbGmail.Location = new Point(950, 15);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(93, 20);
            lbGmail.TabIndex = 15;
            lbGmail.Text = "@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(59, 93, 79);
            label2.Location = new Point(552, 61);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 13;
            label2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(59, 93, 79);
            txtPassword.Location = new Point(670, 61);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(345, 20);
            txtPassword.TabIndex = 14;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(pnFeatureButton);
            pnButton.Controls.Add(pnInfoButton);
            pnButton.FlowDirection = FlowDirection.RightToLeft;
            pnButton.Location = new Point(672, 208);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(502, 165);
            pnButton.TabIndex = 12;
            // 
            // pnFeatureButton
            // 
            pnFeatureButton.Controls.Add(btnSearch);
            pnFeatureButton.Controls.Add(btnLock);
            pnFeatureButton.Controls.Add(btnAdd);
            pnFeatureButton.FlowDirection = FlowDirection.RightToLeft;
            pnFeatureButton.Location = new Point(55, 3);
            pnFeatureButton.Name = "pnFeatureButton";
            pnFeatureButton.Size = new Size(444, 60);
            pnFeatureButton.TabIndex = 18;
            // 
            // pnInfoButton
            // 
            pnInfoButton.Controls.Add(btnCancel);
            pnInfoButton.FlowDirection = FlowDirection.RightToLeft;
            pnInfoButton.Location = new Point(354, 69);
            pnInfoButton.Name = "pnInfoButton";
            pnInfoButton.Size = new Size(145, 55);
            pnInfoButton.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(59, 93, 79);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(10, 4);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            pnInfo.ResumeLayout(false);
            pnInfo.PerformLayout();
            pnButton.ResumeLayout(false);
            pnFeatureButton.ResumeLayout(false);
            pnInfoButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lbRole;
        private Label lbUsername;
        private Label lbName;
        private Label lbID;
        private TextBox txtID;
        private TextBox txtUsername;
        private TextBox txtName;
        private Guna.UI2.WinForms.Guna2ComboBox cbRole;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2GroupBox gbInfo;
        private Button btnAdd;
        private Button btnLock;
        private Button btnSearch;
        private Label label2;
        private TextBox txtPassword;
        private Button btnCancel;
        private Panel pnInfo;
        private Label lbGmail;
        private FlowLayoutPanel pnFeatureButton;
        private FlowLayoutPanel pnInfoButton;
        private FlowLayoutPanel pnButton;
    }
}