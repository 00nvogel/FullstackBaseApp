using BaseBackend.Domain.Events;
using BaseBackend.Shared;

namespace BaseBackend.Domain.Models;

public class ExampleModel : Entity, IAggregateRoot
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;

    private ExampleModel() { } // EF Core

    public static ExampleModel Create(string name)
    {
        var model = new ExampleModel
        {
            Id = Guid.NewGuid(),
            Name = name
        };

        model.Raise(new ExampleEvent(DateTime.UtcNow, $"ExampleModel created: {name}"));

        return model;
    }

    public void Rename(string newName)
    {
        Name = newName;
        Raise(new ExampleEvent(DateTime.UtcNow, $"ExampleModel renamed to: {newName}"));
    }
}
