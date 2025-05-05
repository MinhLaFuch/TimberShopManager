using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class SupplierDTO
    {
        public static readonly string PREFIX = "S";
        public static readonly int CODE_LENGTH = 4;
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public SupplierDTO() { }

        public SupplierDTO(string id, string name, string address, string phoneNumber, string email, string website)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Website = website;
        }
    }
}
