using AutoMapper;
using Restaurant.Application.DTOs;
using Restaurant.Core.Entities;

namespace Restaurant.Infrastructure.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();

        }
    }
}
