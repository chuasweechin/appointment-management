using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Domain.AggregateModels.AppointmentAggregate
{
  public interface IAppointmentRepository : IRepository
  {
    Task<List<Appointment>> Get(string doctorId, string patientId, DateTime date);
    Task<Appointment> Add(Appointment appointment);
    Task<Appointment> FindById(string id);
  }
}
