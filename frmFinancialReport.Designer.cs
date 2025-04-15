namespace timber_shop_manager
{
    partial class frmFinancialReport
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
            btnExport = new Button();
            btnRefresh = new Button();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            lbTimestamp = new Label();
            textBox1 = new TextBox();
            txtImport = new TextBox();
            txtSalary = new TextBox();
            cbTimestamp = new ComboBox();
            gbTime = new GroupBox();
            lbTo = new Label();
            lbFrom = new Label();
            gbStatistic = new GroupBox();
            lbProfitCurrency = new Label();
            lbImportCurrency = new Label();
            lbSalaryCurrency = new Label();
            lbProfit = new Label();
            txtProfit = new TextBox();
            txtSell = new TextBox();
            lbSellCurrency = new Label();
            lbImport = new Label();
            lbSalary = new Label();
            lbSell = new Label();
            gbTime.SuspendLayout();
            gbStatistic.SuspendLayout();
            SuspendLayout();
            // 
            // btnExport
            // 
            btnExport.Location = new Point(349, 133);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(117, 25);
            btnExport.TabIndex = 0;
            btnExport.Text = "Xuất báo cáo";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += button1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(170, 129);
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
            // textBox1
            // 
            textBox1.Location = new Point(136, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtImport
            // 
            txtImport.Location = new Point(164, 96);
            txtImport.Name = "txtImport";
            txtImport.ReadOnly = true;
            txtImport.Size = new Size(100, 27);
            txtImport.TabIndex = 18;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(164, 53);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(100, 27);
            txtSalary.TabIndex = 19;
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
            // gbTime
            // 
            gbTime.Controls.Add(lbTo);
            gbTime.Controls.Add(lbFrom);
            gbTime.Controls.Add(btnRefresh);
            gbTime.Controls.Add(dtpFrom);
            gbTime.Controls.Add(cbTimestamp);
            gbTime.Controls.Add(dtpTo);
            gbTime.Controls.Add(lbTimestamp);
            gbTime.Location = new Point(3, 1);
            gbTime.Name = "gbTime";
            gbTime.Size = new Size(298, 164);
            gbTime.TabIndex = 13;
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
            // gbStatistic
            // 
            gbStatistic.Controls.Add(lbProfitCurrency);
            gbStatistic.Controls.Add(lbImportCurrency);
            gbStatistic.Controls.Add(lbSalaryCurrency);
            gbStatistic.Controls.Add(lbProfit);
            gbStatistic.Controls.Add(txtProfit);
            gbStatistic.Controls.Add(txtSell);
            gbStatistic.Controls.Add(lbSellCurrency);
            gbStatistic.Controls.Add(lbImport);
            gbStatistic.Controls.Add(txtImport);
            gbStatistic.Controls.Add(lbSalary);
            gbStatistic.Controls.Add(lbSell);
            gbStatistic.Controls.Add(btnExport);
            gbStatistic.Controls.Add(txtSalary);
            gbStatistic.Location = new Point(322, 12);
            gbStatistic.Name = "gbStatistic";
            gbStatistic.Size = new Size(466, 164);
            gbStatistic.TabIndex = 14;
            gbStatistic.TabStop = false;
            gbStatistic.Text = "Thông số";
            // 
            // lbProfitCurrency
            // 
            lbProfitCurrency.AutoSize = true;
            lbProfitCurrency.Location = new Point(284, 133);
            lbProfitCurrency.Name = "lbProfitCurrency";
            lbProfitCurrency.Size = new Size(40, 20);
            lbProfitCurrency.TabIndex = 16;
            lbProfitCurrency.Text = "VND";
            // 
            // lbImportCurrency
            // 
            lbImportCurrency.AutoSize = true;
            lbImportCurrency.Location = new Point(284, 96);
            lbImportCurrency.Name = "lbImportCurrency";
            lbImportCurrency.Size = new Size(40, 20);
            lbImportCurrency.TabIndex = 17;
            lbImportCurrency.Text = "VND";
            // 
            // lbSalaryCurrency
            // 
            lbSalaryCurrency.AutoSize = true;
            lbSalaryCurrency.Location = new Point(284, 60);
            lbSalaryCurrency.Name = "lbSalaryCurrency";
            lbSalaryCurrency.Size = new Size(40, 20);
            lbSalaryCurrency.TabIndex = 18;
            lbSalaryCurrency.Text = "VND";
            // 
            // lbProfit
            // 
            lbProfit.AutoSize = true;
            lbProfit.Location = new Point(58, 138);
            lbProfit.Name = "lbProfit";
            lbProfit.Size = new Size(73, 20);
            lbProfit.TabIndex = 20;
            lbProfit.Text = "Lợi nhuận";
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(164, 135);
            txtProfit.Name = "txtProfit";
            txtProfit.ReadOnly = true;
            txtProfit.Size = new Size(100, 27);
            txtProfit.TabIndex = 21;
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
            // lbImport
            // 
            lbImport.AutoSize = true;
            lbImport.Location = new Point(58, 96);
            lbImport.Name = "lbImport";
            lbImport.Size = new Size(82, 20);
            lbImport.TabIndex = 17;
            lbImport.Text = "Nhập hàng";
            // 
            // lbSalary
            // 
            lbSalary.AutoSize = true;
            lbSalary.Location = new Point(40, 60);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(118, 20);
            lbSalary.TabIndex = 16;
            lbSalary.Text = "Lương nhân viên";
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
            // frmFinancialReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 712);
            Controls.Add(gbStatistic);
            Controls.Add(gbTime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFinancialReport";
            Text = "Báo cáo tài chính";
            Load += frmFinancialReport_Load;
            gbTime.ResumeLayout(false);
            gbTime.PerformLayout();
            gbStatistic.ResumeLayout(false);
            gbStatistic.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExport;
        private Button btnRefresh;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label lbTimestamp;
        private TextBox textBox1;
        private TextBox txtImport;
        private TextBox txtSalary;
        private ComboBox cbTimestamp;
        private Label lbSalaryCurrency;
        private GroupBox gbTime;
        private GroupBox gbStatistic;
        private Label lbSell;
        private Label lbImport;
        private Label lbSalary;
        private Label lbTo;
        private Label lbFrom;
        private Label lbProfit;
        private TextBox txtProfit;
        private TextBox txtSell;
        private Label lbSellCurrency;
        private Label lbProfitCurrency;
        private Label lbImportCurrency;
    }
}