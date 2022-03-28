using Adapters.Presenters.Interfaces;
using Application.Domain.Dtos.ProductsDto;
using Application.Ports.OutputPorts.Products;

namespace Adapters.Presenters.Products
{
    public class GetAllProductsPresenter : IGetAllProductsOuputPort, IPresenter<IEnumerable<ProductDto>>
    {
        public IEnumerable<ProductDto> Content { get; private set; }

        public Task Handle(IEnumerable<ProductDto> products)
        {
            Content = products;
            return Task.CompletedTask;
        }
    }
}
