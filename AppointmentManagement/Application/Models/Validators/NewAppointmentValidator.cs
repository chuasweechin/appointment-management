using FluentValidation;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.Application.Models.Validators
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
				.WithMessage("Doctor id is invalid. Not found in database. Please try again.");

			RuleFor(o => o.PatientId)
				.MustAsync(async (patientId, cancellation) => await _patientRepo.FindById(patientId) != null)
				.WithMessage("Patient id is invalid. Not found in database. Please try again.");

			RuleFor(o => o)
				.MustAsync(
					async (request, cancellation) => {
						var doctorAppointmentsForTheDay = await appointmentRepo.Get(request.DoctorId, string.Empty, request.DateTime);
						return doctorAppointmentsForTheDay.TrueForAll(o => o.NoExistingAppointmentForDoctor(request.DoctorId, request.DateTime));
					})
				.WithMessage("The doctor already has a existing appointment for this timeslot. Please try another timeslot for the doctor.");

			RuleFor(o => o)
				.MustAsync(
					async (request, cancellation) => {
						var patientAppointmentsForTheDay = await appointmentRepo.Get(string.Empty, request.PatientId, request.DateTime);
						return patientAppointmentsForTheDay.TrueForAll(o => o.NoExistingAppointmentForPatient(request.PatientId, request.DateTime));
					})
				.WithMessage("The patient already has a existing appointment for this timeslot. Please try another timeslot for the patient.");
		}
	}
}