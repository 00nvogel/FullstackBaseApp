namespace BaseBackendReduced.Core.Events;

public record ExampleEvent(DateTime OccurredOnUtc, string Message) : IDomainEvent;
