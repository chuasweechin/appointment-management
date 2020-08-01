using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppointmentManagement.Application.Models.Dto;
using AppointmentManagement.Application.Models.ViewModels;
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
		public async Task<IActionResult> Get([FromQuery] AppointmentQuery query)
		{
			try
			{
				var appointments = await _appointmentRepo.Get(query.DoctorId, query.PatientId, query.DateTime);
				return Ok(appointments);
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] NewAppointment request)
		{
			try
			{
				var appointment = await _appointmentRepo.Add(new Appointment(request.DoctorId, request.PatientId, request.DateTime));
				return Ok(appointment);
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}

		[HttpPut]
		public async Task<IActionResult> Update([FromBody] CancelAppointment request)
		{
			try
			{
				var appointment = await _appointmentRepo.FindById(request.AppointmentId);
				appointment.Cancel();
				await _appointmentRepo.SaveChangesToDatabase();

				return Ok();
			}
			catch (Exception)
			{
				return StatusCode(500);
			}
		}
	}
}
