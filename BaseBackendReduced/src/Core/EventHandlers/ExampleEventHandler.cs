using BaseBackendReduced.Core.Contracts;
using BaseBackendReduced.Core.Events;

namespace BaseBackendReduced.Core.EventHandlers;

public class ExampleEventHandler : IEventListener<ExampleEvent>
{
    public Task HandleAsync(ExampleEvent @event, CancellationToken ct)
    {
        Console.WriteLine(@event.Message);
        return Task.CompletedTask;
    }
}
