using Application.Domain.Dtos.ProductsDto;
using Enterprise.Domain.Entities;

namespace Enterprise.Domain.Extensions
{
    public static class ProductToDtoExtension
    {
        public static ProductDto ProductToDto(this Product product)
        {
            return new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
            };
        }
    }
}
