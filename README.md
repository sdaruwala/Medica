# Medica

## Project Structure

```
Medica/
├── API/
│   ├── Controllers/
│   │   └── EmployeeRecordsController.cs
├── Application/
│   ├── Interfaces/
│   │   └── IEmployeeRecordService.cs
│   ├── DTOs/
│   │   └── EmployeeRecordDto.cs
│   ├── Extensions/
│   │   └── ServiceCollectionExtensions.cs
│   ├── Services/
│   │   └── EmployeeRecordService.cs
│   └── Mappings/
│       └── MappingProfile.cs
├── Domain/
│   ├── Entities/
│   │   └── EmployeeRecord.cs
│   ├── Validator/
│   │   └── CustomDateTimeConverter.cs
├── Infrastructure/
│   ├── DataServices/
│   │   └── CsvDataLoader.cs
│   ├── Extensions/
│   │   └── ServiceCollectionExtensions.cs
│   ├── Interfaces/
│   │   ├── ICsvDataLoader.cs
│   │   └── IEmployeeRecordRepository.cs
│   └── Repositories/
│       └── EmployeeRecordRepository.cs
├── Presentation/
│   ├── Pages/
│   │   └── EmployeeList.razor
│   ├── Services/
│   │   ├── ApiService.cs
│   │   └── IApiService.cs
├── Tests/
│   ├── Infrastructure/
│   │   ├── CsvDataLoaderTests.cs
│   │   ├── EmployeeRecordRepositoryTests.cs
│   ├── Application/
│   │   └── EmployeeRecordServiceTests.cs
│   ├── API/
│       └── EmployeeRecordsControllerTests.cs
```

## Architecture

The Medica project adopts a Clean Architecture approach, ensuring a clear separation of concerns and enabling high maintainability, scalability, and testability. The project is divided into the following layers:

### API Layer

**Responsibilities:** Exposes the application's endpoints and handles incoming HTTP requests. It serves as the entry point for external interactions.

**Key Component:** `EmployeeRecordsController.cs` manages routes for CRUD operations related to employee records.

### Application Layer

**Responsibilities:** Contains the business logic of the application and interfaces for use cases.

**Key Components:**

- `IEmployeeRecordService.cs` defines the contract for employee-related operations.
- `EmployeeRecordService.cs` implements the business logic.
- `MappingProfile.cs` contains mappings for converting entities to DTOs and vice versa using AutoMapper.
- `ServiceCollectionExtensions.cs` provides dependency injection setup for the application layer.

### Domain Layer

**Responsibilities:** Represents the core of the application, defining the essential business entities and rules.

**Key Components:**

- `EmployeeRecord.cs` defines the domain model for an employee record.
- `CustomDateTimeConverter.cs` ensures custom validation and conversion for date-time fields.

### Infrastructure Layer

**Responsibilities:** Handles data access and external services.

**Key Components:**

- `CsvDataLoader.cs` loads and parses data from CSV files.
- `EmployeeRecordRepository.cs` implements data persistence logic.
- `ServiceCollectionExtensions.cs` enables easy DI setup for the infrastructure layer.

### Presentation Layer

**Responsibilities:** Manages the user interface.

**Key Components:**

- `EmployeeList.razor` displays the employee data using Blazor.
- `ApiService.cs` provides an abstraction for API interactions.

### Tests

**Responsibilities:** Verifies the functionality of the application components.

**Key Components:**

- `CsvDataLoaderTests.cs` validates the data loading logic.
- `EmployeeRecordServiceTests.cs` ensures the correctness of business logic.
- `EmployeeRecordsControllerTests.cs` tests the API layer.

## Principles

The project adheres to the following principles:

- **Separation of Concerns (SoC):** Clear division of responsibilities across layers to reduce coupling and improve maintainability.
- **Single Responsibility Principle (SRP):** Each class has a single responsibility, making it easier to understand and test.
- **Open/Closed Principle (OCP):** Code is open for extension but closed for modification, ensuring robust and scalable implementations.
- **Dependency Inversion Principle (DIP):** Higher-level modules depend on abstractions rather than concrete implementations.
- **Interface Segregation Principle (ISP):** Interfaces are designed to be small and focused, ensuring they are implemented correctly.
- **DRY (Don’t Repeat Yourself):** Common functionality is centralized to prevent redundancy.

## Patterns

The project leverages the following design patterns:

- **Repository Pattern:** Provides a clean abstraction over data access logic.
  - **Example:** `EmployeeRecordRepository.cs` encapsulates data operations for employee records.
- **Factory Pattern:** Used in conjunction with dependency injection to create services and repositories.
  - **Example:** `ServiceCollectionExtensions.cs`.
- **Dependency Injection (DI):** Facilitates loose coupling by injecting dependencies at runtime.
  - **Example:** All services and repositories are registered via `ServiceCollectionExtensions.cs` files.
- **DTO (Data Transfer Object):** Simplifies data exchange between layers.
  - **Example:** `EmployeeRecordDto.cs` is used to transfer data to and from the API.
- **Adapter Pattern:** Translates one interface into another.
  - **Example:** `MappingProfile.cs` adapts domain models to DTOs.
- **Builder Pattern (for Tests):** Utilized for creating complex test data structures in `Tests/`.

## Conclusion

This architecture and design approach ensures:

- **Scalability:** Easy to extend functionality with minimal impact on existing code.
- **Maintainability:** Clear structure and adherence to SOLID principles improve code readability and testability.
- **Testability:** Decoupled components and repository pattern facilitate isolated unit tests.
