using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DtoLayer.CategoryDto
{
    public class ResultCategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool Status { get; set; }
    }
}
