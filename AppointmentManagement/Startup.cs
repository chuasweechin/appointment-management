using AppointmentManagement.Application.Models.Validators;
using AppointmentManagement.Domain.AggregateModels.AppointmentAggregate;
using AppointmentManagement.Domain.AggregateModels.DoctorAggregate;
using AppointmentManagement.Domain.AggregateModels.PatientAggregate;
using AppointmentManagement.Domain.DomainServices;
using AppointmentManagement.Domain.Interface;
using AppointmentManagement.Infrastructure;
using AppointmentManagement.Infrastructure.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AppointmentManagement
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers()
				.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<NewAppointmentValidator>());
		
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Appointment API", Version = "v1" });
			});

			services.AddDbContext<AppDbContext>(options =>
			{
				options.UseNpgsql(Configuration["Database:ConnectionString"]);
			});

			services.AddScoped<IAppointmentRepository, AppointmentRepository>();
			services.AddScoped<IDoctorRepository, DoctorRepository>();
			services.AddScoped<IPatientRepository, PatientRepository>();

			services.AddScoped<IAppointmentDomainService, AppointmentDomainService>();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseSwagger();

			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Appointment V1");
			});

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
