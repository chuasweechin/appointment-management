using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentManagement.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    DoctorId = table.Column<string>(nullable: false),
                    PatientId = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Start = table.Column<DateTimeOffset>(nullable: false),
                    End = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<long>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "CreatedAt", "DoctorId", "End", "PatientId", "Start", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { "A1", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 165, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, 0, 0, 0, 0)), "D1", new DateTimeOffset(new DateTime(2018, 3, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "P1", new DateTimeOffset(new DateTime(2018, 3, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Active", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 165, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "A2", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2400), new TimeSpan(0, 0, 0, 0, 0)), "D1", new DateTimeOffset(new DateTime(2018, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "P1", new DateTimeOffset(new DateTime(2018, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Active", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2400), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "A3", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2570), new TimeSpan(0, 0, 0, 0, 0)), "D1", new DateTimeOffset(new DateTime(2018, 3, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "P2", new DateTimeOffset(new DateTime(2018, 3, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Active", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2570), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "A4", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 0, 0, 0, 0)), "D1", new DateTimeOffset(new DateTime(2018, 4, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "P1", new DateTimeOffset(new DateTime(2018, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Active", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "A5", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0)), "D2", new DateTimeOffset(new DateTime(2018, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "P1", new DateTimeOffset(new DateTime(2018, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Active", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "A6", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 0, 0, 0, 0)), "D2", new DateTimeOffset(new DateTime(2018, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "P1", new DateTimeOffset(new DateTime(2018, 4, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Active", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "A7", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 0, 0, 0, 0)), "D2", new DateTimeOffset(new DateTime(2018, 3, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "P3", new DateTimeOffset(new DateTime(2018, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Active", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "A8", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 0, 0, 0, 0)), "D2", new DateTimeOffset(new DateTime(2018, 4, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "P3", new DateTimeOffset(new DateTime(2018, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Active", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "D1", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 173, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 0, 0, 0, 0)), "Dr Carrot", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 173, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "D2", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 173, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 0, 0, 0, 0)), "Dr Cucumber", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 173, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Age", "CreatedAt", "Gender", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "P1", 12L, new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 0, 0, 0, 0)), "M", "Pear", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "P2", 22L, new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(2520), new TimeSpan(0, 0, 0, 0, 0)), "F", "Apple", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(2520), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "P3", 32L, new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, 0, 0, 0, 0)), "M", "Orange", new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, 0, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
