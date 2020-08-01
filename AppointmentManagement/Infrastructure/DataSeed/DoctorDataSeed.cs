using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;

namespace AppointmentManagement.Infrastructure.DataSeed
{
  public static class DoctorDataSeed
	{
		public static void SeedDoctorData(this ModelBuilder builder)
		{
			List<Doctor> seedData = new List<Doctor>()
			{
				new Doctor("Dr Carrot", "D1"),
				new Doctor("Dr Cucumber", "D2")
			};

			foreach (var data in seedData)
			{
				builder.Entity<Doctor>().HasData(data);
			}
		}
  }
}