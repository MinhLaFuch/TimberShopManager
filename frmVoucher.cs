using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.objects
{
    public partial class frmVoucher : Form
    {
        private static DatabaseHelper dbHelper = new DatabaseHelper();
        public frmVoucher()
        {
            InitializeComponent();
        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            grInfor.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            txtId.Text = string.Empty;

            lbStatus.Text = string.Empty;

            nudDiscount.Value = 0;

            DateTime currentDate = DateTime.Now;
            dtpFrom.Value = currentDate;
            dtpTo.Value = currentDate;

            dtpFrom.MinDate = currentDate;

            dgv.DataSource = LoadVoucherData();
        }

        private DataTable LoadVoucherData()
        {
            string query = @"
                SELECT 
                    Id AS Mã, 
                    Name AS Tên, 
                    StartDate AS [Ngày Bắt Đầu], 
                    EndDate AS [Ngày Kết Thúc], 
                    Discription AS [Mô Tả], 
                    Percentant AS [Phần Trăm], 
                    Price AS Giá 
                FROM Voucher";

            return dbHelper.ExecuteQuery(query);
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "Ngày Bắt Đầu" || dgv.Columns[e.ColumnIndex].Name == "Ngày Kết Thúc")
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy"); // Định dạng ngày tháng
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadForm();
            grInfor.Enabled = true;

            txtId.Focus();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;

            nudDiscount.Value = 0;

            DateTime currentDate = DateTime.Now;
            dtpFrom.Value = dtpFrom.MinDate = currentDate.AddDays(1);
            dtpTo.Value = dtpFrom.Value;

            dgv.DataSource = LoadVoucherData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void rdAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAmount.Checked)
            {
                nudDiscount.DecimalPlaces = 0;
                nudDiscount.Increment = 1;
                nudDiscount.Minimum = 0;
                nudDiscount.Maximum = int.MaxValue;
                nudDiscount.Value = 0;
            }
        }

        private void rdPercentant_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPercentant.Checked)
            {
                nudDiscount.DecimalPlaces = 0;
                nudDiscount.Increment = 1;
                nudDiscount.Minimum = 0;
                nudDiscount.Maximum = 100;
                nudDiscount.Value = 0;
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;

            if (dtpTo.Value < dtpFrom.Value)
            {
                dtpTo.Value = dtpFrom.Value;  
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Voucher WHERE Id = @id";
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                int count = Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@id", txtId.Text.Trim().ToUpper())));
                if (count > 0)
                {
                    lbStatus.Text = "Đã tồn tại mã này!";
                    lbStatus.ForeColor = Color.Red;
                    btnSave.Enabled = false;
                }
                else
                {
                    lbStatus.Text = "Mã hợp lệ.";
                    lbStatus.ForeColor = Color.Green;
                    btnSave.Enabled = true;
                }
            }
            else
            {
                lbStatus.Text = string.Empty;
                btnSave.Enabled = false;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Mã voucher không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên voucher không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (nudDiscount.Value == 0)
            {
                MessageBox.Show("Giảm giá không được bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudDiscount.Focus();
                return;
            }

            string id = txtId.Text.Trim();
            string name = txtName.Text.Trim();
            DateTime startDate = dtpFrom.Value;
            DateTime endDate = dtpTo.Value;  
            string discription = txtContent.Text.Trim();
            string percentant = "0";
            string price = "0";

            if (rdPercentant.Checked)
            {
                percentant = (nudDiscount.Value / 100).ToString();  
            }
            else if (rdAmount.Checked)
            {
                price = nudDiscount.Value.ToString();  
            }

            Voucher voucher = new Voucher(id, name, startDate, endDate, discription, percentant, price);

            Voucher.add(voucher);

            LoadForm();
        }
    }
}
