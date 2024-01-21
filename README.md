# Design Patterns in C#

In this project, I try to demonstrate the usefulness of design patterns. To do this, I first do the wrong way, thus emphasizing the trouble we get into. Then I use the rigth design pattern to solve the problem. 



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
<img src="/pictures/adapter.jpeg" title="adapter"  width="900">

### Decorator Pattern
 The Decorator allows you to modify an object dynamically. You would use it when you want the capabilities of inheritance with subclasses, but you need to add functionality at run time. It is more flexible than inheritance. The Decorator Design Pattern simplifies code because you add functionality using many simple classes. Also, rather than rewrite old code you can extend it with new code and that is always good.
<img src="/pictures/decorator.jfif" title="factory"  width="900">

