using Restoran.Api.DAL.Entities;
using Restoran.DataAccessLayer.Abstracts;
using Restoran.DataAccessLayer.Contracts;
using Restoran.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(AppDbContext context) : base(context)
        {
        }
    }
}
