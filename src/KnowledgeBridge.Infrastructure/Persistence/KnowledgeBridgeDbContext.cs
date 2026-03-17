using Microsoft.EntityFrameworkCore;

namespace KnowledgeBridge.Infrastructure.Persistence;

internal sealed class KnowledgeBridgeDbContext(DbContextOptions<KnowledgeBridgeDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("vector");

        base.OnModelCreating(modelBuilder);
    }
}
