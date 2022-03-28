using Application.Domain.Dtos.ProductsDto;

namespace Application.Ports.InputPorts.Products
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDto createProduct, CancellationToken cancellationToken);
    }
}
