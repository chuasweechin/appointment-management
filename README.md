# Appointment Management API
### Prerequisite:
- Install latest .Net core, https://dotnet.microsoft.com/download
- Install latest PostgresSQL Database, https://www.postgresql.org/download/

### How to run:
1. Update Database.ConnectionString property in "./AppointmentManagement/appsettings.Development.json" to your PostgresSQL setup
2. In your terminal, cd to "./AppointmentManagement" and run the below command. This will build the api and setup the database with seed data.
    - dotnet restore
    - dotnet build
    - dotnet tool install --global dotnet-ef
    - dotnet ef database update
3. Launch the application at https://localhost:5001/swagger/index.html

### Built using:
- .Net Core 3.1
- PostgresSQL 11
- Entity Framework Core 3.1.6
- Fluent Validation 9.0.1
- Swagger 5.5.1
