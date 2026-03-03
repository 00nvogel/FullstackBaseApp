# Web

API entry point and composition root.

## Contents

- **Program.cs** - Application startup and DI configuration

## Dependencies

- Application
- Infrastructure

## Rules

- Registers services via `AddInfrastructure()` and `AddApplication()`
- Defines API endpoints
- No business logic
- Composition root - wires everything together
