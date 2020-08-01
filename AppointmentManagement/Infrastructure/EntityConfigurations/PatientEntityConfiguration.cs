using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;
using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Infrastructure.EntityConfigurations
{
	public class PatientEntityConfiguration : IEntityTypeConfiguration<Patient>
	{
		public void Configure(EntityTypeBuilder<Patient> builder)
		{
			builder.ToTable("Patient");

			builder.HasKey(o => o.Id);
			builder.Property(o => o.Id).HasColumnName("Id");

			builder
				.Property(o => o.CreatedAt)
				.HasColumnName("CreatedAt")
				.IsRequired(true);

			builder
				.Property(o => o.UpdatedAt)
				.HasColumnName("UpdatedAt")
				.IsRequired(true);

			builder
				.Property(o => o.Name)
				.HasColumnName("Name")
				.IsRequired(true);

			builder
				.Property(o => o.Age)
				.HasColumnName("Age")
				.IsRequired(true);

			builder
				.Property(o => o.Gender)
				.HasConversion(
					enumValue => enumValue.Name,
					stringValue => Enumeration.FromDisplayName<Gender>(stringValue)
				)
				.HasColumnName("Gender")
				.IsRequired(true);
		}
	}
}
