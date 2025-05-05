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
                "Nhân viên kế toán" => RoleEnum.ACCOUNTANT,
                "Quản lý cửa hàng" => RoleEnum.MANAGER,
                "Nhân viên bán hàng" => RoleEnum.SALE_AGENT,
                _ => RoleEnum.UNKNOWN
            };
        }

        public static string ConvertToString(RoleEnum role)
        {
            return role switch
            {
                RoleEnum.ADMINISTRATOR => "Quản trị viên",
                RoleEnum.ACCOUNTANT => "Nhân viên kế toán",
                RoleEnum.MANAGER => "Quản lý cửa hàng",
                RoleEnum.SALE_AGENT => "Nhân viên bán hàng",
                _ => "Unknown"
            };
        }
    }
}
