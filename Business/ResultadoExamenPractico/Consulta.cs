using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;

namespace Business.ResultadoExamenPractico
{
    public class Consulta
    {
        public class Execute : IRequest<List<FormularioResultadoExamenPractico>>{}

    public class Handler : IRequestHandler<Execute, List<FormularioResultadoExamenPractico>>
    {
      private readonly FormularioContext context;

      public Handler(FormularioContext context)
      {
        this.context = context;
      }

      public async Task<List<FormularioResultadoExamenPractico>> Handle(Execute request, CancellationToken cancellationToken)
        => await this.context.FormularioResultadoExamenPractico.ToListAsync();
    }
  }
}