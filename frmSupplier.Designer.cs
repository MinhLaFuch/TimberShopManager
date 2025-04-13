namespace timber_shop_manager
{
    partial class frmSupplier
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
            dgvSupplier = new DataGridView();
            btnAdd = new Button();
            btnDel = new Button();
            btnMod = new Button();
            btnSearch = new Button();
            gbInfo = new GroupBox();
            lbID = new Label();
            txtID = new TextBox();
            txtPhoneNumber = new TextBox();
            lbPhoneNumber = new Label();
            txtName = new TextBox();
            lbName = new Label();
            lbAddress = new Label();
            txtWebsite = new TextBox();
            txtAddress = new TextBox();
            lbEmail = new Label();
            lbWebsite = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            grbFunction = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            gbInfo.SuspendLayout();
            grbFunction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSupplier
            // 
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(2, 260);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(806, 427);
            dgvSupplier.TabIndex = 0;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 33);
            btnAdd.TabIndex = 1;
            btnAdd.Text = " Thêm nhà cung cấp";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(472, 27);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 33);
            btnDel.TabIndex = 2;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(255, 27);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 33);
            btnMod.TabIndex = 3;
            btnMod.Text = "Sửa";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(665, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 33);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lbID);
            gbInfo.Controls.Add(txtID);
            gbInfo.Controls.Add(btnCancel);
            gbInfo.Controls.Add(txtPhoneNumber);
            gbInfo.Controls.Add(btnSave);
            gbInfo.Controls.Add(lbPhoneNumber);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(lbName);
            gbInfo.Controls.Add(lbAddress);
            gbInfo.Controls.Add(txtWebsite);
            gbInfo.Controls.Add(txtAddress);
            gbInfo.Controls.Add(lbEmail);
            gbInfo.Controls.Add(lbWebsite);
            gbInfo.Controls.Add(txtEmail);
            gbInfo.Location = new Point(2, 3);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(806, 197);
            gbInfo.TabIndex = 5;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin nhà cung cấp";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(32, 33);
            lbID.Name = "lbID";
            lbID.Size = new Size(122, 20);
            lbID.TabIndex = 6;
            lbID.Text = "Mã nhà cung cấp";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(153, 28);
            txtID.Name = "txtID";
            txtID.Size = new Size(263, 27);
            txtID.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(153, 108);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(263, 27);
            txtPhoneNumber.TabIndex = 19;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(32, 113);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(97, 20);
            lbPhoneNumber.TabIndex = 18;
            lbPhoneNumber.Text = "Số điện thoại";
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(263, 27);
            txtName.TabIndex = 17;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(32, 72);
            lbName.Name = "lbName";
            lbName.Size = new Size(124, 20);
            lbName.TabIndex = 16;
            lbName.Text = "Tên nhà cung cấp";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(447, 33);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(55, 20);
            lbAddress.TabIndex = 10;
            lbAddress.Text = "Địa chỉ";
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(520, 108);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(263, 27);
            txtWebsite.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(520, 28);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(263, 27);
            txtAddress.TabIndex = 11;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(447, 72);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 14;
            lbEmail.Text = "Email";
            // 
            // lbWebsite
            // 
            lbWebsite.AutoSize = true;
            lbWebsite.Location = new Point(447, 113);
            lbWebsite.Name = "lbWebsite";
            lbWebsite.Size = new Size(62, 20);
            lbWebsite.TabIndex = 12;
            lbWebsite.Text = "Website";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(520, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(627, 142);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 33);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(708, 142);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 33);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // grbFunction
            // 
            grbFunction.Controls.Add(btnAdd);
            grbFunction.Controls.Add(btnSearch);
            grbFunction.Controls.Add(btnMod);
            grbFunction.Controls.Add(btnDel);
            grbFunction.Location = new Point(2, 185);
            grbFunction.Margin = new Padding(3, 4, 3, 4);
            grbFunction.Name = "grbFunction";
            grbFunction.Padding = new Padding(3, 4, 3, 4);
            grbFunction.Size = new Size(806, 69);
            grbFunction.TabIndex = 6;
            grbFunction.TabStop = false;
            grbFunction.Text = "Thao tác";
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(815, 689);
            Controls.Add(grbFunction);
            Controls.Add(gbInfo);
            Controls.Add(dgvSupplier);
            Name = "frmSupplier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSupplier";
            Load += frmSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            grbFunction.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSupplier;
        private Button btnAdd;
        private Button btnDel;
        private Button btnMod;
        private Button btnSearch;
        private GroupBox gbInfo;
        private Label lbID;
        private TextBox txtID;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtAddress;
        private Label lbAddress;
        private TextBox txtEmail;
        private Label lbWebsite;
        private TextBox txtWebsite;
        private Label lbEmail;
        private TextBox txtName;
        private Label lbName;
        private TextBox txtPhoneNumber;
        private Label lbPhoneNumber;
        private GroupBox grbFunction;
    }
}