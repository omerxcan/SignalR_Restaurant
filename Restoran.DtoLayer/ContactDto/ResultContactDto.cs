using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DtoLayer.ContactDto
{
    public class ResultContactDto
    {
        public int ContactID { get; set; }
        public string Location { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string FooterDescription { get; set; } = null!;
    }
}
