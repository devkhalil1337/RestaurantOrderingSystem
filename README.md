# 🍽️ Restaurant Ordering System

A complete Restaurant Ordering System built with **ASP.NET Core 7 (Web API)**, **Entity Framework Core**, **SQL Server**, **AutoMapper**, **JWT Authentication**, **Clean Architecture**, and **Swagger UI**.

This project is part of my portfolio to demonstrate backend architecture, clean coding practices, exception handling, authentication/authorization, and best practices in a real-world scenario.

---

## 📊 Project Roadmap

| Status | Feature/Module | Description |
|:------:|:--------------|:------------|
| ✅ | Project Setup | ASP.NET Core 7 Web API project with Clean Architecture |
| ✅ | Database Connection | Configured SQL Server with Entity Framework Core |
| ✅ | Migrations & Seeding | Applied initial migrations to create database |
| ✅ | Authentication | Implemented JWT Authentication (Login/Register) |
| ✅ | Global Exception Handling | Custom middleware to catch and format all exceptions |
| ✅ | Product Module (CRUD) | Create, Read, Update, Delete APIs for Products |
| ✅ | Repository & Unit of Work Pattern | Abstracted data access using best practices |
| ✅ | AutoMapper Integration | Object mapping between Entities and DTOs |
| ✅ | Swagger UI | API documentation and testing through Swagger |
| ⏳ | Future Enhancements | Categories, Orders, and Admin Panel (TBD) |


## 📚 Tech Stack

- **Backend Framework:** ASP.NET Core 7 Web API
- **ORM:** Entity Framework Core
- **Authentication:** JWT Bearer Authentication
- **Mapping:** AutoMapper
- **API Testing:** Swagger (Swashbuckle)
- **Database:** SQL Server
- **Architecture:** Clean Architecture (API Layer, Application Layer, Infrastructure Layer, Core Layer)


## 📊 Folder Structure

```bash
RestaurantOrderingSystem/
|-- Restaurant.API/            # Presentation Layer (Controllers, Middlewares)
|-- Restaurant.Application/    # Interfaces, DTOs, Business Logic Contracts
|-- Restaurant.Core/           # Entities (Domain Models)
|-- Restaurant.Infrastructure/ # Repositories, Services, EF DbContext
```


## 🔑 Key Features

- Secure JWT Authentication and Authorization
- Clean error handling with a Global Exception Middleware
- Modular, scalable architecture (separation of concerns)
- Repository Pattern and Unit of Work to manage DB transactions
- AutoMapper Profiles for clean DTO mapping
- Swagger UI for easy API testing


## 📅 Future Plans

- User Roles (Admin/Customer)
- Role-Based Authorization
- Product Categories
- Order Management (Cart, Checkout)
- Payment Gateway Integration
- Deployment to Cloud (AWS/Azure)


## 🚀 How to Run Locally

1. Clone the repository:
```bash
git clone https://github.com/your-username/RestaurantOrderingSystem.git
```

2. Update your SQL Server connection string in `appsettings.json`.

3. Run Entity Framework migrations:
```bash
dotnet ef database update
```

4. Run the project:
```bash
dotnet run
```

5. Open Swagger UI at:
```
https://localhost:{port}/swagger
```
