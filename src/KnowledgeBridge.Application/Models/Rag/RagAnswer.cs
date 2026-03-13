namespace KnowledgeBridge.Application.Models.Rag;

public sealed class RagAnswer
{
    public required string Answer { get; init; }

    public IReadOnlyList<RagSource> Sources { get; init; } = Array.Empty<RagSource>();
}
