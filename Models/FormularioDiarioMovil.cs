using System;

namespace Models
{
    public class FormularioDiarioMovil
    {
        public long Id { get; set; }
        public short MovCod { get; set; }
        public string EscInsId { get; set; }
        public int MovilKilometraje { get; set; }
        public bool LucesDelanterasCortasIzquierda { get; set; }
        public bool LucesDelanterasLargasIzquierda { get; set; }
        public bool LucesDelanterasSenialeroIzquierdo { get; set; }
        public bool LucesDelanterasCortasDerecha { get; set; }
        public bool LucesDelanterasLargasDerecha { get; set; }
        public bool LucesDelanterasSenialeroDerecho { get; set; }
        public bool LucesTracerasPosicionIzquierda { get; set; }
        public bool LucesTracerasPosicionDerecha { get; set; }
        public bool LucesTracerasSenialeroIzquierdo { get; set; }
        public bool LucesTracerasSenialeroDerecho { get; set; }
        public bool LucesTracerasReversa { get; set; }
        public bool LucesTracerasFreno { get; set; }
        public bool NivelAgua { get; set; }
        public bool NivelAceite { get; set; }
        public bool ObjetoAuxiliar { get; set; }
        public bool ObjetoBaliza { get; set; }
        public bool ObjetoExtintor { get; set; }
        public bool ObjetoConos { get; set; }
        public bool Combustible { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
        
        
    }
}