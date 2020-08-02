using Xunit;
using System;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.UnitTest.Domain
{
  public class AppointmentTests
  {
	[Fact]
	public void Constructor_Appointment_Success()
	{
	  // Arrange
	  string doctorId = "D1";
	  string patientId = "P1";
	  DateTime dateTime = DateTime.Parse("12/31/2018 09:00:00");
	  string id = "A1";

	  // Act
	  Appointment appointment = new Appointment(doctorId, patientId, dateTime, id);

	  // Assert
	  Assert.Equal(doctorId, appointment.DoctorId);
	  Assert.Equal(patientId, appointment.PatientId);
	  Assert.Equal(dateTime, appointment.Start);
	  //Assert.Equal(DateTime.Parse("12/31/2018 10:00:00"), appointment.End);
	  Assert.Equal(id, appointment.Id);
	  Assert.Equal(Status.Active, appointment.Status);
	}
  }
}
