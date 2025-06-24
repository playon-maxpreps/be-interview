# DotNet Interview API

A traditional .NET 8 Web API project with proper namespaces, Main function, and controller-based architecture.

## Project Structure

```
DotNetInterviewApi/
├── Controllers/          # API Controllers
│   └── WeatherForecastController.cs
├── Models/              # Data Models
│   └── WeatherForecast.cs
├── Services/            # Business Logic Services
│   ├── IWeatherService.cs
│   └── WeatherService.cs
├── Data/                # Data Access Layer (for future use)
├── DTOs/                # Data Transfer Objects (for future use)
├── Program.cs           # Application Entry Point
├── appsettings.json     # Configuration
└── DotNetInterviewApi.csproj
```

## Features

- **Traditional .NET Structure**: Uses `Main` function and proper namespaces
- **Controller-based API**: Traditional MVC pattern with controllers
- **Dependency Injection**: Services registered and injected properly
- **Swagger/OpenAPI**: API documentation and testing interface
- **Logging**: Built-in logging with ILogger
- **HTTPS**: HTTPS redirection enabled

## Getting Started

1. **Run the application**:
   ```bash
   dotnet run
   ```

2. **Access the API**:
   - Swagger UI: `https://localhost:7001/swagger`
   - API Endpoints:
     - `GET /api/weatherforecast` - Get all weather forecasts
     - `GET /api/weatherforecast/{id}` - Get specific weather forecast

3. **Build the project**:
   ```bash
   dotnet build
   ```

## API Endpoints

### WeatherForecast
- `GET /api/weatherforecast` - Returns 5 random weather forecasts
- `GET /api/weatherforecast/{id}` - Returns a specific weather forecast by ID (1-5)

## Architecture

This project follows traditional .NET patterns:
- **Program.cs**: Contains the `Main` method and application configuration
- **Controllers**: Handle HTTP requests and responses
- **Services**: Contain business logic and are injected into controllers
- **Models**: Define data structures
- **Dependency Injection**: Services are registered in Program.cs and injected where needed

## Technologies

- .NET 8.0
- ASP.NET Core Web API
- Swagger/OpenAPI
- Dependency Injection
- Logging 