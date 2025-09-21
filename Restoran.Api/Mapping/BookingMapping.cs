using AutoMapper;
using Restoran.DtoLayer.BookingDto;
using Restoran.EntityLayer.Entities;
using System.Runtime.CompilerServices;

namespace Restoran.Api.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking,ResultBookingDto>().ReverseMap();
            CreateMap<Booking,CreateBookingDto>().ReverseMap();
            CreateMap<Booking,GetBookingDto>().ReverseMap();
            CreateMap<Booking,UpdateBookingDto>().ReverseMap();
        }
    }
}
