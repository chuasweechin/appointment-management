using System;
using System.Threading.Tasks;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.Infrastructure.Repositories
{
  public class AppointmentRepository : IAppointmentRepository
	{
		private readonly AppDbContext _context;

		public AppointmentRepository(AppDbContext context)
		{
			_context = context;
		}

		public Task Get(string doctorId, DateTimeOffset date)
		{
			throw new NotImplementedException();
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
  }
}
