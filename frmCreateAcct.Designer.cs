namespace timber_shop_manager
{
    partial class frmCreateAcct
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
            button1 = new Button();
            button2 = new Button();
            lbEmail = new Label();
            lbPWReenter = new Label();
            textBox1 = new TextBox();
            lbPW = new Label();
            button3 = new Button();
            button4 = new Button();
            lb = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(545, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(668, 400);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(54, 47);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbPWReenter
            // 
            lbPWReenter.AutoSize = true;
            lbPWReenter.Location = new Point(54, 252);
            lbPWReenter.Name = "lbPWReenter";
            lbPWReenter.Size = new Size(130, 20);
            lbPWReenter.TabIndex = 3;
            lbPWReenter.Text = "Nhập lại mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 27);
            textBox1.TabIndex = 5;
            // 
            // lbPW
            // 
            lbPW.AutoSize = true;
            lbPW.Location = new Point(54, 144);
            lbPW.Name = "lbPW";
            lbPW.Size = new Size(70, 20);
            lbPW.TabIndex = 6;
            lbPW.Text = "Mật khẩu";
            // 
            // button3
            // 
            button3.Location = new Point(479, 62);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(634, 62);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(377, 215);
            lb.Name = "lb";
            lb.Size = new Size(46, 20);
            lb.TabIndex = 9;
            lb.Text = "Email";
            // 
            // frmCreateAcct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(lbPW);
            Controls.Add(textBox1);
            Controls.Add(lbPWReenter);
            Controls.Add(lbEmail);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCreateAcct";
            Text = "frmCreateAcct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lbEmail;
        private Label lbPWReenter;
        private TextBox textBox1;
        private Label lbPW;
        private Button button3;
        private Button button4;
        private Label lb;
    }
}