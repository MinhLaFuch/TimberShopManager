using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public enum RoleEnum
    {
        MANAGER,
        SALE_AGENT,
        ADMINISTRATOR,
        ACCOUNTANT,
        UNKNOWN
    }

    public static class RoleHelper
    {
        public static RoleEnum ConvertToEnum(string role)
        {
            return role switch
            {
                "Quản trị viên" => RoleEnum.ADMINISTRATOR,
                "Kế toán" => RoleEnum.ACCOUNTANT,
                "Quản lý" => RoleEnum.MANAGER,
                "Bán hàng" => RoleEnum.SALE_AGENT,
                _ => RoleEnum.UNKNOWN
            };
        }

        public static string ConvertToString(RoleEnum role)
        {
            return role switch
            {
                RoleEnum.ADMINISTRATOR => "Quản trị viên",
                RoleEnum.ACCOUNTANT => "Kế toán",
                RoleEnum.MANAGER => "Quản lý",
                RoleEnum.SALE_AGENT => "Bán hàng",
                _ => "Unknown"
            };
        }
    }
}
