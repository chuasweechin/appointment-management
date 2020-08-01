using System.Threading.Tasks;

namespace AppointmentManagement.Domain.AggregateModels.PatientAggregate
{
  public interface IPatientRepository
  {
    Task Add(Patient patient);
    Task<Patient> FindById(string id);
  }
}
