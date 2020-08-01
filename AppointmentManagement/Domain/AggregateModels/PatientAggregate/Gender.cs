using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Domain.AggregateModels.PatientAggregate
{
  public class Gender : Enumeration
  {
    public static Gender Male = new Gender(1, "M");
    public static Gender Female = new Gender(2, "F");

    public Gender(int id, string name) : base(id, name) {}
  }
}
