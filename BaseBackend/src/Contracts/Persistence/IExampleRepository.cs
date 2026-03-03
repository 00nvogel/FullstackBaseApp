using BaseBackend.Domain.Models;

namespace BaseBackend.Contracts;

public interface IExampleRepository : IRepository<ExampleModel>
{
    public Task<ExampleModel?> GetByIdAsync(Guid id, CancellationToken ct = default);
}
