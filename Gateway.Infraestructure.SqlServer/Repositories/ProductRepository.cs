using Enterprise.Domain.Entities;
using Enterprise.Domain.Interfaces.Repositories;
using Gateway.Infrastructure.SqlServer.DataContext;

namespace Gateway.Infrastructure.SqlServer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) => _context = context;

        public void Add(Product entity)
        {
            _context.Products.Add(entity);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
