using System.Threading.Tasks;
using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Domain.AggregateModels.DoctorAggregate
{
  public interface IDoctorRepository : IRepository
  {
    Task Add(Doctor doctor);
    Task<Doctor> FindById(string id);
  }
}
