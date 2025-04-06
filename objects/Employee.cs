using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.objects
{
    public class Employee 
    {
        protected string id;
        protected Role role;
        private static DatabaseHelper dbHelper = new DatabaseHelper();

        internal Employee(string id, string role) 
        { 
            this.id = id;
            this.role = ConvertRole(role);

        }

        private static Role ConvertRole(string role)
        {
            switch (role)
            {
                case "Administrator":
                    return Role.ADMINISTRATOR;
                case "Accountant":
                    return Role.ACCOUNTANT;
                case "Manager":
                    return Role.MANAGER;
                case "Sale Agent":
                    return Role.SALE_AGENT;
                default:
                    return Role.UNKNOWN;
            }
        }

        public static Role GetPermission(string username)
        {
            string query = "SELECT Role FROM EMPLOYEE WHERE Username = @username";
            string role = Convert.ToString(dbHelper.ExecuteScalar(query, new SqlParameter("@username", username)));

            return ConvertRole(role);
        }
    }
}
