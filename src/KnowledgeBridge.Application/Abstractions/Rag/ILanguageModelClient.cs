namespace KnowledgeBridge.Application.Abstractions.Rag;

public interface ILanguageModelClient
{
    Task<string> Complete(string prompt, CancellationToken cancellationToken);
}
