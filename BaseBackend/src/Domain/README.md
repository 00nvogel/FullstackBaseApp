# Domain

Business logic layer containing entities, value objects, and domain events.

## Contents

- **Models/** - Aggregate roots and entities
- **Events/** - Domain events raised by entities

## Dependencies

- Shared

## Rules

- Pure business logic, no infrastructure concerns
- Entities use factory methods (e.g., `Create()`) to enforce invariants
- Business operations raise domain events via `Raise()`
- No dependencies on Application or Infrastructure
