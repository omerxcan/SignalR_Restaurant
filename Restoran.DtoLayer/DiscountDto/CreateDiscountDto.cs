using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DtoLayer.DiscountDto
{
    public class CreateDiscountDto
    {
        public string Title { get; set; } = null!;
        public string Amount { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
