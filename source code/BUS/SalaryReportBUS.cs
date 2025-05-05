using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timber_shop_manager.DAL;
using timber_shop_manager.DTO;

namespace timber_shop_manager.BUS
{
    public class SalaryReportBUS
    {
        private SalaryReportDAL salaryReportDAL = new SalaryReportDAL();

        public List<EmployeeSalaryDTO> GetSalaryReport(DateTime reportDate)
        {
            int month = reportDate.Month;
            int year = reportDate.Year;
            DataTable dt = salaryReportDAL.GetSalaryReport(month, year);

            List<EmployeeSalaryDTO> salaryList = new List<EmployeeSalaryDTO>();
            foreach (DataRow row in dt.Rows)
            {
                salaryList.Add(new EmployeeSalaryDTO
                {
                    EmployeeId = row["Mã nhân viên"].ToString(),
                    EmployeeName = row["Tên nhân viên"].ToString(),
                    TotalAttendDays = Convert.ToInt32(row["Tổng ngày công"]),
                    LateDays = Convert.ToInt32(row["Số ngày trễ"]),
                    AbsentDays = Convert.ToInt32(row["Số ngày vắng"]),
                    TotalSalary = Convert.ToInt64(row["Tổng lương"])
                });
            }

            return salaryList;
        }

        public DataTable GetSalaryReportDataTable(DateTime reportDate)
        {
            int month = reportDate.Month;
            int year = reportDate.Year;
            return salaryReportDAL.GetSalaryReport(month, year);
        }
    }
}
