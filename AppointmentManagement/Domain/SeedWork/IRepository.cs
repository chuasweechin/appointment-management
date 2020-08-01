using System.Threading.Tasks;

namespace AppointmentManagement.Domain.Models.SeedWork
{
  public interface IRepository
  {
    Task SaveChangesToDatabase();
  }
}
