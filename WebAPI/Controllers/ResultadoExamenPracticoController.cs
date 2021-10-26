using System.Threading.Tasks;
using Business.ResultadoExamenPractico;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadoExamenPracticoController : MiControllerBase
    {
        
    [HttpPost]
    public async Task<ActionResult<Unit>> AltaResultadoExamenPractico(Nuevo.Ejecuta data) => await this.Mediator.Send(data);
    }
}