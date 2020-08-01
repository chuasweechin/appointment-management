using System;
using AppointmentManagement.Domain.Exceptions;
using AppointmentManagement.Domain.Models.SeedWork;

namespace AppointmentManagement.Domain.AggregateModels.AppointmentAggregate
{
  public class Appointment : BaseEntity, IAggregateRoot
	{
		public string DoctorId { get; private set; }
		public string PatientId { get; private set; }

		public Status Status { get; private set; }

		public DateTimeOffset Start { get; private set; }
		public DateTimeOffset End { get; private set; }

		public Appointment(string doctorId, string patientId, DateTimeOffset start) : base()
		{
			DoctorId = doctorId;
			PatientId = patientId;

			Status = Status.Active;

			Start = start;

			SetDateTimeEnd();
			IsWithinConsultationWindow();
		}

		private void IsWithinConsultationWindow()
		{
			const uint CONSULTATION_START_TIME = 8;
			const uint CONSULTATION_END_TIME = 16;

			if (Start.LocalDateTime.Hour < CONSULTATION_START_TIME || Start.LocalDateTime.Hour > CONSULTATION_END_TIME)
				throw new AppointmentDomainException(
					$"Appointment made is not within the consultation window of " +
					$"{ CONSULTATION_START_TIME }:00am to { CONSULTATION_END_TIME }:00pm. " +
					"The appointment cannot be made."
				);
		}

		private void SetDateTimeEnd()
		{
			const uint CONSULTATION_DURATION = 1;
			End = Start.AddHours(CONSULTATION_DURATION);
		}
  }
}