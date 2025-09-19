using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.BusinessLayer.Abstract;
using Restoran.DataAccessLayer.Abstracts;
using Restoran.EntityLayer.Entities;

namespace Restoran.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TAdd(testimonial);
            return Ok("Referans başarıyla eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TUpdate(value);
            return Ok("Referans başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok("Referans başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
    }

}
