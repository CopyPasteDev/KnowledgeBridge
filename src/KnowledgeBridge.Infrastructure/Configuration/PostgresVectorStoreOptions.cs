namespace KnowledgeBridge.Infrastructure.Configuration;

public sealed class PostgresVectorStoreOptions
{
    public const string SectionName = "PostgresVectorStore";

    public string ConnectionString { get; init; } = string.Empty;

    public int EmbeddingDimensions { get; init; } = 768;
}
