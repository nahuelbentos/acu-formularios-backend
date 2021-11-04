using System;

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
    }
}