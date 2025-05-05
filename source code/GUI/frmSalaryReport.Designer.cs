namespace timber_shop_manager
{
    partial class frmSalaryReport
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryReport));
            pnButton = new FlowLayoutPanel();
            btnCreate = new Guna.UI2.WinForms.Guna2Button();
            dtpDateReport = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtAccountantId = new TextBox();
            grEmployeeInfor = new Guna.UI2.WinForms.Guna2GroupBox();
            pnEmployeeSalary = new Panel();
            txtAbsentDay = new TextBox();
            label1 = new Label();
            txtAttendDay = new TextBox();
            lbAttendDay = new Label();
            lbSalary = new Label();
            lbLateDay = new Label();
            txtSalary = new TextBox();
            txtLateDay = new TextBox();
            pnEmployeeInfo = new Panel();
            txtEmployeeId = new TextBox();
            txtEmployeeName = new TextBox();
            lbEmployeeName = new Label();
            lbID = new Label();
            pnAttendance = new FlowLayoutPanel();
            btnViewAttend = new Guna.UI2.WinForms.Guna2Button();
            dtpReportFor = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            lbDateReport = new Label();
            pnInfo = new FlowLayoutPanel();
            grAcountantInfor = new Guna.UI2.WinForms.Guna2GroupBox();
            pnReport = new Panel();
            txtAccountantName = new TextBox();
            lbAccountantName = new Label();
            lbAccountantId = new Label();
            pnButton.SuspendLayout();
            grEmployeeInfor.SuspendLayout();
            pnEmployeeSalary.SuspendLayout();
            pnEmployeeInfo.SuspendLayout();
            pnAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pnInfo.SuspendLayout();
            grAcountantInfor.SuspendLayout();
            pnReport.SuspendLayout();
            SuspendLayout();
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnCreate);
            pnButton.Location = new Point(0, 208);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(413, 69);
            pnButton.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.CustomizableEdges = customizableEdges1;
            btnCreate.DisabledState.BorderColor = Color.DarkGray;
            btnCreate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreate.FillColor = Color.FromArgb(59, 93, 79);
            btnCreate.Font = new Font("Segoe UI", 9F);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(3, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCreate.Size = new Size(130, 56);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Lập báo cáo";
            btnCreate.Click += btnCreate_Click;
            // 
            // dtpDateReport
            // 
            dtpDateReport.Checked = true;
            dtpDateReport.CustomFormat = "dd/MM/yyyy";
            dtpDateReport.CustomizableEdges = customizableEdges3;
            dtpDateReport.FillColor = Color.FromArgb(59, 93, 79);
            dtpDateReport.Font = new Font("Segoe UI", 9F);
            dtpDateReport.ForeColor = Color.White;
            dtpDateReport.Format = DateTimePickerFormat.Custom;
            dtpDateReport.Location = new Point(111, 5);
            dtpDateReport.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDateReport.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDateReport.Name = "dtpDateReport";
            dtpDateReport.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpDateReport.Size = new Size(198, 45);
            dtpDateReport.TabIndex = 1;
            dtpDateReport.Value = new DateTime(2025, 4, 15, 22, 31, 0, 592);
            // 
            // txtAccountantId
            // 
            txtAccountantId.BackColor = Color.White;
            txtAccountantId.BorderStyle = BorderStyle.None;
            txtAccountantId.ForeColor = Color.FromArgb(59, 93, 79);
            txtAccountantId.Location = new Point(111, 60);
            txtAccountantId.Margin = new Padding(3, 4, 3, 4);
            txtAccountantId.Name = "txtAccountantId";
            txtAccountantId.ReadOnly = true;
            txtAccountantId.Size = new Size(198, 20);
            txtAccountantId.TabIndex = 3;
            // 
            // grEmployeeInfor
            // 
            grEmployeeInfor.Controls.Add(pnEmployeeSalary);
            grEmployeeInfor.Controls.Add(pnEmployeeInfo);
            grEmployeeInfor.Controls.Add(pnAttendance);
            grEmployeeInfor.CustomBorderColor = Color.FromArgb(59, 93, 79);
            grEmployeeInfor.CustomizableEdges = customizableEdges9;
            grEmployeeInfor.FillColor = SystemColors.Control;
            grEmployeeInfor.Font = new Font("Segoe UI", 9F);
            grEmployeeInfor.ForeColor = Color.White;
            grEmployeeInfor.Location = new Point(422, 3);
            grEmployeeInfor.Name = "grEmployeeInfor";
            grEmployeeInfor.ShadowDecoration.CustomizableEdges = customizableEdges10;
            grEmployeeInfor.Size = new Size(768, 280);
            grEmployeeInfor.TabIndex = 1;
            grEmployeeInfor.Text = "Nhân viên";
            // 
            // pnEmployeeSalary
            // 
            pnEmployeeSalary.Controls.Add(txtAbsentDay);
            pnEmployeeSalary.Controls.Add(label1);
            pnEmployeeSalary.Controls.Add(txtAttendDay);
            pnEmployeeSalary.Controls.Add(lbAttendDay);
            pnEmployeeSalary.Controls.Add(lbSalary);
            pnEmployeeSalary.Controls.Add(lbLateDay);
            pnEmployeeSalary.Controls.Add(txtSalary);
            pnEmployeeSalary.Controls.Add(txtLateDay);
            pnEmployeeSalary.Enabled = false;
            pnEmployeeSalary.Location = new Point(439, 43);
            pnEmployeeSalary.Name = "pnEmployeeSalary";
            pnEmployeeSalary.Size = new Size(326, 155);
            pnEmployeeSalary.TabIndex = 1;
            // 
            // txtAbsentDay
            // 
            txtAbsentDay.BackColor = Color.White;
            txtAbsentDay.BorderStyle = BorderStyle.None;
            txtAbsentDay.ForeColor = Color.FromArgb(59, 93, 79);
            txtAbsentDay.Location = new Point(126, 40);
            txtAbsentDay.Margin = new Padding(3, 4, 3, 4);
            txtAbsentDay.Name = "txtAbsentDay";
            txtAbsentDay.Size = new Size(149, 20);
            txtAbsentDay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(59, 93, 79);
            label1.Location = new Point(9, 40);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "Vắng";
            // 
            // txtAttendDay
            // 
            txtAttendDay.BackColor = Color.White;
            txtAttendDay.BorderStyle = BorderStyle.None;
            txtAttendDay.ForeColor = Color.FromArgb(59, 93, 79);
            txtAttendDay.Location = new Point(125, 11);
            txtAttendDay.Margin = new Padding(3, 4, 3, 4);
            txtAttendDay.Name = "txtAttendDay";
            txtAttendDay.Size = new Size(149, 20);
            txtAttendDay.TabIndex = 1;
            // 
            // lbAttendDay
            // 
            lbAttendDay.AutoSize = true;
            lbAttendDay.BackColor = Color.Transparent;
            lbAttendDay.ForeColor = Color.FromArgb(59, 93, 79);
            lbAttendDay.Location = new Point(8, 11);
            lbAttendDay.Name = "lbAttendDay";
            lbAttendDay.Size = new Size(116, 20);
            lbAttendDay.TabIndex = 0;
            lbAttendDay.Text = "Tổng ngày công";
            // 
            // lbSalary
            // 
            lbSalary.AutoSize = true;
            lbSalary.BackColor = Color.Transparent;
            lbSalary.ForeColor = Color.FromArgb(59, 93, 79);
            lbSalary.Location = new Point(11, 112);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(86, 20);
            lbSalary.TabIndex = 6;
            lbSalary.Text = "Tổng lương";
            // 
            // lbLateDay
            // 
            lbLateDay.AutoSize = true;
            lbLateDay.BackColor = Color.Transparent;
            lbLateDay.ForeColor = Color.FromArgb(59, 93, 79);
            lbLateDay.Location = new Point(11, 75);
            lbLateDay.Name = "lbLateDay";
            lbLateDay.Size = new Size(55, 20);
            lbLateDay.TabIndex = 4;
            lbLateDay.Text = "Trễ giờ";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.White;
            txtSalary.BorderStyle = BorderStyle.None;
            txtSalary.ForeColor = Color.FromArgb(59, 93, 79);
            txtSalary.Location = new Point(125, 112);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(149, 20);
            txtSalary.TabIndex = 7;
            // 
            // txtLateDay
            // 
            txtLateDay.BackColor = Color.White;
            txtLateDay.BorderStyle = BorderStyle.None;
            txtLateDay.ForeColor = Color.FromArgb(59, 93, 79);
            txtLateDay.Location = new Point(125, 75);
            txtLateDay.Margin = new Padding(3, 4, 3, 4);
            txtLateDay.Name = "txtLateDay";
            txtLateDay.Size = new Size(149, 20);
            txtLateDay.TabIndex = 5;
            // 
            // pnEmployeeInfo
            // 
            pnEmployeeInfo.Controls.Add(txtEmployeeId);
            pnEmployeeInfo.Controls.Add(txtEmployeeName);
            pnEmployeeInfo.Controls.Add(lbEmployeeName);
            pnEmployeeInfo.Controls.Add(lbID);
            pnEmployeeInfo.Enabled = false;
            pnEmployeeInfo.Location = new Point(8, 43);
            pnEmployeeInfo.Name = "pnEmployeeInfo";
            pnEmployeeInfo.Size = new Size(413, 155);
            pnEmployeeInfo.TabIndex = 0;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.BackColor = Color.White;
            txtEmployeeId.BorderStyle = BorderStyle.None;
            txtEmployeeId.ForeColor = Color.FromArgb(59, 93, 79);
            txtEmployeeId.Location = new Point(114, 24);
            txtEmployeeId.Margin = new Padding(3, 4, 3, 4);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(250, 20);
            txtEmployeeId.TabIndex = 1;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = Color.White;
            txtEmployeeName.BorderStyle = BorderStyle.None;
            txtEmployeeName.ForeColor = Color.FromArgb(59, 93, 79);
            txtEmployeeName.Location = new Point(114, 63);
            txtEmployeeName.Margin = new Padding(3, 4, 3, 4);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(250, 20);
            txtEmployeeName.TabIndex = 3;
            // 
            // lbEmployeeName
            // 
            lbEmployeeName.AutoSize = true;
            lbEmployeeName.BackColor = Color.Transparent;
            lbEmployeeName.ForeColor = Color.FromArgb(59, 93, 79);
            lbEmployeeName.Location = new Point(30, 63);
            lbEmployeeName.Name = "lbEmployeeName";
            lbEmployeeName.Size = new Size(32, 20);
            lbEmployeeName.TabIndex = 2;
            lbEmployeeName.Text = "Tên";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.BackColor = Color.Transparent;
            lbID.ForeColor = Color.FromArgb(59, 93, 79);
            lbID.Location = new Point(32, 24);
            lbID.Name = "lbID";
            lbID.Size = new Size(30, 20);
            lbID.TabIndex = 0;
            lbID.Text = "Mã";
            // 
            // pnAttendance
            // 
            pnAttendance.Controls.Add(btnViewAttend);
            pnAttendance.Controls.Add(dtpReportFor);
            pnAttendance.Dock = DockStyle.Bottom;
            pnAttendance.FlowDirection = FlowDirection.RightToLeft;
            pnAttendance.Location = new Point(0, 213);
            pnAttendance.Name = "pnAttendance";
            pnAttendance.Size = new Size(768, 67);
            pnAttendance.TabIndex = 2;
            // 
            // btnViewAttend
            // 
            btnViewAttend.CustomizableEdges = customizableEdges5;
            btnViewAttend.DisabledState.BorderColor = Color.DarkGray;
            btnViewAttend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnViewAttend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnViewAttend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnViewAttend.FillColor = Color.FromArgb(59, 93, 79);
            btnViewAttend.Font = new Font("Segoe UI", 9F);
            btnViewAttend.ForeColor = Color.White;
            btnViewAttend.Location = new Point(658, 3);
            btnViewAttend.Name = "btnViewAttend";
            btnViewAttend.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnViewAttend.Size = new Size(107, 57);
            btnViewAttend.TabIndex = 1;
            btnViewAttend.Text = "Xem chấm công";
            btnViewAttend.Click += btnViewAttend_Click;
            // 
            // dtpReportFor
            // 
            dtpReportFor.Checked = true;
            dtpReportFor.CustomFormat = "MM/yyyy";
            dtpReportFor.CustomizableEdges = customizableEdges7;
            dtpReportFor.FillColor = Color.FromArgb(59, 93, 79);
            dtpReportFor.Font = new Font("Segoe UI", 9F);
            dtpReportFor.ForeColor = Color.White;
            dtpReportFor.Format = DateTimePickerFormat.Custom;
            dtpReportFor.Location = new Point(454, 3);
            dtpReportFor.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpReportFor.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpReportFor.Name = "dtpReportFor";
            dtpReportFor.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpReportFor.ShowUpDown = true;
            dtpReportFor.Size = new Size(198, 45);
            dtpReportFor.TabIndex = 0;
            dtpReportFor.Value = new DateTime(2025, 4, 15, 22, 31, 0, 592);
            dtpReportFor.ValueChanged += dtpReportFor_ValueChanged;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.BackgroundColor = Color.LightGray;
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
            dgv.Location = new Point(6, 287);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1208, 589);
            dgv.TabIndex = 1;
            dgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv.ThemeStyle.BackColor = Color.LightGray;
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
            dgv.ThemeStyle.RowsStyle.Height = 29;
            dgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgv.CellClick += dgv_CellClick;
            // 
            // lbDateReport
            // 
            lbDateReport.AutoSize = true;
            lbDateReport.BackColor = Color.Transparent;
            lbDateReport.ForeColor = Color.FromArgb(59, 93, 79);
            lbDateReport.Location = new Point(24, 11);
            lbDateReport.Name = "lbDateReport";
            lbDateReport.Size = new Size(69, 20);
            lbDateReport.TabIndex = 0;
            lbDateReport.Text = "Ngày lập";
            // 
            // pnInfo
            // 
            pnInfo.Controls.Add(grAcountantInfor);
            pnInfo.Controls.Add(grEmployeeInfor);
            pnInfo.Location = new Point(3, -3);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(1200, 283);
            pnInfo.TabIndex = 0;
            // 
            // grAcountantInfor
            // 
            grAcountantInfor.Controls.Add(pnButton);
            grAcountantInfor.Controls.Add(pnReport);
            grAcountantInfor.CustomBorderColor = Color.FromArgb(59, 93, 79);
            grAcountantInfor.CustomizableEdges = customizableEdges11;
            grAcountantInfor.FillColor = SystemColors.Control;
            grAcountantInfor.Font = new Font("Segoe UI", 9F);
            grAcountantInfor.ForeColor = Color.White;
            grAcountantInfor.Location = new Point(3, 3);
            grAcountantInfor.Name = "grAcountantInfor";
            grAcountantInfor.ShadowDecoration.CustomizableEdges = customizableEdges12;
            grAcountantInfor.Size = new Size(413, 280);
            grAcountantInfor.TabIndex = 0;
            grAcountantInfor.Text = "Kế toán";
            // 
            // pnReport
            // 
            pnReport.Controls.Add(txtAccountantName);
            pnReport.Controls.Add(lbAccountantName);
            pnReport.Controls.Add(dtpDateReport);
            pnReport.Controls.Add(txtAccountantId);
            pnReport.Controls.Add(lbDateReport);
            pnReport.Controls.Add(lbAccountantId);
            pnReport.Enabled = false;
            pnReport.Location = new Point(3, 43);
            pnReport.Name = "pnReport";
            pnReport.Size = new Size(406, 155);
            pnReport.TabIndex = 0;
            // 
            // txtAccountantName
            // 
            txtAccountantName.BackColor = Color.White;
            txtAccountantName.BorderStyle = BorderStyle.None;
            txtAccountantName.ForeColor = Color.FromArgb(59, 93, 79);
            txtAccountantName.Location = new Point(111, 108);
            txtAccountantName.Margin = new Padding(3, 4, 3, 4);
            txtAccountantName.Name = "txtAccountantName";
            txtAccountantName.ReadOnly = true;
            txtAccountantName.Size = new Size(198, 20);
            txtAccountantName.TabIndex = 5;
            // 
            // lbAccountantName
            // 
            lbAccountantName.AutoSize = true;
            lbAccountantName.BackColor = Color.Transparent;
            lbAccountantName.ForeColor = Color.FromArgb(59, 93, 79);
            lbAccountantName.Location = new Point(24, 108);
            lbAccountantName.Name = "lbAccountantName";
            lbAccountantName.Size = new Size(32, 20);
            lbAccountantName.TabIndex = 4;
            lbAccountantName.Text = "Tên";
            // 
            // lbAccountantId
            // 
            lbAccountantId.AutoSize = true;
            lbAccountantId.BackColor = Color.Transparent;
            lbAccountantId.ForeColor = Color.FromArgb(59, 93, 79);
            lbAccountantId.Location = new Point(24, 60);
            lbAccountantId.Name = "lbAccountantId";
            lbAccountantId.Size = new Size(30, 20);
            lbAccountantId.TabIndex = 2;
            lbAccountantId.Text = "Mã";
            // 
            // frmSalaryReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 865);
            Controls.Add(dgv);
            Controls.Add(pnInfo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSalaryReport";
            Text = "frmSalaryReport";
            Load += frmSalaryReport_Load;
            pnButton.ResumeLayout(false);
            grEmployeeInfor.ResumeLayout(false);
            pnEmployeeSalary.ResumeLayout(false);
            pnEmployeeSalary.PerformLayout();
            pnEmployeeInfo.ResumeLayout(false);
            pnEmployeeInfo.PerformLayout();
            pnAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pnInfo.ResumeLayout(false);
            grAcountantInfor.ResumeLayout(false);
            pnReport.ResumeLayout(false);
            pnReport.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnButton;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateReport;
        private TextBox txtAccountantId;
        private Guna.UI2.WinForms.Guna2GroupBox grEmployeeInfor;
        private Panel pnEmployeeInfo;
        private TextBox txtEmployeeId;
        private TextBox txtEmployeeName;
        private Label lbEmployeeName;
        private Label lbID;
        private Label lbSalary;
        private TextBox txtSalary;
        private FlowLayoutPanel pnAttendance;
        private Guna.UI2.WinForms.Guna2Button btnViewAttend;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Label lbDateReport;
        private FlowLayoutPanel pnInfo;
        private Guna.UI2.WinForms.Guna2GroupBox grAcountantInfor;
        private Panel pnReport;
        private Label lbAccountantId;
        private Panel pnEmployeeSalary;
        private TextBox txtAttendDay;
        private TextBox txtOnTimeDay;
        private Label lbOnTimeDay;
        private Label lbAttendDay;
        private Label lbLateDay;
        private TextBox txtLateDay;
        private TextBox txtAccountantName;
        private Label lbAccountantName;
        private Guna.UI2.WinForms.Guna2Button btnStatistics;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReportFor;
        private TextBox txtAbsentDay;
        private Label label1;
    }
}