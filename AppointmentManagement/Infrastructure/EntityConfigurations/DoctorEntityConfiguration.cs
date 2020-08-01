using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;

namespace AppointmentManagement.Infrastructure.EntityConfigurations
{
	public class DoctorEntityConfiguration : IEntityTypeConfiguration<Doctor>
	{
		public void Configure(EntityTypeBuilder<Doctor> builder)
		{
			builder.ToTable("Doctor");

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
		}
	}
}
