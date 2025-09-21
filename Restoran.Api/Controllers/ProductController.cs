using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restoran.BusinessLayer.Abstract;
using Restoran.DataAccessLayer.Contracts;
using Restoran.DtoLayer.ProductDto;
using Restoran.EntityLayer.Entities;
using System.Reflection.Metadata.Ecma335;

namespace Restoran.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly AppDbContext _context;

        public ProductController(IProductService productService, AppDbContext context)
        {
            _productService = productService;
            _context = context;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetAll();
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var values = _context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategoryDto
            {
                CategoryName = y.Category.CategoryName,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                Description = y.Description,
                Price = y.Price,
                ImageUrl = y.ImageUrl,
                ProductStatus = y.ProductStatus,
            }).ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.TAdd(product);
            return Ok("Ürün başarıyla oluşturuldu");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return Ok("Ürün başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
    }

}
