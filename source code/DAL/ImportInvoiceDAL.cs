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
    public class ImportInvoiceDAL
    {
        private DatabaseHelper db = new();
        public void Insert(ImportInvoiceDTO dto)
        {
            string query = @"INSERT INTO ImportInvoice (Id, SupId, ManId, PaymentDate, TotalPrice, PaymentMethod) 
                     VALUES (@Id, @SupId, @ManId, @PaymentDate, @TotalPrice, @Method)";

            db.ExecuteNonQuery(query, 
                new SqlParameter("@Id", dto.Id),
                new SqlParameter("@SupId", dto.SupId),
                new SqlParameter("@ManId", dto.ManId),
                new SqlParameter("@PaymentDate", dto.PaymentDate),
                new SqlParameter("@TotalPrice", dto.TotalPrice),
                new SqlParameter("@Method", dto.PaymentMethod ?? ""));
        }

        public void UpdateTotal(string id, long total)
        {
            string query = "UPDATE ImportInvoice SET TotalPrice = @Total WHERE Id = @Id";

            db.ExecuteNonQuery(query, 
                new SqlParameter("@Total", total),
                new SqlParameter("@Id", id));
        }

        public string GetLastInvoiceId()
        {
            string query = "SELECT TOP 1 Id FROM ImportInvoice ORDER BY Id DESC";
            var result = db.ExecuteScalar(query);
            return result?.ToString();
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM ImportInvoice"; 
            return db.ExecuteQuery(query);     
        }
    }
}
