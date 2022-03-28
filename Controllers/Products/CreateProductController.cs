using Adapters.Presenters.Interfaces;
using Application.Domain.Dtos.ProductsDto;
using Application.Ports.InputPorts.Products;
using Application.Ports.OutputPorts.Products;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        private readonly ICreateProductInputPort _createProductInputPort;
        private readonly ICreateProductOutputPort _createProductOutputPort;

        public CreateProductController(ICreateProductInputPort createProductInputPort, ICreateProductOutputPort createProductOutputPort) => 
            (_createProductInputPort, _createProductOutputPort) = (createProductInputPort, createProductOutputPort);

        [HttpPost]
        public async Task<ProductDto> CreateProduct(CreateProductDto createProductDto)
        {
            await _createProductInputPort.Handle(createProductDto, new CancellationToken());
            return ((IPresenter<ProductDto>)_createProductOutputPort).Content;
        }
    }
}
