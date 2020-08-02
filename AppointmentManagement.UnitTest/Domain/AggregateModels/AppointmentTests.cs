using Xunit;
using System;
using AppointmentManagement.Domain.Exceptions;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.UnitTest.Domain.AggregateModels
{
  public class AppointmentTests
  {
		[Theory]
		[InlineData("D1", "P1", "12/31/2018 09:00:00", "12/31/2018 10:00:00", "A1")]
		[InlineData("D2", "P2", "12/31/2020 09:00:00", "12/31/2020 10:00:00", "A2")]
		public void Constructor_Appointment_Success(string doctorId, string patientId, string appointmentStart, string appointmentEnd, string id)
		{
			// Arrange
			DateTime appointmentDateTime = DateTime.Parse(appointmentStart);

			// Act
			Appointment appointment = new Appointment(doctorId, patientId, appointmentDateTime, id);

			// Assert
			Assert.Equal(doctorId, appointment.DoctorId);
			Assert.Equal(patientId, appointment.PatientId);
			Assert.Equal(appointmentDateTime, appointment.Start);
			Assert.Equal(DateTime.Parse(appointmentEnd), appointment.End);
			Assert.Equal(id, appointment.Id);
			Assert.Equal(Status.Active, appointment.Status);
		}

		[Theory]
		[InlineData("D1", "")]
		[InlineData("", "P1")]
		[InlineData("", "")]
		public void Constructor_MissingDoctorIdOrPatientId_ThrowArgumentException(string doctorId, string patientId)
		{
			// Arrange & Act & Assert
			Assert.Throws<ArgumentException>(
				() => new Appointment(doctorId, patientId, DateTime.Parse("12/31/2018 09:00:00"), "A1")
			);
		}

		[Theory]
		[InlineData("12/31/2018 00:00:00")]
		[InlineData("12/31/2018 01:00:00")]
		[InlineData("12/31/2018 02:00:00")]
		[InlineData("12/31/2018 03:00:00")]
		[InlineData("12/31/2018 04:00:00")]
		[InlineData("12/31/2018 05:00:00")]
		[InlineData("12/31/2018 06:00:00")]
		[InlineData("12/31/2018 07:00:00")]
		[InlineData("12/31/2018 17:00:00")]
		[InlineData("12/31/2018 18:00:00")]
		[InlineData("12/31/2018 19:00:00")]
		[InlineData("12/31/2018 20:00:00")]
		[InlineData("12/31/2018 21:00:00")]
		[InlineData("12/31/2018 22:00:00")]
		[InlineData("12/31/2018 23:00:00")]
		public void Constructor_OutsideConsultationWindow_ThrowAppointmentDomainException(string appointmentStart)
		{
			// Arrange & Act & Assert
			Assert.Throws<AppointmentDomainException>(
				() => new Appointment("D1", "P1", DateTime.Parse(appointmentStart), "A1")
			);
		}

		[Theory]
		[InlineData("D1", "P1", "12/31/2018 09:00:00", "A1")]
		[InlineData("D2", "P2", "12/31/2020 09:00:00", "A2")]
		public void Cancel_Appointment_Success(string doctorId, string patientId, string dateTime, string id)
		{
			// Arrange & Act
			Appointment appointment = new Appointment(doctorId, patientId, DateTime.Parse(dateTime), id);
			appointment.Cancel();

			// Assert
			Assert.Equal(Status.Cancelled, appointment.Status);
		}

		[Theory]
		[InlineData("12/31/2018 09:00:00", "12/31/2018 09:00:00", false, false)]
		[InlineData("12/31/2020 09:00:00", "12/31/2020 09:00:00", false, false)]
		[InlineData("12/31/2020 09:00:00", "12/31/2020 09:00:00", true, true)]
		[InlineData("12/31/2018 09:00:00", "12/31/2018 10:00:00", false, true)]
		[InlineData("12/31/2020 09:00:00", "12/31/2020 12:00:00", false, true)]
		public void NoExistingAppointmentForDoctor_Success(string appointmentDateTime, string newAppointmentDateTime, bool cancelled, bool expectedResult)
		{
			// Arrange
			Appointment appointment = new Appointment("D1", "P1", DateTime.Parse(appointmentDateTime), "A1");

			if (cancelled)
				appointment.Cancel();

			// Act & Assert
			Assert.Equal(expectedResult, appointment.NoExistingAppointmentForDoctor("D1", DateTime.Parse(newAppointmentDateTime)));
		}


		[Theory]
		[InlineData("12/31/2018 09:00:00", "12/31/2018 09:00:00", false, false)]
		[InlineData("12/31/2020 09:00:00", "12/31/2020 09:00:00", false, false)]
		[InlineData("12/31/2020 09:00:00", "12/31/2020 09:00:00", true, true)]
		[InlineData("12/31/2018 09:00:00", "12/31/2018 10:00:00", false, true)]
		[InlineData("12/31/2020 09:00:00", "12/31/2020 12:00:00", false, true)]
		public void NoExistingAppointmentForPatient_Success(string appointmentDateTime, string newAppointmentDateTime, bool cancelled, bool expectedResult)
		{
			// Arrange
			Appointment appointment = new Appointment("D1", "P1", DateTime.Parse(appointmentDateTime), "A1");

			if (cancelled)
				appointment.Cancel();

			// Act & Assert
			Assert.Equal(expectedResult, appointment.NoExistingAppointmentForPatient("P1", DateTime.Parse(newAppointmentDateTime)));
		}
	}
}
