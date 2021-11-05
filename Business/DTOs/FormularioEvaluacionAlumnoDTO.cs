using System;
using Models;

namespace Business.DTOs
{
  public class FormularioEvaluacionAlumnoDTO
  {

    public long Id { get; set; }
    public string Instructor { get; set; }
    public string Alumno { get; set; }
    public short Clase { get; set; }
    public string Observaciones { get; set; }
    public DateTime Fecha { get; set; }

    public string FechaCreacion { get; set; }

    public string ProgresoEnciendeVehiculo { get; set; }
    public string ProgresoMarchaVehiculo { get; set; }
    public string ProgresoEncendidoEnNeutro { get; set; }

    public string SeguridadCinturon { get; set; }
    public string SeguridadRegulaButacaApoyaCabezas { get; set; }
    public string SeguridadRegulaEspejos { get; set; }


    public string DominaUsoPedales { get; set; }
    public string DominaAdministracionCambios { get; set; }
    public string DominaUsoEspejos { get; set; }
    public string TieneBuenaTecnicaBrazos { get; set; }
    public string DominaVehiculoEnRepecho { get; set; }
    public string SenializaCorrectamenteCambioCarril { get; set; }

    public string ReconoceSentidosCirculacion { get; set; }
    public string CirculaManteniendoDerecha { get; set; }
    public string MantieneDistanciaSeguridad { get; set; }
    public string RespetaTodasSenialesTransito { get; set; }
    public string SenializaManiobrasARealizar { get; set; }
    public string RespetaSendasPeatonales { get; set; }
    public string RespetaOtrosUsuariosDeLaVia { get; set; }
    public string MantieneVelocidadAdecuada { get; set; }
    public string FrenaConSuficienteAnticipacion { get; set; }

    public string GiroUbicacionCorrectamente { get; set; }
    public string GiroSenializaCorrectamente { get; set; }
    public string GiroIngresaCorrectamenteNuevaVia { get; set; }
    public string GiroVelocidadCorrecta { get; set; }

    public string SaleConduciendoACU { get; set; }
    public string VuelveConduciendoACU { get; set; }

    public string EvaluaEnfrentaAdecuadamenteDificultades { get; set; }
    public string ToleranciaStressTransito { get; set; }
    public string AceptaIndicacionesInstructor { get; set; }

    public string MarchaAtras { get; set; }
    public string Slalom { get; set; }
    public string EstacionamientoLateralDerecho { get; set; }
    public string EstacionamientoLateralIzquierdo { get; set; }
    public string Estacionamient45GradosDerecho { get; set; }
    public string Estacionamient45GradosIzquierdo { get; set; }
  }
}