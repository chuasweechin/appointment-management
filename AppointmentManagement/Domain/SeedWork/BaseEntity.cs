using System;

namespace AppointmentManagement.Domain.Models.SeedWork
{
  public class BaseEntity
  {
		public string Id { get; set; }

		public DateTimeOffset CreatedAt { get; set; }
		public DateTimeOffset UpdatedAt { get; set; }

		public BaseEntity()
		{
			Id = GenerateTypeId();
			CreatedAt = DateTimeOffset.UtcNow;
			UpdatedAt = DateTimeOffset.UtcNow;
		}

		private string GenerateTypeId()
		{
			return $"{ GetType().Name.Substring(0,1) }-{ Guid.NewGuid() }".ToLower();
		}
  }
}
