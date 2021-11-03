using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DesperfectoMovil;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DesperfectoMovilController : MiControllerBase
  {

    [HttpPost]
    public async Task<ActionResult<Unit>> AltaDesperfectoMovil(Nuevo.Ejecuta data) 
        => await this.Mediator.Send(data);

    [HttpGet]
    public async Task<ActionResult<List<FormularioDesperfectoMovil>>> GetDesperfectoMovil() 
        => await this.Mediator.Send(new Consulta.Ejecuta());

    [HttpGet("{id}")]
    public async Task<ActionResult<FormularioDesperfectoMovil>> GetById(int id)
        => await this.Mediator.Send(new ConsultaById.Ejecuta { Id = id });

    [HttpGet("movil/{id}")]
    public async Task<ActionResult<List<FormularioDesperfectoMovil>>> GetByMovil(int id)
        => await this.Mediator.Send(new ConsultaByMovil.Ejecuta { MovilId = id });

    [HttpGet("instructor/{id}")]
    public async Task<ActionResult<List<FormularioDesperfectoMovil>>> GetByInstructor(string id)
        => await this.Mediator.Send(new ConsultaByInstructor.Ejecuta { InstructorId = id });
  }
}