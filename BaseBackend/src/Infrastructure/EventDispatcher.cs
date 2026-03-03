using System.Reflection;
using BaseBackend.Contracts;
using BaseBackend.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace BaseBackend.Infrastructure;

public class EventDispatcher : IEventPublisher
{
    private readonly IServiceProvider _serviceProvider;

    public EventDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task Publish<TEvent>(TEvent @event, CancellationToken ct) where TEvent : IDomainEvent
    {
        var listeners = _serviceProvider.GetServices<IEventListener<TEvent>>();

        foreach (var listener in listeners)
        {
            try
            {
                await listener.HandleAsync(@event, ct).ConfigureAwait(false);
            }
            catch
            {
                // Handle Errors
            }
        }
    }
}
