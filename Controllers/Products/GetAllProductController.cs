using Adapters.Presenters.Interfaces;
using Application.Domain.Dtos.ProductsDto;
using Application.Ports.InputPorts.Products;
using Application.Ports.OutputPorts.Products;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductController
    {
        private readonly IGetAllProductsInputPort _getAllProductInputPort;
        private readonly IGetAllProductsOuputPort _getAllProductsOutputPort;

        public GetAllProductController(IGetAllProductsInputPort getAllProductInputPort, IGetAllProductsOuputPort getAllProductsOutputPort) => 
            (_getAllProductInputPort, _getAllProductsOutputPort) = (getAllProductInputPort, getAllProductsOutputPort);

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            await _getAllProductInputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDto>>)_getAllProductsOutputPort).Content;
        }

    }
}
