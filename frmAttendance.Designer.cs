namespace timber_shop_manager
{
    partial class frmAttendance
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            realTimeClock = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            btnAttend = new Guna.UI2.WinForms.Guna2Button();
            pnFromTo = new FlowLayoutPanel();
            lbFrom = new Label();
            dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lbTo = new Label();
            dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            cbTimeStamp = new Guna.UI2.WinForms.Guna2ComboBox();
            lbTimeStamp = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel1.SuspendLayout();
            pnFromTo.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
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
            dgv.Dock = DockStyle.Fill;
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.Location = new Point(0, 0);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1046, 537);
            dgv.TabIndex = 7;
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
            dgv.ThemeStyle.ReadOnly = false;
            dgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgv.ThemeStyle.RowsStyle.Height = 29;
            dgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAttend);
            panel1.Controls.Add(pnFromTo);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(cbTimeStamp);
            panel1.Controls.Add(lbTimeStamp);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 537);
            panel1.TabIndex = 8;
            // 
            // btnAttend
            // 
            btnAttend.CustomizableEdges = customizableEdges1;
            btnAttend.DisabledState.BorderColor = Color.DarkGray;
            btnAttend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAttend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAttend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAttend.FillColor = Color.FromArgb(59, 93, 79);
            btnAttend.Font = new Font("Segoe UI", 9F);
            btnAttend.ForeColor = Color.White;
            btnAttend.Location = new Point(10, 281);
            btnAttend.Margin = new Padding(3, 2, 3, 2);
            btnAttend.Name = "btnAttend";
            btnAttend.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAttend.Size = new Size(175, 42);
            btnAttend.TabIndex = 12;
            btnAttend.Text = "Chấm công";
            // 
            // pnFromTo
            // 
            pnFromTo.Controls.Add(lbFrom);
            pnFromTo.Controls.Add(dtpFrom);
            pnFromTo.Controls.Add(lbTo);
            pnFromTo.Controls.Add(dtpTo);
            pnFromTo.Location = new Point(9, 105);
            pnFromTo.Margin = new Padding(3, 2, 3, 2);
            pnFromTo.Name = "pnFromTo";
            pnFromTo.Size = new Size(178, 116);
            pnFromTo.TabIndex = 20;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.BackColor = SystemColors.Control;
            lbFrom.Location = new Point(3, 0);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(20, 15);
            lbFrom.TabIndex = 16;
            lbFrom.Text = "Từ";
            // 
            // dtpFrom
            // 
            dtpFrom.Checked = true;
            dtpFrom.CustomizableEdges = customizableEdges3;
            dtpFrom.FillColor = Color.FromArgb(59, 93, 79);
            dtpFrom.Font = new Font("Segoe UI", 9F);
            dtpFrom.ForeColor = Color.White;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(3, 17);
            dtpFrom.Margin = new Padding(3, 2, 3, 2);
            dtpFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpFrom.Size = new Size(170, 34);
            dtpFrom.TabIndex = 9;
            dtpFrom.Value = new DateTime(2025, 4, 14, 10, 42, 36, 85);
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new Point(3, 53);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(28, 15);
            lbTo.TabIndex = 17;
            lbTo.Text = "Đến";
            // 
            // dtpTo
            // 
            dtpTo.Checked = true;
            dtpTo.CustomizableEdges = customizableEdges5;
            dtpTo.FillColor = Color.FromArgb(59, 93, 79);
            dtpTo.Font = new Font("Segoe UI", 9F);
            dtpTo.ForeColor = Color.White;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(3, 70);
            dtpTo.Margin = new Padding(3, 2, 3, 2);
            dtpTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpTo.Size = new Size(170, 34);
            dtpTo.TabIndex = 10;
            dtpTo.Value = new DateTime(2025, 4, 14, 10, 42, 5, 478);
            // 
            // btnRefresh
            // 
            btnRefresh.CustomizableEdges = customizableEdges7;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(59, 93, 79);
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(9, 225);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRefresh.Size = new Size(176, 42);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Làm mới";
            // 
            // cbTimeStamp
            // 
            cbTimeStamp.BackColor = Color.Transparent;
            cbTimeStamp.CustomizableEdges = customizableEdges9;
            cbTimeStamp.DrawMode = DrawMode.OwnerDrawFixed;
            cbTimeStamp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTimeStamp.FocusedColor = Color.FromArgb(94, 148, 255);
            cbTimeStamp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbTimeStamp.Font = new Font("Segoe UI", 10F);
            cbTimeStamp.ForeColor = Color.FromArgb(59, 93, 79);
            cbTimeStamp.ItemHeight = 30;
            cbTimeStamp.Location = new Point(14, 43);
            cbTimeStamp.Margin = new Padding(3, 2, 3, 2);
            cbTimeStamp.Name = "cbTimeStamp";
            cbTimeStamp.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbTimeStamp.Size = new Size(168, 36);
            cbTimeStamp.TabIndex = 18;
            // 
            // lbTimeStamp
            // 
            lbTimeStamp.AutoSize = true;
            lbTimeStamp.ForeColor = Color.FromArgb(59, 93, 79);
            lbTimeStamp.Location = new Point(14, 20);
            lbTimeStamp.Name = "lbTimeStamp";
            lbTimeStamp.Size = new Size(81, 15);
            lbTimeStamp.TabIndex = 17;
            lbTimeStamp.Text = "Mốc thời gian";
            // 
            // frmAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 537);
            Controls.Add(panel1);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAttendance";
            Text = "Báo cáo chấm công của ";
            Load += frmAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnFromTo.ResumeLayout(false);
            pnFromTo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private System.Windows.Forms.Timer realTimeClock;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAttend;
        private FlowLayoutPanel pnFromTo;
        private Label lbFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Label lbTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2ComboBox cbTimeStamp;
        private Label lbTimeStamp;
    }
}