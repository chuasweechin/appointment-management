# appointment-management
Prerequisite:
- Install latest .Net core, https://dotnet.microsoft.com/download
- Install latest PostgresSQL Database, https://www.postgresql.org/download/

How to run:
1. Update Database.ConnectionString property in "./AppointmentManagement/appsettings.Development.json" to your own PostgresSQL setup
2. On your terminal, cd to "./AppointmentManagement" and execute the command to below. This will build the .net core application and setup the database with seed data.
    - dotnet restore
    - dotnet build
    - dotnet ef database update
3. Launch the application at https://localhost:5001/swagger/index.html
4. Done!
