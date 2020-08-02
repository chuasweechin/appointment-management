using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.Domain.Interface
{
  public interface IAppointmentDomainService
  {
    Task<List<Appointment>> GetAppointment(string doctorId, string patientId, DateTime dateTime);
    Task<Appointment> CreateNewAppointment(string doctorId, string patientId, DateTime dateTime);
    Task CancelExistingAppointment(string appointmentId);
  }
}
