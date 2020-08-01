using Microsoft.EntityFrameworkCore;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;
using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Infrastructure.EntityConfigurations
{
	public class AppointmentEntityConfiguration : IEntityTypeConfiguration<Appointment>
	{
		public void Configure(EntityTypeBuilder<Appointment> builder)
		{
			builder.ToTable("Appointment");

			builder.HasKey(o => o.Id);
			builder.Property(o => o.Id).HasColumnName("Id");

			// Column Configuration
			builder
				.Property(o => o.CreatedAt)
				.HasColumnName("CreatedAt")
				.IsRequired(true);

			builder
				.Property(o => o.UpdatedAt)
				.HasColumnName("UpdatedAt")
				.IsRequired(true);

			builder
				.Property(o => o.DoctorId)
				.HasColumnName("DoctorId")
				.IsRequired(true);

			builder
				.Property(o => o.PatientId)
				.HasColumnName("PatientId")
				.IsRequired(true);

			builder
				.Property(o => o.Status)
				.HasConversion(
					enumValue => enumValue.Name,
					stringValue => Enumeration.FromDisplayName<Status>(stringValue)
				)
				.HasColumnName("Status")
				.IsRequired(true);

			builder
				.Property(o => o.Start)
				.HasColumnName("Start")
				.IsRequired(true);

			builder
				.Property(o => o.End)
				.HasColumnName("End")
				.IsRequired(true);
		}
	}
}
