using Enterprise.Domain.Entities;

namespace Enterprise.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IAddEntity<Product>, IGetAllEntity<Product>
    {

    }
}
