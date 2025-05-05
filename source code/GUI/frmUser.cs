using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmUser : Form
    {
        #region Properties
        private EmployeeBUS empBUS = new();
        private EmployeeDTO emp;

        public frmUser()
        {
            InitializeComponent();
            emp = empBUS.GetEmployeeById("E001");
        }

        public frmUser(EmployeeDTO emp) : this()
        {
            this.emp = emp;
        }
        public EmployeeDTO employeeDTO
        {
            get { return emp; }
        }
        #endregion
        #region Support methods
        #endregion
        #region Button click events
        #endregion
        #region 
        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }

        private void DisableAllTextBox()
        {
            txtEmail.Enabled = false;
            txtName.Enabled = false;
            txtIden.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtAddress.Enabled = false;
            dtpBirthday.Enabled = false;
            txtAdmission.Enabled = false;
            txtSalary.Enabled = false;
        }

        private void LoadInformation()
        {
            txtEmail.Text = empBUS.GetAccountByEmployeeId(emp.Id).Email;
            txtName.Text = emp.Name;
            txtIden.Text = emp.IdentificationNumber;
            txtPhoneNumber.Text = emp.PhoneNumber;
            txtAddress.Text = emp.Address;
            dtpBirthday.Value = emp.Birthday;
            txtAdmission.Text = emp.Role;
            txtSalary.Text = emp.Salary.ToString();
            btnSave.Visible = false;
            btnCancel.Visible = false;
            DisableAllTextBox();
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = true;
            txtPhoneNumber.Enabled = true;
            btnChangeInfo.Visible = false;
            btnChangePW.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            new frmChangePW(this, txtEmail.Text).ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            emp.Address = txtAddress.Text;
            emp.PhoneNumber = txtPhoneNumber.Text;
            empBUS.AddOrUpdateEmployee(emp);

            LoadInformation();
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadInformation();
        }
    }
}
