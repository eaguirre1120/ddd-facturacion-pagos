using Facpag.Data.Context;
using Facpag.Data.Repository;
using Facpag.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Facpag.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRespository<>));

            serviceCollection.AddDbContext<MyContext>(options =>
            options.UseMySql("Server=localhost;Port=3306;Database=facturacion; Uid=root;Pwd=;"));
        }
    }
}
