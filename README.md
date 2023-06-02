# Dotnet webapi with SQL Server project

## Start with

- ✅ .NET 6.0
- ✅ Create Web API

## Web API

- ✅ Model-View-Controller (MVC) pattern
- ✅ Best Practices - Data structure Clean 🧹, code changed between Controller and Service
- Asynchronous implementation with async/await
- Data-Transfer-Object (DTO) pattern
- CRUD operations
- HTTP requests methods (GET, POST, PUT, DELETE)

## Entity Framework Core

- Persistence
- Object-relational mapping (ORM)
- SQL Server
- Code-first Migrations
- CRUD with Entity Framework Core

## Authentication

- User registration & login
- Cryptography algorithm
- JWT

## Database Relationships

- One-to-One
- One-to-Many
- Many-to-Many

## Building a Game Project

## 🔰 Working Notes

### 📌 1. Create Web API

|            | DTO  |                | DTO  |             | Model |              |
| ---------- | ---- | -------------- | ---- | ----------- | ----- | ------------ |
| **Client** | <--> | **Controller** | <--> | **Service** | <-->  | **Database** |

Build a clean structure:

Interfaces, DTOs, Models, Services, Controllers, Repositories, etc.

After build ICharacterService file, we can derectly `implement inferface` in CharacterService file automatically. **Click 💡 to implement inferface.** Then we can jump between character controller and character service. Then remove the ok result call from controller to service.

### 📌 2. Service Response w Generics

The characters are wrapped in the service response, the front end could react to the new property and provide a smooth user experience with toast notifications or something similar instead of presenting complex exception messages in the console or worse a frozen application in case of an error.
