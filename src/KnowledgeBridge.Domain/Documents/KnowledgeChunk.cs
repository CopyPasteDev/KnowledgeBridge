namespace KnowledgeBridge.Domain.Documents;

public sealed class KnowledgeChunk
{
    /// <summary>
    /// Внутренний идентификатор чанка, который генерируется заново при каждой переиндексации.
    /// </summary>
    public Guid Id { get; init; }

    public Guid SourceDocumentId { get; init; }

    public required string Text { get; init; }

    /// <summary>
    /// Порядок чанка внутри исходного документа. Должен быть уникальным в рамках документа.
    /// </summary>
    public int Index { get; init; }

    public IReadOnlyList<float> Embedding { get; init; } = Array.Empty<float>();

    /// <summary>
    /// Время записи в БД.
    /// </summary>
    public DateTimeOffset UpdatedAt { get; init; }
}
