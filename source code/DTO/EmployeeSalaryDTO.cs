using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class EmployeeSalaryDTO
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int TotalAttendDays { get; set; }
        public int LateDays { get; set; }
        public int AbsentDays { get; set; }
        public long TotalSalary { get; set; }
    }

}
