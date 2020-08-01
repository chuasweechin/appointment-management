using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Domain.AggregateModels.AppointmentAggregate
{
  public class Status : Enumeration
  {
    public static Status Active = new Status(1, "Active");
    public static Status Cancelled = new Status(2, "Cancelled");

    public Status(int id, string name) : base(id, name) {}
  }
}
