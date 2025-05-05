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
    public class FinancialBUS
    {
        private readonly FinancialDAL dal = new();

        public DataTable GetFinancialDetails(DateTime date, bool byDay)
        {
            return byDay
                ? dal.GetFinancialDataByDay(date.Month, date.Year)
                : dal.GetFinancialDataByMonth(date.Year);
        }

        public FinancialReportDTO GetMonthlyReport(DateTime date)
        {
            return dal.GetMonthlySummary(date.Month, date.Year);
        }
    }
}
