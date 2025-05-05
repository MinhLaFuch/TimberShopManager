using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using timber_shop_manager.DAL;
using timber_shop_manager.DTO;

namespace timber_shop_manager.BUS
{
    public class AccountBUS
    {
        private AccountDAL dal = new AccountDAL();

        public bool IsExist(string email) => dal.Exists(email);

        public void CreateAccount(AccountDTO account)
        {
            if (dal.Exists(account.Email))
                throw new System.Exception("Tài khoản đã tồn tại.");
            dal.Create(account);
        }

        public void BlockAccount(string email)
        {
            dal.Block(email);
        }

        public DataTable GetAccountsForGrid()
        {
            return dal.GetAccountsData();
        }

        public List<string> GetDistinctRoles()
        {
            return dal.GetRoles();
        }

        public bool VerifyAccount(string email, string password)
        {
            return dal.Verify(email, password);
        }

        public EmployeeDTO LoginAndGetEmployee(string email, string password)
        {
            if (!dal.Verify(email, password))
                return null;

            string employeeId = dal.GetEmployeeIdByEmail(email);
            if (string.IsNullOrEmpty(employeeId))
                return null;

            EmployeeDAL empDal = new EmployeeDAL();
            return empDal.GetEmployeeById(employeeId);
        }

        public AccountDTO GetAccountByEmail(string email)
        {
            return dal.GetAccountByEmail(email);
        }

        public void ChangePassword(string email, string password)
        {
            dal.ChangePassword(email, password);
        }

        public string CheckLoginStatus(string email, string password)
        {
            return dal.CheckLoginStatus(email, password);
        }
    }
}
