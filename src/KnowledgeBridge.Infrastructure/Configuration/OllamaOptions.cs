namespace KnowledgeBridge.Infrastructure.Configuration;

public sealed class OllamaOptions
{
    public const string SectionName = "Ollama";

    public string BaseUrl { get; init; } = "http://localhost:11434";

    public string ChatModel { get; init; } = "qwen2.5:7b";

    public string EmbeddingModel { get; init; } = "nomic-embed-text";
}
