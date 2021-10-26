using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Business.ManejadorError;
using MediatR;
using Models;
using Persistance;

namespace Business.EvaluacionAlumno
{
    public class Nuevo
    {
    public class Ejecuta : IRequest
    {
        public string EscInsId { get; set; }
        public string AlumnoNombreApellido { get; set; }
        public short NumeroClase { get; set; }

        public ProgresoInicial ProgresoEnciendeVehiculo { get; set; }
        public ProgresoInicial ProgresoMarchaVehiculo { get; set; }
        public ProgresoInicial ProgresoEncendidoEnNeutro { get; set; } 

        public ProgresoAlumno SeguridadCinturon { get; set; }
        public ProgresoAlumno SeguridadRegulaButacaApoyaCabezas { get; set; }
        public ProgresoAlumno SeguridadRegulaEspejos { get; set; }


        public ProgresoAlumno DominaUsoPedales { get; set; }
        public ProgresoAlumno DominaAdministracionCambios { get; set; }
        public ProgresoAlumno DominaUsoEspejos { get; set; }
        public ProgresoAlumno TieneBuenaTecnicaBrazos { get; set; }
        public ProgresoAlumno DominaVehiculoEnRepecho { get; set; }
        public ProgresoAlumno SenializaCorrectamenteCambioCarril { get; set; }

        public ProgresoAlumno ReconoceSentidosCirculacion { get; set; }
        public ProgresoAlumno CirculaManteniendoDerecha { get; set; }
        public ProgresoAlumno MantieneDistanciaSeguridad { get; set; }
        public ProgresoAlumno RespetaTodasSenialesTransito { get; set; }
        public ProgresoAlumno SenializaManiobrasARealizar { get; set; }
        public ProgresoAlumno RespetaSendasPeatonales { get; set; }
        public ProgresoAlumno RespetaOtrosUsuariosDeLaVia { get; set; }
        public ProgresoAlumno MantieneVelocidadAdecuada { get; set; }
        public ProgresoAlumno FrenaConSuficienteAnticipacion { get; set; }

        public ProgresoAlumno GiroUbicacionCorrectamente { get; set; }
        public ProgresoAlumno GiroSenializaCorrectamente { get; set; }
        public ProgresoAlumno GiroIngresaCorrectamenteNuevaVia { get; set; }
        public ProgresoAlumno GiroVelocidadCorrecta { get; set; }

        public ProgresoAlumno SaleConduciendoACU { get; set; }
        public ProgresoAlumno VuelveConduciendoACU { get; set; }

        public ProgresoAlumno EvaluaEnfrentaAdecuadamenteDificultades { get; set; }
        public ProgresoAlumno ToleranciaStressTransito { get; set; }
        public ProgresoAlumno AceptaIndicacionesInstructor { get; set; }
        
        public ProgresoManiobras MarchaAtras { get; set; }
        public ProgresoManiobras Slalom { get; set; }
        public ProgresoManiobras EstacionamientoLateralDerecho { get; set; }
        public ProgresoManiobras EstacionamientoLateralIzquierdo { get; set; }
        public ProgresoManiobras Estacionamient45GradosDerecho { get; set; }
        public ProgresoManiobras Estacionamient45GradosIzquierdo { get; set; }
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
        
        this.context.FormularioEvaluacionAlumno.Add( new FormularioEvaluacionAlumno {            
            EscInsId = request.EscInsId,
            AlumnoNombreApellido = request.AlumnoNombreApellido,
            NumeroClase = request.NumeroClase,
            ProgresoEnciendeVehiculo = request.ProgresoEnciendeVehiculo,
            ProgresoMarchaVehiculo = request.ProgresoMarchaVehiculo,
            ProgresoEncendidoEnNeutro = request.ProgresoEncendidoEnNeutro,
            SeguridadCinturon = request.SeguridadCinturon,
            SeguridadRegulaButacaApoyaCabezas = request.SeguridadRegulaButacaApoyaCabezas,
            SeguridadRegulaEspejos = request.SeguridadRegulaEspejos,
            DominaUsoPedales = request.DominaUsoPedales,
            DominaAdministracionCambios = request.DominaAdministracionCambios,
            DominaUsoEspejos = request.DominaUsoEspejos,
            TieneBuenaTecnicaBrazos = request.TieneBuenaTecnicaBrazos,
            DominaVehiculoEnRepecho = request.DominaVehiculoEnRepecho,
            SenializaCorrectamenteCambioCarril = request.SenializaCorrectamenteCambioCarril,
            ReconoceSentidosCirculacion = request.ReconoceSentidosCirculacion,
            CirculaManteniendoDerecha = request.CirculaManteniendoDerecha,
            MantieneDistanciaSeguridad = request.MantieneDistanciaSeguridad,
            RespetaTodasSenialesTransito = request.RespetaTodasSenialesTransito,
            SenializaManiobrasARealizar = request.SenializaManiobrasARealizar,
            RespetaSendasPeatonales = request.RespetaSendasPeatonales,
            RespetaOtrosUsuariosDeLaVia = request.RespetaOtrosUsuariosDeLaVia,
            MantieneVelocidadAdecuada = request.MantieneVelocidadAdecuada,
            FrenaConSuficienteAnticipacion = request.FrenaConSuficienteAnticipacion,
            GiroUbicacionCorrectamente = request.GiroUbicacionCorrectamente,
            GiroSenializaCorrectamente = request.GiroSenializaCorrectamente,
            GiroIngresaCorrectamenteNuevaVia = request.GiroIngresaCorrectamenteNuevaVia,
            GiroVelocidadCorrecta = request.GiroVelocidadCorrecta,
            SaleConduciendoACU = request.SaleConduciendoACU,
            VuelveConduciendoACU = request.VuelveConduciendoACU,
            EvaluaEnfrentaAdecuadamenteDificultades = request.EvaluaEnfrentaAdecuadamenteDificultades,
            ToleranciaStressTransito = request.ToleranciaStressTransito,
            AceptaIndicacionesInstructor = request.AceptaIndicacionesInstructor,
            MarchaAtras = request.MarchaAtras,
            Slalom = request.Slalom,
            EstacionamientoLateralDerecho = request.EstacionamientoLateralDerecho,
            EstacionamientoLateralIzquierdo = request.EstacionamientoLateralIzquierdo,
            Estacionamient45GradosDerecho = request.Estacionamient45GradosDerecho,
            Estacionamient45GradosIzquierdo = request.Estacionamient45GradosIzquierdo,
            Observaciones = request.Observaciones,
            FechaCreacion = DateTime.Now
        } );

        var result = await this.context.SaveChangesAsync();

        if( result > 0)
            return Unit.Value;

        throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Ocurrió un error al crear la el Formulario Diario Movil" });
      }
    }
 
        
    }
}