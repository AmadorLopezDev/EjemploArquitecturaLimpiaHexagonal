using Application.Domain.Dtos.ProductsDto;

namespace Application.Ports.OutputPorts.Products
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDto newProduct);
    }
}
