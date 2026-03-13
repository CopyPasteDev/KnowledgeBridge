using KnowledgeBridge.Application.Models.Rag;

namespace KnowledgeBridge.Application.Abstractions.Rag;

public interface IRagService
{
    Task<RagAnswer> Ask(RagQuestion question, CancellationToken cancellationToken);
}
