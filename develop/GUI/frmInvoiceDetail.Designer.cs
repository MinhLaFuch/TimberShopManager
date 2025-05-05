namespace timber_shop_manager.GUI
{
    partial class frmInvoiceDetail
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
            dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            nCB = new ReaLTaiizor.Controls.NightControlBox();
            pnTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pnTop.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dgv.Location = new Point(0, 36);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(914, 564);
            dgv.TabIndex = 0;
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
            nCB.Location = new Point(775, 0);
            nCB.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nCB.MaximizeHoverForeColor = Color.White;
            nCB.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nCB.MinimizeHoverForeColor = Color.White;
            nCB.Name = "nCB";
            nCB.Size = new Size(139, 31);
            nCB.TabIndex = 0;
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(59, 93, 79);
            pnTop.Controls.Add(nCB);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(914, 37);
            pnTop.TabIndex = 1;
            // 
            // frmInvoiceDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnTop);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInvoiceDetail";
            Text = "Chi tiết hoá đơn";
            Load += InvoiceDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pnTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private ReaLTaiizor.Controls.NightControlBox nCB;
        private Panel pnTop;
    }
}