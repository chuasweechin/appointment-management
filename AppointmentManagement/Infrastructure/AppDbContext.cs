using Microsoft.EntityFrameworkCore;
using AppointmentManagement.Infrastructure.DataSeed;
using AppointmentManagement.Infrastructure.EntityConfigurations;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;

namespace AppointmentManagement.Infrastructure
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Patient> Patients { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AppointmentEntityConfiguration());
			modelBuilder.ApplyConfiguration(new DoctorEntityConfiguration());
			modelBuilder.ApplyConfiguration(new PatientEntityConfiguration());

			modelBuilder.SeedAppointmentData();
			modelBuilder.SeedDoctorData();
			modelBuilder.SeedPatientData();

			base.OnModelCreating(modelBuilder);
		}
	}
}