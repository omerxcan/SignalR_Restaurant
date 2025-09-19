using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.BusinessLayer.Abstract;
using Restoran.EntityLayer.Entities;

namespace Restoran.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _discountService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDiscount(Discount discount)
        {
            _discountService.TAdd(discount);
            return Ok("İndirim başarıyla oluşturuldu");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirim başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateDiscount(Discount discount)
        {
            _discountService.TUpdate(discount);
            return Ok("İndirim başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }
    }

}
