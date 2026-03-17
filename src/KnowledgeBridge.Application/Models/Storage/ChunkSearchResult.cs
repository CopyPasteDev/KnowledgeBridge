using KnowledgeBridge.Domain.Documents;

namespace KnowledgeBridge.Application.Models.Storage;

public sealed class ChunkSearchResult
{
    /// <summary>Найденный чанк.</summary>
    public required KnowledgeChunk Chunk { get; init; }

    /// <summary>Документ, которому принадлежит найденный чанк.</summary>
    public required SourceDocument Document { get; init; }

    /// <summary>Оценка релевантности результата.</summary>
    public double Score { get; init; }
}
