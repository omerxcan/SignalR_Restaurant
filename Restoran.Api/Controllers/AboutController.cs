using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.BusinessLayer.Abstract;
using Restoran.DtoLayer.AboutDto;
using Restoran.EntityLayer.Entities;

namespace Restoran.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            return Ok(_aboutService.TGetAll());
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto aboutDto)
        {
            About about = new About()
            {
                ImageUrl = aboutDto.ImageUrl,
                Title = aboutDto.Title,
                Description = aboutDto.Description
            };
            _aboutService.TAdd(about);
            return Ok("Hakkımda bilgisi başarılı bir şekilde eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımda bilgisi başarılı bir şekilde silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto aboutDto)
        {
            About about = new About()
            {
                AboutID = aboutDto.AboutID,
                ImageUrl = aboutDto.ImageUrl,
                Title = aboutDto.Title,
                Description = aboutDto.Description
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkımda bilgisi başarılı bir şekilde güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }
    }
}
