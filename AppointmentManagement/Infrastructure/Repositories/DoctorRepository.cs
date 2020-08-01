using System.Threading.Tasks;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;

namespace AppointmentManagement.Infrastructure.Repositories
{
  public class DoctorRepository : IDoctorRepository
	{
		private readonly AppDbContext _context;

		public DoctorRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task Add(Doctor doctor)
		{
			_context.Doctors.Add(doctor);
			await _context.SaveChangesAsync();
		}

		public async Task<Doctor> FindById(string id)
		{
			return await _context.Doctors.FindAsync(id);
		}
  }
}
