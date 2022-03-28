using Application.Domain.Dtos.ProductsDto;

namespace Application.Ports.OutputPorts.Products
{
    public interface IGetAllProductsOuputPort
    {
        Task Handle(IEnumerable<ProductDto> products);
    }
}
