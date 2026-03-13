namespace KnowledgeBridge.Domain.Documents;

public sealed class KnowledgeChunk
{
    public Guid Id { get; init; }

    public Guid SourceDocumentId { get; init; }

    public required string Text { get; init; }

    public int Index { get; init; }

    public IReadOnlyList<float> Embedding { get; init; } = Array.Empty<float>();

    public DateTimeOffset UpdatedAt { get; init; }
}
