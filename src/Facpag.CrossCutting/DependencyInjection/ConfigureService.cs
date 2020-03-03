using Facpag.Domain.Interfaces.Services.Bill;
using Facpag.Domain.Interfaces.Services.Detail;
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
            serviceCollection.AddTransient<IBillService, BillService>();
            serviceCollection.AddTransient<IDetailService, DetailService>();
        }
    }
}
