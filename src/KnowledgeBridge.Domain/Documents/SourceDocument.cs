namespace KnowledgeBridge.Domain.Documents;

public sealed class SourceDocument
{
    public Guid Id { get; init; }

    public required string ExternalId { get; init; }

    public required string Title { get; init; }

    public required string ContentChecksum { get; init; }

    public IReadOnlyDictionary<string, string> Metadata { get; init; } = new Dictionary<string, string>();

    public DateTimeOffset UpdatedAt { get; init; }
}
