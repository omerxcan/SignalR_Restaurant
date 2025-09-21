using AutoMapper;
using Restoran.DtoLayer.ProductDto;
using Restoran.EntityLayer.Entities;

namespace Restoran.Api.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,GetProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductWithCategoryDto>().ReverseMap();
        }
    }
}
