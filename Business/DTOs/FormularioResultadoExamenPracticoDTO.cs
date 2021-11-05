using System;
using Models;

namespace Business.DTOs
{
    public class FormularioResultadoExamenPracticoDTO
    {
        public long Id { get; set; }
        public string Instructor { get; set; }
        public string Alumno { get; set; }
        public string Resultado { get; set; }
        public DateTime Fecha { get; set; }
        public string FechaCreacion { get; set; }

        public string EsAlumnoOtroInstructor { get; set; }
        public string InstructorDelAlumno { get; set; }
        public string MotivoReprobacionPista { get; set; }
        public string MotivoReprobacionCalle { get; set; }
        public string DetalleMotivoPerdida { get; set; }
    }
}