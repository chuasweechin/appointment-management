# appointment-management
Prerequisite:
- Install latest .Net core, https://dotnet.microsoft.com/download
- Install latest PostgresSQL Database, https://www.postgresql.org/download/

How to run:
- Update Database.ConnectionString property in "./AppointmentManagement/appsettings.Development.json" to your own PostgresSQL setup
- On your terminal, cd to "./AppointmentManagement" and execute the command to below. This will build the .net core application and setup the database with seed data.
  - dotnet restore
  - dotnet build
  - dotnet ef database update
- On your browser, go to https://localhost:5001/swagger/index.html
- Done!
