namespace KnowledgeBridge.Application.Abstractions.Embeddings;

public interface IEmbeddingGenerator
{
    Task<IReadOnlyList<float>> Generate(string text, CancellationToken cancellationToken);
}
