namespace timber_shop_manager
{
    partial class frmCustomer
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
            components = new System.ComponentModel.Container();
            dataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            groupBox2 = new GroupBox();
            btnClear = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(8, 204);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(398, 234);
            dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 127);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(66, 25);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(326, 23);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(326, 23);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(66, 91);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(326, 23);
            txtAddress.TabIndex = 3;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 94);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 61);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "SĐT";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(8, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 59);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(311, 22);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm sạch";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button3
            // 
            button3.Location = new Point(220, 22);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(127, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(33, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView);
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Khách hàng";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private TextBox txtAddress;
        private Label label3;
        private Label label2;
        private Label label1;
        private BindingSource bindingSource1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button btnClear;
        private Button button3;
    }
}