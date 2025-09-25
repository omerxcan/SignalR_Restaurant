using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.BusinessLayer.Abstract;
using Restoran.DtoLayer.DiscountDto;
using Restoran.EntityLayer.Entities;

namespace Restoran.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            var value = _mapper.Map<Discount>(createDiscountDto);
            _discountService.TAdd(value);
            return Ok("İndirim başarıyla oluşturuldu");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirim başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            var value = _mapper.Map<Discount>(updateDiscountDto);
            _discountService.TUpdate(value);
            return Ok("İndirim başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _mapper.Map<GetDiscountDto>(_discountService.TGetById(id));
            return Ok(value);
        }
    }

}
