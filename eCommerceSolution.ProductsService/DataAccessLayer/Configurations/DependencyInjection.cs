using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
    {
        return services;
    }
}
