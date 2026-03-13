namespace KnowledgeBridge.Application.Abstractions.Ingestion;

public interface ITextChunker
{
    IReadOnlyList<string> Chunk(string text);
}
