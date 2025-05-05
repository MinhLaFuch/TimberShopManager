namespace timber_shop_manager
{
    partial class frmFinancial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grInfor = new GroupBox();
            btnPrint = new Guna.UI2.WinForms.Guna2Button();
            dtpTimeReport = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtPofit = new TextBox();
            txtTotalRevenue = new TextBox();
            txtTotalExpenses = new TextBox();
            txtName = new TextBox();
            lbProfit = new Label();
            lbTotalRevenue = new Label();
            lbTotalExpenses = new Label();
            label2 = new Label();
            label1 = new Label();
            grFunction = new GroupBox();
            panel1 = new Panel();
            rdbMonth = new RadioButton();
            rdbDay = new RadioButton();
            dtpTimeView = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lbTimeView = new Label();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            grInfor.SuspendLayout();
            grFunction.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 0;
            // 
            // chart
            // 
            chart.BorderlineColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Dock = DockStyle.Left;
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(0, 0);
            chart.Margin = new Padding(3, 4, 3, 4);
            chart.Name = "chart";
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(690, 865);
            chart.TabIndex = 3;
            chart.Text = "chart1";
            // 
            // grInfor
            // 
            grInfor.Controls.Add(btnPrint);
            grInfor.Controls.Add(dtpTimeReport);
            grInfor.Controls.Add(txtPofit);
            grInfor.Controls.Add(txtTotalRevenue);
            grInfor.Controls.Add(txtTotalExpenses);
            grInfor.Controls.Add(txtName);
            grInfor.Controls.Add(lbProfit);
            grInfor.Controls.Add(lbTotalRevenue);
            grInfor.Controls.Add(lbTotalExpenses);
            grInfor.Controls.Add(label2);
            grInfor.Controls.Add(label1);
            grInfor.Location = new Point(690, 166);
            grInfor.Margin = new Padding(3, 4, 3, 4);
            grInfor.Name = "grInfor";
            grInfor.Padding = new Padding(3, 4, 3, 4);
            grInfor.Size = new Size(541, 357);
            grInfor.TabIndex = 1;
            grInfor.TabStop = false;
            grInfor.Text = "Thông tin";
            // 
            // btnPrint
            // 
            btnPrint.BorderColor = Color.BlanchedAlmond;
            btnPrint.CustomizableEdges = customizableEdges1;
            btnPrint.DisabledState.BorderColor = Color.DarkGray;
            btnPrint.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrint.FillColor = Color.FromArgb(59, 93, 79);
            btnPrint.Font = new Font("Segoe UI", 9F);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(158, 313);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPrint.Size = new Size(145, 28);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "In báo cáo";
            btnPrint.Click += btnPrint_Click;
            // 
            // dtpTimeReport
            // 
            dtpTimeReport.BackColor = Color.White;
            dtpTimeReport.Checked = true;
            dtpTimeReport.CustomFormat = "dd/MM/yyyy";
            dtpTimeReport.CustomizableEdges = customizableEdges3;
            dtpTimeReport.Enabled = false;
            dtpTimeReport.FillColor = Color.FromArgb(59, 93, 79);
            dtpTimeReport.Font = new Font("Segoe UI", 9F);
            dtpTimeReport.ForeColor = Color.White;
            dtpTimeReport.Format = DateTimePickerFormat.Custom;
            dtpTimeReport.Location = new Point(158, 87);
            dtpTimeReport.Margin = new Padding(3, 4, 3, 4);
            dtpTimeReport.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTimeReport.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTimeReport.Name = "dtpTimeReport";
            dtpTimeReport.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpTimeReport.Size = new Size(318, 48);
            dtpTimeReport.TabIndex = 3;
            dtpTimeReport.Value = new DateTime(2025, 4, 20, 0, 23, 42, 562);
            // 
            // txtPofit
            // 
            txtPofit.BackColor = Color.White;
            txtPofit.BorderStyle = BorderStyle.None;
            txtPofit.Enabled = false;
            txtPofit.Location = new Point(158, 256);
            txtPofit.Margin = new Padding(3, 4, 3, 4);
            txtPofit.Name = "txtPofit";
            txtPofit.Size = new Size(317, 20);
            txtPofit.TabIndex = 9;
            // 
            // txtTotalRevenue
            // 
            txtTotalRevenue.BackColor = Color.White;
            txtTotalRevenue.BorderStyle = BorderStyle.None;
            txtTotalRevenue.Enabled = false;
            txtTotalRevenue.Location = new Point(158, 203);
            txtTotalRevenue.Margin = new Padding(3, 4, 3, 4);
            txtTotalRevenue.Name = "txtTotalRevenue";
            txtTotalRevenue.Size = new Size(317, 20);
            txtTotalRevenue.TabIndex = 7;
            // 
            // txtTotalExpenses
            // 
            txtTotalExpenses.BackColor = Color.White;
            txtTotalExpenses.BorderStyle = BorderStyle.None;
            txtTotalExpenses.Enabled = false;
            txtTotalExpenses.Location = new Point(158, 149);
            txtTotalExpenses.Margin = new Padding(3, 4, 3, 4);
            txtTotalExpenses.Name = "txtTotalExpenses";
            txtTotalExpenses.Size = new Size(317, 20);
            txtTotalExpenses.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Enabled = false;
            txtName.Location = new Point(158, 43);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(317, 20);
            txtName.TabIndex = 1;
            // 
            // lbProfit
            // 
            lbProfit.AutoSize = true;
            lbProfit.Location = new Point(33, 260);
            lbProfit.Name = "lbProfit";
            lbProfit.Size = new Size(73, 20);
            lbProfit.TabIndex = 8;
            lbProfit.Text = "Lợi nhuận";
            // 
            // lbTotalRevenue
            // 
            lbTotalRevenue.AutoSize = true;
            lbTotalRevenue.Location = new Point(33, 207);
            lbTotalRevenue.Name = "lbTotalRevenue";
            lbTotalRevenue.Size = new Size(68, 20);
            lbTotalRevenue.TabIndex = 6;
            lbTotalRevenue.Text = "Tổng thu";
            // 
            // lbTotalExpenses
            // 
            lbTotalExpenses.AutoSize = true;
            lbTotalExpenses.Location = new Point(33, 153);
            lbTotalExpenses.Name = "lbTotalExpenses";
            lbTotalExpenses.Size = new Size(66, 20);
            lbTotalExpenses.TabIndex = 4;
            lbTotalExpenses.Text = "Tổng chi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 100);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày lập báo cáo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 47);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên kế toán";
            // 
            // grFunction
            // 
            grFunction.Controls.Add(panel1);
            grFunction.Controls.Add(dtpTimeView);
            grFunction.Controls.Add(lbTimeView);
            grFunction.Dock = DockStyle.Top;
            grFunction.Location = new Point(690, 0);
            grFunction.Margin = new Padding(3, 4, 3, 4);
            grFunction.Name = "grFunction";
            grFunction.Padding = new Padding(3, 4, 3, 4);
            grFunction.Size = new Size(542, 169);
            grFunction.TabIndex = 0;
            grFunction.TabStop = false;
            grFunction.Text = "Chức năng";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdbMonth);
            panel1.Controls.Add(rdbDay);
            panel1.Location = new Point(48, 29);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 32);
            panel1.TabIndex = 0;
            // 
            // rdbMonth
            // 
            rdbMonth.AutoSize = true;
            rdbMonth.Location = new Point(184, 4);
            rdbMonth.Margin = new Padding(3, 4, 3, 4);
            rdbMonth.Name = "rdbMonth";
            rdbMonth.Size = new Size(105, 24);
            rdbMonth.TabIndex = 1;
            rdbMonth.Text = "Theo tháng";
            rdbMonth.UseVisualStyleBackColor = true;
            rdbMonth.CheckedChanged += rdb_CheckedChanged;
            // 
            // rdbDay
            // 
            rdbDay.AutoSize = true;
            rdbDay.Checked = true;
            rdbDay.Location = new Point(46, 5);
            rdbDay.Margin = new Padding(3, 4, 3, 4);
            rdbDay.Name = "rdbDay";
            rdbDay.Size = new Size(99, 24);
            rdbDay.TabIndex = 0;
            rdbDay.TabStop = true;
            rdbDay.Text = "Theo ngày";
            rdbDay.UseVisualStyleBackColor = true;
            rdbDay.CheckedChanged += rdb_CheckedChanged;
            // 
            // dtpTimeView
            // 
            dtpTimeView.Checked = true;
            dtpTimeView.CustomFormat = "MM/yyyy";
            dtpTimeView.CustomizableEdges = customizableEdges5;
            dtpTimeView.FillColor = Color.FromArgb(59, 93, 79);
            dtpTimeView.Font = new Font("Segoe UI", 9F);
            dtpTimeView.ForeColor = Color.White;
            dtpTimeView.Format = DateTimePickerFormat.Custom;
            dtpTimeView.Location = new Point(150, 85);
            dtpTimeView.Margin = new Padding(3, 4, 3, 4);
            dtpTimeView.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTimeView.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTimeView.Name = "dtpTimeView";
            dtpTimeView.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpTimeView.ShowUpDown = true;
            dtpTimeView.Size = new Size(229, 48);
            dtpTimeView.TabIndex = 2;
            dtpTimeView.Value = new DateTime(2025, 4, 20, 0, 12, 18, 753);
            dtpTimeView.ValueChanged += dtpTimeView_ValueChanged;
            // 
            // lbTimeView
            // 
            lbTimeView.AutoSize = true;
            lbTimeView.Location = new Point(48, 100);
            lbTimeView.Name = "lbTimeView";
            lbTimeView.Size = new Size(71, 20);
            lbTimeView.TabIndex = 1;
            lbTimeView.Text = "Thời gian";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(59, 93, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(59, 93, 79);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle3;
            dgv.Dock = DockStyle.Bottom;
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.Location = new Point(690, 531);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(542, 334);
            dgv.TabIndex = 2;
            dgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv.ThemeStyle.BackColor = Color.Gainsboro;
            dgv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ThemeStyle.HeaderStyle.Height = 50;
            dgv.ThemeStyle.ReadOnly = true;
            dgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgv.ThemeStyle.RowsStyle.Height = 25;
            dgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmFinancial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 865);
            Controls.Add(dgv);
            Controls.Add(grFunction);
            Controls.Add(grInfor);
            Controls.Add(chart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFinancial";
            Text = "Báo cáo tài chính";
            Load += frmFinancialReport_Load;
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            grInfor.ResumeLayout(false);
            grInfor.PerformLayout();
            grFunction.ResumeLayout(false);
            grFunction.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private GroupBox grInfor;
        private GroupBox grFunction;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTimeView;
        private Label lbTimeView;
        private Panel panel1;
        private RadioButton rdbMonth;
        private RadioButton rdbDay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTimeReport;
        private TextBox txtPofit;
        private TextBox txtTotalRevenue;
        private TextBox txtTotalExpenses;
        private TextBox txtName;
        private Label lbProfit;
        private Label lbTotalRevenue;
        private Label lbTotalExpenses;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}