namespace timber_shop_manager
{
    partial class frmSale
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
            grbInvoice = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            grbCustomer = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            grbCost = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            btnCreate = new Button();
            grbInvoice.SuspendLayout();
            grbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbInvoice
            // 
            grbInvoice.Controls.Add(dateTimePicker1);
            grbInvoice.Controls.Add(textBox3);
            grbInvoice.Controls.Add(label3);
            grbInvoice.Controls.Add(label2);
            grbInvoice.Controls.Add(label1);
            grbInvoice.Controls.Add(textBox1);
            grbInvoice.Location = new Point(4, 12);
            grbInvoice.Name = "grbInvoice";
            grbInvoice.Size = new Size(260, 100);
            grbInvoice.TabIndex = 0;
            grbInvoice.TabStop = false;
            grbInvoice.Text = "Hóa đơn";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(80, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(174, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(80, 17);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 72);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Ngày lập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 1;
            label1.Text = "Số";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 69);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 0;
            // 
            // grbCustomer
            // 
            grbCustomer.Controls.Add(textBox5);
            grbCustomer.Controls.Add(textBox4);
            grbCustomer.Controls.Add(textBox2);
            grbCustomer.Controls.Add(label4);
            grbCustomer.Controls.Add(label6);
            grbCustomer.Controls.Add(label5);
            grbCustomer.Location = new Point(270, 12);
            grbCustomer.Name = "grbCustomer";
            grbCustomer.Size = new Size(260, 100);
            grbCustomer.TabIndex = 1;
            grbCustomer.TabStop = false;
            grbCustomer.Text = "Khách hàng";
            grbCustomer.Enter += grbCustomer_Enter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(80, 17);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(174, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(80, 43);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 72);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 21);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 7;
            label6.Text = "SĐT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 47);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 8;
            label5.Text = "Tên";
            // 
            // grbCost
            // 
            grbCost.Location = new Point(536, 12);
            grbCost.Name = "grbCost";
            grbCost.Size = new Size(260, 100);
            grbCost.TabIndex = 1;
            grbCost.TabStop = false;
            grbCost.Text = "Chi phí";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(792, 249);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Location = new Point(4, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(792, 65);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // button3
            // 
            button3.Location = new Point(266, 22);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(170, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Hủy phiếu";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(80, 22);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Tạo phiếu";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // frmSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(grbCost);
            Controls.Add(grbCustomer);
            Controls.Add(grbInvoice);
            Name = "frmSale";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSale";
            grbInvoice.ResumeLayout(false);
            grbInvoice.PerformLayout();
            grbCustomer.ResumeLayout(false);
            grbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInvoice;
        private GroupBox grbCustomer;
        private GroupBox grbCost;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label4;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button btnCreate;
    }
}