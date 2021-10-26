using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Business.ManejadorError;
using MediatR;
using Models;
using Persistance;

namespace Business.DesperfectoMovil
{
  public class Nuevo
  {
    public class Ejecuta : IRequest
    {
      public short MovilId { get; set; }
      public string InstructorId { get; set; }
      public int MovilKilometraje { get; set; }
      public string Desperfecto { get; set; }
    }

    public class Manejador : IRequestHandler<Ejecuta>
    {
      private readonly FormularioContext context;

      public Manejador(FormularioContext context)
      {
        this.context = context;
      }

      public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
      {
        this.context.FormularioDesperfectoMovil.Add(new FormularioDesperfectoMovil
        {

          MovCod = request.MovilId,
          EscInsId = request.InstructorId,
          MovilKilometraje = request.MovilKilometraje,
          Desperfecto = request.Desperfecto,
          FechaCreacion = DateTime.Now
        });


        var result = await this.context.SaveChangesAsync();

        if (result > 0)
          return Unit.Value;

        throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Ocurrió un error al crear el Formulario Desperfecto Movil" });
      }
    }
  }
}