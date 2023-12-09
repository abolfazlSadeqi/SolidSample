SOLID stands 
1)	S(SRP) = Single Responsibility 
2)	O(OCP)  = Open/Closed 
3)	L(LSP)  = Liskov Substitution 
4)	I(ISP)  = Interface Segregation 
5)	D(DIP)  = Dependency Inversion 


S(SRP) 
A class should have only one reason to change
every class should have only one responsibility
O(OCP) 
Software entities (classes, modules, functions, etc.)  should be open for extension, but closed for modification

L(LSP) 
 you should be able to use any derived class instead of a parent class and have it behave 
This means that the behavior of the derived class should not contradict the behavior of the base class.

I(ISP) 
Clients should not be forced to depend upon interfaces that they do not use

D(DIP) 
When following this principle, the conventional dependency relationships established from high-level, policy-setting modules to low-level, dependency modules are reversed, thus rendering high-level modules independent of the low-level module implementation details

The Dependency Inversion Principle states that high-level modules should not depend upon low-level modules.

The principle states:
A.	High-level modules should not import anything from low-level modules. Both should depend on abstractions (e.g., interfaces).
B.	Abstractions should not depend on details. Details (concrete implementations) should depend on abstractions.


