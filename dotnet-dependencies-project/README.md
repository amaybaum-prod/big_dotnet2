# dotnet-dependencies-project

This project is a .NET application that demonstrates a typical structure for a web application with a focus on user and product management. It includes various services, controllers, and models, along with unit and integration tests.

## Project Structure

- **src/**: Contains the main application code.
  - **Program.cs**: Entry point of the application.
  - **Models/**: Contains the data models for the application.
    - **User.cs**: Defines the User class.
    - **Product.cs**: Defines the Product class.
  - **Services/**: Contains business logic and service interfaces.
    - **IUserService.cs**: Interface for user-related operations.
    - **UserService.cs**: Implementation of IUserService.
    - **IProductService.cs**: Interface for product-related operations.
    - **ProductService.cs**: Implementation of IProductService.
  - **Controllers/**: Contains the API controllers.
    - **UserController.cs**: Handles user-related HTTP requests.
    - **ProductController.cs**: Handles product-related HTTP requests.
  - **Data/**: Contains the database context and migrations.
    - **ApplicationDbContext.cs**: Configures the database context.
    - **Migrations/**: Contains migration files for database schema changes.

- **tests/**: Contains unit and integration tests for the application.
  - **UnitTests/**: Contains unit tests for services.
    - **UserServiceTests.cs**: Tests for UserService.
    - **ProductServiceTests.cs**: Tests for ProductService.
  - **IntegrationTests/**: Contains integration tests for API endpoints.
    - **ApiTests.cs**: Tests for API responses.

## Setup Instructions

1. **Clone the repository**:
   ```
   git clone https://github.com/microsoft/vscode-remote-try-dotnet.git
   cd dotnet-dependencies-project
   ```

2. **Restore dependencies**:
   ```
   dotnet restore
   ```

3. **Run the application**:
   ```
   dotnet run
   ```

4. **Run tests**:
   ```
   dotnet test
   ```

## Usage

- Access the API endpoints for user and product management.
- Use the provided services to interact with the data models.
- Modify the configuration in `appsettings.json` and `appsettings.Development.json` as needed for your environment.

## Dependencies

This project includes several dependencies that are essential for its functionality. Please refer to the `dotnet-dependencies-project.csproj` file for a complete list of libraries and frameworks used in this project.