using Microsoft.EntityFrameworkCore;
using Restoran.DataAccessLayer.Abstracts;
using Restoran.DataAccessLayer.Contracts;
using Restoran.DataAccessLayer.Repositories;
using Restoran.DtoLayer.ProductDto;
using Restoran.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly AppDbContext _context;
        public EfProductDal(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetProductsWithCategory()
        {
            var values = _context.Products.Include(x => x.Category).ToList();
            return values;
            //var values = _context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategoryDto
            //{
            //    CategoryName = y.Category.CategoryName,
            //    ProductID = y.ProductID,
            //    ProductName = y.ProductName,
            //    Description = y.Description,
            //    Price = y.Price,
            //    ImageUrl = y.ImageUrl,
            //    ProductStatus = y.ProductStatus,
            //}).ToList();   
            //return values;
        }
    }
}
