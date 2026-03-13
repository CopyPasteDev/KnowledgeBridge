using KnowledgeBridge.Application.Models.Ingestion;

namespace KnowledgeBridge.Application.Abstractions.Ingestion;

public interface IYouTrackSourceClient
{
    Task<IReadOnlyList<SourceIssue>> GetResolvedIssues(CancellationToken cancellationToken);
}
