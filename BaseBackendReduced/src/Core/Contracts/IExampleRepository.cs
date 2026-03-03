using BaseBackendReduced.Core.Models;

namespace BaseBackendReduced.Core.Contracts;

public interface IExampleRepository : IRepository<ExampleModel>
{
    public Task<ExampleModel?> GetByIdAsync(Guid id, CancellationToken ct = default);
}
