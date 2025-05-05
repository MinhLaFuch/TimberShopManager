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
    public class VoucherBUS
    {
        private readonly VoucherDAL dal = new();

        public DataTable GetAllVouchers()
        {
            return dal.GetAll();
        }

        public string ValidateVoucherId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return "Mã Voucher không được bỏ trống";

            return dal.Exists(id) ? "Mã Voucher đã tồn tại" : "Mã Voucher hợp lệ";
        }

        public void AddVoucher(VoucherDTO voucher)
        {
            if (dal.Exists(voucher.Id))
                throw new Exception("Mã Voucher đã tồn tại");

            dal.Insert(voucher);
        }

        public DataTable GetVoucherCodesOnly()
        {
            return dal.GetAllVoucherCodes();
        }

        public VoucherDTO GetVoucherById(string id)
        {
            return dal.GetVoucherById(id);
        }
    }
}
