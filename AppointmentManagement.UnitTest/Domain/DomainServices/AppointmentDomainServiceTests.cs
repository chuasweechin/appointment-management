using Xunit;
using System;
using System.Threading.Tasks;
using AppointmentManagement.Domain.Exceptions;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;
using AppointmentManagement.Domain.DomainServices;
using AppointmentManagement.UnitTest.Fixture;

namespace AppointmentManagement.UnitTest.DomainServices
{
  public class AppointmentDomainServiceTests
	{
		[Theory]
		[InlineData("D1", "P1", "03/08/2018 09:00:00", 1)]
		[InlineData("D1", "P1", "04/08/2018 10:00:00", 2)]
		[InlineData("D1", "P2", "03/08/2018 10:00:00", 1)]
		[InlineData("D1", "", "03/08/2018 10:00:00", 2)]
		[InlineData("", "P1", "04/08/2018 10:00:00", 2)]
		public async Task GetAppointment_Success(string doctorId, string patientId, string dateTime, int expectedResult)
		{
			// Arrange
			MockAppointmentRepository mockAppointmentRepository = new MockAppointmentRepository();
			AppointmentDomainService appointmentDomainService = new AppointmentDomainService(mockAppointmentRepository, null, null);

			// Act
			var appointments = await appointmentDomainService.GetAppointment(doctorId, patientId, DateTime.Parse(dateTime));

			// Assert
			Assert.Equal(expectedResult, appointments.Count);
		}

		[Theory]
		[InlineData("D1", "P1", "03/08/2018 11:00:00")]
		[InlineData("D1", "P1", "03/08/2018 12:00:00")]
		[InlineData("D2", "P2", "03/08/2018 12:00:00")]
		public async Task CreateNewAppointment_Success(string doctorId, string patientId, string dateTime)
		{
			// Arrange
			MockAppointmentRepository mockAppointmentRepository = new MockAppointmentRepository();
			MockDoctorRepository mockDoctorRepository = new MockDoctorRepository();
			MockPatientRepository mockPatientRepository = new MockPatientRepository();
			AppointmentDomainService appointmentDomainService = new AppointmentDomainService(mockAppointmentRepository, mockDoctorRepository, mockPatientRepository);

			// Act
			var appointment = await appointmentDomainService.CreateNewAppointment(doctorId, patientId, DateTime.Parse(dateTime));

			// Assert
			Assert.Equal(Status.Active, appointment.Status);
		}

		[Theory]
		[InlineData("D9")]
		[InlineData("Dx")]
		[InlineData("Da")]
		public async Task CreateNewAppointment_InvalidDoctorId_ThrowException(string doctorId)
		{
			// Arrange
			MockAppointmentRepository mockAppointmentRepository = new MockAppointmentRepository();
			MockDoctorRepository mockDoctorRepository = new MockDoctorRepository();
			MockPatientRepository mockPatientRepository = new MockPatientRepository();
			AppointmentDomainService appointmentDomainService = new AppointmentDomainService(mockAppointmentRepository, mockDoctorRepository, mockPatientRepository);

			// Act & Assert
			await Assert.ThrowsAsync<AppointmentDomainException>(async () => await appointmentDomainService.CreateNewAppointment(doctorId, "P1", DateTime.Parse("03/08/2018 11:00:00")));
		}

		[Theory]
		[InlineData("P9")]
		[InlineData("Px")]
		[InlineData("Pa")]
		public async Task CreateNewAppointment_InvalidPatientId_ThrowException(string patientId)
		{
			// Arrange
			MockAppointmentRepository mockAppointmentRepository = new MockAppointmentRepository();
			MockDoctorRepository mockDoctorRepository = new MockDoctorRepository();
			MockPatientRepository mockPatientRepository = new MockPatientRepository();
			AppointmentDomainService appointmentDomainService = new AppointmentDomainService(mockAppointmentRepository, mockDoctorRepository, mockPatientRepository);

			// Act & Assert
			await Assert.ThrowsAsync<AppointmentDomainException>(async () => await appointmentDomainService.CreateNewAppointment("D1", patientId, DateTime.Parse("03/08/2018 11:00:00")));
		}

		[Theory]
		[InlineData("D1", "03/08/2018 09:00:00")]
		[InlineData("D1", "04/08/2018 10:00:00")]
		public async Task CreateNewAppointment_DoctorAlreadyHasAppointment_ThrowAppointmentDomainException(string doctorId, string dateTime)
		{
			// Arrange
			MockAppointmentRepository mockAppointmentRepository = new MockAppointmentRepository();
			MockDoctorRepository mockDoctorRepository = new MockDoctorRepository();
			MockPatientRepository mockPatientRepository = new MockPatientRepository();
			AppointmentDomainService appointmentDomainService = new AppointmentDomainService(mockAppointmentRepository, mockDoctorRepository, mockPatientRepository);

			// Act & Assert
			await Assert.ThrowsAsync<AppointmentDomainException>(async () => await appointmentDomainService.CreateNewAppointment(doctorId, "P1", DateTime.Parse(dateTime)));
		}

		[Theory]
		[InlineData("P1", "03/08/2018 09:00:00")]
		[InlineData("P1", "04/08/2018 10:00:00")]
		public async Task CreateNewAppointment_PatientAlreadyHasAppointment_ThrowAppointmentDomainException(string patientId, string dateTime)
		{
			// Arrange
			MockAppointmentRepository mockAppointmentRepository = new MockAppointmentRepository();
			MockDoctorRepository mockDoctorRepository = new MockDoctorRepository();
			MockPatientRepository mockPatientRepository = new MockPatientRepository();
			AppointmentDomainService appointmentDomainService = new AppointmentDomainService(mockAppointmentRepository, mockDoctorRepository, mockPatientRepository);

			// Act & Assert
			await Assert.ThrowsAsync<AppointmentDomainException>(async () => await appointmentDomainService.CreateNewAppointment("D2", patientId, DateTime.Parse(dateTime)));
		}

		[Theory]
		[InlineData("A1")]
		[InlineData("A2")]
		[InlineData("A3")]
		[InlineData("A4")]
		public async Task CancelExistingAppointment_Success(string appointmentId)
		{
			// Arrange
			MockAppointmentRepository mockAppointmentRepository = new MockAppointmentRepository();
			AppointmentDomainService appointmentDomainService = new AppointmentDomainService(mockAppointmentRepository, null, null);

			// Act
			var appointment = await appointmentDomainService.CancelExistingAppointment(appointmentId);

			// Assert
			Assert.Equal(Status.Cancelled, appointment.Status);
		}
	}
}
