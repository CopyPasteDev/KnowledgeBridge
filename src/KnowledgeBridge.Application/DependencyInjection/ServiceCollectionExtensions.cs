using Microsoft.Extensions.DependencyInjection;

namespace KnowledgeBridge.Application.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddKnowledgeBridgeApplication(this IServiceCollection services)
    {
        return services;
    }
}
