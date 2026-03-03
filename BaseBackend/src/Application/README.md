# Application

Use case layer containing event handlers and application services.

## Contents

- **EventHandlers/** - Handlers for domain events

## Dependencies

- Contracts

## Rules

- Orchestrates domain logic
- Implements `IEventListener<T>` for domain event handling
- No direct infrastructure dependencies
- Handlers are auto-registered via `AddApplication()`
