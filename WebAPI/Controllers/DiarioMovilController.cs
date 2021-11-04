using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DiarioMovil;
using Business.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DiarioMovilController : MiControllerBase
  {
    [HttpPost]
    public async Task<ActionResult<Unit>> AltaDiarioMovil(Nuevo.Ejecuta data) => await this.Mediator.Send(data);

    [HttpGet]
    public async Task<ActionResult<List<FormularioDiarioMovilDTO>>> GetDiarioMovil() => await this.Mediator.Send(new Consulta.Ejecuta());
    
    [HttpGet("{id}")]
    public async Task<ActionResult<FormularioDiarioMovil>> GetById(int id) => await this.Mediator.Send(new ConsultaById.Ejecuta { Id = id });

    [HttpGet("movil/{id}")]
    public async Task<ActionResult<List<FormularioDiarioMovil>>> GetByMovil(int id) => await this.Mediator.Send(new ConsultaByMovil.Ejecuta { MovilId = id });
    
    [HttpGet("instructor/{id}")]
    public async Task<ActionResult<List<FormularioDiarioMovil>>> GetByInstructor(string id) => await this.Mediator.Send(new ConsultaByInstructor.Ejecuta { InstructorId = id });


    [HttpPost("excel")]
    public async Task<ActionResult<object>> GetDiarioMovilExcel( long[] ids) => await this.Mediator.Send(new ExportExcel.Execute{ Ids = ids });

  }
}