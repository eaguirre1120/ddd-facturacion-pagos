using Facpag.Domain.Interfaces.Services.Product;
using Facpag.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Facpag.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProductService, ProductService>();
        }
    }
}
