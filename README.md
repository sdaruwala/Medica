# Medica

#Project Structure

Medica/
├── API/
│   ├── Controllers/
│   │   └── EmployeeRecordsController.cs
├── Application/
│   ├── Interfaces/
│   │   └── IEmployeeRecordService.cs
│   ├── DTOs/ 
│   │   └── EmployeeRecordDto.cs 
│   ├── Services/
│   │   └── EmployeeRecordService.cs
│   └── Mappings/ 
│       └── MappingProfile.cs
├── Domain/
│   ├── Entities/
│   │   └── PatientRecord.cs
├── Infrastructure/
│   ├── Data/
│   │   └── CsvDataLoader.cs
│   └── Services/
│       └── PatientRecordRepository.cs
├── Presentation/
│   ├── Components/
│   │   └── PatientRecordGrid.razor
│   ├── Services/
│   │   └── ApiService.cs
├──Tests/
│
├── Infrastructure
│   ├── CsvDataLoaderTests.cs
│   ├── EmployeeRecordRepositoryTests.cs
│
├── Application
│   ├── EmployeeRecordServiceTests.cs
│
├── API
│   ├── EmployeeRecordsControllerTests.cs
