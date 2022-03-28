using Application.Interactors.Products;
using Application.Ports.InputPorts.Products;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Interactors
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddInteractors(this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();
            return services;
        }
    }
}
