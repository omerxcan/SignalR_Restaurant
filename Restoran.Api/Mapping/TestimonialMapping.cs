using AutoMapper;
using Restoran.DtoLayer.TestimonialDto;
using Restoran.EntityLayer.Entities;

namespace Restoran.Api.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial,ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,UpdateTestimonialDto>().ReverseMap();
        }
    }
}
