# DI.LifeTimes.WebApp
ASP.NET Core Dependency Injection life time services
App to understand how to work DI integrated in ASP.NET Core
DI integrated in ASP.NET Core supplied an IoC mecanism with a concept often called "Container".
"Container" is in charge to load instances, injection and lifetime of all application dependances
# Key concept: 
- The principle of Dependency Inversion: This is a software design principle. It suggests a solution to the problem of dependencies but the principle does not define how to implement them or what technique to use
- Inversion of Control (IoC): This is a way of applying the principle of Inversion of Dependencies. The IoC is the mechanism that allows higher-level components to depend on abstractions rather than the concrete implementation of lower-level components.
- Dependency Injection: This is a Design Pattern to implement the IoC. It allows to inject the concrete implementation of a lower level component into a higher level component
IoC Container: Also known as “DI Container”. It is a framework that implements automatic DI for components
# Different way to implement DI
- Injection by Constructor: One of the most popular DI techniques. With this approach you create an instance of your dependency and pass it as an argument to the constructor of the dependent class
- Injection by Method: In this case you create an instance of the dependency and pass it to a specific method of the dependent class
- Property Injection: This approach allows you to assign the instance of your dependency to a specific property of the dependent class
# Lifetime services
Sometimes you need an individual instance of your dependency that will "live" for the lifetime of your application. This may be useful for a "logger" or "helper" type service, but it is unacceptable for other services. The IoC “container” allows you to control the lifetime of a registered service. When you register a service by specifying a lifetime, the “container” will automatically delete it as needed. There are three types of lifetimes for services:

- Singleton: This type of lifetime creates an instance of the service available as long as the application remains running. You must register a "Singleton" type service using the Add() / AddSingleton() method
- Transient: Using this type of lifetime, your service will be created each time it is requested. This means, for example, that a service injected into the constructor of a class will last “as long” as the instance of this class. To create a service with a "Transient" lifetime you must use the AddTransient() method
- Scoped: This type of “Scoped” lifetime allows you to create a new instance of a service per each request from a client. This is particularly useful in the context of ASP.NET as it allows you to share the same service instance for the duration of processing the http request. To activate the "Scoped" lifetime you must use the AddScoped() method
