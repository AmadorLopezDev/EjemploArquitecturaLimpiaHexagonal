using Application.Domain.Dtos.ProductsDto;
using Application.Ports.InputPorts.Products;
using Application.Ports.OutputPorts.Products;
using Enterprise.Domain.Entities;
using Enterprise.Domain.Extensions;
using Enterprise.Domain.Interfaces.Repositories;

namespace Application.Interactors.Products
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateProductOutputPort _createProductOutputPort;

        public CreateProductInteractor(IProductRepository productRepository, IUnitOfWork unitOfWork, ICreateProductOutputPort createProductOutputPort) => 
            (_productRepository, _unitOfWork, _createProductOutputPort) = (productRepository, unitOfWork, createProductOutputPort);

        public async Task Handle(CreateProductDto createProduct, CancellationToken cancellationToken)
        {
            Product newProduct = new Product().ProductFromCreateProductDto(createProduct);
            _productRepository.Add(newProduct);
            await _unitOfWork.SaveChangesAssync(cancellationToken);
            await _createProductOutputPort.Handle(newProduct.ProductToProductDto());
        }
    }
}
