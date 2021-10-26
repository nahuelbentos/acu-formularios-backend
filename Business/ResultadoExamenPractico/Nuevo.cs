using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Business.ManejadorError;
using MediatR;
using Models;
using Persistance;

namespace Business.ResultadoExamenPractico
{
  public class Nuevo
  {
    public class Ejecuta : IRequest
    {
      public string EscInsId { get; set; }
      public string AlumnoNombreApellido { get; set; }
      public bool EsAlumnoOtroInstructor { get; set; }
      public string InstructorAlumnoId { get; set; }
      public ResultadoExamen Resultado { get; set; }
      public MotivoReprobacionPista? MotivoReprobacionPista { get; set; }
      public MotivoReprobacionCalle? MotivoReprobacionCalle { get; set; }
      public string DetalleMotivoPerdida { get; set; }
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
        Console.WriteLine(" Estoy en el manejador");
        Console.WriteLine("     request.MotivoReprobacionPista: " + request.MotivoReprobacionPista);


          this.context.FormularioResultadoExamenPractico.Add( new FormularioResultadoExamenPractico {
              EscInsId = request.EscInsId,
              AlumnoNombreApellido = request.AlumnoNombreApellido,
              EsAlumnoOtroInstructor = request.EsAlumnoOtroInstructor,
              InstructorAlumnoId = request.InstructorAlumnoId,
              Resultado = request.Resultado,
              MotivoReprobacionPista = request.MotivoReprobacionPista,
              MotivoReprobacionCalle = request.MotivoReprobacionCalle,
              DetalleMotivoPerdida = request.DetalleMotivoPerdida,
              FechaCreacion =DateTime.Now
          });

          var result = await this.context.SaveChangesAsync();
          if( result > 0)
            return Unit.Value;
        
        throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Ocurrió un error al crear el Formulario Resultado Examen Practico" });
      }
    }

  }
}