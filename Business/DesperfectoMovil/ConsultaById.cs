using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Models;
using Persistance;

namespace Business.DesperfectoMovil
{
  public class ConsultaById
  {
    public class Ejecuta : IRequest<FormularioDesperfectoMovil>
    {
      public int Id { get; set; }
    }

    public class Manejador : IRequestHandler<Ejecuta, FormularioDesperfectoMovil>
    {
      private readonly FormularioContext context;

      public Manejador(FormularioContext context)
      {
        this.context = context;
      }
      public async Task<FormularioDesperfectoMovil> Handle(Ejecuta request, CancellationToken cancellationToken) => await this.context.FormularioDesperfectoMovil.FindAsync(request.Id);
    }
  
  }
}