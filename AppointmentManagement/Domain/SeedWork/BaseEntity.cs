using System;

namespace AppointmentManagement.Domain.Models.SeedWork
{
  public class BaseEntity
  {
		public string Id { get; protected set; }

		public DateTimeOffset CreatedAt { get; protected set; }
		public DateTimeOffset UpdatedAt { get; protected set; }

		protected BaseEntity() { }

		public BaseEntity(string id)
		{
			DateTimeOffset utcNow = DateTimeOffset.UtcNow;

			Id = string.IsNullOrEmpty(id) ? GenerateTypeId() : id;
			CreatedAt = utcNow;
			UpdatedAt = utcNow;
		}

		private string GenerateTypeId()
		{
			return $"{ GetType().Name.Substring(0,1) }-{ Guid.NewGuid() }".ToLower();
		}
  }
}
