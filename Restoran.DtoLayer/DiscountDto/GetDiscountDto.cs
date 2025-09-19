using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DtoLayer.DiscountDto
{
    public class GetDiscountDto
    {
        public int DiscountID { get; set; }
        public string Title { get; set; } = null!;
        public string Amount { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
