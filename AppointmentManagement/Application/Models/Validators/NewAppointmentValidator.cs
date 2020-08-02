using FluentValidation;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.Application.Models.Validators
{
	public class NewAppointmentValidator : AbstractValidator<NewAppointment>
	{
		public NewAppointmentValidator()
		{
			RuleFor(o => o.DateTime)
				.Must(dateTime => dateTime.Minute == 0 && dateTime.Second == 0 && dateTime.Millisecond == 0)
				.WithMessage("Appointment time must be based on a hourly slot. Please try again.");
		}
	}
}