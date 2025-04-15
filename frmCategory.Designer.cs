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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            gbInfo = new GroupBox();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            txtDescription = new RichTextBox();
            lbDescription = new Label();
            txtName = new TextBox();
            lbName = new Label();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            txtID = new TextBox();
            lbID = new Label();
            btnViewProduct = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnMod = new Guna.UI2.WinForms.Guna2Button();
            btnDel = new Guna.UI2.WinForms.Guna2Button();
            dgvCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            pnButton = new FlowLayoutPanel();
            pnInfoButton = new FlowLayoutPanel();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            pnButton.SuspendLayout();
            pnInfoButton.SuspendLayout();
            SuspendLayout();
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(pnInfoButton);
            gbInfo.Controls.Add(txtDescription);
            gbInfo.Controls.Add(lbDescription);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(lbName);
            gbInfo.Controls.Add(txtID);
            gbInfo.Controls.Add(lbID);
            gbInfo.Location = new Point(12, 12);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(1202, 228);
            gbInfo.TabIndex = 1;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin";
            // 
            // btnCancel
            // 
            btnCancel.CustomizableEdges = customizableEdges3;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(59, 93, 79);
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(115, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.Size = new Size(106, 28);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(519, 23);
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            txtDescription.Size = new Size(667, 120);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(465, 26);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(48, 20);
            lbDescription.TabIndex = 11;
            lbDescription.Text = "Mô tả";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(141, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 20);
            txtName.TabIndex = 10;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(36, 76);
            lbName.Name = "lbName";
            lbName.Size = new Size(101, 20);
            lbName.TabIndex = 9;
            lbName.Text = "Tên danh mục";
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges1;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(59, 93, 79);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(106, 28);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(141, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 20);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(36, 40);
            lbID.Name = "lbID";
            lbID.Size = new Size(99, 20);
            lbID.TabIndex = 0;
            lbID.Text = "Mã danh mục";
            // 
            // btnViewProduct
            // 
            btnViewProduct.BorderColor = Color.Transparent;
            btnViewProduct.CustomizableEdges = customizableEdges5;
            btnViewProduct.DisabledState.BorderColor = Color.DarkGray;
            btnViewProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            btnViewProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnViewProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnViewProduct.FillColor = Color.FromArgb(59, 93, 79);
            btnViewProduct.Font = new Font("Segoe UI", 9F);
            btnViewProduct.ForeColor = Color.White;
            btnViewProduct.Location = new Point(3, 186);
            btnViewProduct.Name = "btnViewProduct";
            btnViewProduct.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnViewProduct.Size = new Size(131, 55);
            btnViewProduct.TabIndex = 8;
            btnViewProduct.Text = "Xem sản phẩm";
            // 
            // btnSearch
            // 
            btnSearch.BorderColor = Color.Transparent;
            btnSearch.CustomizableEdges = customizableEdges7;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(59, 93, 79);
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(3, 247);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSearch.Size = new Size(131, 55);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
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
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAdd.Size = new Size(131, 55);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            // 
            // btnMod
            // 
            btnMod.BorderColor = Color.Transparent;
            btnMod.CustomizableEdges = customizableEdges11;
            btnMod.DisabledState.BorderColor = Color.DarkGray;
            btnMod.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMod.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMod.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMod.FillColor = Color.FromArgb(59, 93, 79);
            btnMod.Font = new Font("Segoe UI", 9F);
            btnMod.ForeColor = Color.White;
            btnMod.Location = new Point(3, 64);
            btnMod.Name = "btnMod";
            btnMod.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnMod.Size = new Size(131, 55);
            btnMod.TabIndex = 11;
            btnMod.Text = "Sửa";
            // 
            // btnDel
            // 
            btnDel.BorderColor = Color.Transparent;
            btnDel.CustomizableEdges = customizableEdges13;
            btnDel.DisabledState.BorderColor = Color.DarkGray;
            btnDel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDel.FillColor = Color.FromArgb(59, 93, 79);
            btnDel.Font = new Font("Segoe UI", 9F);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(3, 125);
            btnDel.Name = "btnDel";
            btnDel.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnDel.Size = new Size(131, 55);
            btnDel.TabIndex = 12;
            btnDel.Text = "Xóa";
            // 
            // dgvCategory
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.ColumnHeadersHeight = 4;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategory.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategory.Location = new Point(206, 246);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(1008, 404);
            dgvCategory.TabIndex = 13;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCategory.ThemeStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCategory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvCategory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCategory.ThemeStyle.HeaderStyle.Height = 4;
            dgvCategory.ThemeStyle.ReadOnly = false;
            dgvCategory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvCategory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCategory.ThemeStyle.RowsStyle.Height = 29;
            dgvCategory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCategory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnAdd);
            pnButton.Controls.Add(btnMod);
            pnButton.Controls.Add(btnDel);
            pnButton.Controls.Add(btnViewProduct);
            pnButton.Controls.Add(btnSearch);
            pnButton.Location = new Point(26, 262);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(133, 308);
            pnButton.TabIndex = 14;
            // 
            // pnInfoButton
            // 
            pnInfoButton.Controls.Add(btnSave);
            pnInfoButton.Controls.Add(btnCancel);
            pnInfoButton.Location = new Point(965, 181);
            pnInfoButton.Name = "pnInfoButton";
            pnInfoButton.Size = new Size(228, 41);
            pnInfoButton.TabIndex = 14;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(pnButton);
            Controls.Add(dgvCategory);
            Controls.Add(gbInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategory";
            Text = "frmCatagory";
            Load += frmCatagory_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            pnButton.ResumeLayout(false);
            pnInfoButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbInfo;
        private RichTextBox txtDescription;
        private Label lbDescription;
        private TextBox txtName;
        private Label lbName;
        private TextBox txtID;
        private Label lbID;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnViewProduct;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnMod;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategory;
        private FlowLayoutPanel pnButton;
        private FlowLayoutPanel pnInfoButton;
    }
}