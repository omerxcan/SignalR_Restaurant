using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.Api.DAL.Entities;
using Restoran.BusinessLayer.Abstract;
using Restoran.DtoLayer.CategoryDto;

namespace Restoran.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);
            value.Status = true;
            _categoryService.TAdd(value);
            return Ok("Kategori Başarıyla oluşturuldu");
            //_categoryService.TAdd(new Category
            //{
            //    CategoryName = createCategoryDto.CategoryName,
            //    Status = true,
            //});
            //return Ok("Kategori başarıyla oluşturuldu");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("Kategori başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            _categoryService.TUpdate(value);
            return Ok("Kategori başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _mapper.Map<GetCategoryDto>(_categoryService.TGetById(id));
            return Ok(value);
        }

    }
}
