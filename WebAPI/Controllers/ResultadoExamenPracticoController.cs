using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DTOs;
using Business.ResultadoExamenPractico;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class ResultadoExamenPracticoController : MiControllerBase
  {

    [HttpPost]
    public async Task<ActionResult<Unit>> AltaResultadoExamenPractico(Nuevo.Ejecuta data) => await this.Mediator.Send(data);

    [HttpGet]
    public async Task<ActionResult<List<FormularioResultadoExamenPracticoDTO>>> GetResultadoExamenPractico()
        => await this.Mediator.Send(new Consulta.Execute());

    [HttpGet("instructor/{id}")]
    public async Task<ActionResult<List<FormularioResultadoExamenPractico>>> GetResultadoExamenPracticoById(string id)
        => await this.Mediator.Send(new ConsultaByInstructor.Execute { InstructorId = id });

  }
}