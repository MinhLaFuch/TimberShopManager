namespace timber_shop_manager
{
    partial class frmInvoiceReport
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
            dgv = new DataGridView();
            gbTime = new GroupBox();
            lbTo = new Label();
            lbFrom = new Label();
            btnRefresh = new Button();
            dtpFrom = new DateTimePicker();
            cbTimestamp = new ComboBox();
            dtpTo = new DateTimePicker();
            lbTimestamp = new Label();
            gbStatistic = new GroupBox();
            lbQuantityCurrency = new Label();
            txtSell = new TextBox();
            lbSellCurrency = new Label();
            lbQuantity = new Label();
            lbSell = new Label();
            btnExport = new Button();
            txtSalary = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            gbTime.SuspendLayout();
            gbStatistic.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(3, 191);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(810, 247);
            dgv.TabIndex = 0;
            // 
            // gbTime
            // 
            gbTime.Controls.Add(lbTo);
            gbTime.Controls.Add(lbFrom);
            gbTime.Controls.Add(btnRefresh);
            gbTime.Controls.Add(dtpFrom);
            gbTime.Controls.Add(cbTimestamp);
            gbTime.Controls.Add(dtpTo);
            gbTime.Controls.Add(lbTimestamp);
            gbTime.Location = new Point(-3, 2);
            gbTime.Name = "gbTime";
            gbTime.Size = new Size(326, 183);
            gbTime.TabIndex = 14;
            gbTime.TabStop = false;
            gbTime.Text = "Thời gian";
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new Point(9, 101);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(36, 20);
            lbTo.TabIndex = 20;
            lbTo.Text = "Đến";
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new Point(9, 56);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(26, 20);
            lbFrom.TabIndex = 21;
            lbFrom.Text = "Từ";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(213, 141);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(88, 51);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(127, 27);
            dtpFrom.TabIndex = 2;
            // 
            // cbTimestamp
            // 
            cbTimestamp.FormattingEnabled = true;
            cbTimestamp.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng", "Quý", "Năm", "Ngày -> Ngày" });
            cbTimestamp.Location = new Point(113, 17);
            cbTimestamp.Name = "cbTimestamp";
            cbTimestamp.Size = new Size(151, 28);
            cbTimestamp.TabIndex = 10;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(88, 96);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(122, 27);
            dtpTo.TabIndex = 3;
            // 
            // lbTimestamp
            // 
            lbTimestamp.AutoSize = true;
            lbTimestamp.Location = new Point(6, 20);
            lbTimestamp.Name = "lbTimestamp";
            lbTimestamp.Size = new Size(101, 20);
            lbTimestamp.TabIndex = 4;
            lbTimestamp.Text = "Mốc thời gian";
            // 
            // gbStatistic
            // 
            gbStatistic.Controls.Add(lbQuantityCurrency);
            gbStatistic.Controls.Add(txtSell);
            gbStatistic.Controls.Add(lbSellCurrency);
            gbStatistic.Controls.Add(lbQuantity);
            gbStatistic.Controls.Add(lbSell);
            gbStatistic.Controls.Add(btnExport);
            gbStatistic.Controls.Add(txtSalary);
            gbStatistic.Location = new Point(329, 12);
            gbStatistic.Name = "gbStatistic";
            gbStatistic.Size = new Size(466, 164);
            gbStatistic.TabIndex = 15;
            gbStatistic.TabStop = false;
            gbStatistic.Text = "Thông số";
            // 
            // lbQuantityCurrency
            // 
            lbQuantityCurrency.AutoSize = true;
            lbQuantityCurrency.Location = new Point(284, 60);
            lbQuantityCurrency.Name = "lbQuantityCurrency";
            lbQuantityCurrency.Size = new Size(64, 20);
            lbQuantityCurrency.TabIndex = 18;
            lbQuantityCurrency.Text = "hóa đơn";
            // 
            // txtSell
            // 
            txtSell.Location = new Point(164, 17);
            txtSell.Name = "txtSell";
            txtSell.ReadOnly = true;
            txtSell.Size = new Size(100, 27);
            txtSell.TabIndex = 19;
            // 
            // lbSellCurrency
            // 
            lbSellCurrency.AutoSize = true;
            lbSellCurrency.Location = new Point(284, 23);
            lbSellCurrency.Name = "lbSellCurrency";
            lbSellCurrency.Size = new Size(40, 20);
            lbSellCurrency.TabIndex = 15;
            lbSellCurrency.Text = "VND";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(40, 60);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(118, 20);
            lbQuantity.TabIndex = 16;
            lbQuantity.Text = "Lương nhân viên";
            // 
            // lbSell
            // 
            lbSell.AutoSize = true;
            lbSell.Location = new Point(58, 25);
            lbSell.Name = "lbSell";
            lbSell.Size = new Size(71, 20);
            lbSell.TabIndex = 15;
            lbSell.Text = "Bán hàng";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(349, 133);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(117, 25);
            btnExport.TabIndex = 0;
            btnExport.Text = "Xuất báo cáo";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(164, 53);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(100, 27);
            txtSalary.TabIndex = 19;
            // 
            // frmInvoiceReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 712);
            Controls.Add(gbStatistic);
            Controls.Add(gbTime);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInvoiceReport";
            Text = "frmInvoiceReport";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            gbTime.ResumeLayout(false);
            gbTime.PerformLayout();
            gbStatistic.ResumeLayout(false);
            gbStatistic.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private GroupBox gbTime;
        private Label lbTo;
        private Label lbFrom;
        private Button btnRefresh;
        private DateTimePicker dtpFrom;
        private ComboBox cbTimestamp;
        private DateTimePicker dtpTo;
        private Label lbTimestamp;
        private GroupBox gbStatistic;
        private Label lbQuantityCurrency;
        private TextBox txtSell;
        private Label lbSellCurrency;
        private Label lbSell;
        private Button btnExport;
        private TextBox txtSalary;
        private Label lbQuantity;
    }
}