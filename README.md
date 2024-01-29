# Design Patterns in C#

In this project, I try to demonstrate the usefulness of design patterns. To do this, I first do the wrong way, thus emphasizing the trouble we get into. Then I use the right design pattern to solve the problem. 



## Creational Patterns

### Simple Factory Pattern
Create an object without exposing the instantiation logic to the client.

### Factory Pattern

Define an interface for creating an object, but let subclasses decide which class to instantiate. Let a class defer instantiation to subclasses. The instantiation process will be carried out through the subclasses that derive from this abstract class.
<img src="/pictures/factory.jpeg" title="factory"  width="900">

### Abstract Factory Pattern
Provide an interface for creating families of related or dependant objects without specifying their concrete classes. Encapsulate a group of individual factories that have a common theme. Concrete classes are never mentionned.
<img src="/pictures/abstractfactory.png" title="abtract factory"  width="900">

### Builder Pattern
You use the builder design pattern when you want to construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code. The Builder pattern provides an alternative to the Abstract Factory design pattern when it comes to make complex objects. 
<img src="/pictures/builder.webp" title="facade"  width="900">



## Structural Patterns

### Adapter Pattern
Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.
<img src="/pictures/adapter.jpeg" title="adapter"  width="900">

### Decorator Pattern
 The Decorator allows you to modify an object dynamically. You would use it when you want the capabilities of inheritance with subclasses, but you need to add functionality at run time. It is more flexible than inheritance. The Decorator Design Pattern simplifies code because you add functionality using many simple classes. Also, rather than rewrite old code you can extend it with new code and that is always good.
<img src="/pictures/decorator.jfif" title="decorator"  width="900">

### Facade Pattern
The Facade pattern basically says that you should simplify your methods so that much of what is done is in the background. In technical terms you should decouple the client from the sub components needed to perform an operation.
<img src="/pictures/facade.png" title="facade"  width="900">



## Behavioral Patterns

### Command Pattern
Command turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.
<img src="/pictures/adapter.jpeg" title="adapter"  width="900">
