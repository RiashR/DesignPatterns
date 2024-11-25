# State Pattern

## Overview

The **State Pattern** is a behavioral design pattern that allows an object to alter its behavior when its internal state changes. 
It represents state-specific behavior in a separate class and delegates behavior to the current state.

This pattern is part of the **Gang of Four (GoF)** design patterns and is particularly useful for managing complex state 
transitions in a clean and maintainable way.

---

## Key Components

1. **State Interface (`IState`)**:
   - Defines the common interface for all concrete states.
   - Declares the methods that each state must implement.

2. **Concrete States (`ConcreteStateA`, `ConcreteStateB`)**:
   - Implement the behavior associated with a particular state of the context.

3. **Context (`Context`)**:
   - Maintains a reference to the current state.
   - Delegates requests to the current state.

---

## UML Diagram

```plaintext
+------------------+       implements       +------------------+
|     Context      |----------------------->|       State       |
|------------------|                        +------------------+
| - state: State   |                               ^      
|------------------|                               |      
| + setState(State)|      +------------------------+-----------------------+
| + request()      |      |                                                |
+------------------+  +---------------+                       +----------------+
                     | ConcreteStateA |                       | ConcreteStateB |
                     +---------------+                       +----------------+
                     | handleRequest()|                       | handleRequest()|
                     +---------------+                       +----------------+
```

---

## When to Use the State Pattern

The State Pattern is suitable when:
1. **An object’s behavior depends on its state**:
   - E.g., a video player can play, pause, or stop based on its current mode.
2. **You want to avoid complex `if-else` or `switch` logic**:
   - Instead of hardcoding state transitions, the State Pattern encapsulates them in state classes.
3. **New states need to be added frequently**:
   - Adding a new state becomes as simple as adding a new class.

---

## Examples of Use Cases

1. **Games**:
   - A character can have different states like running, jumping, or idle. Each state has distinct behaviors.
2. **UI Workflow**:
   - Buttons in a UI may be enabled, disabled, or loading based on the application state.
3. **Vending Machines**:
   - The behavior changes based on whether an item is selected, payment is pending, or the transaction is complete.
4. **Tetris Game**:
   - Different game states such as idle, playing, paused, or game over.

---


## Advantages

1. **Single Responsibility Principle**:
   - Each state handles its specific behavior, making the system easier to maintain and extend.
2. **Open/Closed Principle**:
   - Adding new states doesn’t require modifying existing states or the context.
3. **Eliminates Complex Conditionals**:
   - Avoids `if-else` or `switch` statements for state management.
4. **Encapsulation**:
   - State-specific behavior is encapsulated in separate classes.

---

## Disadvantages

1. **Increased Complexity**:
   - Requires creating multiple state classes, which can lead to more files and added complexity for simple systems.
2. **Context-State Coupling**:
   - The context must be aware of all possible states to initialize and manage transitions.
3. **Potential Overhead**:
   - In scenarios with many small states, creating separate classes for each can be overkill.

---


## Comparison with Other Patterns

| **Pattern**       | **Comparison**                                                                                                                                 |
|--------------------|-----------------------------------------------------------------------------------------------------------------------------------------------|
| **Strategy**       | Focuses on algorithms that can be swapped out at runtime, while State is about object behavior based on internal state.                       |
| **Observer**       | Manages dependent objects reacting to state changes, whereas State focuses on encapsulating the behavior within the object itself.            |
| **Mediator**       | Manages communication between multiple objects, while State is concerned with managing behavior of one object in different states.            |

---

## Summary

The **State Pattern** is a powerful tool for handling complex state-based behavior in a clean, maintainable way. It is ideal for scenarios where objects transition between multiple states with distinct behaviors, and it avoids hardcoding state transitions.

---

