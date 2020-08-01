using System.Threading.Tasks;

namespace AppointmentManagement.Domain.AggregateModels.DoctorAggregate
{
  public interface IDoctorRepository
  {
    Task Add(Doctor doctor);
    Task<Doctor> FindById(string id);
  }
}
