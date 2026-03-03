using BaseBackendReduced.Core.Contracts;
using BaseBackendReduced.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseBackendReduced.Infrastructure.Repositories;

public class ExampleRepository : IExampleRepository
{
    private readonly AppDbContext _dbContext;

    public ExampleRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(ExampleModel aggregate, CancellationToken ct = default)
    {
        await _dbContext.Examples.AddAsync(aggregate, ct);
    }

    public void Remove(ExampleModel aggregate)
    {
        _dbContext.Examples.Remove(aggregate);
    }

    public async Task<ExampleModel?> GetByIdAsync(Guid id, CancellationToken ct = default)
    {
        return await _dbContext.Examples.FirstOrDefaultAsync(e => e.Id == id, ct);
    }
}
