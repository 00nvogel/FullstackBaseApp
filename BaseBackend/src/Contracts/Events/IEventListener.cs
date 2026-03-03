using BaseBackend.Shared;

namespace BaseBackend.Contracts;

public interface IEventListener<in TEvent> where TEvent : IDomainEvent
{
    public Task HandleAsync(TEvent @event, CancellationToken ct);
}
