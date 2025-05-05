using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class AttendanceDTO
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Review { get; set; }

        public AttendanceDTO() { }

        public AttendanceDTO(string id, DateTime date, string review = null)
        {
            Id = id;
            Date = date;
            Review = review;
        }
    }
}
