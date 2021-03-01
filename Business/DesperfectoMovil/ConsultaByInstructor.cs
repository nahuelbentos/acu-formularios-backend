using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;

namespace Business.DesperfectoMovil
{
  public class ConsultaByInstructor
  {
    public class Ejecuta : IRequest<List<FormularioDesperfectoMovil>>
    {
      public string InstructorId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<FormularioDesperfectoMovil>>
    {
      private readonly FormularioContext context;

      public Manejador(FormularioContext context)
      {
        this.context = context;
      }
      public async Task<List<FormularioDesperfectoMovil>> Handle(Ejecuta request, CancellationToken cancellationToken)
        => await this.context.FormularioDesperfectoMovil.Where(f => f.EscInsId == request.InstructorId).ToListAsync();
    }

  }
}