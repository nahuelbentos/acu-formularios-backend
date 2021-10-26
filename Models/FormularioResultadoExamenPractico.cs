using System;

namespace Models
{
    public class FormularioResultadoExamenPractico
    {
        
        public long Id { get; set; }
        public string EscInsId { get; set; }
        public string AlumnoNombreApellido { get; set; }
        public bool EsAlumnoOtroInstructor { get; set; }
        public string InstructorAlumnoId { get; set; }
        public ResultadoExamen Resultado { get; set; }
        public MotivoReprobacionPista? MotivoReprobacionPista { get; set; }
        public MotivoReprobacionCalle? MotivoReprobacionCalle { get; set; }
        public string DetalleMotivoPerdida { get; set; }
        public DateTime FechaCreacion { get; set; }
        
        
    }
    public enum ResultadoExamen
    {
        Aprobado,
        ReprobadoPista,
        ReprobadoCalle,
    }
    public enum MotivoReprobacionPista
    {
        MarchaAtras,
        Slalom,
        EstacionamientoLateralDerecho,
        EstacionamientoLateralIzquierdo,
        Estacionamient45GradosDerecho,
        Estacionamient45GradosIzquierdo,
        CartelPare,
        Otro,
    }
    public enum MotivoReprobacionCalle
    {
        MalIngresoRotonda,
        NoRespetoDerecho,
        OlvidoSenialero,
        Otro,
    }
}