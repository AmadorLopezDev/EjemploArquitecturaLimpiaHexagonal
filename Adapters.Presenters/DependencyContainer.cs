using Adapters.Presenters.Products;
using Application.Ports.OutputPorts.Products;
using Microsoft.Extensions.DependencyInjection;

namespace Adapters.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
            services.AddScoped<IGetAllProductsOuputPort, GetAllProductsPresenter>();
            return services;
        }
    }
}
