using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppointmentManagement.Application.Models;
using AppointmentManagement.Domain.DomainServices;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;
using AppointmentManagement.Domain.Interface;

namespace AppointmentManagement.Application.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AppointmentController : ControllerBase
	{
		private readonly IAppointmentRepository _appointmentRepo;
		private readonly IAppointmentDomainService _appointmentDomainService;

		public AppointmentController(IAppointmentRepository appointmentRepo, IAppointmentDomainService appointmentDomainService)
		{
			_appointmentRepo = appointmentRepo;
			_appointmentDomainService = appointmentDomainService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAppointment([FromQuery] AppointmentQuery query)
		{
			try
			{
				var appointments = await _appointmentDomainService.GetAppointment(query.DoctorId, query.PatientId, query.DateTime);
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
				var appointment = await _appointmentDomainService.CreateNewAppointment(request.DoctorId, request.PatientId, request.DateTime);
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
				var appointment = await _appointmentDomainService.CancelExistingAppointment(request.AppointmentId);
				return Ok(appointment);
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}
	}
}
