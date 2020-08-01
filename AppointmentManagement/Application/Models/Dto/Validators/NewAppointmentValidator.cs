using FluentValidation;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.Application.Models.Dto.Validators
{
	public class NewAppointmentValidator : AbstractValidator<NewAppointment>
	{
		private readonly IAppointmentRepository _appointmentRepo;
		private readonly IDoctorRepository _doctorRepo;
		private readonly IPatientRepository _patientRepo;

		public NewAppointmentValidator(IAppointmentRepository appointmentRepo, IDoctorRepository doctorRepo, IPatientRepository patientRepo)
		{
			_appointmentRepo = appointmentRepo;
			_doctorRepo = doctorRepo;
			_patientRepo = patientRepo;

			RuleFor(o => o.DoctorId)
				.MustAsync(async (doctorId, cancellation) => await _doctorRepo.FindById(doctorId) != null)
				.WithMessage("Doctor id is invalid. Not found in database.");

			RuleFor(o => o.PatientId)
				.MustAsync(async (patientId, cancellation) => await _patientRepo.FindById(patientId) != null)
				.WithMessage("Patient id is invalid. Not found in database.");
		}
	}
}