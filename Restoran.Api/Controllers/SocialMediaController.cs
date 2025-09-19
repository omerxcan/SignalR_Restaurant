using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.BusinessLayer.Abstract;
using Restoran.EntityLayer.Entities;

namespace Restoran.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _socialMediaService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.TAdd(socialMedia);
            return Ok("Sosyal medya başarıyla eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            _socialMediaService.TUpdate(value);
            return Ok("Sosyal medya başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.TUpdate(socialMedia);
            return Ok("Sosyal medya başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }
    }
}
