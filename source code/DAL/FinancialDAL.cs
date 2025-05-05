using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using timber_shop_manager.DTO;

namespace timber_shop_manager.DAL
{
    public class FinancialDAL
    {
        private readonly DatabaseHelper dbHelper = new();

        public DataTable GetFinancialDataByDay(int month, int year)
        {
            string query = @"
                SELECT 
                    CAST(PaymentDate AS DATE) AS Ngay,
                    ISNULL(SUM(CASE WHEN Type = 'Sale' THEN Total ELSE 0 END), 0) AS TongThu,
                    ISNULL(SUM(CASE WHEN Type = 'Import' THEN Total ELSE 0 END), 0) AS TongChi
                FROM (
                    SELECT PaymentDate, TotalCost AS Total, 'Sale' AS Type
                    FROM SaleInvoice
                    WHERE MONTH(PaymentDate) = @Month AND YEAR(PaymentDate) = @Year

                    UNION ALL

                    SELECT PaymentDate, TotalPrice AS Total, 'Import' AS Type
                    FROM ImportInvoice
                    WHERE MONTH(PaymentDate) = @Month AND YEAR(PaymentDate) = @Year
                ) AS Combined
                GROUP BY CAST(PaymentDate AS DATE)
                ORDER BY Ngay";

            return dbHelper.ExecuteQuery(query, new SqlParameter("@Month", month), new SqlParameter("@Year", year));
        }

        public DataTable GetFinancialDataByMonth(int year)
        {
            string query = @"
                SELECT 
                    MONTH(PaymentDate) AS Thang,
                    ISNULL(SUM(CASE WHEN Type = 'Sale' THEN Total ELSE 0 END), 0) AS TongThu,
                    ISNULL(SUM(CASE WHEN Type = 'Import' THEN Total ELSE 0 END), 0) AS TongChi
                FROM (
                    SELECT PaymentDate, TotalCost AS Total, 'Sale' AS Type
                    FROM SaleInvoice
                    WHERE YEAR(PaymentDate) = @Year

                    UNION ALL

                    SELECT PaymentDate, TotalPrice AS Total, 'Import' AS Type
                    FROM ImportInvoice
                    WHERE YEAR(PaymentDate) = @Year
                ) AS Combined
                GROUP BY MONTH(PaymentDate)
                ORDER BY Thang";

            return dbHelper.ExecuteQuery(query, new SqlParameter("@Year", year));
        }

        public FinancialReportDTO GetMonthlySummary(int month, int year)
        {
            string query = @"
                SELECT 
                    ISNULL(SUM(CASE WHEN Type = 'Sale' THEN Total ELSE 0 END), 0) AS TongThu,
                    ISNULL(SUM(CASE WHEN Type = 'Import' THEN Total ELSE 0 END), 0) AS TongChi
                FROM (
                    SELECT PaymentDate, TotalCost AS Total, 'Sale' AS Type
                    FROM SaleInvoice
                    WHERE MONTH(PaymentDate) = @Month AND YEAR(PaymentDate) = @Year
                    UNION ALL
                    SELECT PaymentDate, TotalPrice AS Total, 'Import' AS Type
                    FROM ImportInvoice
                    WHERE MONTH(PaymentDate) = @Month AND YEAR(PaymentDate) = @Year
                ) AS Combined";

            var table = dbHelper.ExecuteQuery(query, new SqlParameter("@Month", month), new SqlParameter("@Year", year));
            var dto = new FinancialReportDTO
            {
                Revenue = table.Rows.Count > 0 ? Convert.ToDecimal(table.Rows[0]["TongThu"]) : 0,
                Expenses = table.Rows.Count > 0 ? Convert.ToDecimal(table.Rows[0]["TongChi"]) : 0
            };
            return dto;
        }
    }
}
