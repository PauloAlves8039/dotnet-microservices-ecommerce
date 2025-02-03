using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogicLayer.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services)
    {
        return services;
    }
}
