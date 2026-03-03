namespace BaseBackendReduced.Core.Contracts;

public interface IUnitOfWork
{
    public Task<int> SaveAsync(CancellationToken ct = default);
}
