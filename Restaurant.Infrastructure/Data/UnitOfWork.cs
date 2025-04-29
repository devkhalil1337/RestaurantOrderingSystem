using Restaurant.Application.Interfaces;

namespace Restaurant.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RestaurantDbContext _context;

        public IProductRepository Products { get; }
        public ICategoryRepository Category { get; }
        public UnitOfWork(RestaurantDbContext context,
                          IProductRepository productRepository,
                          ICategoryRepository category)
        {
            _context = context;
            Products = productRepository;
            Category = category;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
