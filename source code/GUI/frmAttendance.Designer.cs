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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendance));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            realTimeClock = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lbEmployeeId = new Label();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            lbRealTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnAttend = new Guna.UI2.WinForms.Guna2Button();
            pnFromTo = new FlowLayoutPanel();
            dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            pictureBox1 = new PictureBox();
            dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pnTop = new Panel();
            nCB = new ReaLTaiizor.Controls.NightControlBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel1.SuspendLayout();
            pnFromTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            pnTop.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
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
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.Location = new Point(3, 108);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(971, 608);
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
            dgv.ThemeStyle.ReadOnly = false;
            dgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgv.ThemeStyle.RowsStyle.Height = 29;
            dgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // realTimeClock
            // 
            realTimeClock.Tick += realTimeClock_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Controls.Add(lbEmployeeId);
            panel1.Controls.Add(lbRealTime);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 716);
            panel1.TabIndex = 0;
            // 
            // lbEmployeeId
            // 
            lbEmployeeId.AutoSize = true;
            lbEmployeeId.Location = new Point(17, 684);
            lbEmployeeId.Name = "lbEmployeeId";
            lbEmployeeId.Size = new Size(101, 20);
            lbEmployeeId.TabIndex = 3;
            lbEmployeeId.Text = "lbEmployeeId";
            lbEmployeeId.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.CustomizableEdges = customizableEdges3;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(59, 93, 79);
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(3, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearch.Size = new Size(201, 56);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // lbRealTime
            // 
            lbRealTime.AutoSize = false;
            lbRealTime.BackColor = Color.Transparent;
            lbRealTime.BorderStyle = BorderStyle.Fixed3D;
            lbRealTime.Location = new Point(14, 16);
            lbRealTime.Margin = new Padding(3, 4, 3, 4);
            lbRealTime.Name = "lbRealTime";
            lbRealTime.Size = new Size(199, 67);
            lbRealTime.TabIndex = 0;
            lbRealTime.Text = "guna2HtmlLabel1";
            lbRealTime.TextAlignment = ContentAlignment.MiddleCenter;
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
            btnAttend.Location = new Point(3, 3);
            btnAttend.Name = "btnAttend";
            btnAttend.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAttend.Size = new Size(200, 56);
            btnAttend.TabIndex = 1;
            btnAttend.Text = "Chấm công";
            btnAttend.Click += btnAttend_Click;
            // 
            // pnFromTo
            // 
            pnFromTo.Controls.Add(dtpFrom);
            pnFromTo.Controls.Add(pictureBox1);
            pnFromTo.Controls.Add(dtpTo);
            pnFromTo.Controls.Add(flowLayoutPanel1);
            pnFromTo.Location = new Point(3, 46);
            pnFromTo.Name = "pnFromTo";
            pnFromTo.Size = new Size(512, 56);
            pnFromTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            dtpFrom.Checked = true;
            dtpFrom.CustomFormat = "dd/MM/yyyy";
            dtpFrom.CustomizableEdges = customizableEdges5;
            dtpFrom.FillColor = Color.FromArgb(59, 93, 79);
            dtpFrom.Font = new Font("Segoe UI", 9F);
            dtpFrom.ForeColor = Color.White;
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(3, 3);
            dtpFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpFrom.Size = new Size(194, 45);
            dtpFrom.TabIndex = 0;
            dtpFrom.Value = new DateTime(2025, 4, 14, 10, 42, 36, 85);
            dtpFrom.ValueChanged += dtpValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // dtpTo
            // 
            dtpTo.Checked = true;
            dtpTo.CustomFormat = "dd/MM/yyyy";
            dtpTo.CustomizableEdges = customizableEdges7;
            dtpTo.FillColor = Color.FromArgb(59, 93, 79);
            dtpTo.Font = new Font("Segoe UI", 9F);
            dtpTo.ForeColor = Color.White;
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(290, 3);
            dtpTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpTo.Size = new Size(194, 45);
            dtpTo.TabIndex = 1;
            dtpTo.Value = new DateTime(2025, 4, 14, 10, 42, 5, 478);
            dtpTo.ValueChanged += dtpValueChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 56);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 125);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pnTop);
            flowLayoutPanel2.Controls.Add(pnFromTo);
            flowLayoutPanel2.Controls.Add(dgv);
            flowLayoutPanel2.Location = new Point(224, -5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(971, 721);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(59, 93, 79);
            pnTop.Controls.Add(nCB);
            pnTop.Location = new Point(3, 3);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(968, 37);
            pnTop.TabIndex = 5;
            // 
            // nCB
            // 
            nCB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nCB.BackColor = Color.Transparent;
            nCB.CloseHoverColor = Color.FromArgb(59, 93, 79);
            nCB.CloseHoverForeColor = Color.White;
            nCB.DefaultLocation = true;
            nCB.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nCB.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nCB.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nCB.EnableMaximizeButton = true;
            nCB.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nCB.EnableMinimizeButton = true;
            nCB.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nCB.Location = new Point(829, 0);
            nCB.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nCB.MaximizeHoverForeColor = Color.White;
            nCB.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nCB.MinimizeHoverForeColor = Color.White;
            nCB.Name = "nCB";
            nCB.Size = new Size(139, 31);
            nCB.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btnAttend);
            flowLayoutPanel3.Controls.Add(btnSearch);
            flowLayoutPanel3.Location = new Point(14, 90);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(207, 125);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // frmAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 716);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAttendance";
            Load += frmAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnFromTo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            pnTop.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private System.Windows.Forms.Timer realTimeClock;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAttend;
        private FlowLayoutPanel pnFromTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbRealTime;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Label lbEmployeeId;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pnTop;
        private ReaLTaiizor.Controls.NightControlBox nCB;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}