using System.Threading.Tasks;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;

namespace AppointmentManagement.Infrastructure.Repositories
{
  public class PatientRepository : IPatientRepository
	{
		private readonly AppDbContext _context;

		public PatientRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task Add(Patient patient)
		{
			_context.Patients.Add(patient);
			await _context.SaveChangesAsync();
		}

		public async Task<Patient> FindById(string id)
		{
			return await _context.Patients.FindAsync(id);
		}
	}
}
