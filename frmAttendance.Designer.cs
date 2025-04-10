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
            dgvWorkingHour = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvWorkingHour).BeginInit();
            SuspendLayout();
            // 
            // dgvWorkingHour
            // 
            dgvWorkingHour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkingHour.Location = new Point(288, 125);
            dgvWorkingHour.Name = "dgvWorkingHour";
            dgvWorkingHour.RowHeadersWidth = 51;
            dgvWorkingHour.Size = new Size(300, 188);
            dgvWorkingHour.TabIndex = 0;
            // 
            // frmWorkHour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvWorkingHour);
            Name = "frmWorkHour";
            Text = "Báo cáo chấm công của ";
            Load += frmWorkHour_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWorkingHour).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvWorkingHour;
    }
}