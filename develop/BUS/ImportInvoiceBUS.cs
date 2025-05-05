using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timber_shop_manager.DAL;
using timber_shop_manager.DTO;

namespace timber_shop_manager.BUS
{
    public class ImportInvoiceBUS
    {
        private ImportInvoiceDAL dal = new();
        public void Insert(ImportInvoiceDTO dto)
        {
            dal.Insert(dto);
        }

        public void UpdateTotal(string id, long total)
        {
            dal.UpdateTotal(id, total);
        }
        public string GenerateNewInvoiceId()
        {
            string lastId = dal.GetLastInvoiceId();
            return Program.GenerateNextCode(lastId, ImportInvoiceDTO.PREFIX, ImportInvoiceDTO.CODE_LENGTH);
        }

        public DataTable LoadAllImportInvoices()
        {
            return dal.GetAll(); 
        }

    }
}
