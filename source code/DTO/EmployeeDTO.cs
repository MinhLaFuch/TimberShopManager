using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class EmployeeDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdentificationNumber { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public double Salary { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }

        public EmployeeDTO() { }

        public EmployeeDTO(string id, string name, string iden, string address, DateTime birthday, double salary, string phone, string role)
        {
            Id = id;
            Name = name;
            IdentificationNumber = iden;
            Address = address;
            Birthday = birthday;
            Salary = salary;
            PhoneNumber = phone;
            Role = role;
        }
    }
}
