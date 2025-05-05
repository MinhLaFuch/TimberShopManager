using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timber_shop_manager.DAL;
using timber_shop_manager.DTO;

namespace timber_shop_manager.BUS
{
    public class EmployeeBUS
    {
        private readonly EmployeeDAL dal = new EmployeeDAL();
        private readonly AccountDAL accountDAL = new AccountDAL();

        public DataTable GetEmployeeList() => dal.GetEmployeeData();

        public List<string> GetRoles() => dal.GetRoles();

        public void AddOrUpdateEmployee(EmployeeDTO emp)
        {
            if (emp.Birthday > DateTime.Now)
                throw new Exception("Ngày sinh không hợp lệ.");
            if (emp.Salary < 0)
                throw new Exception("Lương không hợp lệ.");

            dal.SaveEmployee(emp);
        }

        public void DeleteEmployee(string id)
        {
            dal.DeleteEmployee(id);
        }

        public string GetLastEmployeeId()
        {
            return dal.GetLastEmployeeId();
        }

        public EmployeeDTO GetEmployeeById(string id)
        {
            return dal.GetEmployeeById(id);
        }

        public AccountDTO GetAccountByEmployeeId(string employeeId)
        {
            return accountDAL.GetAccountByEmployeeId(employeeId);
        }
    }
}
