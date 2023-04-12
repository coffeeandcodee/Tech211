# WEEK 3

## Lab Nav
#### :scroll:[LAB1, 2 & 3: Pillars of OOP](./FourPillars(LAB1%2C2%263)/FourPillarsApp) :scroll:[LAB4: Collections](./LAB4_Collections/Collections_Lab/)

## Monday 03/04

Learnt that the "test base" is through the terminal, and that the test explorer is simply a GUI independent of NUnit. "dotnet test" can be run from the terminal to execute tests, however it may be tougher to interpret test results via the terminal.

```c#
global using NUnit.Framework;

```
We learnt that the "usings" file that is created with the instantiation of an NUnit project ensures that NUnit framework is accessible within the other NUnit project files. 

NUnit originally used the "classic" model, however this model is now out of date. The "constraint" model is the go to of present day. The constraint-based Assert model uses a single method of the Assert class for all assertions.

```c#
Assert.That(myString, Is.EqualTo("Hello"));
```
The second argument in the method call above uses one of NUnit's **syntax helpers** to create an **EqualConstraint**. The same assertion could be made below.
```c#
Assert.That(myString, new EqualConstraint("hello"));
```
Can also define constraints prior Assert.That() calls.
```c#
Constraint myConstraint = Is.Unique;
            Assert.That(myArray, myConstraint);
            Assert.That(myArray2, myConstraint);
```

## Tuesday 04/04

Being testable makes code more robust in the future
Tests should follow the FIRST criteria.

Other forms of testing exist rather than unit testing, such as integration testing, and system testing which is a level above.

 ~70% of testing is Automated Unit Tests
Above this is Automated API Tests and Automated Integration Tests 

Fast: Runs in milliseconds.
Initial test slower than the rest, due to framework loading up. e.g 14ms to 1ms.

Isolated: standalone, no dependecies on file system, web services or databases.

Repeatable: Gives the same result every time.

Self-checking: The test runner should inform whether pass or fail. You don't need to manually check the input.

Timely: Doesn't take too long to write. If the test setup is complex, should code under test be refactored instead?

Thorough: Do your unit tests have appropriate coverage?

## Wednesday 05/04

OOP day. 
Abstraction vs Encapsulation:

Abstraction IN OOP is modelling real world objects as objects in code.

Encapsulation is, WITHIN THIS object, the "hiding" of information within this object. Complexity does not need to be exposed. 

OOP is the integration of data and functionality that act on data in the same scope, as opposed to Procedural programming where data and methods are seperate. Understanding OOP is more intuitive, and helps keep "coupling" low.

Both structs and classes are data structures that exhibit abstraction and encapsulation.

Structs are quite similar to Classes. However, two key differences.
Structs are VALUE TYPES. They are passed BY VALUE (i.e are copied) and live on stack
Structs CANNOT INHERIT. Cannot be inherited from and can't inherit anything.

The "new" keyword can be used to instantiate a struct, however being a value type, it isn't necessary.

int is actually an example of a struct.

Inheritance: In C# you can only inherit from ONE class. There is no multiple inheritance

All classes inherit from the OBJECT CLASS. All objects inherit methods such as Equals, GetType ToString, GetHashCode, etc. Can bee seen in documentation.

## Thursday 06/04

Abstract classes are classes that are inherited from. They are never instantiated. Abstract methods have no codeblock.
```c#
 public abstract string Speak();
//Notice no code block
```
The Object class is the superclass of all classes. It comes with its own method. Console.WriteLine({object}) would return the
Object classes ToString() method. Important to overwrite this in class methods if you wish to return a specific message related to the object.

Polymorphism in OOP is when objects can take many forms. An example of this is a Dog object being identified as say a Canine object (if a canine class is defined) as well as an Animal object, with the Animal class being a superclass of the Canine class.

You cannot have an object of an interface. Interfaces can have properties. Interfaces CANNOT have fields or private methods.
An object can inherit multiple interfaces but not multiple classes.


## Tuesday 11/06

SOLID Principles

S: Solid Responsibility Principle
O: Open Closed Principle
L: Liskov Substitution Principle
I: Interface Segregation Principle
D: Dependency Inversion Principle

S:
A software module (typically class) should represent just on thing, have 
one responsibility.

Class members (fields, properties, and methods) should be cohesive.

Class should have only one reason to change. e.g social security number 
made relevant. SSN now added to Person class

Example of this is diving of hunter and camera in seperate classes in 
the polymorphic shootout lab.

Open/Closed:
Open for extension, closed for modification
Entities (methods and classes) should be open for extension but closed 
for modification. 

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

Many small, specific interfaces are better than one large, general 
purpose one.

Having smaller interfaces makes it easier to obey Liskov.

Dependency Inversion: 


