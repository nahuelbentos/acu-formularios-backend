using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.DesperfectoMovil;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistance;
using WebAPI.Middleware;

namespace WebAPI
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      // Configuración de CORS
      services.AddCors(o => o.AddPolicy("corsApp", builder =>
      {
        builder
          .AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader();
      }));

      services.AddDbContext<FormularioContext>(opt =>
      {
        opt.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection"));
      });
      //  Configuracion IIS
      services.Configure<IISServerOptions>(options =>
          {
            options.AutomaticAuthentication = false;
          });
      services.Configure<IISOptions>(options =>
          {
            options.ForwardClientCertificate = false;
          });
      services.AddOptions();

      services.AddControllers();
      // Middleware

      services.AddMediatR(typeof(Nuevo.Manejador).Assembly);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      // Indico que la app use la policy "corsApp"definida en ConfigureServices.      
      app.UseCors("corsApp");

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseCors(builder =>
      {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
      });
    //   app.UseHttpsRedirection();

      app.UseRouting();

      app.UseMiddleware<ManejadorErrorMiddleware>();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}


