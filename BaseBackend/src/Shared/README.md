# Shared

Foundation layer containing reusable building blocks.

## Contents

- **Entities/** - Base classes for domain modeling
  - `Entity` - Base class with domain event support
  - `IAggregateRoot` - Marker interface for aggregate roots
  - `IDomainEvent` - Interface for domain events

## Rules

- Reusable building blocks (base classes, value objects, result types)
- No external package dependencies (except base framework)
- No infrastructure concerns
