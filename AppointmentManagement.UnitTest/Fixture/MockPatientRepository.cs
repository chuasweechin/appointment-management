using System.Threading.Tasks;
using System.Collections.Generic;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;

namespace AppointmentManagement.UnitTest.Fixture
{
  public class MockPatientRepository : IPatientRepository
	{
		readonly List<Patient> patients = new List<Patient>()
		{
			new Patient("Pear", 12, Gender.Male, "P1"),
			new Patient("Apple", 22, Gender.Female, "P2"),
			new Patient("Orange", 32, Gender.Male, "P3")
		};

		public MockPatientRepository() {}

		public async Task Add(Patient patient)
		{
			patients.Add(patient);
			await Task.CompletedTask;
		}

		public async Task<Patient> FindById(string id)
		{
			await Task.CompletedTask;
			return patients.Find(o => o.Id == id);
		}

		public async Task SaveChangesToDatabase()
		{
			await Task.CompletedTask;
		}
	}
}
