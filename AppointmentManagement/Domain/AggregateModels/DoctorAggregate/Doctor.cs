using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Domain.AggregateModels.DoctorAggregate
{
	public class Doctor : BaseEntity, IAggregateRoot
	{
		public string Name { get; private set; }

		public Doctor(string name) : base()
		{
			Name = name;
		}
	}
}
