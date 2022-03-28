using Enterprise.Domain.Interfaces.Repositories;
using Gateway.Infrastructure.SqlServer.DataContext;

namespace Gateway.Infrastructure.SqlServer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context) => _context = context;

        public Task<int> SaveChangesAssync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
