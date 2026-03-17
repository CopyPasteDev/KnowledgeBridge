using KnowledgeBridge.Application.Models.Storage;
using KnowledgeBridge.Domain.Documents;

namespace KnowledgeBridge.Application.Abstractions.Storage;

public interface IVectorStore
{
    Task UpsertDocument(SourceDocument document, IReadOnlyList<KnowledgeChunk> chunks, CancellationToken cancellationToken);

    Task<IReadOnlyList<ChunkSearchResult>> Search(IReadOnlyList<float> embedding, int limit, CancellationToken cancellationToken);
}
