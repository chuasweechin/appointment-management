using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;
using AppointmentManagement.Domain.Exceptions;
using AppointmentManagement.Domain.Interface;

namespace AppointmentManagement.Domain.DomainServices
{
  public class AppointmentDomainService : IAppointmentDomainService
	{
		private readonly IAppointmentRepository _appointmentRepo;
		private readonly IDoctorRepository _doctorRepo;
		private readonly IPatientRepository _patientRepo;

		public AppointmentDomainService(IAppointmentRepository appointmentRepo, IDoctorRepository doctorRepo, IPatientRepository patientRepo)
		{
			_appointmentRepo = appointmentRepo;
			_doctorRepo = doctorRepo;
			_patientRepo = patientRepo;
		}

		public async Task<List<Appointment>> GetAppointment(string doctorId, string patientId, DateTime dateTime)
		{
			return await _appointmentRepo.Get(doctorId, patientId, dateTime);
		}

		public async Task<Appointment> CreateNewAppointment(string doctorId, string patientId, DateTime dateTime)
		{
			await IsValidDoctor(doctorId);
			await IsValidPatient(patientId);

			await IsDoctorAvailableForTheDay(doctorId, dateTime);
			await IsPatientAvailableForTheDay(patientId, dateTime);
			
			var appointment = new Appointment(doctorId, patientId, dateTime);
			await _appointmentRepo.Add(appointment);

			return appointment;
		}

		public async Task CancelExistingAppointment(string appointmentId)
		{
			var appointment = await _appointmentRepo.FindById(appointmentId);
			appointment.Cancel();

			await _appointmentRepo.SaveChangesToDatabase();
		}

		private async Task IsValidDoctor(string doctorId)
		{
			if (await _doctorRepo.FindById(doctorId) == null)
				throw new AppointmentDomainException(
					"Doctor id is not found in the database. Invalid request."
				);
		}

		private async Task IsValidPatient(string patientId)
		{
			if (await _patientRepo.FindById(patientId) != null)
				throw new AppointmentDomainException(
					"Patient id is not found in the database. Invalid request."
				);
		}

		private async Task IsDoctorAvailableForTheDay(string doctorId, DateTime dateTime)
		{
			var doctorAppointmentForTheDay = await _appointmentRepo.Get(doctorId, string.Empty, dateTime);

			if (!doctorAppointmentForTheDay.TrueForAll(o => o.NoExistingAppointmentForDoctor(doctorId, dateTime)))
				throw new AppointmentDomainException(
					"The doctor already has a existing appointment for this timeslot. Please try another timeslot for the doctor."
				);
		}

		private async Task IsPatientAvailableForTheDay(string patientId, DateTime dateTime)
		{
			var patientAppointmentForTheDay = await _appointmentRepo.Get(string.Empty, patientId, dateTime);

			if (!patientAppointmentForTheDay.TrueForAll(o => o.NoExistingAppointmentForPatient(patientId, dateTime)))
				throw new AppointmentDomainException(
					"The patient already has a existing appointment for this timeslot. Please try another timeslot for the doctor."
				);
		}
	}
}
