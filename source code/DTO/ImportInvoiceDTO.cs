using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace timber_shop_manager.DTO
{
    public class ImportInvoiceDTO
    {
        public static readonly string PREFIX = "IMP";
        public static readonly int CODE_LENGTH = 6;
        public string Id { get; set; }
        public string SupId { get; set; }
        public string ManId { get; set; }
        public DateTime PaymentDate { get; set; }
        public long TotalPrice { get; set; }
        public string PaymentMethod { get; set; }

        public static class Method
        {
            public static readonly string CRASH = "Tiền mặt", TRANFER = "Chuyển khoản";
        }

    }

}
