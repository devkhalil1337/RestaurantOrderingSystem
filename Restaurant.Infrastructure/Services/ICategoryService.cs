using Restaurant.Application.DTOs;
using Restaurant.Core.Entities;

namespace Restaurant.Infrastructure.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<CategoryDto> GetByIdAsync(int id);
        Task<CategoryDto> AddAsync(CategoryDto product);
        Task UpdateAsync(CategoryDto product);
        Task DeleteAsync(int id);
    }
}
