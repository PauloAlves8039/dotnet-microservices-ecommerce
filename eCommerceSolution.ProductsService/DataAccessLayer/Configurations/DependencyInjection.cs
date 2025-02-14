using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using DataAccessLayer.Repositories;
using DataAccessLayer.RepositoryContracts;

namespace DataAccessLayer.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionStringTemplate = configuration.GetConnectionString("DefaultConnection")!;

        var connectionString = connectionStringTemplate
          .Replace("$MYSQL_HOST", Environment.GetEnvironmentVariable("MYSQL_HOST"))
          .Replace("$MYSQL_PASSWORD", Environment.GetEnvironmentVariable("MYSQL_PASSWORD"));

        services.AddDbContext<ApplicationDbContext>(options => {
            options.UseMySQL(connectionString);
        });

        services.AddScoped<IProductsRepository, ProductsRepository>();

        return services;
    }
}
