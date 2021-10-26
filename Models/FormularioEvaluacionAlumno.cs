using System;

namespace Models
{
    public class FormularioEvaluacionAlumno
    {
        
        public long Id { get; set; }
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
        public DateTime FechaCreacion { get; set; }
    }

    
    public enum ProgresoInicial
    {
        PrimerIntento,
        AlgunosIntentos,
        NoLoLogroAun,
    }
    public enum ProgresoAlumno
    {
        Siempre,
        AVeces,
        NoLoLogroTodavia,
    }
    
    public enum ProgresoManiobras
    {
        PrimerIntento,
        AlgunosIntentos,
        NoLoLogroTodavia,
        NoCorresponde,
    }

}