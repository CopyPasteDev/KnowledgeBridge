using KnowledgeBridge.Application.Models.Storage;
using KnowledgeBridge.Domain.Documents;

namespace KnowledgeBridge.Application.Abstractions.Storage;

public interface IVectorStore
{
    /// <summary>Сохраняет документ и связанный с ним набор чанков.</summary>
    /// <remarks>Документ идентифицируется по <see cref="SourceDocument.ExternalId"/>.</remarks>
    Task UpsertDocument(SourceDocument document, IReadOnlyList<KnowledgeChunk> chunks, CancellationToken cancellationToken);

    /// <summary>Возвращает наиболее близкие чанки для эмбеддинга запроса.</summary>
    /// <remarks>
    /// Возвращает не более <paramref name="limit"/> результатов,
    /// отсортированных от более релевантного к менее релевантному.
    /// </remarks>
    Task<IReadOnlyList<ChunkSearchResult>> Search(IReadOnlyList<float> embedding, int limit, CancellationToken cancellationToken);
}
