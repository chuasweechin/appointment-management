using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.UnitTest.Fixture
{
  public class MockAppointmentRepository : IAppointmentRepository
	{
		readonly List<Appointment> appointments = new List<Appointment>()
		{
			new Appointment("D1", "P1", DateTime.Parse("03/08/2018 09:00:00"), "A1"),
			new Appointment("D1", "P1", DateTime.Parse("04/08/2018 10:00:00"), "A2"),
			new Appointment("D1", "P2", DateTime.Parse("03/08/2018 10:00:00"), "A3"),
			new Appointment("D1", "P1", DateTime.Parse("04/08/2018 11:00:00"), "A4"),
			new Appointment("D2", "P1", DateTime.Parse("03/18/2018 08:00:00"), "A5"),
			new Appointment("D2", "P1", DateTime.Parse("04/18/2018 09:00:00"), "A6"),
			new Appointment("D2", "P3", DateTime.Parse("03/18/2018 09:00:00"), "A7"),
			new Appointment("D2", "P3", DateTime.Parse("04/18/2018 10:00:00"), "A8")
		};

		public MockAppointmentRepository() {}

		public async Task<List<Appointment>> Get(string doctorId, string patientId, DateTime dateTime)
		{
			await Task.CompletedTask;

			return appointments
				.Where(o =>
					(string.IsNullOrEmpty(patientId) || o.PatientId == patientId) &&
					(string.IsNullOrEmpty(doctorId) || o.DoctorId == doctorId) &&
					o.Start.Date == dateTime.Date).ToList();
		}

		public async Task<Appointment> Add(Appointment appointment)
		{
			await Task.CompletedTask;

			appointments.Add(appointment);
			return appointment;
		}

		public async Task<Appointment> FindById(string id)
		{
			await Task.CompletedTask;

			return appointments.Find(o => o.Id == id);
		}

		public async Task SaveChangesToDatabase()
		{
			await Task.CompletedTask;
		}
  }
}
