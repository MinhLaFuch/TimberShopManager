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
        private static DatabaseHelper dbHelper = new DatabaseHelper();
        
        protected string id, name, identificationNumber, address;
        protected DateTime dateOfBirth;
        protected float salary;
        protected Role role;

        public Employee(string id, string name, string identificationNumber, string address, DateTime dateOfBirth, float salary, string role) 
            : this(id, name,  identificationNumber, address, dateOfBirth, salary, ConvertRole(role)) { }
        

        public Employee(string id, string name, string identificationNumber, string address, DateTime dateOfBirth, float salary, Role role)
        {
            this.id = id;
            this.name = name;
            this.identificationNumber = identificationNumber;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.salary = salary;
            this.role = role;
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

        public static string ConverRole(Role role)
        {
            switch (role)
            {
                case Role.ADMINISTRATOR:
                    return "Administrator";
                case Role.ACCOUNTANT:
                    return "Acountant";
                case Role.MANAGER:
                    return "Manager";
                case Role.SALE_AGENT:
                    return "Sale Agent";
                default:
                    return null;
            }
        }

        public static Role GetPermission(string username)
        {
            string query = "SELECT Role FROM Employee WHERE Username = @username";
            string role = Convert.ToString(dbHelper.ExecuteScalar(query, new SqlParameter("@username", username)));

            return ConvertRole(role);
        }
    }
}
