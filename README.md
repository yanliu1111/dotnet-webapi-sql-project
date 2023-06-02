# Dotnet webapi with SQL Server project

## Start with

- ✅ .NET 6.0
- ✅ Create Web API

## Web API

- ✅ Model-View-Controller (MVC) pattern
- ✅ Best Practices - Data structure Clean 🧹, code changed between Controller and Service
- ✅ Asynchronous implementation with async/await Task
- ✅ Service Response with Generics
- ✅ Data-Transfer-Object (DTO) pattern
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

### 📌 3. Data-Transfer-Object (DTO) pattern

Character foder is for all the data transfer objects regarding the rpg characters. The idea behind dtos is that you've got a model that you want to send to the client, but you don't want to send all the properties of that model. So you create a dto that only contains the properties that you want to send to the client.--`smaller and faster`.

For example, we could add properties like the created and modified date or a flag for the soft deletion of that character, we don't want to send this data to the client. So we map certain properties of the character model to the character dto, that would be the case of returning data to the client. But it also works the other way around we already create a new character by only providing an id and a name, so why not use a type that only consists of these two properties or other properties we want to use.

It is important when I build a frontend that should use a specific type of the creation of a new character. In this project, I can use the character dto and add charactor dto as a parameter to the create character method.

Work flow: after building `AddCharacterDto` and `GetCharacterDto`, remove them to controller and service methods.
