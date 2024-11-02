# Insurance Claim Processing with Mediator Pattern

## Overview

This project demonstrates an insurance claim processing system using the **Mediator Pattern** in C#. The solution enables separate services (like fraud detection and claim approval) to communicate through a central mediator, promoting loose coupling and simplifying service interaction.

## Structure

- **Claim Events**: Represents specific actions or statuses in the claim lifecycle (e.g., `ValidateClaimEvent`, `FraudCheckCompletedEvent`).
- **Service Interfaces**: Define the operations of key services (`IFraudDetectionService`, `IClaimApprovalService`).
- **Mediator**: The `ClaimMediator` class routes events between services based on their type, ensuring services communicate indirectly.
- **Concrete Services**: Implementations of the fraud detection and claim approval services handle specific claim operations.
- **Program.cs**: Demonstrates the process of claim validation and approval using the mediator.
- **Unit Tests**: NUnit tests (using NSubstitute and FluentAssertions) verify mediator routing and ensure proper interaction between services.

## Key Concepts

1. **Mediator Pattern**: A design pattern where an intermediary (the mediator) coordinates communication between components, reducing direct dependencies.
2. **Loose Coupling**: Services do not directly depend on each other but rely on the mediator for message routing.
3. **Extensibility**: New services or events can be easily integrated without modifying existing services.

## Running the Solution

1. **Dependencies**: Install NUnit, FluentAssertions, and NSubstitute for testing.
2. **Usage**: Run the `Program.cs` to see claim validation and approval in action.
3. **Testing**: Execute the NUnit tests to validate functionality.

This solution is well-suited for insurance systems requiring coordinated interactions across multiple services, supporting scalability and maintainability.
