namespace BaseBackend.Shared;

public interface IDomainEvent
{
    public DateTime OccurredOnUtc { get; }
}
