using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;
using System.Linq;
using Business.DTOs;

namespace Business.DiarioMovil
{
    public class Consulta
    {
        
    public class Ejecuta : IRequest<List<FormularioDiarioMovilDTO>> { }

    public class Manejador : IRequestHandler<Ejecuta, List<FormularioDiarioMovilDTO>>
    {
      private readonly FormularioContext context;

      public Manejador(FormularioContext context)
      {
        this.context = context;
      }
      public async Task<List<FormularioDiarioMovilDTO>> Handle(Ejecuta request, CancellationToken cancellationToken) 
        => await this.context.FormularioDiarioMovil
          .Select( f =>  new FormularioDiarioMovilDTO {
            Id = f.Id,
            Fecha = f.FechaCreacion,
            Instructor = f.EscInsId,
            Kilometraje = f.MovilKilometraje,
            Movil = f.MovCod,
            Observaciones = f.Observaciones
          })
          .ToListAsync();
      
    }

    }
}