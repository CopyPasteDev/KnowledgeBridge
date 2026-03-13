namespace KnowledgeBridge.Infrastructure.Configuration;

public sealed class RagOptions
{
    public const string SectionName = "Rag";

    public int SimilaritySearchLimit { get; init; } = 5;

    public int MaxContextCharacters { get; init; } = 12000;
}
