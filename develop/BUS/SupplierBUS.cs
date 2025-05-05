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
    public class SupplierBUS
    {
        private SupplierDAL supplierDAL = new SupplierDAL();

        public DataTable GetAll()
        {
            return supplierDAL.GetAllSuppliers();
        }

        public void SaveSupplier(SupplierDTO supplier)
        {
            supplierDAL.AddOrUpdate(supplier);
        }

        public void DeleteSupplier(SupplierDTO supplier)
        {
            supplierDAL.Delete(supplier);
        }

        public List<string> GetSupplierPhoneNumbers()
        {
            DataTable dt = supplierDAL.GetAllSuppliers();
            return dt.AsEnumerable()
                     .Select(row => row["ContactNumber"].ToString())
                     .Where(phone => !string.IsNullOrWhiteSpace(phone))
                     .ToList();
        }

        public SupplierDTO GetSupplierByPhone(string phoneNumber)
        {
            return supplierDAL.GetByPhone(phoneNumber);
        }

        public SupplierDTO GetSupplierById(string id)
        {
            return supplierDAL.GetById(id);
        }

        public string GenerateNextSupplierId()
        {
            string lastId = supplierDAL.GetLastSupplierId();
            return Program.GenerateNextCode(lastId, SupplierDTO.PREFIX, SupplierDTO.CODE_LENGTH);
        }
    }
}
