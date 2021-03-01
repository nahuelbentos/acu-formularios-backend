using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;

namespace Business.DiarioMovil
{
    public class ConsultaByMovil
    {
    public class Ejecuta : IRequest<List<FormularioDiarioMovil>>
    {
      public int MovilId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<FormularioDiarioMovil>>
    {
      private readonly FormularioContext context;

      public Manejador(FormularioContext context)
      {
        this.context = context;
      }
      public async Task<List<FormularioDiarioMovil>> Handle(Ejecuta request, CancellationToken cancellationToken) 
        => await this.context.FormularioDiarioMovil.Where(f => f.MovCod == request.MovilId).ToListAsync();
    }
    
        
    }
}