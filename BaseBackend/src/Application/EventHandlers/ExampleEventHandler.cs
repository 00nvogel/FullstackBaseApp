using BaseBackend.Contracts;
using BaseBackend.Domain.Events;

namespace BaseBackend.Application.EventHandlers;

public class ExampleEventHandler : IEventListener<ExampleEvent>
{
    public Task HandleAsync(ExampleEvent @event, CancellationToken ct)
    {
        Console.WriteLine(@event.Message);
        return Task.CompletedTask;
    }
}
