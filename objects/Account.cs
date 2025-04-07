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
        private string username, password;

        public string Username { get;}

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
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
