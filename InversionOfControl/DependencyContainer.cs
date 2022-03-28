using Adapters.Presenters;
using Application.Interactors;
using Gateway.Infrastructure.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InversionOfControl
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddProjectDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddInteractors();
            services.AddPresenters();
            return services;
        }
    }
}
