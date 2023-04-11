
SOLID Principles

S: Solid Responsibility Principle
O: Open Closed Principle
L: Liskov Substitution Principle
I: Interface Segregation Principle
D: Dependency Inversion Principle

S:
A software module (typically class) should represent just on thing, have one responsibility.

Class members (fields, properties, and methods) should be cohesive.

Class should have only one reason to change. e.g social security number made relevant. SSN now added to Person class

Example of this is diving of hunter and camera in seperate classes in the polymorphic shootout lab.

Open/Closed:
Open for extension, closed for modification
Entities (methods and classes) should be open for extension but closed for modification. 

The weapon class is abstract and once defined should not be changed

public class AlienInvasionException: Exception { }

Liskov Substitution:
Interfaces should be implemented consistently throughout program.

Recall Hare class from lecture recording

```c#
public virtual string Move(){
    position += _speed;
    return "Moving along";
}

public virtual string Move(int times){
    return $"I'm not moving, I need a rest";
}

```

Interface Segration Principles:

Many small, specific interfaces are better than one large, general purpose one.

Having smaller interfaces makes it easier to obey Liskov.

Dependency Inversion: 


