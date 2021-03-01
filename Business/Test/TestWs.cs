using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Business.Test
{
    public class TestWs
    {
        
    public class Ejecuta : IRequest  { }

    public class Manejador : IRequestHandler<Ejecuta>
    {
      public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
      {
        return Unit.Value ;
      }
    }
  }
}