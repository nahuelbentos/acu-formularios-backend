using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;

namespace Business.DiarioMovil
{
    public class Consulta
    {
        
    public class Ejecuta : IRequest<List<FormularioDiarioMovil>> { }

    public class Manejador : IRequestHandler<Ejecuta, List<FormularioDiarioMovil>>
    {
      private readonly FormularioContext context;

      public Manejador(FormularioContext context)
      {
        this.context = context;
      }
      public async Task<List<FormularioDiarioMovil>> Handle(Ejecuta request, CancellationToken cancellationToken) => await this.context.FormularioDiarioMovil.ToListAsync();
      
    }

    }
}