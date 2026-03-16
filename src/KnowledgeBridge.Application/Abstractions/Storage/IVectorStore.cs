using KnowledgeBridge.Application.Models.Storage;
using KnowledgeBridge.Domain.Documents;

namespace KnowledgeBridge.Application.Abstractions.Storage;

public interface IVectorStore
{
    /// <summary>
    /// Создаёт новый документ по внешнему идентификатору или обновляет существующий.
    /// </summary>
    /// <remarks>
    /// Если документа с тем же <see cref="SourceDocument.ExternalId"/> нет,
    /// реализация вставляет документ и все переданные чанки.
    /// Если <see cref="SourceDocument.ContentChecksum"/> совпадает с сохранённым значением,
    /// реализация обновляет только <see cref="SourceDocument.UpdatedAt"/>.
    /// Если checksum отличается, реализация обновляет документ,
    /// удаляет существующие чанки и вставляет переданный набор в одной транзакции.
    /// </remarks>
    Task UpsertDocument(SourceDocument document, IReadOnlyList<KnowledgeChunk> chunks, CancellationToken cancellationToken);

    Task<IReadOnlyList<ChunkSearchResult>> Search(IReadOnlyList<float> embedding, int limit, CancellationToken cancellationToken);
}
