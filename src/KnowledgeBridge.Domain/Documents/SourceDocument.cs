namespace KnowledgeBridge.Domain.Documents;

public sealed class SourceDocument
{
    /// <summary>Внутренний идентификатор документа.</summary>
    public Guid Id { get; init; }

    /// <summary>Внешний идентификатор документа в источнике.</summary>
    public required string ExternalId { get; init; }

    /// <summary>Заголовок документа.</summary>
    public required string Title { get; init; }

    /// <summary>Контрольная сумма содержимого документа.</summary>
    public required string ContentChecksum { get; init; }

    /// <summary>Метаданные документа из источника.</summary>
    public IReadOnlyDictionary<string, string> Metadata { get; init; } = new Dictionary<string, string>();

    /// <summary>Время записи документа в БД.</summary>
    public DateTimeOffset UpdatedAt { get; init; }
}
