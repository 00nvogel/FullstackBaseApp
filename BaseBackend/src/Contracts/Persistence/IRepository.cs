using BaseBackend.Shared;

namespace BaseBackend.Contracts;

public interface IRepository<TAggregate> where TAggregate : class, IAggregateRoot
{
    public Task AddAsync(TAggregate aggregate, CancellationToken ct = default);
    public void Remove(TAggregate aggregate);
}
