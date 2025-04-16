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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lbTimeStamp = new Label();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            cbTimeStamp = new Guna.UI2.WinForms.Guna2ComboBox();
            dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnAttend = new Guna.UI2.WinForms.Guna2Button();
            lbHour = new Label();
            lbAttendStatus = new Label();
            realTimeClock = new System.Windows.Forms.Timer(components);
            pnFromTo = new FlowLayoutPanel();
            lbFrom = new Label();
            lbTo = new Label();
            pnAttend = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pnFromTo.SuspendLayout();
            pnAttend.SuspendLayout();
            SuspendLayout();
            // 
            // lbTimeStamp
            // 
            lbTimeStamp.AutoSize = true;
            lbTimeStamp.ForeColor = Color.FromArgb(59, 93, 79);
            lbTimeStamp.Location = new Point(15, 4);
            lbTimeStamp.Name = "lbTimeStamp";
            lbTimeStamp.Size = new Size(101, 20);
            lbTimeStamp.TabIndex = 5;
            lbTimeStamp.Text = "Mốc thời gian";
            // 
            // dgv
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv.ColumnHeadersHeight = 4;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle6;
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.Location = new Point(229, 4);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(953, 635);
            dgv.TabIndex = 7;
            dgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv.ThemeStyle.BackColor = Color.White;
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
            // cbTimeStamp
            // 
            cbTimeStamp.BackColor = Color.Transparent;
            cbTimeStamp.CustomizableEdges = customizableEdges11;
            cbTimeStamp.DrawMode = DrawMode.OwnerDrawFixed;
            cbTimeStamp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTimeStamp.FocusedColor = Color.FromArgb(94, 148, 255);
            cbTimeStamp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbTimeStamp.Font = new Font("Segoe UI", 10F);
            cbTimeStamp.ForeColor = Color.FromArgb(59, 93, 79);
            cbTimeStamp.ItemHeight = 30;
            cbTimeStamp.Location = new Point(15, 34);
            cbTimeStamp.Name = "cbTimeStamp";
            cbTimeStamp.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cbTimeStamp.Size = new Size(191, 36);
            cbTimeStamp.TabIndex = 8;
            // 
            // dtpFrom
            // 
            dtpFrom.Checked = true;
            dtpFrom.CustomizableEdges = customizableEdges13;
            dtpFrom.FillColor = Color.FromArgb(59, 93, 79);
            dtpFrom.Font = new Font("Segoe UI", 9F);
            dtpFrom.ForeColor = Color.White;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(3, 23);
            dtpFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.ShadowDecoration.CustomizableEdges = customizableEdges14;
            dtpFrom.Size = new Size(194, 45);
            dtpFrom.TabIndex = 9;
            dtpFrom.Value = new DateTime(2025, 4, 14, 10, 42, 36, 85);
            // 
            // dtpTo
            // 
            dtpTo.Checked = true;
            dtpTo.CustomizableEdges = customizableEdges15;
            dtpTo.FillColor = Color.FromArgb(59, 93, 79);
            dtpTo.Font = new Font("Segoe UI", 9F);
            dtpTo.ForeColor = Color.White;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(3, 94);
            dtpTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.ShadowDecoration.CustomizableEdges = customizableEdges16;
            dtpTo.Size = new Size(194, 45);
            dtpTo.TabIndex = 10;
            dtpTo.Value = new DateTime(2025, 4, 14, 10, 42, 5, 478);
            // 
            // btnRefresh
            // 
            btnRefresh.CustomizableEdges = customizableEdges17;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(59, 93, 79);
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(12, 254);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnRefresh.Size = new Size(194, 56);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Làm mới";
            // 
            // btnAttend
            // 
            btnAttend.CustomizableEdges = customizableEdges19;
            btnAttend.DisabledState.BorderColor = Color.DarkGray;
            btnAttend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAttend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAttend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAttend.FillColor = Color.FromArgb(59, 93, 79);
            btnAttend.Font = new Font("Segoe UI", 9F);
            btnAttend.ForeColor = Color.White;
            btnAttend.Location = new Point(3, 23);
            btnAttend.Name = "btnAttend";
            btnAttend.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnAttend.Size = new Size(191, 56);
            btnAttend.TabIndex = 12;
            btnAttend.Text = "Chấm công";
            btnAttend.Click += btnAttend_Click;
            // 
            // lbHour
            // 
            lbHour.AutoSize = true;
            lbHour.ForeColor = Color.FromArgb(59, 93, 79);
            lbHour.Location = new Point(3, 0);
            lbHour.Name = "lbHour";
            lbHour.Size = new Size(41, 20);
            lbHour.TabIndex = 13;
            lbHour.Text = "adsd";
            // 
            // lbAttendStatus
            // 
            lbAttendStatus.AutoSize = true;
            lbAttendStatus.ForeColor = Color.FromArgb(59, 93, 79);
            lbAttendStatus.Location = new Point(3, 82);
            lbAttendStatus.Name = "lbAttendStatus";
            lbAttendStatus.Size = new Size(49, 20);
            lbAttendStatus.TabIndex = 14;
            lbAttendStatus.Text = "sadad";
            // 
            // pnFromTo
            // 
            pnFromTo.Controls.Add(lbFrom);
            pnFromTo.Controls.Add(dtpFrom);
            pnFromTo.Controls.Add(lbTo);
            pnFromTo.Controls.Add(dtpTo);
            pnFromTo.Location = new Point(12, 76);
            pnFromTo.Name = "pnFromTo";
            pnFromTo.Size = new Size(203, 155);
            pnFromTo.TabIndex = 15;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.BackColor = SystemColors.Control;
            lbFrom.Location = new Point(3, 0);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(26, 20);
            lbFrom.TabIndex = 16;
            lbFrom.Text = "Từ";
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new Point(3, 71);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(36, 20);
            lbTo.TabIndex = 17;
            lbTo.Text = "Đến";
            // 
            // pnAttend
            // 
            pnAttend.Controls.Add(lbHour);
            pnAttend.Controls.Add(btnAttend);
            pnAttend.Controls.Add(lbAttendStatus);
            pnAttend.Location = new Point(5, 387);
            pnAttend.Name = "pnAttend";
            pnAttend.Size = new Size(218, 125);
            pnAttend.TabIndex = 16;
            // 
            // frmAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(pnAttend);
            Controls.Add(pnFromTo);
            Controls.Add(btnRefresh);
            Controls.Add(cbTimeStamp);
            Controls.Add(dgv);
            Controls.Add(lbTimeStamp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAttendance";
            Text = "Báo cáo chấm công của ";
            Load += frmAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pnFromTo.ResumeLayout(false);
            pnFromTo.PerformLayout();
            pnAttend.ResumeLayout(false);
            pnAttend.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbTimeStamp;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2ComboBox cbTimeStamp;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAttend;
        private Label lbHour;
        private Label lbAttendStatus;
        private System.Windows.Forms.Timer realTimeClock;
        private FlowLayoutPanel pnFromTo;
        private Label lbFrom;
        private Label lbTo;
        private FlowLayoutPanel pnAttend;
    }
}