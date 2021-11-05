using System;

namespace Business.DTOs
{
    public class FormularioDesperfectoMovilDTO
    {

    public long Id { get; set; }
    public short Movil { get; set; }
    public string Instructor { get; set; }
    public int Kilometraje { get; set; }
    public string Desperfecto { get; set; }
    public DateTime Fecha { get; set; }
    public string FechaCreacion { get; set; }
    }
}