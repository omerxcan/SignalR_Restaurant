using Restoran.DataAccessLayer.Abstracts;
using Restoran.DataAccessLayer.Contracts;
using Restoran.DataAccessLayer.Repositories;
using Restoran.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(AppDbContext context) : base(context)
        {
        }
    }
}
