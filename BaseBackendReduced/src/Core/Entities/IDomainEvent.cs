namespace BaseBackendReduced.Core;

public interface IDomainEvent
{
    public DateTime OccurredOnUtc { get; }
}
