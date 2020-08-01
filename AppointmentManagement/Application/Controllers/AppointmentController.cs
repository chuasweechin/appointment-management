using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;
using System;

namespace AppointmentManagement.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly ILogger _logger;

        public AppointmentController(ILogger<AppointmentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
          Appointment a = new Appointment("D1", "P1", DateTimeOffset.UtcNow);
          return Ok(a);
        }
    }
}
