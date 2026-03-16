namespace KnowledgeBridge.Domain.Documents;

public sealed class SourceDocument
{
    /// <summary>
    /// Внутренний идентификатор, который приложение генерирует как UUID v7.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Внешний идентификатор источника, который используется как уникальный ключ документа.
    /// </summary>
    public required string ExternalId { get; init; }

    public required string Title { get; init; }

    /// <summary>
    /// Checksum от заголовка и нормализованного текста документа.
    /// </summary>
    public required string ContentChecksum { get; init; }

    /// <summary>
    /// Метаданные источника, включая время изменения данных на стороне источника.
    /// </summary>
    public IReadOnlyDictionary<string, string> Metadata { get; init; } = new Dictionary<string, string>();

    /// <summary>
    /// Время записи в БД.
    /// </summary>
    public DateTimeOffset UpdatedAt { get; init; }
}
