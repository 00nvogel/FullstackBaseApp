using BaseBackendReduced.Core;
using BaseBackendReduced.Core.Contracts;
using BaseBackendReduced.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseBackendReduced.Infrastructure;

public class AppDbContext : DbContext, IUnitOfWork
{
    private readonly IEventPublisher _eventPublisher;

    public AppDbContext(DbContextOptions<AppDbContext> options, IEventPublisher eventPublisher) : base(options)
    {
        _eventPublisher = eventPublisher;
    }

    internal DbSet<ExampleModel> Examples => Set<ExampleModel>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    public async Task<int> SaveAsync(CancellationToken ct = default)
    {
        var entities = ChangeTracker.Entries<Entity>()
            .Where(e => e.Entity.DomainEvents.Count > 0)
            .Select(e => e.Entity)
            .ToList();

        var a = await SaveChangesAsync(ct);

        await PublishEvents(entities, ct);

        return 0;
    }

    private async Task PublishEvents(List<Entity> entities, CancellationToken ct)
    {
        var events = entities
            .SelectMany(e => e.DomainEvents)
            .ToList();

        entities.ForEach(e => e.ClearDomainEvents());

        foreach (var ev in events)
        {
            await _eventPublisher.Publish(ev, ct);
        }
    }
}
