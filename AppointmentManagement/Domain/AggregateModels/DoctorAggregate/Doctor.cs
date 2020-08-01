using System;
using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Domain.AggregateModels.DoctorAggregate
{
	public class Doctor : BaseEntity, IAggregateRoot
	{
		public string Name { get; private set; }

		protected Doctor() { }

		public Doctor(string name, string id = "") : base(id)
		{
			Name = string.IsNullOrEmpty(name) ? throw new ArgumentException() : name;
		}
	}
}
