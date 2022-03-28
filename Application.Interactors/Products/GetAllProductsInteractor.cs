using Application.Ports.InputPorts.Products;
using Application.Ports.OutputPorts.Products;
using Enterprise.Domain.Entities;
using Enterprise.Domain.Extensions;
using Enterprise.Domain.Interfaces.Repositories;

namespace Application.Interactors.Products
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        private readonly IProductRepository _productRespository;
        private readonly IGetAllProductsOuputPort _getAllProductsOutputPort;

        public GetAllProductsInteractor(IProductRepository productRespository, IGetAllProductsOuputPort getAllProductsOutputPort) =>
            (_productRespository, _getAllProductsOutputPort) = (productRespository, getAllProductsOutputPort);

        public Task Handle()
        {
            IEnumerable<Product> products = _productRespository.GetAll();
            _getAllProductsOutputPort.Handle(products.Select(p => p.ProductToProductDto()).ToList());
            return Task.CompletedTask;
        }
    }
}
