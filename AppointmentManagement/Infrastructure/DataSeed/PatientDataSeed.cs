using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;

namespace AppointmentManagement.Infrastructure.DataSeed
{
  public static class PatientDataSeed
	{
		public static void SeedPatientData(this ModelBuilder builder)
		{
			List<Patient> seedData = new List<Patient>()
			{
				new Patient("Pear", 12, Gender.Male, "P1"),
				new Patient("Apple", 22, Gender.Female, "P2"),
				new Patient("Orange", 32, Gender.Male, "P3"),
			};

			foreach (var data in seedData)
			{
				builder.Entity<Patient>().HasData(data);
			}
		}
  }
}