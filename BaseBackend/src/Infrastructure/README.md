# Infrastructure

Persistence and external services layer.

## Contents

- **AppDbContext** - EF Core database context implementing `IUnitOfWork`
- **Configurations/** - Entity type configurations (`IEntityTypeConfiguration<T>`)
- **Repositories/** - Repository implementations
- **EventDispatcher** - Dispatches domain events to handlers

## Dependencies

- Contracts

## Rules

- Implements interfaces from Contracts
- DbSets are `internal` to force repository usage
- Configurations define entity-to-table mappings
- `AddInfrastructure()` registers all infrastructure services
