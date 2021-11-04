using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DTOs;
using Business.EvaluacionAlumno;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EvaluacionAlumnoController : MiControllerBase
  {

    [HttpPost]
    public async Task<ActionResult<Unit>> AltaEvaluacionAlumno(Nuevo.Ejecuta data)
        => await this.Mediator.Send(data);

    [HttpGet]
    public async Task<ActionResult<List<FormularioEvaluacionAlumnoDTO>>> GetEvaluacionAlumno()
        => await this.Mediator.Send(new Consulta.Execute());

    [HttpGet("instructor/{id}")]
    public async Task<ActionResult<List<FormularioEvaluacionAlumnoDTO>>> GetEvaluacionAlumnoByInstructor(string id)
        => await this.Mediator.Send(new ConsultaByInstructor.Execute { InstructorId = id });

  }
}