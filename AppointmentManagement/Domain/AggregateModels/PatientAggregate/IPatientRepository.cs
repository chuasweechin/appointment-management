using System.Threading.Tasks;
using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Domain.AggregateModels.PatientAggregate
{
  public interface IPatientRepository : IRepository
  {
    Task Add(Patient patient);
    Task<Patient> FindById(string id);
  }
}
