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
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DoctorId = table.Column<string>(nullable: false),
                    PatientId = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
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
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
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
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
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
                    { "A1", new DateTime(2020, 8, 2, 2, 16, 27, 272, DateTimeKind.Local).AddTicks(9260), "D1", new DateTime(2018, 3, 8, 10, 0, 0, 0, DateTimeKind.Local), "P1", new DateTime(2018, 3, 8, 9, 0, 0, 0, DateTimeKind.Local), "Active", new DateTime(2020, 8, 2, 2, 16, 27, 272, DateTimeKind.Local).AddTicks(9260) },
                    { "A2", new DateTime(2020, 8, 2, 2, 16, 27, 273, DateTimeKind.Local).AddTicks(9810), "D1", new DateTime(2018, 4, 8, 11, 0, 0, 0, DateTimeKind.Local), "P1", new DateTime(2018, 4, 8, 10, 0, 0, 0, DateTimeKind.Local), "Active", new DateTime(2020, 8, 2, 2, 16, 27, 273, DateTimeKind.Local).AddTicks(9810) },
                    { "A3", new DateTime(2020, 8, 2, 2, 16, 27, 273, DateTimeKind.Local).AddTicks(9960), "D1", new DateTime(2018, 3, 8, 11, 0, 0, 0, DateTimeKind.Local), "P2", new DateTime(2018, 3, 8, 10, 0, 0, 0, DateTimeKind.Local), "Active", new DateTime(2020, 8, 2, 2, 16, 27, 273, DateTimeKind.Local).AddTicks(9960) },
                    { "A4", new DateTime(2020, 8, 2, 2, 16, 27, 273, DateTimeKind.Local).AddTicks(9980), "D1", new DateTime(2018, 4, 8, 12, 0, 0, 0, DateTimeKind.Local), "P1", new DateTime(2018, 4, 8, 11, 0, 0, 0, DateTimeKind.Local), "Active", new DateTime(2020, 8, 2, 2, 16, 27, 273, DateTimeKind.Local).AddTicks(9980) },
                    { "A5", new DateTime(2020, 8, 2, 2, 16, 27, 273, DateTimeKind.Local).AddTicks(9990), "D2", new DateTime(2018, 3, 18, 9, 0, 0, 0, DateTimeKind.Local), "P1", new DateTime(2018, 3, 18, 8, 0, 0, 0, DateTimeKind.Local), "Active", new DateTime(2020, 8, 2, 2, 16, 27, 273, DateTimeKind.Local).AddTicks(9990) },
                    { "A6", new DateTime(2020, 8, 2, 2, 16, 27, 274, DateTimeKind.Local).AddTicks(10), "D2", new DateTime(2018, 4, 18, 10, 0, 0, 0, DateTimeKind.Local), "P1", new DateTime(2018, 4, 18, 9, 0, 0, 0, DateTimeKind.Local), "Active", new DateTime(2020, 8, 2, 2, 16, 27, 274, DateTimeKind.Local).AddTicks(10) },
                    { "A7", new DateTime(2020, 8, 2, 2, 16, 27, 274, DateTimeKind.Local).AddTicks(20), "D2", new DateTime(2018, 3, 18, 10, 0, 0, 0, DateTimeKind.Local), "P3", new DateTime(2018, 3, 18, 9, 0, 0, 0, DateTimeKind.Local), "Active", new DateTime(2020, 8, 2, 2, 16, 27, 274, DateTimeKind.Local).AddTicks(20) },
                    { "A8", new DateTime(2020, 8, 2, 2, 16, 27, 274, DateTimeKind.Local).AddTicks(30), "D2", new DateTime(2018, 4, 18, 11, 0, 0, 0, DateTimeKind.Local), "P3", new DateTime(2018, 4, 18, 10, 0, 0, 0, DateTimeKind.Local), "Active", new DateTime(2020, 8, 2, 2, 16, 27, 274, DateTimeKind.Local).AddTicks(30) }
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "D1", new DateTime(2020, 8, 2, 2, 16, 27, 276, DateTimeKind.Local).AddTicks(4360), "Dr Carrot", new DateTime(2020, 8, 2, 2, 16, 27, 276, DateTimeKind.Local).AddTicks(4360) },
                    { "D2", new DateTime(2020, 8, 2, 2, 16, 27, 276, DateTimeKind.Local).AddTicks(5030), "Dr Cucumber", new DateTime(2020, 8, 2, 2, 16, 27, 276, DateTimeKind.Local).AddTicks(5030) }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Age", "CreatedAt", "Gender", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "P1", 12L, new DateTime(2020, 8, 2, 2, 16, 27, 277, DateTimeKind.Local).AddTicks(1650), "M", "Pear", new DateTime(2020, 8, 2, 2, 16, 27, 277, DateTimeKind.Local).AddTicks(1650) },
                    { "P2", 22L, new DateTime(2020, 8, 2, 2, 16, 27, 277, DateTimeKind.Local).AddTicks(3150), "F", "Apple", new DateTime(2020, 8, 2, 2, 16, 27, 277, DateTimeKind.Local).AddTicks(3150) },
                    { "P3", 32L, new DateTime(2020, 8, 2, 2, 16, 27, 277, DateTimeKind.Local).AddTicks(3200), "M", "Orange", new DateTime(2020, 8, 2, 2, 16, 27, 277, DateTimeKind.Local).AddTicks(3200) }
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
