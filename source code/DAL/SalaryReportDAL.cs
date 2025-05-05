using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.DAL
{
    public class SalaryReportDAL
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public DataTable GetSalaryReport(int month, int year)
        {
            string query = @"
SELECT 
    e.Id AS [Mã nhân viên], 
    e.Name AS [Tên nhân viên],
    COUNT(DISTINCT CAST(a.Date AS DATE)) AS [Tổng ngày công],  
    SUM(CASE WHEN a.Review LIKE '%muộn%' THEN 1 ELSE 0 END) AS [Số ngày trễ],
    (DATEDIFF(DAY, 
        CAST(@year AS VARCHAR) + '-' + CAST(@month AS VARCHAR) + '-01', 
        EOMONTH(CAST(@year AS VARCHAR) + '-' + CAST(@month AS VARCHAR) + '-01')) + 1 
    - COUNT(DISTINCT CAST(a.Date AS DATE))) AS [Số ngày vắng],  
    (COUNT(DISTINCT CAST(a.Date AS DATE)) * e.Salary) AS [Tổng lương]  
FROM Employee e
LEFT JOIN Attendance a ON e.Id = a.Id 
AND MONTH(a.Date) = @month 
AND YEAR(a.Date) = @year
GROUP BY e.Id, e.Name, e.Salary";

            return dbHelper.ExecuteQuery(query,
                new SqlParameter("@month", month),
                new SqlParameter("@year", year));
        }
    }
}
