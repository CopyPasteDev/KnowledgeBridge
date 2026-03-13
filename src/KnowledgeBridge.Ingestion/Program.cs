using KnowledgeBridge.Application.DependencyInjection;
using KnowledgeBridge.Infrastructure.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddKnowledgeBridgeApplication();
builder.Services.AddKnowledgeBridgeInfrastructure(builder.Configuration);
builder.Services.AddHostedService<IngestionWorker>();

IHost host = builder.Build();
await host.RunAsync();

internal sealed class IngestionWorker(ILogger<IngestionWorker> logger) : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("KnowledgeBridge ingestion host started.");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("KnowledgeBridge ingestion host stopped.");
        return Task.CompletedTask;
    }
}
