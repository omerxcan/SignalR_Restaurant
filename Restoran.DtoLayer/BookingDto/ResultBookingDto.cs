using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DtoLayer.BookingDto
{
    public class ResultBookingDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
