using System;
using System.Threading.Tasks;

namespace AppointmentManagement.Domain.AggregateModels.AppointmentAggregate
{
  public interface IAppointmentRepository
  {
    Task Get(string doctorId, DateTimeOffset date);
    Task Add(Appointment appointment);
    Task<Appointment> FindById(string id);
  }
}
