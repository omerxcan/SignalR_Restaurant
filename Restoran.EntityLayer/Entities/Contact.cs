using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.EntityLayer.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Location { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string FooterDescription { get; set; } = null!;
    }
}
