namespace KnowledgeBridge.Infrastructure.Configuration;

public sealed class YouTrackOptions
{
    public const string SectionName = "YouTrack";

    public string BaseUrl { get; init; } = string.Empty;

    public string PermanentToken { get; init; } = string.Empty;
}
