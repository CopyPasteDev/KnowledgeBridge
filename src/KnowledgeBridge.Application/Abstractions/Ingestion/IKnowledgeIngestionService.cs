namespace KnowledgeBridge.Application.Abstractions.Ingestion;

public interface IKnowledgeIngestionService
{
    Task Run(CancellationToken cancellationToken);
}
