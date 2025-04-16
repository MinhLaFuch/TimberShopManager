namespace timber_shop_manager
{
    partial class frmCategory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            gbInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            pnButton = new FlowLayoutPanel();
            pnInfo = new Panel();
            txtDescription = new RichTextBox();
            txtName = new TextBox();
            lbName = new Label();
            txtID = new TextBox();
            lbID = new Label();
            lbDescription = new Label();
            pnFeatureButton = new FlowLayoutPanel();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            btnViewProduct = new Guna.UI2.WinForms.Guna2Button();
            btnMod = new Guna.UI2.WinForms.Guna2Button();
            btnDel = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            pnInfoButton = new FlowLayoutPanel();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            gbInfo.SuspendLayout();
            pnButton.SuspendLayout();
            pnInfo.SuspendLayout();
            pnFeatureButton.SuspendLayout();
            pnInfoButton.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle3;
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.Location = new Point(12, 283);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1165, 356);
            dgv.TabIndex = 13;
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
            gbInfo.CustomizableEdges = customizableEdges15;
            gbInfo.FillColor = SystemColors.Control;
            gbInfo.Font = new Font("Segoe UI", 9F);
            gbInfo.ForeColor = Color.White;
            gbInfo.Location = new Point(12, 12);
            gbInfo.Name = "gbInfo";
            gbInfo.ShadowDecoration.CustomizableEdges = customizableEdges16;
            gbInfo.Size = new Size(1179, 265);
            gbInfo.TabIndex = 15;
            gbInfo.Text = "Thông tin";
            // 
            // pnButton
            // 
            pnButton.Controls.Add(pnFeatureButton);
            pnButton.Controls.Add(pnInfoButton);
            pnButton.FlowDirection = FlowDirection.RightToLeft;
            pnButton.Location = new Point(472, 214);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(707, 140);
            pnButton.TabIndex = 16;
            // 
            // pnInfo
            // 
            pnInfo.Controls.Add(txtDescription);
            pnInfo.Controls.Add(txtName);
            pnInfo.Controls.Add(lbName);
            pnInfo.Controls.Add(txtID);
            pnInfo.Controls.Add(lbID);
            pnInfo.Controls.Add(lbDescription);
            pnInfo.Location = new Point(3, 59);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(1167, 128);
            pnInfo.TabIndex = 15;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(484, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            txtDescription.Size = new Size(667, 87);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(112, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 20);
            txtName.TabIndex = 10;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.FromArgb(59, 93, 79);
            lbName.Location = new Point(5, 61);
            lbName.Name = "lbName";
            lbName.Size = new Size(101, 20);
            lbName.TabIndex = 9;
            lbName.Text = "Tên danh mục";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(112, 6);
            txtID.Name = "txtID";
            txtID.Size = new Size(236, 20);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.ForeColor = Color.FromArgb(59, 93, 79);
            lbID.Location = new Point(5, 3);
            lbID.Name = "lbID";
            lbID.Size = new Size(99, 20);
            lbID.TabIndex = 0;
            lbID.Text = "Mã danh mục";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.ForeColor = Color.FromArgb(59, 93, 79);
            lbDescription.Location = new Point(430, 3);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(48, 20);
            lbDescription.TabIndex = 11;
            lbDescription.Text = "Mô tả";
            // 
            // pnFeatureButton
            // 
            pnFeatureButton.Controls.Add(btnSearch);
            pnFeatureButton.Controls.Add(btnViewProduct);
            pnFeatureButton.Controls.Add(btnMod);
            pnFeatureButton.Controls.Add(btnDel);
            pnFeatureButton.Controls.Add(btnAdd);
            pnFeatureButton.FlowDirection = FlowDirection.RightToLeft;
            pnFeatureButton.Location = new Point(-5, 3);
            pnFeatureButton.Name = "pnFeatureButton";
            pnFeatureButton.Size = new Size(709, 61);
            pnFeatureButton.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BorderColor = Color.Transparent;
            btnSearch.CustomizableEdges = customizableEdges1;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(59, 93, 79);
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(574, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSearch.Size = new Size(132, 43);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnViewProduct
            // 
            btnViewProduct.BorderColor = Color.Transparent;
            btnViewProduct.CustomizableEdges = customizableEdges3;
            btnViewProduct.DisabledState.BorderColor = Color.DarkGray;
            btnViewProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            btnViewProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnViewProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnViewProduct.FillColor = Color.FromArgb(59, 93, 79);
            btnViewProduct.Font = new Font("Segoe UI", 9F);
            btnViewProduct.ForeColor = Color.White;
            btnViewProduct.Location = new Point(436, 3);
            btnViewProduct.Name = "btnViewProduct";
            btnViewProduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnViewProduct.Size = new Size(132, 43);
            btnViewProduct.TabIndex = 8;
            btnViewProduct.Text = "Xem sản phẩm";
            btnViewProduct.Click += btnViewProduct_Click;
            // 
            // btnMod
            // 
            btnMod.BorderColor = Color.Transparent;
            btnMod.CustomizableEdges = customizableEdges5;
            btnMod.DisabledState.BorderColor = Color.DarkGray;
            btnMod.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMod.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMod.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMod.FillColor = Color.FromArgb(59, 93, 79);
            btnMod.Font = new Font("Segoe UI", 9F);
            btnMod.ForeColor = Color.White;
            btnMod.Location = new Point(298, 3);
            btnMod.Name = "btnMod";
            btnMod.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMod.Size = new Size(132, 43);
            btnMod.TabIndex = 11;
            btnMod.Text = "Sửa";
            btnMod.Click += btnMod_Click;
            // 
            // btnDel
            // 
            btnDel.BorderColor = Color.Transparent;
            btnDel.CustomizableEdges = customizableEdges7;
            btnDel.DisabledState.BorderColor = Color.DarkGray;
            btnDel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDel.FillColor = Color.FromArgb(59, 93, 79);
            btnDel.Font = new Font("Segoe UI", 9F);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(160, 3);
            btnDel.Name = "btnDel";
            btnDel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDel.Size = new Size(132, 43);
            btnDel.TabIndex = 12;
            btnDel.Text = "Xóa";
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BorderColor = Color.Transparent;
            btnAdd.CustomizableEdges = customizableEdges9;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(59, 93, 79);
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(22, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAdd.Size = new Size(132, 43);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // pnInfoButton
            // 
            pnInfoButton.Controls.Add(btnCancel);
            pnInfoButton.Controls.Add(btnSave);
            pnInfoButton.FlowDirection = FlowDirection.RightToLeft;
            pnInfoButton.Location = new Point(427, 70);
            pnInfoButton.Name = "pnInfoButton";
            pnInfoButton.Size = new Size(277, 63);
            pnInfoButton.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.CustomizableEdges = customizableEdges11;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(59, 93, 79);
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(142, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCancel.Size = new Size(132, 43);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges13;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(59, 93, 79);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(4, 3);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSave.Size = new Size(132, 43);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(gbInfo);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategory";
            Text = "frmCatagory";
            Load += frmCatagory_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            gbInfo.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnInfo.ResumeLayout(false);
            pnInfo.PerformLayout();
            pnFeatureButton.ResumeLayout(false);
            pnInfoButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2GroupBox gbInfo;
        private TextBox txtName;
        private RichTextBox txtDescription;
        private FlowLayoutPanel pnInfoButton;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Label lbDescription;
        private FlowLayoutPanel pnFeatureButton;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnMod;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnViewProduct;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Label lbID;
        private TextBox txtID;
        private Label lbName;
        private FlowLayoutPanel pnButton;
        private Panel pnInfo;
    }
}