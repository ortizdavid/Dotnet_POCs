using GenericRepository.Models;

namespace GenericRepository.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetByPriceRange(float minPrice, float maxPrice)
        {
            return _dbSet.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }
    }
}