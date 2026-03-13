using KnowledgeBridge.Application.DependencyInjection;
using KnowledgeBridge.Infrastructure.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddKnowledgeBridgeApplication();
builder.Services.AddKnowledgeBridgeInfrastructure(builder.Configuration);
builder.Services.AddHostedService<TelegramBotWorker>();

IHost host = builder.Build();
await host.RunAsync();

internal sealed class TelegramBotWorker(ILogger<TelegramBotWorker> logger) : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("KnowledgeBridge Telegram bot host started.");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("KnowledgeBridge Telegram bot host stopped.");
        return Task.CompletedTask;
    }
}
