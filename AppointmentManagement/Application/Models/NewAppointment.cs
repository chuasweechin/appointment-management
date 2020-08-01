using System;

namespace AppointmentManagement.Application.Models
{
  public class NewAppointment
  {
    public string PatientId { get; set; }
    public string DoctorId { get; set; }
    public DateTime DateTime { get; set; }
  }
}
