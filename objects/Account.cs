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

namespace timber_shop_manager.objects
{
    public class Account
    {
        private static DatabaseHelper dbHelper = new DatabaseHelper();
        private string username = string.Empty;
        private string password = string.Empty;
        private Employee.Role role = Employee.Role.UNKNOWN;
        public string Username { get;}
        public string Password { get; }
        public Employee Employee { get; }

        public Account(string username, string password)
        {
            this.username = username.Trim();
            this.password = password.Trim();
        }
        
        public bool verifyUsername()
        {
            string query = "SELECT 1 FROM Account WHERE Username = @user";
            
            return dbHelper.ExecuteScalar(query, new SqlParameter("@user", username)) != null;
        }

        public bool verifyPassword()
        {
            if (verifyUsername())
            {
                string query = "SELECT 1 FROM Account WHERE Username = @user AND Password = @pass";
                return dbHelper.ExecuteScalar(query,
                    new SqlParameter("@user", username),
                    new SqlParameter("@pass", password)) != null;
            }
            return false;
        }

        public Employee.Role verifyPermission()
        {
            return Employee.GetPermission(this.username);
        }
    }
}
