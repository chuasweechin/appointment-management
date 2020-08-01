using Microsoft.EntityFrameworkCore;
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
			base.OnModelCreating(modelBuilder);
		}
	}
}