# Design Patterns in C#


## Creational Patterns

### Simple Factory Pattern
Create an object without exposing the instantiation logic to the client.

### Factory Pattern

Define an interface for creating an object, but let subclasses decide which class to instantiate. Let a class defer instantiation to subclasses. The instantiation process will be carried out through the subclasses that derive from this abstract class.
<img src="/pictures/factory.jpeg" title="factory"  width="900">

### Abstract Factory Pattern
Provide an interface for creating families of related or dependant objects without specifying their concrete classes. Encapsulate a group of individual factories that have a common theme. Concrete classes are never mentionned.
<img src="/pictures/abstractfactory.png" title="abtract factory"  width="900">



## Structural Patterns

### Adapter Pattern
Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.
<img src="/pictures/adapter.jpeg" title="factory"  width="900">
