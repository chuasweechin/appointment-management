using System;

namespace AppointmentManagement.Domain.Exceptions
{
  public class AppointmentDomainException : Exception
  {
    public AppointmentDomainException() { }
    public AppointmentDomainException(string message) : base(message) { }
    public AppointmentDomainException(string message, Exception innerException) : base(message, innerException) { }
  }
}