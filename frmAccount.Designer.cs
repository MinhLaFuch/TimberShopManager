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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lbRole = new Label();
            lbEmail = new Label();
            lbName = new Label();
            lbID = new Label();
            btnCreate = new Button();
            btnLock = new Button();
            btnSearch = new Button();
            gbInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            pnButton = new FlowLayoutPanel();
            pnInfoButton = new FlowLayoutPanel();
            btnCancel = new Button();
            pnFeatureButton = new FlowLayoutPanel();
            pnInfo = new Panel();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            gbInfo.SuspendLayout();
            pnButton.SuspendLayout();
            pnInfoButton.SuspendLayout();
            pnFeatureButton.SuspendLayout();
            pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.FromArgb(59, 93, 79);
            cbRole.BorderColor = Color.FromArgb(59, 93, 79);
            cbRole.CustomizableEdges = customizableEdges5;
            cbRole.DrawMode = DrawMode.OwnerDrawFixed;
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FocusedColor = Color.FromArgb(94, 148, 255);
            cbRole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbRole.Font = new Font("Segoe UI", 10F);
            cbRole.ForeColor = Color.FromArgb(68, 88, 112);
            cbRole.ItemHeight = 30;
            cbRole.Location = new Point(585, 35);
            cbRole.Margin = new Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbRole.Size = new Size(302, 36);
            cbRole.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.InactiveCaption;
            txtID.BorderStyle = BorderStyle.None;
            txtID.ForeColor = Color.FromArgb(59, 93, 79);
            txtID.Location = new Point(122, 11);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(302, 16);
            txtID.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveCaption;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.FromArgb(59, 93, 79);
            txtEmail.Location = new Point(586, 11);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 16);
            txtEmail.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.InactiveCaption;
            txtName.BorderStyle = BorderStyle.None;
            txtName.ForeColor = Color.FromArgb(59, 93, 79);
            txtName.Location = new Point(122, 45);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(302, 16);
            txtName.TabIndex = 3;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.ForeColor = Color.FromArgb(59, 93, 79);
            lbRole.Location = new Point(471, 46);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(51, 15);
            lbRole.TabIndex = 10;
            lbRole.Text = "Chức vụ";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.ForeColor = Color.FromArgb(59, 93, 79);
            lbEmail.Location = new Point(473, 11);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.FromArgb(59, 93, 79);
            lbName.Location = new Point(11, 46);
            lbName.Name = "lbName";
            lbName.Size = new Size(98, 15);
            lbName.TabIndex = 2;
            lbName.Text = "Họ tên nhân viên";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.ForeColor = Color.FromArgb(59, 93, 79);
            lbID.Location = new Point(11, 11);
            lbID.Name = "lbID";
            lbID.Size = new Size(79, 15);
            lbID.TabIndex = 0;
            lbID.Text = "Mã nhân viên";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(59, 93, 79);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9F);
            btnCreate.ForeColor = SystemColors.ButtonFace;
            btnCreate.Location = new Point(4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(116, 30);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Tạo tài khoản";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnLock
            // 
            btnLock.BackColor = Color.FromArgb(59, 93, 79);
            btnLock.FlatStyle = FlatStyle.Flat;
            btnLock.Font = new Font("Segoe UI", 9F);
            btnLock.ForeColor = SystemColors.ButtonFace;
            btnLock.Location = new Point(126, 3);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(116, 30);
            btnLock.TabIndex = 7;
            btnLock.Text = "Khóa tài khoản";
            btnLock.UseVisualStyleBackColor = false;
            btnLock.Click += btnLock_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(59, 93, 79);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(248, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 30);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(pnButton);
            gbInfo.Controls.Add(pnInfo);
            gbInfo.CustomBorderColor = Color.FromArgb(59, 93, 79);
            gbInfo.CustomizableEdges = customizableEdges7;
            gbInfo.Dock = DockStyle.Top;
            gbInfo.FillColor = SystemColors.Control;
            gbInfo.Font = new Font("Segoe UI", 9F);
            gbInfo.ForeColor = Color.White;
            gbInfo.Location = new Point(0, 0);
            gbInfo.Margin = new Padding(3, 2, 3, 2);
            gbInfo.Name = "gbInfo";
            gbInfo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            gbInfo.Size = new Size(925, 165);
            gbInfo.TabIndex = 11;
            gbInfo.Text = "Thông tin";
            // 
            // pnButton
            // 
            pnButton.Controls.Add(pnInfoButton);
            pnButton.Controls.Add(pnFeatureButton);
            pnButton.FlowDirection = FlowDirection.RightToLeft;
            pnButton.Location = new Point(405, 119);
            pnButton.Margin = new Padding(3, 2, 3, 2);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(507, 41);
            pnButton.TabIndex = 12;
            // 
            // pnInfoButton
            // 
            pnInfoButton.Controls.Add(btnCancel);
            pnInfoButton.FlowDirection = FlowDirection.RightToLeft;
            pnInfoButton.Location = new Point(381, 2);
            pnInfoButton.Margin = new Padding(3, 2, 3, 2);
            pnInfoButton.Name = "pnInfoButton";
            pnInfoButton.Size = new Size(123, 39);
            pnInfoButton.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(59, 93, 79);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnFeatureButton
            // 
            pnFeatureButton.Controls.Add(btnSearch);
            pnFeatureButton.Controls.Add(btnLock);
            pnFeatureButton.Controls.Add(btnCreate);
            pnFeatureButton.FlowDirection = FlowDirection.RightToLeft;
            pnFeatureButton.Location = new Point(8, 2);
            pnFeatureButton.Margin = new Padding(3, 2, 3, 2);
            pnFeatureButton.Name = "pnFeatureButton";
            pnFeatureButton.Size = new Size(367, 39);
            pnFeatureButton.TabIndex = 18;
            // 
            // pnInfo
            // 
            pnInfo.Controls.Add(txtEmail);
            pnInfo.Controls.Add(cbRole);
            pnInfo.Controls.Add(txtName);
            pnInfo.Controls.Add(lbEmail);
            pnInfo.Controls.Add(lbRole);
            pnInfo.Controls.Add(lbID);
            pnInfo.Controls.Add(txtID);
            pnInfo.Controls.Add(lbName);
            pnInfo.Location = new Point(12, 32);
            pnInfo.Margin = new Padding(3, 2, 3, 2);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(900, 83);
            pnInfo.TabIndex = 17;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(59, 93, 79);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle6;
            dgv.Dock = DockStyle.Fill;
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.Location = new Point(0, 165);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.Size = new Size(925, 441);
            dgv.TabIndex = 12;
            dgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv.ThemeStyle.BackColor = Color.Gainsboro;
            dgv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ThemeStyle.HeaderStyle.Height = 50;
            dgv.ThemeStyle.ReadOnly = true;
            dgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(59, 93, 79);
            dgv.ThemeStyle.RowsStyle.Height = 25;
            dgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgv.CellClick += dgv_CellClick;
            dgv.DataBindingComplete += dgv_DataBindingComplete;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 606);
            Controls.Add(dgv);
            Controls.Add(gbInfo);
            ForeColor = Color.FromArgb(59, 93, 79);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAccount";
            Text = "frmAccount";
            Load += frmAccount_Load;
            gbInfo.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnInfoButton.ResumeLayout(false);
            pnFeatureButton.ResumeLayout(false);
            pnInfo.ResumeLayout(false);
            pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbRole;
        private Label lbEmail;
        private Label lbName;
        private Label lbID;
        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtName;
        private Guna.UI2.WinForms.Guna2ComboBox cbRole;
        private Guna.UI2.WinForms.Guna2GroupBox gbInfo;
        private Button btnCreate;
        private Button btnLock;
        private Button btnSearch;
        private Button btnCancel;
        private Panel pnInfo;
        private FlowLayoutPanel pnFeatureButton;
        private FlowLayoutPanel pnInfoButton;
        private FlowLayoutPanel pnButton;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
    }
}