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
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;

namespace timber_shop_manager.objects
{
    public partial class frmVoucher : Form
    {
        #region Properties
        private readonly VoucherBUS voucherBUS = new();
        private readonly EmployeeDTO emp;
        private bool authority;
        public frmVoucher()
        {
            InitializeComponent();
        }
        public frmVoucher(EmployeeDTO emp) : this()
        {
            this.emp = emp;
            authority = (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.ADMINISTRATOR) || (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.MANAGER);
        }
        #endregion
        #region Support methods
        private void LoadForm()
        {
            grInfo.Enabled = false;
            EnterDefaultMode();
            ClearInput();
            dgv.DataSource = voucherBUS.GetAllVouchers();
        }
        private void EnterDefaultMode()
        {
            grInfo.Enabled = false;
            ButtonVisibility(true, false);
        }
        private void ClearInput()
        {
            txtId.Clear();
            txtName.Clear();
            txtContent.Clear();
            nudDiscount.Value = 0;
            lbStatus.Text = string.Empty;

            DateTime current = DateTime.Now;
            dtpFrom.MinDate = dtpFrom.Value = current.AddDays(1);
            dtpTo.MinDate = dtpFrom.Value;
            dtpTo.Value = dtpFrom.Value;
        }
        private void ButtonVisibility(bool defaultBtn, bool editBtn)
        {
            btnAdd.Visible = defaultBtn && authority;
            btnSave.Visible = btnCancel.Visible = editBtn;
        }
        #endregion
        #region Load event
        private void frmVoucher_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion
        #region Button click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            grInfo.Enabled = true;
            txtId.Focus();
            
            ButtonVisibility(false, true);

            nudDiscount.Value = 0;

            DateTime currentDate = DateTime.Now;
            dtpFrom.Value = dtpFrom.MinDate = currentDate.AddDays(1);
            dtpTo.Value = dtpFrom.Value;

            dgv.DataSource = voucherBUS.GetAllVouchers();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Mã khuyến mãi không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên khuyến mãi không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudDiscount.Value == 0)
            {
                MessageBox.Show("Giá trị giảm giá phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal percent = rdPercentant.Checked ? (decimal)Math.Round(nudDiscount.Value / 100, 2) : 0;
            int price = rdAmount.Checked ? (int)nudDiscount.Value : 0;

            VoucherDTO voucher = new(txtId.Text, txtName.Text, dtpFrom.Value, dtpTo.Value, txtContent.Text, percent, price);

            try
            {
                voucherBUS.AddVoucher(voucher);
                MessageBox.Show("Thêm khuyến mãi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Cell formatting event
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

            if (dgv.Columns[e.ColumnIndex].Name == "Phần Trăm" || dgv.Columns[e.ColumnIndex].Name == "Giá")
            {
                // Nếu giá trị không phải null và là kiểu số
                if (e.Value != null && e.Value is decimal)
                {
                    // Làm tròn và hiển thị đến 2 chữ số thập phân
                    e.Value = Math.Round((decimal)e.Value, 2).ToString("0.00");
                    e.FormattingApplied = true;
                }
            }
        }
        #endregion
        #region Value Changed events
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
            string result = voucherBUS.ValidateVoucherId(txtId.Text.Trim().ToUpper());
            lbStatus.Text = result;
            lbStatus.ForeColor = result.Contains("exists") ? Color.Red : Color.Green;
            btnSave.Enabled = result == "Mã Voucher hợp lệ";
        }
        #endregion
        #region Key press event
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
        #endregion
    }
}
