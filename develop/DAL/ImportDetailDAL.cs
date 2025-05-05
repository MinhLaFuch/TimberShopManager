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
    public class ImportDetailDAL
    {
        private DatabaseHelper db = new();

        public void Insert(ImportDetailDTO dto)
        {
            string query = @"INSERT INTO ImportDetail 
                        (Id, ProId, Quanitty, Price, Tax, Total, WarrantyDateEnd)
                        VALUES (@Id, @ProId, @Quantity, @Price, @Tax, @Total, @WarrantyDateEnd)";

            db.ExecuteNonQuery(query, new SqlParameter("@Id", dto.Id),
                new SqlParameter("@ProId", dto.ProId),
                new SqlParameter("@Quantity", dto.Quantity),
                new SqlParameter("@Price", dto.Price),
                new SqlParameter("@Tax", dto.Tax),
                new SqlParameter("@Total", dto.Total),
                new SqlParameter("@WarrantyDateEnd", dto.WarrantyDateEnd));
        }


        public List<ImportDetailDTO> GetImportDetailsByInvoiceId(string invoiceId)
        {
            string query = @"
        SELECT 
            sd.ProId AS ProductId,
            p.Name AS ProductName,
            sd.Price,
            sd.Quantity,
            p.CalculationUnit AS Unit,
            sd.Total,
            sd.WarrantyDateEnd
        FROM ImportDetail sd
        JOIN Product p ON sd.ProId = p.Id
        WHERE sd.Id = @invoiceId";

            var dt = db.ExecuteQuery(query, new SqlParameter("@invoiceId", invoiceId));

            return dt.AsEnumerable().Select(row => new ImportDetailDTO
            {
                ProId = row.Field<string>("ProductId"),
                ProName = row.Field<string>("ProductName"),
                Price = row.Field<long>("Price"),
                Quantity = row.Field<int>("Quantity"),
                Unit = row.Field<string>("Unit"),
                Total = row.Field<long>("Total"),
                WarrantyDateEnd = row.Field<DateTime>("WarrantyDateEnd")
            }).ToList();
        }

    }

}
