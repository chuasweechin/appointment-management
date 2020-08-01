using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;
using Microsoft.EntityFrameworkCore;

namespace AppointmentManagement.Infrastructure.Repositories
{
  public class AppointmentRepository : IAppointmentRepository
	{
		private readonly AppDbContext _context;

		public AppointmentRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<List<Appointment>> Get(string doctorId, string patientId, DateTime dateTime)
		{
			return await _context.Appointments
				.Where(o =>
					(string.IsNullOrEmpty(patientId) || o.PatientId == patientId) &&
					(string.IsNullOrEmpty(doctorId) || o.DoctorId == doctorId) &&
					o.Start.Date == dateTime.Date)
				.ToListAsync();
		}

		public async Task Add(Appointment appointment)
		{
			_context.Appointments.Add(appointment);
			await _context.SaveChangesAsync();
		}

		public async Task<Appointment> FindById(string id)
		{
			return await _context.Appointments.FindAsync(id);
		}

		public async Task SaveChangesToDatabase()
		{
			await _context.SaveChangesAsync();
		}
  }
}
