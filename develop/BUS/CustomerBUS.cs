using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timber_shop_manager.DAL.TimberShop.DAL;
using timber_shop_manager.DTO;

namespace timber_shop_manager.BUS
{
    public class CustomerBUS
    {
        private readonly CustomerDAL dal = new();

        public CustomerDTO GetCustomer(string phone)
        {
            return dal.GetByPhone(phone);
        }

        public void SaveCustomer(CustomerDTO customer)
        {
            if (dal.Exists(customer.PhoneNumber))
                dal.Update(customer);
            else
                dal.Insert(customer);
        }

        public void DeleteCustomer(string phone)
        {
            dal.Delete(phone);
        }

        public DataTable LoadAll()
        {
            return dal.GetAll();
        }
        public List<string> GetAllCustomerPhoneNumbers()
        {
            return dal.GetAllPhoneNumbers();
        }
    }
}
