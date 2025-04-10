namespace timber_shop_manager
{
    partial class frmManage
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
            btnProduct = new Button();
            btnSupplier = new Button();
            btnCustomer = new Button();
            btnAccount = new Button();
            btnEmployee = new Button();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(14, 101);
            btnProduct.Margin = new Padding(3, 4, 3, 4);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(270, 77);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Hàng hóa";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.Location = new Point(14, 16);
            btnSupplier.Margin = new Padding(3, 4, 3, 4);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(270, 77);
            btnSupplier.TabIndex = 0;
            btnSupplier.Text = "Nhà cung cấp";
            btnSupplier.UseVisualStyleBackColor = true;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(14, 187);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(270, 77);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(14, 272);
            btnAccount.Margin = new Padding(3, 4, 3, 4);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(270, 77);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "Tài khoản";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(14, 356);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(270, 73);
            btnEmployee.TabIndex = 4;
            btnEmployee.Text = "Nhân viên";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // frmManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 453);
            Controls.Add(btnEmployee);
            Controls.Add(btnAccount);
            Controls.Add(btnCustomer);
            Controls.Add(btnSupplier);
            Controls.Add(btnProduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmManage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh mục";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduct;
        private Button btnSupplier;
        private Button btnCustomer;
        private Button btnAccount;
        private Button btnEmployee;
    }
}