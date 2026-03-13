using KnowledgeBridge.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KnowledgeBridge.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddKnowledgeBridgeInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddOptions<OllamaOptions>()
            .Bind(configuration.GetSection(OllamaOptions.SectionName));

        services
            .AddOptions<PostgresVectorStoreOptions>()
            .Bind(configuration.GetSection(PostgresVectorStoreOptions.SectionName));

        services
            .AddOptions<RagOptions>()
            .Bind(configuration.GetSection(RagOptions.SectionName));

        services
            .AddOptions<TelegramBotOptions>()
            .Bind(configuration.GetSection(TelegramBotOptions.SectionName));

        services
            .AddOptions<YouTrackOptions>()
            .Bind(configuration.GetSection(YouTrackOptions.SectionName));

        return services;
    }
}
