using AutoMapper;
using Restaurant.Application.DTOs;
using Restaurant.Core.Entities;

namespace Restaurant.Infrastructure.MappingProfiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();

        }
    }
}
