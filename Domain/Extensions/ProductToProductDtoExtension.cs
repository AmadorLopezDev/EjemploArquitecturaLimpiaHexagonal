using Application.Domain.Dtos.ProductsDto;
using Enterprise.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Domain.Extensions
{
    public static class ProductToProductDtoExtension
    {
        public static ProductDto ProductToProductDto(this Product product)
        {
            return new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
            };
        }
    }
}
