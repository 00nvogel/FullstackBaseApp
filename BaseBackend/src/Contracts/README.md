# Contracts

Interface layer defining ports for infrastructure implementations.

## Contents

- **Events/** - Event handling contracts
  - `IEventListener<T>` - Interface for domain event handlers
  - `IEventPublisher` - Interface for publishing domain events
- **Persistence/** - Data access contracts
  - `IRepository<T>` - Generic repository interface
  - `IExampleRepository` - Specific repository for ExampleModel
  - `IUnitOfWork` - Unit of work pattern interface

## Dependencies

- Shared
- Domain

## Rules

- Only interfaces, no implementations
- Defines contracts that Infrastructure implements
- Defines contracts that Application uses
