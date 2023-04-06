# WEEK 3

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

Structs are VALUE TYPES. They are passed BY VALUE (i.e are copied) and live on stack
Structs CANNOT INHERIT. Cannot be inherited from and can't inherit anything.

int is actually an example of a struct.

Inheritance: In C# you can only inherit from ONE class. There is no multiple inheritance

All classes inherit from the OBJECT CLASS. All objects inherit methods such as Equals, GetType ToString, GetHashCode, etc. Can bee seen in documentation.