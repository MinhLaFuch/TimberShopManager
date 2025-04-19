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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grInfor = new GroupBox();
            grFunction = new GroupBox();
            panel1 = new Panel();
            rdbMonth = new RadioButton();
            rdbDay = new RadioButton();
            dtpTimeView = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lbTimeView = new Label();
            label1 = new Label();
            label2 = new Label();
            lbTotalExpenses = new Label();
            lbTotalRevenue = new Label();
            lbProfit = new Label();
            txtName = new TextBox();
            txtTotalExpenses = new TextBox();
            txtTotalRevenue = new TextBox();
            txtPofit = new TextBox();
            dtpTimeReport = new Guna.UI2.WinForms.Guna2DateTimePicker();
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
            textBox1.Location = new Point(136, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
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
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(884, 740);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            // 
            // grInfor
            // 
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
            grInfor.Location = new Point(884, 124);
            grInfor.Name = "grInfor";
            grInfor.Size = new Size(473, 268);
            grInfor.TabIndex = 1;
            grInfor.TabStop = false;
            grInfor.Text = "Thông tin";
            // 
            // grFunction
            // 
            grFunction.Controls.Add(panel1);
            grFunction.Controls.Add(dtpTimeView);
            grFunction.Controls.Add(lbTimeView);
            grFunction.Dock = DockStyle.Top;
            grFunction.Location = new Point(884, 0);
            grFunction.Name = "grFunction";
            grFunction.Size = new Size(473, 127);
            grFunction.TabIndex = 2;
            grFunction.TabStop = false;
            grFunction.Text = "Chức năng";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdbMonth);
            panel1.Controls.Add(rdbDay);
            panel1.Location = new Point(42, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 24);
            panel1.TabIndex = 2;
            // 
            // rdbMonth
            // 
            rdbMonth.AutoSize = true;
            rdbMonth.Location = new Point(161, 3);
            rdbMonth.Name = "rdbMonth";
            rdbMonth.Size = new Size(85, 19);
            rdbMonth.TabIndex = 1;
            rdbMonth.TabStop = true;
            rdbMonth.Text = "Theo tháng";
            rdbMonth.UseVisualStyleBackColor = true;
            // 
            // rdbDay
            // 
            rdbDay.AutoSize = true;
            rdbDay.Location = new Point(40, 4);
            rdbDay.Name = "rdbDay";
            rdbDay.Size = new Size(80, 19);
            rdbDay.TabIndex = 0;
            rdbDay.TabStop = true;
            rdbDay.Text = "Theo ngày";
            rdbDay.UseVisualStyleBackColor = true;
            // 
            // dtpTimeView
            // 
            dtpTimeView.Checked = true;
            dtpTimeView.CustomFormat = "MM/yyyy";
            dtpTimeView.CustomizableEdges = customizableEdges3;
            dtpTimeView.Font = new Font("Segoe UI", 9F);
            dtpTimeView.Format = DateTimePickerFormat.Custom;
            dtpTimeView.Location = new Point(131, 64);
            dtpTimeView.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTimeView.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTimeView.Name = "dtpTimeView";
            dtpTimeView.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpTimeView.ShowUpDown = true;
            dtpTimeView.Size = new Size(200, 36);
            dtpTimeView.TabIndex = 1;
            dtpTimeView.Value = new DateTime(2025, 4, 20, 0, 12, 18, 753);
            // 
            // lbTimeView
            // 
            lbTimeView.AutoSize = true;
            lbTimeView.Location = new Point(42, 75);
            lbTimeView.Name = "lbTimeView";
            lbTimeView.Size = new Size(56, 15);
            lbTimeView.TabIndex = 0;
            lbTimeView.Text = "Thời gian";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên kế toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 75);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày lập báo cáo";
            // 
            // lbTotalExpenses
            // 
            lbTotalExpenses.AutoSize = true;
            lbTotalExpenses.Location = new Point(29, 115);
            lbTotalExpenses.Name = "lbTotalExpenses";
            lbTotalExpenses.Size = new Size(53, 15);
            lbTotalExpenses.TabIndex = 2;
            lbTotalExpenses.Text = "Tổng chi";
            // 
            // lbTotalRevenue
            // 
            lbTotalRevenue.AutoSize = true;
            lbTotalRevenue.Location = new Point(29, 155);
            lbTotalRevenue.Name = "lbTotalRevenue";
            lbTotalRevenue.Size = new Size(55, 15);
            lbTotalRevenue.TabIndex = 3;
            lbTotalRevenue.Text = "Tổng thu";
            // 
            // lbProfit
            // 
            lbProfit.AutoSize = true;
            lbProfit.Location = new Point(29, 195);
            lbProfit.Name = "lbProfit";
            lbProfit.Size = new Size(60, 15);
            lbProfit.TabIndex = 4;
            lbProfit.Text = "Lợi nhuận";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(138, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 23);
            txtName.TabIndex = 5;
            // 
            // txtTotalExpenses
            // 
            txtTotalExpenses.Enabled = false;
            txtTotalExpenses.Location = new Point(138, 112);
            txtTotalExpenses.Name = "txtTotalExpenses";
            txtTotalExpenses.Size = new Size(278, 23);
            txtTotalExpenses.TabIndex = 6;
            // 
            // txtTotalRevenue
            // 
            txtTotalRevenue.Enabled = false;
            txtTotalRevenue.Location = new Point(138, 152);
            txtTotalRevenue.Name = "txtTotalRevenue";
            txtTotalRevenue.Size = new Size(278, 23);
            txtTotalRevenue.TabIndex = 7;
            // 
            // txtPofit
            // 
            txtPofit.Enabled = false;
            txtPofit.Location = new Point(138, 192);
            txtPofit.Name = "txtPofit";
            txtPofit.Size = new Size(278, 23);
            txtPofit.TabIndex = 8;
            // 
            // dtpTimeReport
            // 
            dtpTimeReport.Checked = true;
            dtpTimeReport.CustomFormat = "dd/MM/yyyy";
            dtpTimeReport.CustomizableEdges = customizableEdges1;
            dtpTimeReport.Font = new Font("Segoe UI", 9F);
            dtpTimeReport.Format = DateTimePickerFormat.Custom;
            dtpTimeReport.Location = new Point(138, 65);
            dtpTimeReport.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTimeReport.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTimeReport.Name = "dtpTimeReport";
            dtpTimeReport.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpTimeReport.Size = new Size(278, 36);
            dtpTimeReport.TabIndex = 9;
            dtpTimeReport.Value = new DateTime(2025, 4, 20, 0, 23, 42, 562);
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeight = 4;
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
            dgv.Location = new Point(884, 398);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.Size = new Size(473, 342);
            dgv.TabIndex = 3;
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
            dgv.ThemeStyle.HeaderStyle.Height = 4;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 740);
            Controls.Add(dgv);
            Controls.Add(grFunction);
            Controls.Add(grInfor);
            Controls.Add(chart);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}