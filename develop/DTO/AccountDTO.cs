using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class AccountDTO
    {
        public string Email { get; set; }
        public string EmployeeId { get; set; }
        public string Password { get; set; }
        public bool IsActivate { get; set; } = true;

        public AccountDTO() { }

        public AccountDTO(string email, string employeeId, string password = null, bool isActivate = true)
        {
            Email = email;
            EmployeeId = employeeId;
            Password = password;
            IsActivate = isActivate;
        }

        public static class STATUS
        {
            public static readonly string BLOCKED = "Đã bị khoá";
            public static readonly string NOT_EXISTS = "Không tồn tại";
            public static readonly string OK = "Ok";
        }
    }
}
