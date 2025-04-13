namespace timber_shop_manager
{
    partial class frmCatagory
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
            dgvCatagory = new DataGridView();
            gbInfo = new GroupBox();
            txtDescription = new RichTextBox();
            lbDescription = new Label();
            txtName = new TextBox();
            lbName = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtID = new TextBox();
            lbID = new Label();
            btnAdd = new Button();
            btnMod = new Button();
            btnDel = new Button();
            btnSearch = new Button();
            btnViewProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCatagory).BeginInit();
            gbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCatagory
            // 
            dgvCatagory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatagory.Location = new Point(180, 170);
            dgvCatagory.Name = "dgvCatagory";
            dgvCatagory.RowHeadersWidth = 51;
            dgvCatagory.Size = new Size(608, 265);
            dgvCatagory.TabIndex = 0;
            dgvCatagory.CellContentClick += dgvCatagory_CellContentClick;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(txtDescription);
            gbInfo.Controls.Add(lbDescription);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(lbName);
            gbInfo.Controls.Add(btnSave);
            gbInfo.Controls.Add(btnCancel);
            gbInfo.Controls.Add(txtID);
            gbInfo.Controls.Add(lbID);
            gbInfo.Location = new Point(12, 12);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(776, 152);
            gbInfo.TabIndex = 1;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(402, 23);
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            txtDescription.Size = new Size(125, 120);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(316, 26);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(48, 20);
            lbDescription.TabIndex = 11;
            lbDescription.Text = "Mô tả";
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
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
            btnSave.Location = new Point(543, 117);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(662, 117);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(141, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
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
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 170);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 43);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm danh mục";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(12, 219);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(141, 41);
            btnMod.TabIndex = 3;
            btnMod.Text = "Sửa danh mục";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(12, 266);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(141, 46);
            btnDel.TabIndex = 4;
            btnDel.Text = "Xóa danh mục";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 318);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 43);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnViewProduct
            // 
            btnViewProduct.Location = new Point(12, 367);
            btnViewProduct.Name = "btnViewProduct";
            btnViewProduct.Size = new Size(141, 47);
            btnViewProduct.TabIndex = 6;
            btnViewProduct.Text = "Xem sản phẩm";
            btnViewProduct.UseVisualStyleBackColor = true;
            btnViewProduct.Click += btnViewProduct_Click;
            // 
            // frmCatagory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewProduct);
            Controls.Add(btnSearch);
            Controls.Add(btnDel);
            Controls.Add(btnMod);
            Controls.Add(btnAdd);
            Controls.Add(gbInfo);
            Controls.Add(dgvCatagory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCatagory";
            Text = "frmCatagory";
            Load += frmCatagory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCatagory).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCatagory;
        private GroupBox gbInfo;
        private RichTextBox txtDescription;
        private Label lbDescription;
        private TextBox txtName;
        private Label lbName;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtID;
        private Label lbID;
        private Button btnAdd;
        private Button btnMod;
        private Button btnDel;
        private Button btnSearch;
        private Button btnViewProduct;
    }
}