using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
        private readonly IMapper _mapper;
        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _mapper.Map<List<ResultAboutDto>>(_aboutService.TGetAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto aboutDto)
        {
            var value = _mapper.Map<About>(aboutDto);
            _aboutService.TAdd(value);
            return Ok("Hakkımda bilgisi başarılı bir şekilde eklendi");
            //About about = new About()
            //{
            //    ImageUrl = aboutDto.ImageUrl,
            //    Title = aboutDto.Title,
            //    Description = aboutDto.Description
            //};
            //_aboutService.TAdd(about);
            //return Ok("Hakkımda bilgisi başarılı bir şekilde eklendi");
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
            var value = _mapper.Map<About>(aboutDto);
            _aboutService.TUpdate(value);
            return Ok("Hakkımda bilgisi başarılı bir şekilde güncellendi");
            //About about = new About()
            //{
            //    AboutID = aboutDto.AboutID,
            //    ImageUrl = aboutDto.ImageUrl,
            //    Title = aboutDto.Title,
            //    Description = aboutDto.Description
            //};
            //_aboutService.TUpdate(about);
            //return Ok("Hakkımda bilgisi başarılı bir şekilde güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _mapper.Map<GetAboutDto>(_aboutService.TGetById(id));
            return Ok(value);
            //var value = _aboutService.TGetById(id);
            //return Ok(value);
        }
    }
}
