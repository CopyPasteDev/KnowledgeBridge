namespace KnowledgeBridge.Infrastructure.Configuration;

public sealed class TelegramBotOptions
{
    public const string SectionName = "TelegramBot";

    public string BotToken { get; init; } = string.Empty;

    public IReadOnlyList<long> WhitelistUserIds { get; init; } = Array.Empty<long>();
}
