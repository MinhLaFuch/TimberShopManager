using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class SaleInvoiceDTO
    {
        public static readonly decimal VAT_TAX = Convert.ToDecimal(0.1);
        public static readonly string PREFIX = "SI";
        public static readonly int CODE_LENGTH = 4;

        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public string EmployeeId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalCost { get; set; }
        public string PaymentMethod { get; set; }

        public SaleInvoiceDTO(string id, string phoneNumber, string employeeId, DateTime paymentDate, decimal totalCost, string paymentMethod)
        {
            Id = id;
            PhoneNumber = phoneNumber;
            EmployeeId = employeeId;
            PaymentDate = paymentDate;
            TotalCost = totalCost;
            PaymentMethod = paymentMethod;
        }

        public static class Method
        {
            public static readonly string CRASH = "Tiền mặt", TRANFER = "Chuyển khoản";
        }
    }

}
