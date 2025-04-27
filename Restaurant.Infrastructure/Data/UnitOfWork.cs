using Restaurant.Application.Interfaces;

namespace Restaurant.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RestaurantDbContext _context;

        public IProductRepository Products { get; }

        public UnitOfWork(RestaurantDbContext context,
                          IProductRepository productRepository)
        {
            _context = context;
            Products = productRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
