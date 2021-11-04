using System;

namespace Business.DTOs
{
  public class FormularioDiarioMovilDTO
  {
    public long Id { get; set; }
    public short Movil { get; set; }
    public string Instructor { get; set; }
    public int Kilometraje { get; set; }
    public string Observaciones { get; set; }
    public DateTime Fecha { get; set; }
    public string FechaString { get; set; }
  }
}