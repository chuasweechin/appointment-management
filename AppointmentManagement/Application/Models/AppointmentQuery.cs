using System;

namespace AppointmentManagement.Application.Models
{
  public class AppointmentQuery
  {
    public string DoctorId { get; set; }
    public string PatientId { get; set; }
    public DateTime DateTime { get; set; }
  }
}
