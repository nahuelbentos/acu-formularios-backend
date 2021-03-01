using System;
using System.Threading.Tasks;
using Business.Test;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController  : MiControllerBase
    {
        
    [HttpGet]
    public async Task<ActionResult<Unit>> getTest() => await this.Mediator.Send(new TestWs.Ejecuta() );
    }
}