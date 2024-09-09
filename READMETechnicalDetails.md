# Trendyol Checkout Case

This project is an example of a shopping cart application similar to those used in e-commerce websites. It is developed using .NET 7 and follows the principles of Domain-Driven Design (DDD). PostgreSQL is used as the database, and Entity Framework Core (EF Core) is utilized for data management. Additionally, a promotion management service is implemented using the Strategy Pattern, and MediatR is used for handling service commands. The application is also Dockerized to facilitate deployment.

## Features

- **Cart Management:** Add, remove, and reset items (DefaultItem, DigitalItem, VasItem) in the cart.
- **Promotion Management:** Calculate and apply the most advantageous promotion among different types (SameSellerPromotion, CategoryPromotion, TotalPricePromotion).
- Use of **Strategy Pattern** for a dynamic and extensible promotion calculation structure.
- Use of **Mediator Pattern** to manage communication between service handlers.
- **Testing:** xUnit tests for both Application and Domain layers.
- **Dockerized Application:** Easily deployable using Docker.

## Technologies Used

- .NET 7
- Entity Framework Core (ORM)
- PostgreSQL
- MediatR
- Swagger
- xUnit
- Docker
