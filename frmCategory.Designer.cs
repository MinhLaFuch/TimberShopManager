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
            btnProduct = new Button();
            btnSupplier = new Button();
            btnCustomer = new Button();
            btnAccount = new Button();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(12, 76);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(236, 58);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Hàng hóa";
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            btnSupplier.Location = new Point(12, 12);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(236, 58);
            btnSupplier.TabIndex = 0;
            btnSupplier.Text = "Nhà cung cấp";
            btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(12, 140);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(236, 58);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(12, 204);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(236, 58);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "Tài khoản";
            btnAccount.UseVisualStyleBackColor = true;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 278);
            Controls.Add(btnAccount);
            Controls.Add(btnCustomer);
            Controls.Add(btnSupplier);
            Controls.Add(btnProduct);
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh mục";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduct;
        private Button btnSupplier;
        private Button btnCustomer;
        private Button btnAccount;
    }
}