using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.Infrastructure.DataSeed
{
  public static class AppointmentDataSeed
	{
		public static void SeedAppointmentData(this ModelBuilder builder)
		{
			List<Appointment> seedData = new List<Appointment>()
			{
				new Appointment("D1", "P1", DateTimeOffset.Parse("03/08/2018 09:00:00 +08:00"), "A1"),
				new Appointment("D1", "P1", DateTimeOffset.Parse("04/08/2018 10:00:00 +08:00"), "A2"),
				new Appointment("D1", "P2", DateTimeOffset.Parse("03/08/2018 10:00:00 +08:00"), "A3"),
				new Appointment("D1", "P1", DateTimeOffset.Parse("04/08/2018 11:00:00 +08:00"), "A4"),
				new Appointment("D2", "P1", DateTimeOffset.Parse("03/18/2018 08:00:00 +08:00"), "A5"),
				new Appointment("D2", "P1", DateTimeOffset.Parse("04/18/2018 09:00:00 +08:00"), "A6"),
				new Appointment("D2", "P3", DateTimeOffset.Parse("03/18/2018 09:00:00 +08:00"), "A7"),
				new Appointment("D2", "P3", DateTimeOffset.Parse("04/18/2018 10:00:00 +08:00"), "A8")
			};

			foreach (var data in seedData)
			{
				builder.Entity<Appointment>().HasData(data);
			}
		}
  }
}