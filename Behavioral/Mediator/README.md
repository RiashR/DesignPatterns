# Mediator Design Pattern

##Claims Processing Workflow

Implementation of the Mediator in the claims processing system.

How: Use a mediator to coordinate actions between departments like underwriting, fraud detection, claim validation, and payout.

Why: Claims processing often involves interactions across different services (e.g., validation, assessment, and payment), where each department or service has to communicate without being tightly coupled to each other.

Example: A ClaimMediator could manage communication across different departments, notifying each department when the claim state changes or when specific actions are required (e.g., notifying fraud detection for high-risk claims).
