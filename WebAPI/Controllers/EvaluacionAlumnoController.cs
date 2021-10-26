using System.Threading.Tasks;
using Business.EvaluacionAlumno;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluacionAlumnoController : MiControllerBase
    {
        
    [HttpPost]
    public async Task<ActionResult<Unit>> AltaEvaluacionAlumno(Nuevo.Ejecuta data) => await this.Mediator.Send(data);
    }
}