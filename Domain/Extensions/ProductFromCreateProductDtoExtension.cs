using Application.Domain.Dtos.ProductsDto;
using Enterprise.Domain.Entities;

namespace Enterprise.Domain.Extensions
{
    public static class ProductFromCreateProductDtoExtension
    {
        public static Product ProductFromCreateProductDto(this Product product, CreateProductDto newProduct)
        {
            return new Product()
            {
                Name = newProduct.Name,
            };
        }
    }
}
