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
    public string FechaCreacion { get; set; }
    public string LucesDelanterasCortasIzquierda { get; set; }
    public string LucesDelanterasLargasIzquierda { get; set; }
    public string LucesDelanterasSenialeroIzquierdo { get; set; }
    public string LucesDelanterasCortasDerecha { get; set; }
    public string LucesDelanterasLargasDerecha { get; set; }
    public string LucesDelanterasSenialeroDerecho { get; set; }
    public string LucesTracerasPosicionIzquierda { get; set; }
    public string LucesTracerasPosicionDerecha { get; set; }
    public string LucesTracerasSenialeroIzquierdo { get; set; }
    public string LucesTracerasSenialeroDerecho { get; set; }
    public string LucesTracerasReversa { get; set; }
    public string LucesTracerasFreno { get; set; }
    public string NivelAgua { get; set; }
    public string NivelAceite { get; set; }
    public string ObjetoAuxiliar { get; set; }
    public string ObjetoBaliza { get; set; }
    public string ObjetoExtintor { get; set; }
    public string ObjetoConos { get; set; }
    public string Combustible { get; set; } 
  }
}