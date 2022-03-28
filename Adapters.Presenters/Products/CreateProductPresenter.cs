using Adapters.Presenters.Interfaces;
using Application.Domain.Dtos.ProductsDto;
using Application.Ports.OutputPorts.Products;

namespace Adapters.Presenters.Products
{
    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDto>
    {
        public ProductDto Content { get; private set; }

        public Task Handle(ProductDto newProduct)
        {
            Content = newProduct;
            return Task.CompletedTask;
        }
    }
}
