using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Models;
using Persistance;

namespace Business.DiarioMovil
{
  public class ConsultaById
  {
    public class Ejecuta : IRequest<FormularioDiarioMovil>
    {
      public int Id { get; set; }
    }

    public class Manejador : IRequestHandler<Ejecuta, FormularioDiarioMovil>
    {
      private readonly FormularioContext context;

      public Manejador(FormularioContext context)
      {
        this.context = context;
      }
      public async Task<FormularioDiarioMovil> Handle(Ejecuta request, CancellationToken cancellationToken) => await this.context.FormularioDiarioMovil.FindAsync(request.Id);
    }


  }
}