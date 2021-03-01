using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Business.ManejadorError;
using MediatR;
using Models;
using Persistance;

namespace Business.DiarioMovil
{
  public class Nuevo
  {
    public class Ejecuta : IRequest
    {
      public short MovilId { get; set; }
      public string InstructorId { get; set; }
      public int MovilKilometraje { get; set; }
      public bool LucesDelanterasCortasIzquierda { get; set; }
      public bool LucesDelanterasLargasIzquierda { get; set; }
      public bool LucesDelanterasSenialeroIzquierdo { get; set; }
      public bool LucesDelanterasCortasDerecha { get; set; }
      public bool LucesDelanterasLargasDerecha { get; set; }
      public bool LucesDelanterasSenialeroDerecho { get; set; }
      public bool LucesTracerasPosicionIzquierda { get; set; }
      public bool LucesTracerasPosicionDerecha { get; set; }
      public bool LucesTracerasSenialeroIzquierdo { get; set; }
      public bool LucesTracerasSenialeroDerecho { get; set; }
      public bool LucesTracerasReversa { get; set; }
      public bool LucesTracerasFreno { get; set; }
      public bool NivelAgua { get; set; }
      public bool NivelAceite { get; set; }
      public bool ObjetoAuxiliar { get; set; }
      public bool ObjetoBaliza { get; set; }
      public bool ObjetoExtintor { get; set; }
      public bool ObjetoConos { get; set; }
      public bool Combustible { get; set; }
      public string Observaciones { get; set; }
    }

    public class Manejador : IRequestHandler<Ejecuta>
    {
      private readonly FormularioContext context;

      public Manejador( FormularioContext context )
      {
        this.context = context;
      }

      public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
      {
        this.context.FormularioDiarioMovil.Add( new FormularioDiarioMovil {
            MovCod = request.MovilId,
            EscInsId = request.InstructorId,
            MovilKilometraje = request.MovilKilometraje,
            LucesDelanterasCortasIzquierda = request.LucesDelanterasCortasIzquierda,
            LucesDelanterasLargasIzquierda = request.LucesDelanterasLargasIzquierda,
            LucesDelanterasSenialeroIzquierdo = request.LucesDelanterasSenialeroIzquierdo,
            LucesDelanterasCortasDerecha = request.LucesDelanterasCortasDerecha,
            LucesDelanterasLargasDerecha = request.LucesDelanterasLargasDerecha,
            LucesDelanterasSenialeroDerecho = request.LucesDelanterasSenialeroDerecho,
            LucesTracerasPosicionIzquierda = request.LucesTracerasPosicionIzquierda,
            LucesTracerasPosicionDerecha = request.LucesTracerasPosicionDerecha,
            LucesTracerasSenialeroIzquierdo = request.LucesTracerasSenialeroIzquierdo,
            LucesTracerasSenialeroDerecho = request.LucesTracerasSenialeroDerecho,
            LucesTracerasReversa = request.LucesTracerasReversa,
            LucesTracerasFreno = request.LucesTracerasFreno,
            NivelAgua = request.NivelAgua,
            NivelAceite = request.NivelAceite,
            ObjetoAuxiliar = request.ObjetoAuxiliar,
            ObjetoBaliza = request.ObjetoBaliza,
            ObjetoExtintor = request.ObjetoExtintor,
            ObjetoConos = request.ObjetoConos,
            Combustible = request.Combustible,
            Observaciones = request.Observaciones,
            FechaCreacion = DateTime.Now
        });

        var result = await this.context.SaveChangesAsync();

        if( result > 0)
            return Unit.Value;

        throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Ocurrió un error al crear la el Formulario Diario Movil" });
      }
    }
  }
}