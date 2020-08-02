using System.Threading.Tasks;
using System.Collections.Generic;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;

namespace AppointmentManagement.UnitTest.Fixture
{
	public class MockDoctorRepository : IDoctorRepository
	{
		readonly List<Doctor> doctors = new List<Doctor>()
		{
				new Doctor("Dr Carrot", "D1"),
				new Doctor("Dr Cucumber", "D2")
		};

		public MockDoctorRepository() {}

		public async Task Add(Doctor doctor)
		{
			doctors.Add(doctor);
			await Task.CompletedTask;
		}

		public async Task<Doctor> FindById(string id)
		{
			await Task.CompletedTask;
			return doctors.Find(o => o.Id == id);
		}

		public async Task SaveChangesToDatabase()
		{
			await Task.CompletedTask;
		}
	}
}
