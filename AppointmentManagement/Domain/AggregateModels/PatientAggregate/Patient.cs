using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Domain.AggregateModels.PatientAggregate
{
  public class Patient : BaseEntity, IAggregateRoot
	{
		public string Name { get; private set; }
		public uint Age { get; private set; }
		public Gender Gender { get; private set; }

		public Patient(string name, uint age, Gender gender) : base()
		{
			Name = name;
			Age = age;
			Gender = gender;
		}
	}
}