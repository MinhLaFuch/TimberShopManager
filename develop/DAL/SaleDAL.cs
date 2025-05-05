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
    public class SaleDAL
    {
        private readonly DatabaseHelper db = new();

        public void SaveInvoice(SaleInvoiceDTO invoice)
        {
            string query = @"INSERT INTO SaleInvoice (Id, PhoneNumber, SalId, PaymentDate, TotalCost, PaymentMethod)
                         VALUES (@Id, @PhoneNumber, @SalId, @PaymentDate, @TotalCost, @PaymentMethod)";
            db.ExecuteNonQuery(query,
                new SqlParameter("@Id", invoice.Id),
                new SqlParameter("@PhoneNumber", invoice.PhoneNumber),
                new SqlParameter("@SalId", invoice.EmployeeId),
                new SqlParameter("@PaymentDate", invoice.PaymentDate),
                new SqlParameter("@TotalCost", invoice.TotalCost),
                new SqlParameter("@PaymentMethod", invoice.PaymentMethod));
        }

        public void SaveSaleDetail(SaleDetailDTO detail)
        {
            string query = @"INSERT INTO SaleDetail (Id, ProId, Quantity, Price, Tax, Total, WarrantyEnd)
                         VALUES (@Id, @ProId, @Quantity, @Price, @Tax, @Total, @WarrantyEnd)";
            db.ExecuteNonQuery(query,
                new SqlParameter("@Id", detail.InvoiceId),
                new SqlParameter("@ProId", detail.ProductId),
                new SqlParameter("@Quantity", detail.Quantity),
                new SqlParameter("@Price", detail.Price),
                new SqlParameter("@Tax", detail.Tax),
                new SqlParameter("@Total", detail.Total),
                new SqlParameter("@WarrantyEnd", detail.WarrantyEnd));
        }

        public string GetLastInvoiceId()
        {
            object result = db.ExecuteScalar("SELECT MAX(Id) FROM SaleInvoice");
            return result == DBNull.Value ? "SI0000" : result.ToString();
        }

        public DataTable GetAllInvoices()
        {
            string query = @"SELECT * FROM SaleInvoice";
            return db.ExecuteQuery(query);
        }

        public void SaveAppliedVoucher(string invoiceId, string voucherId)
        {
            string query = "INSERT INTO Applied (VouId, Id) VALUES (@vouId, @invoiceId)";
            db.ExecuteNonQuery(query,
                new SqlParameter("@vouId", voucherId),
                new SqlParameter("@invoiceId", invoiceId));
        }

        public List<InvoiceDetailDTO> GetInvoiceDetails(string invoiceId)
        {
            string query = @"
        SELECT 
            sd.ProId AS ProductId,
            p.Name AS ProductName,
            sd.Price,
            sd.Quantity,
            p.CalculationUnit AS Unit,
            sd.Total,
            sd.WarrantyEnd
        FROM SaleDetail sd
        JOIN Product p ON sd.ProId = p.Id
        WHERE sd.Id = @invoiceId";

            var dt = db.ExecuteQuery(query, new SqlParameter("@invoiceId", invoiceId));

            return dt.AsEnumerable().Select(row => new InvoiceDetailDTO
            {
                ProductId = row.Field<string>("ProductId"),
                ProductName = row.Field<string>("ProductName"),
                Price = row.Field<long>("Price"),
                Quantity = row.Field<int>("Quantity"),
                Unit = row.Field<string>("Unit"),
                Total = row.Field<long>("Total"),
                WarrantyEnd = row.Field<DateTime>("WarrantyEnd")
            }).ToList();
        }

    }

}
