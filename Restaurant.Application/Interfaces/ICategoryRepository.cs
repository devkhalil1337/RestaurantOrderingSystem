

using Restaurant.Core.Entities;

namespace Restaurant.Application.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> AddAsync(Category product);
        Task UpdateAsync(Category product);
        Task DeleteAsync(int id);
    }
}
