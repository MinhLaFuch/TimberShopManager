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
            lbTimeStamp = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            cbTimeStamp = new Guna.UI2.WinForms.Guna2ComboBox();
            dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnAttend = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lbTimeStamp
            // 
            lbTimeStamp.AutoSize = true;
            lbTimeStamp.Location = new Point(-1, 9);
            lbTimeStamp.Name = "lbTimeStamp";
            lbTimeStamp.Size = new Size(101, 20);
            lbTimeStamp.TabIndex = 5;
            lbTimeStamp.Text = "Mốc thời gian";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            cbTimeStamp.CustomizableEdges = customizableEdges1;
            cbTimeStamp.DrawMode = DrawMode.OwnerDrawFixed;
            cbTimeStamp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTimeStamp.FocusedColor = Color.FromArgb(94, 148, 255);
            cbTimeStamp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbTimeStamp.Font = new Font("Segoe UI", 10F);
            cbTimeStamp.ForeColor = Color.FromArgb(68, 88, 112);
            cbTimeStamp.ItemHeight = 30;
            cbTimeStamp.Location = new Point(15, 34);
            cbTimeStamp.Name = "cbTimeStamp";
            cbTimeStamp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbTimeStamp.Size = new Size(191, 36);
            cbTimeStamp.TabIndex = 8;
            // 
            // dtpFrom
            // 
            dtpFrom.Checked = true;
            dtpFrom.CustomizableEdges = customizableEdges3;
            dtpFrom.FillColor = Color.FromArgb(59, 93, 79);
            dtpFrom.Font = new Font("Segoe UI", 9F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(12, 91);
            dtpFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpFrom.Size = new Size(194, 45);
            dtpFrom.TabIndex = 9;
            dtpFrom.Value = new DateTime(2025, 4, 14, 10, 42, 36, 85);
            // 
            // dtpTo
            // 
            dtpTo.Checked = true;
            dtpTo.CustomizableEdges = customizableEdges5;
            dtpTo.FillColor = Color.FromArgb(59, 93, 79);
            dtpTo.Font = new Font("Segoe UI", 9F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(15, 151);
            dtpTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpTo.Size = new Size(191, 45);
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
            btnRefresh.Location = new Point(12, 224);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRefresh.Size = new Size(194, 56);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Làm mới";
            // 
            // btnAttend
            // 
            btnAttend.CustomizableEdges = customizableEdges9;
            btnAttend.DisabledState.BorderColor = Color.DarkGray;
            btnAttend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAttend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAttend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAttend.FillColor = Color.FromArgb(59, 93, 79);
            btnAttend.Font = new Font("Segoe UI", 9F);
            btnAttend.ForeColor = Color.White;
            btnAttend.Location = new Point(15, 394);
            btnAttend.Name = "btnAttend";
            btnAttend.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAttend.Size = new Size(191, 56);
            btnAttend.TabIndex = 12;
            btnAttend.Text = "Chấm công";
            // 
            // frmAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(btnAttend);
            Controls.Add(btnRefresh);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(cbTimeStamp);
            Controls.Add(dgv);
            Controls.Add(lbTimeStamp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAttendance";
            Text = "Báo cáo chấm công của ";
            Load += frmAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
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
    }
}