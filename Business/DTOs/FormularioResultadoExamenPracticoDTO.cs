using System;
using Models;

namespace Business.DTOs
{
    public class FormularioResultadoExamenPracticoDTO
    {
        public long Id { get; set; }
        public string Instructor { get; set; }
        public string Alumno { get; set; }
        public ResultadoExamen Resultado { get; set; }
        public DateTime Fecha { get; set; }
    }
}