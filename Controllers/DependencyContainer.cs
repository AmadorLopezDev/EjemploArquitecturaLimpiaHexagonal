using Application.Domain.Validators.Products;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddMvcCore()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateProductDtoValidator>());
            return services;
        }
    }
}
