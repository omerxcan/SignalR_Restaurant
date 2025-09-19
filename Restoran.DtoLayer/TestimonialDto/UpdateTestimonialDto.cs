using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DtoLayer.TestimonialDto
{
    public class UpdateTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public bool Status { get; set; }
    }
}
