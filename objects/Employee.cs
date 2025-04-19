using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static timber_shop_manager.objects.Employee;

namespace timber_shop_manager.objects
{
    public class Employee 
    {

        public static readonly string PREFIX = "E";
        public static readonly int CODE_LENGTH = 4;
        public static readonly int MIN_WORKING_AGE = 18;
        public enum Role
        {
            MANAGER,
            SALE_AGENT,
            ADMINISTRATOR,
            ACCOUNTANT,
            UNKNOWN
        }

        private static DatabaseHelper dbHelper = new DatabaseHelper();

        protected string id, name, identificationNumber, address, phoneNumber;
        protected DateTime birthday;
        protected double salary;
        protected Role role;

        public Employee(string id, string name, string identificationNumber, string address, DateTime birthday, string salary, string phoneNumber, string role)
        {
            this.id = id.Trim();
            this.name = InputValidator.CapitalizeName(name.Trim());
            this.identificationNumber = identificationNumber.Trim();
            this.address = address.Trim();
            this.birthday = birthday;
            this.salary = Convert.ToDouble(salary.Trim());
            this.phoneNumber = phoneNumber.Trim();
            this.role = ConvertRole(role.Trim());
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

        public static Role GetPermission(Account acc)
        {
            string query = "SELECT e.Role FROM Employee e JOIN Account a ON a.Id = e.Id WHERE a.Email = @email";
            string role = Convert.ToString(dbHelper.ExecuteScalar(query, new SqlParameter("@email", acc.Email)));

            return ConvertRole(role);
        }

        public static void add(Employee e)
        {
            string query = "SELECT COUNT(Id) FROM Employee WHERE Id = @id";
            int count = Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@id", e.id)));
            if (count != 0)
            {
                query = "UPDATE Employee SET " +
                    "Name = @name, IdentificationNumber = @iden, Address = @address, Birthday = @birth, Salary = @salary, PhoneNumber = @phone, Role = @role " +
                    "WHERE Id = @id";
            } 
            else
            {
                query = "INSERT INTO Employee (Id, Name, IdentificationNumber, Address, Birthday, Salary, PhoneNumber, Role) VALUES " +
                    "(@id, @name, @iden, @address, @birth, @salary, @phone, @role)";
                //(@id, @name, @iden, @address, @birhday, @salary, @phoneNumber, @role)
            }
            dbHelper.ExecuteNonQuery(query, 
                new SqlParameter("@id", e.id),
                new SqlParameter("@name", e.name),
                new SqlParameter("@iden", e.identificationNumber),
                new SqlParameter("@address", e.address),
                new SqlParameter("@birth", e.birthday),
                new SqlParameter("@salary", e.salary),
                new SqlParameter("@phone", e.phoneNumber),
                new SqlParameter("@role", ConverRole(e.role)));
        }

        public static void delete(Employee e) 
        {
            string query = "UPDATE Employee SET IsDeleted = 1 WHERE Id = @id";
            dbHelper.ExecuteNonQuery(query, new SqlParameter("@id", e.id));
        }

        public static bool IsLegalWorkingAge(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;

            if (birthday.Date > today.AddYears(-age))
            {
                age--;
            }

            return age >= MIN_WORKING_AGE;
        }
    }
}
