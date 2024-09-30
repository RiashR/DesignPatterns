# Composite Design Pattern

## Contains code example of a client's Insurance Policy details .

The example models insurance policies, where you can have a composite of policies, such as a general insurance policy that can include both Car and Home insurance as well as individual add-ons.

## Composite Pattern Key Concepts:
- **Component**: Declares the interface for objects in the composition.
- **Leaf**: Represents leaf objects in the composition (i.e., objects with no children).
- **Composite**: Defines behavior for components having children and stores child components.

# Brief History of the Composite Pattern:
The Composite Pattern was first formalized as part of the Gang of Four (GoF) design patterns in the book Design Patterns: Elements of Reusable Object-Oriented Software (1994) by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides. The book cataloged 23 classic design patterns aimed at improving the reusability and maintainability of object-oriented software systems.

The Composite Pattern is classified as a structural pattern because it deals with the composition of objects to form tree-like structures that represent part-whole hierarchies. The pattern's primary goal is to allow individual objects and composite objects (objects made up of other objects) to be treated uniformly, simplifying client code that operates on them.

## Where the Composite Pattern Fits in OOP and SOLID:
OOP is based on four key principles: Abstraction, Encapsulation, Inheritance, and Polymorphism.
The Composite Pattern leverages polymorphism by ensuring that both individual objects (leaves) and composite objects (composites) share the same interface, allowing them to be treated the same way by the client. This is central to the pattern’s design.
Inheritance or interface implementation plays a key role here, as all components implement or inherit from a common interface or abstract class.

## Single Responsibility Principle (SRP):
Each class in the Composite Pattern has a single responsibility. Leaf classes represent individual objects, while Composite classes represent the aggregation of these objects. Both roles are clearly defined, avoiding class bloat.

## Open/Closed Principle (OCP):
The pattern makes systems open for extension but closed for modification. You can easily add new types of leaves or composites without changing existing code. By using a common interface, new components can integrate seamlessly into the system.

## Liskov Substitution Principle (LSP):
The Composite Pattern ensures that any composite object (like a folder in a filesystem) and a leaf object (like a file) can be used interchangeably without breaking the client code. The interface makes it possible to substitute objects without affecting the overall behavior.

## Interface Segregation Principle (ISP):
The components in the Composite Pattern generally implement a minimal, well-defined interface. By ensuring that both leaves and composites adhere to a common, relevant interface, the pattern prevents forcing unnecessary methods onto components that don’t need them.

## Dependency Inversion Principle (DIP):
The Composite Pattern promotes coding against abstractions. The client code interacts with the component interface (IInsuranceComponent in our case), rather than with specific leaf or composite implementations. This decouples high-level logic from low-level implementation details.

### Conclusion:
The Composite Pattern emerged from the need to model complex hierarchical structures in object-oriented systems. It fits naturally within the principles of OOP, promoting polymorphism and inheritance to enable uniform treatment of objects and compositions. Additionally, the pattern strongly aligns with SOLID design principles, especially in terms of extensibility, abstraction, and decoupling, making it an essential structural pattern for developing maintainable and scalable software.
