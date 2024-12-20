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

### Bridge Pattern
The Bridge pattern lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation, which can be developed independently of each other. It allows to abide by the "O" in SOLID principles. When a class is to evolve by way of inheritance according to several dimensions, it will unavoidably grow exponentially. The Bridge pattern attempts to solve this problem by switching from inheritance to the object composition. What this means is that you extract one of the dimensions into a separate class hierarchy, so that the original classes will reference an object of the new hierarchy, instead of having all of its state and behaviors within one class.
<img src="/pictures/bridge.png" title="bridge"  width="900">

### Proxy Pattern
Proxy is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.
<img src="/pictures/proxy.png" title="proxy"  width="900">



## Behavioral Patterns

### Command Pattern
Command turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.
<img src="/pictures/command.png" title="command"  width="900">

### Chain of Responsability Pattern
Chain of responsability lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain. It is very used a lot in ASP.NET with middlewares.
<img src="/pictures/chain.png" title="chain of responsability"  width="900">


