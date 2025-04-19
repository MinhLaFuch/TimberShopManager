using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace timber_shop_manager.objects
{
    public class Account
    {
        private static DatabaseHelper dbHelper = new DatabaseHelper();

        private string email;
        private string employeeId;

        public string Email => email;

        public Account(string email, string employeeId)
        {
            this.email = email.Trim();
            this.employeeId = employeeId.Trim();
        }

        public static void create(Account acc)
        {
            string query = "INSERT INTO Account (Email, Password, Id) VALUES (@email, @password, @employeeId)";
            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@email", acc.email),
                new SqlParameter("@password", HashPassword(acc.employeeId)),
                new SqlParameter("@employeeId", acc.employeeId));
        }

        public static void block(Account acc)
        {
            string query = "UPDATE Account SET IsActivate = 0 WHERE Email = @email";
            dbHelper.ExecuteNonQuery(query, new SqlParameter("@email", acc.email));
        }

        public bool exists()
        {
            string query = "SELECT 1 FROM Account WHERE Email = @email";
            
            return dbHelper.ExecuteScalar(query, new SqlParameter("@email", this.email)) != null;
        }

        public bool verify(string password)
        {
            string query = "SELECT 1 FROM Account WHERE Email = @email AND Password = @password";
            return dbHelper.ExecuteScalar(query,
                new SqlParameter("@email", email),
                new SqlParameter("@password", HashPassword(password.Trim()))) != null;
        }

        public Employee.Role getRole()
        {
            return Employee.GetPermission(this);
        }

        private static string HashPassword(string plainTextPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(plainTextPassword);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Convert sang chuỗi hex
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
        

}
}
