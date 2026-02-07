Mediator pattern
The mediator design pattern aims to reduce dependencies between objects by restricting direct communication and instead creating a way for them to collaborate only through the mediator object. In simpler terms, there is an object that encapsulates and manages how other objects interact with each other.

The problem
Flexibility: As business requirements evolve, it becomes increasingly important to have flexible applications that can adapt to changing needs. However, applications that are tightly coupled can make it difficult to make changes or add new features. A change in one object can have a ripple effect throughout the entire application, this can cause delays in development and increase the risk of introducing bugs or other issues.

Complex management: Each object should be aware of the interfaces and implementations of other objects it interacts with. However, this can make the system more complicated to comprehend, maintain, and develop and this issue grows over time like a snowball, directly impacting the developers, management, and the final product used by the clients.

Coupling: Objects that communicate directly are usually tightly coupled, in these cases making changes to those objects could impact others, leading to more changes in models, scripts, etc.





Problem
The Solution
In the image below we can see how the Mediator pattern works, we have some services that can communicate with each other through a mediator object.

By allowing services to communicate without direct references, the application becomes more flexible, with simplified interactions and reduced dependencies, making it easier to maintain.

In this article, we are going to use the Mediator pattern through a library called MediatR. This library offers classes that allow efficient communication between multiple objects in a loosely coupled manner, simplifying the exchange of information, and making it easier to manage existing features and integrate new ones. It’s important to note that MediatR follows the Single Responsibility Principle and Dependency Inversion Principle.


Process
