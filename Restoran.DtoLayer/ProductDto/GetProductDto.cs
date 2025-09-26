using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DtoLayer.ProductDto
{
    public class GetProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public bool ProductStatus { get; set; }
        public int CategoryID { get; set; }
    }
}
