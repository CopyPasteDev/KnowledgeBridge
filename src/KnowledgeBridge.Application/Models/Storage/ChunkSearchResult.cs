using KnowledgeBridge.Domain.Documents;

namespace KnowledgeBridge.Application.Models.Storage;

public sealed class ChunkSearchResult
{
    public required KnowledgeChunk Chunk { get; init; }

    public required SourceDocument Document { get; init; }

    public double Score { get; init; }
}
