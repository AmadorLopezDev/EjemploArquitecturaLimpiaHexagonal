using Application.Domain.Dtos.ProductsDto;
using FluentValidation;

namespace Application.Domain.Validators.Products
{
    public class CreateProductDtoValidator: AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("To Create a Product need a Name with value.");
            RuleFor(x => x.Name.Trim()).NotEmpty().WithMessage("To Create a Product need a Name with value.");
        }
    }
}
