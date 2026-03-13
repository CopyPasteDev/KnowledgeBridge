namespace KnowledgeBridge.Application.Models.Ingestion;

public sealed class SourceIssue
{
    public required string Id { get; init; }

    public required string Summary { get; init; }

    public string? Description { get; init; }

    public IReadOnlyList<string> Comments { get; init; } = Array.Empty<string>();

    public DateTimeOffset UpdatedAt { get; init; }
}
