Test doubles using fakes and Moq

FAKE:
Accurate implementation of an interface but contains elements not 
suitable for production (e.g a List object instead of access to a DB).

DUMMY:
Fills in for a real object but has no functionality

STUB:
An implementation that returns specified canned responses to calls.

SPY:
Records information such as the amount of times the method was called.

MOCK:
An implementation that has predefined behaviour for the methods 
called in the test. 


You can use the mock object to verify that the real object was called with the 
expected parameters. It can verify that the real object was not called with unexpected 
parameters.


**Why should you use an in-memory database for testing?**

To avoid manipulating actual database, and working with actual database is slower. 

**Why should you use the Moq framework for testing?**
Allows easier testing of complex code without the need of boilerplate.


**Why did we refactor our WPF-EF system to use a Service class?**
Adding a service layer allows us to seperate the functionality of the
of the controller and repository layers. It allows each part to be 
tested seperately.

**How does Dependency injection aid unit testing?**
Objects can be created independently of object being tested. 
It becomes easier to add things such as Fakes and Dummies.

**How can we use a Moq to check if a method is called with the correct parameters?**
Using a spy, via the Verify method.

**What is the difference between strict and loose mocking behaviour?**
strict - expects stubs and responses
loose - will run regardless of tests being set up 

A REST API is Representational State Tranfer (REST) Application Programming interface (API).

The domain name system (DNS) identifies between host name provided (e.g https://en.wikipedia.org/wiki/HTTP) and an IP (interet protocol) address.


HTTP stands for HyperText Transfer Protocol. It is an application layer protocol in the Internet protocol suite model for distributed, collaborative, hypermedia information systems.


Dependency injection is when you construct an object outside another object then inject it into another object without being "glued" to it. 

HTTP request consists of HTTP verb, header, and a message body.

The dependency injection container allows us to more easily do dependency injection in our services.
DI allows inversion of control (D in Solid)

Transient