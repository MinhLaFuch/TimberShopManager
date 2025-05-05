using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timber_shop_manager.DAL;
using timber_shop_manager.DTO;

namespace timber_shop_manager.BUS
{
    public class ImportDetailBUS
    {
        private ImportDetailDAL dal = new ImportDetailDAL();

        public void Insert(ImportDetailDTO dto)
        {
            dal.Insert(dto);
        }

        public List<ImportDetailDTO> GetInvoiceDetail(string invoiceId)
        {
            return dal.GetImportDetailsByInvoiceId(invoiceId);
        }
    }

}
