using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppointmentManagement.Application.Models;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;

namespace AppointmentManagement.Application.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AppointmentController : ControllerBase
	{
		private readonly IAppointmentRepository _appointmentRepo;

		public AppointmentController(IAppointmentRepository appointmentRepo)
		{
			_appointmentRepo = appointmentRepo;
		}

		[HttpGet]
		public async Task<IActionResult> GetAppointments([FromQuery] AppointmentQuery query)
		{
			try
			{
				var appointments = await _appointmentRepo.Get(query.DoctorId, query.PatientId, query.DateTime);
				return Ok(appointments);
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPost]
		public async Task<IActionResult> CreateAppointment([FromBody] NewAppointment request)
		{
			try
			{
				var appointment = await _appointmentRepo.Add(new Appointment(request.DoctorId, request.PatientId, request.DateTime));
				return Ok(appointment);
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpPut]
		public async Task<IActionResult> CancelAppointment([FromBody] CancelAppointment request)
		{
			try
			{
				var appointment = await _appointmentRepo.FindById(request.AppointmentId);
				appointment.Cancel();
				await _appointmentRepo.SaveChangesToDatabase();

				return Ok();
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}
	}
}
