using System;

namespace AppointmentManagement.Domain.Models.SeedWork
{
  public class BaseEntity
  {
		public string Id { get; protected set; }

		public DateTime CreatedAt { get; protected set; }
		public DateTime UpdatedAt { get; protected set; }

		protected BaseEntity() { }

		public BaseEntity(string id)
		{
			DateTime now = DateTime.Now;

			Id = string.IsNullOrEmpty(id) ? GenerateTypeId() : id;
			CreatedAt = now;
			UpdatedAt = now;
		}

		private string GenerateTypeId()
		{
			return $"{ GetType().Name.Substring(0,1) }-{ Guid.NewGuid() }".ToUpper();
		}
  }
}
