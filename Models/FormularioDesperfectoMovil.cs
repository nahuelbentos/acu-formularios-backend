using System;
using System.Threading;
namespace Models
{
    public class FormularioDesperfectoMovil
    {
        
        public long Id { get; set; }
        public short MovCod { get; set; }
        public string EscInsId { get; set; }
        public int MovilKilometraje { get; set; }
        public string Desperfecto { get; set; }

        public DateTime FechaCreacion { get; set; }
        
        
    }
}