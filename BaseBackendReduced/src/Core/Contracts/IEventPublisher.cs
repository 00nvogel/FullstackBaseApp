namespace BaseBackendReduced.Core.Contracts;

public interface IEventPublisher
{
    public Task Publish<TEvent>(TEvent @event, CancellationToken ct) where TEvent : IDomainEvent;
}
