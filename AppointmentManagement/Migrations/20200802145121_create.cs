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
                    { "A1", new DateTime(2020, 8, 2, 22, 51, 20, 738, DateTimeKind.Local).AddTicks(1210), "D1", new DateTime(2018, 3, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "P1", new DateTime(2018, 3, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2020, 8, 2, 22, 51, 20, 738, DateTimeKind.Local).AddTicks(1210) },
                    { "A2", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(480), "D1", new DateTime(2018, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "P1", new DateTime(2018, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(480) },
                    { "A3", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(640), "D1", new DateTime(2018, 3, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "P2", new DateTime(2018, 3, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(640) },
                    { "A4", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(660), "D1", new DateTime(2018, 4, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "P1", new DateTime(2018, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(660) },
                    { "A5", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(670), "D2", new DateTime(2018, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), "P1", new DateTime(2018, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(670) },
                    { "A6", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(680), "D2", new DateTime(2018, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "P1", new DateTime(2018, 4, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(680) },
                    { "A7", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(690), "D2", new DateTime(2018, 3, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "P3", new DateTime(2018, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(690) },
                    { "A8", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(700), "D2", new DateTime(2018, 4, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), "P3", new DateTime(2018, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2020, 8, 2, 22, 51, 20, 743, DateTimeKind.Local).AddTicks(700) }
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "D1", new DateTime(2020, 8, 2, 22, 51, 20, 744, DateTimeKind.Local).AddTicks(8340), "Dr Carrot", new DateTime(2020, 8, 2, 22, 51, 20, 744, DateTimeKind.Local).AddTicks(8340) },
                    { "D2", new DateTime(2020, 8, 2, 22, 51, 20, 744, DateTimeKind.Local).AddTicks(8930), "Dr Cucumber", new DateTime(2020, 8, 2, 22, 51, 20, 744, DateTimeKind.Local).AddTicks(8930) }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Age", "CreatedAt", "Gender", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "P1", 12L, new DateTime(2020, 8, 2, 22, 51, 20, 745, DateTimeKind.Local).AddTicks(5660), "M", "Pear", new DateTime(2020, 8, 2, 22, 51, 20, 745, DateTimeKind.Local).AddTicks(5660) },
                    { "P2", 22L, new DateTime(2020, 8, 2, 22, 51, 20, 745, DateTimeKind.Local).AddTicks(7100), "F", "Apple", new DateTime(2020, 8, 2, 22, 51, 20, 745, DateTimeKind.Local).AddTicks(7100) },
                    { "P3", 32L, new DateTime(2020, 8, 2, 22, 51, 20, 745, DateTimeKind.Local).AddTicks(7140), "M", "Orange", new DateTime(2020, 8, 2, 22, 51, 20, 745, DateTimeKind.Local).AddTicks(7140) }
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
