﻿// <auto-generated />
using System;
using AppointmentManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AppointmentManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AppointmentManagement.Domain.AggregateModels.AppointmentAggregate.Appointment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("Id")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnName("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnName("DoctorId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("End")
                        .HasColumnName("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnName("PatientId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Start")
                        .HasColumnName("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("Status")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnName("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Appointment");

                    b.HasData(
                        new
                        {
                            Id = "A1",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 165, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, 0, 0, 0, 0)),
                            DoctorId = "D1",
                            End = new DateTimeOffset(new DateTime(2018, 3, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            PatientId = "P1",
                            Start = new DateTimeOffset(new DateTime(2018, 3, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Status = "Active",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 165, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "A2",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2400), new TimeSpan(0, 0, 0, 0, 0)),
                            DoctorId = "D1",
                            End = new DateTimeOffset(new DateTime(2018, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            PatientId = "P1",
                            Start = new DateTimeOffset(new DateTime(2018, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Status = "Active",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2400), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "A3",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2570), new TimeSpan(0, 0, 0, 0, 0)),
                            DoctorId = "D1",
                            End = new DateTimeOffset(new DateTime(2018, 3, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            PatientId = "P2",
                            Start = new DateTimeOffset(new DateTime(2018, 3, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Status = "Active",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2570), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "A4",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 0, 0, 0, 0)),
                            DoctorId = "D1",
                            End = new DateTimeOffset(new DateTime(2018, 4, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            PatientId = "P1",
                            Start = new DateTimeOffset(new DateTime(2018, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Status = "Active",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "A5",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0)),
                            DoctorId = "D2",
                            End = new DateTimeOffset(new DateTime(2018, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            PatientId = "P1",
                            Start = new DateTimeOffset(new DateTime(2018, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Status = "Active",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "A6",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 0, 0, 0, 0)),
                            DoctorId = "D2",
                            End = new DateTimeOffset(new DateTime(2018, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            PatientId = "P1",
                            Start = new DateTimeOffset(new DateTime(2018, 4, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Status = "Active",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "A7",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 0, 0, 0, 0)),
                            DoctorId = "D2",
                            End = new DateTimeOffset(new DateTime(2018, 3, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            PatientId = "P3",
                            Start = new DateTimeOffset(new DateTime(2018, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Status = "Active",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "A8",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 0, 0, 0, 0)),
                            DoctorId = "D2",
                            End = new DateTimeOffset(new DateTime(2018, 4, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            PatientId = "P3",
                            Start = new DateTimeOffset(new DateTime(2018, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Status = "Active",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 171, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("AppointmentManagement.Domain.AggregateModels.DoctorAggregate.Doctor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("Id")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnName("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnName("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            Id = "D1",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 173, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Dr Carrot",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 173, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "D2",
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 173, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Dr Cucumber",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 173, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("AppointmentManagement.Domain.AggregateModels.PatientAggregate.Patient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("Id")
                        .HasColumnType("text");

                    b.Property<long>("Age")
                        .HasColumnName("Age")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnName("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnName("Gender")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnName("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            Id = "P1",
                            Age = 12L,
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 0, 0, 0, 0)),
                            Gender = "M",
                            Name = "Pear",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "P2",
                            Age = 22L,
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(2520), new TimeSpan(0, 0, 0, 0, 0)),
                            Gender = "F",
                            Name = "Apple",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(2520), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = "P3",
                            Age = 32L,
                            CreatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, 0, 0, 0, 0)),
                            Gender = "M",
                            Name = "Orange",
                            UpdatedAt = new DateTimeOffset(new DateTime(2020, 8, 1, 16, 36, 47, 174, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
