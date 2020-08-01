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

		public DateTime Start { get; private set; }
		public DateTime End { get; private set; }

		protected Appointment() { }

		public Appointment(string doctorId, string patientId, DateTime start, string id = "") : base(id)
		{
			DoctorId = string.IsNullOrEmpty(doctorId) ? throw new ArgumentException() : doctorId;
			PatientId = string.IsNullOrEmpty(patientId) ? throw new ArgumentException() : patientId;

			Status = Status.Active;

			Start = start;

			SetDateTimeEnd();
			IsWithinConsultationWindow();
		}

		public void Cancel()
		{
			Status = Status.Cancelled;
			UpdatedAt = DateTime.Now;
		}

		public bool NoExistingAppointmentForDoctor(string doctorId, DateTime dateTime)
		{
			if (Status == Status.Cancelled)
				return true;

			if (DoctorId == doctorId)
			{
				if (dateTime >= Start && dateTime <= End)
					return false;
			}

			return true;
		}

		public bool NoExistingAppointmentForPatient(string patientId, DateTime dateTime)
		{
			if (Status == Status.Cancelled)
				return true;

			if (PatientId == patientId)
			{
				if (dateTime >= Start && dateTime <= End)
					return false;
			}

			return true;
		}

		private void IsWithinConsultationWindow()
		{
			const uint CONSULTATION_START_TIME = 8;
			const uint CONSULTATION_END_TIME = 16;

			if (Start.Hour < CONSULTATION_START_TIME || Start.Hour > CONSULTATION_END_TIME)
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