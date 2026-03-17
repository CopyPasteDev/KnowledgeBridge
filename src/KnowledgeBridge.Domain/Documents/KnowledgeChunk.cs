namespace KnowledgeBridge.Domain.Documents;

public sealed class KnowledgeChunk
{
    /// <summary>Внутренний идентификатор чанка.</summary>
    public Guid Id { get; init; }

    /// <summary>Идентификатор родительского документа.</summary>
    public Guid SourceDocumentId { get; init; }

    /// <summary>Текст чанка.</summary>
    public required string Text { get; init; }

    /// <summary>Порядковый номер чанка в документе.</summary>
    public int Index { get; init; }

    /// <summary>Векторное представление чанка.</summary>
    public IReadOnlyList<float> Embedding { get; init; } = Array.Empty<float>();

    /// <summary>Время записи чанка в БД.</summary>
    public DateTimeOffset UpdatedAt { get; init; }
}
