using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.xmp.impl;
using Microsoft.Data.SqlClient;
using timber_shop_manager.DTO;
using timber_shop_manager.objects;

namespace timber_shop_manager.DAL
{
    public class AccountDAL
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public void Create(AccountDTO account)
        {
            string query = "INSERT INTO Account (Email, Password, Id) VALUES (@Email, @Password, @EmployeeId)";
            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@Email", account.Email.Trim()),
                new SqlParameter("@Password", HashPassword(account.EmployeeId.Trim().ToLower())),
                new SqlParameter("@EmployeeId", account.EmployeeId));
        }

        public void Block(string email)
        {
            string query = "UPDATE Account SET IsActivate = 0 WHERE Email = @Email";
            dbHelper.ExecuteNonQuery(query, new SqlParameter("@Email", email));
        }

        public bool Exists(string email)
        {
            string query = "SELECT 1 FROM Account WHERE Email = @Email";
            return dbHelper.ExecuteScalar(query, new SqlParameter("@Email", email)) != null;
        }

        private string HashPassword(string plainTextPassword)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(plainTextPassword);
                var hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public DataTable GetAccountsData()
        {
            string query = @"
                SELECT 
                    emp.Id AS 'Mã',
                    emp.Name AS 'Tên',
                    acc.Email AS 'Tên tài khoản',
                    emp.Role AS 'Chức vụ',
                    ISNULL(acc.IsActivate, 1) AS IsActivate,
                    CASE 
                        WHEN acc.Email IS NULL THEN 0
                        WHEN acc.IsActivate = 0 THEN 2
                        ELSE 1
                    END AS SortOrder
                FROM Employee emp
                LEFT JOIN Account acc ON emp.Id = acc.Id
                ORDER BY SortOrder, emp.Id";

            return dbHelper.ExecuteQuery(query);
        }

        public List<string> GetRoles()
        {
            string query = "SELECT DISTINCT Role FROM Employee ORDER BY Role";
            return dbHelper.GetDataForComboBox(query, "Role");
        }

        public bool Verify(string email, string password)
        {
            string query = "SELECT 1 FROM Account WHERE Email = @Email AND Password = @Password AND IsActivate = 1";
            //MessageBox.Show(HashPassword(password), "Xác nhận", MessageBoxButtons.YesNo);
            return dbHelper.ExecuteScalar(query,
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", HashPassword(password))) != null;
        }

        public string GetEmployeeIdByEmail(string email)
        {
            string query = "SELECT Id FROM Account WHERE Email = @Email";
            var result = dbHelper.ExecuteScalar(query, new SqlParameter("@Email", email));
            return result == null ? null : result.ToString();
        }

        public AccountDTO GetAccountByEmployeeId(string employeeId)
        {
            string query = "SELECT * FROM Account WHERE Id = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", employeeId)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];

            return new AccountDTO
            {
                Email = row["Email"].ToString(),
                EmployeeId = row["Id"].ToString(),
                Password = row["Password"]?.ToString(),
                IsActivate = row["IsActivate"] != DBNull.Value && (bool)row["IsActivate"]
            };
        }

        public AccountDTO GetAccountByEmail(string email)
        {
            string query = "SELECT * FROM Account WHERE Email = @email";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", email)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];

            return new AccountDTO
            {
                Email = row["Email"].ToString(),
                EmployeeId = row["Id"].ToString(),
                Password = row["Password"]?.ToString(),
                IsActivate = row["IsActivate"] != DBNull.Value && (bool)row["IsActivate"]
            };
        }

        public void ChangePassword(string email, string password)
        {
            string query = "UPDATE Account SET Password = @Password WHERE Email = @Email";
            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", HashPassword(password)));
        }

        public string CheckLoginStatus(string email, string password)
        {
            string query = "SELECT Password, IsActivate FROM Account WHERE Email = @Email";

            SqlDataReader reader = dbHelper.ExecuteReader(query, new SqlParameter("@Email", email));
                    
            if (!reader.HasRows)
            {
                return AccountDTO.STATUS.NOT_EXISTS;
            }

            if (reader.Read())
            {
                string storedPassword = reader["Password"].ToString();
                bool isActivate = Convert.ToBoolean(reader["IsActivate"]);

                if (!isActivate)
                    return AccountDTO.STATUS.BLOCKED;

                if (storedPassword == password)
                    return AccountDTO.STATUS.OK;
            }

            return AccountDTO.STATUS.NOT_EXISTS;
        }

    }
}
