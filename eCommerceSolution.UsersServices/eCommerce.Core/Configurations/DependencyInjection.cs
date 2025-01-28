using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}
