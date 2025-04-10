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
            dgvAttendance = new DataGridView();
            cbTimeStamp = new ComboBox();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            cbTime = new ComboBox();
            lbTimeStamp = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(200, -2);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(352, 440);
            dgvAttendance.TabIndex = 0;
            // 
            // cbTimeStamp
            // 
            cbTimeStamp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTimeStamp.FormattingEnabled = true;
            cbTimeStamp.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng", "Quý", "Năm", "Ngày -> Ngày" });
            cbTimeStamp.Location = new Point(-1, 41);
            cbTimeStamp.Name = "cbTimeStamp";
            cbTimeStamp.Size = new Size(195, 28);
            cbTimeStamp.TabIndex = 1;
            cbTimeStamp.SelectedValueChanged += cbTimeStamp_SelectedValueChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(-1, 117);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(195, 27);
            dtpFrom.TabIndex = 2;
            dtpFrom.Visible = false;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(-1, 165);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(195, 27);
            dtpTo.TabIndex = 3;
            dtpTo.Visible = false;
            // 
            // cbTime
            // 
            cbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTime.FormattingEnabled = true;
            cbTime.Location = new Point(22, 116);
            cbTime.Name = "cbTime";
            cbTime.Size = new Size(151, 28);
            cbTime.TabIndex = 4;
            cbTime.Visible = false;
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
            // frmAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 450);
            Controls.Add(lbTimeStamp);
            Controls.Add(cbTime);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(cbTimeStamp);
            Controls.Add(dgvAttendance);
            Name = "frmAttendance";
            Text = "Báo cáo chấm công của ";
            Load += frmWorkHour_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAttendance;
        private ComboBox cbTimeStamp;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private ComboBox cbTime;
        private Label lbTimeStamp;
    }
}