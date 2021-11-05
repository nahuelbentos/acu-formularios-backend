using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Business.DTOs;
using Models;

namespace Business.Utils
{
  public static class Helpers
  {
    public static DataTable ToDataTable<T>(this IList<T> data)
    {
      PropertyDescriptorCollection props =
      TypeDescriptor.GetProperties(typeof(T));
      DataTable table = new DataTable();
      for (int i = 0; i < props.Count; i++)
      {
        PropertyDescriptor prop = props[i];
        table.Columns.Add(prop.Name, prop.PropertyType);
      }
      object[] values = new object[props.Count];
      foreach (T item in data)
      {
        for (int i = 0; i < values.Length; i++)
        {
          values[i] = props[i].GetValue(item);
        }
        table.Rows.Add(values);
      }
      return table;
    }

    public static FormularioDiarioMovilDTO toFormularioDiarioMovilDTO(FormularioDiarioMovil f) => new FormularioDiarioMovilDTO
    {
      Id = f.Id,
      Fecha = f.FechaCreacion,
      FechaCreacion = f.FechaCreacion.ToShortDateString(),
      Instructor = f.EscInsId,
      Kilometraje = f.MovilKilometraje,
      Movil = f.MovCod,
      Observaciones = f.Observaciones,
      LucesDelanterasCortasIzquierda = f.LucesDelanterasCortasIzquierda ? "Correcto" : "Problemas",
      LucesDelanterasLargasIzquierda = f.LucesDelanterasLargasIzquierda ? "Correcto" : "Problemas",
      LucesDelanterasSenialeroIzquierdo = f.LucesDelanterasSenialeroIzquierdo ? "Correcto" : "Problemas",
      LucesDelanterasCortasDerecha = f.LucesDelanterasCortasDerecha ? "Correcto" : "Problemas",
      LucesDelanterasLargasDerecha = f.LucesDelanterasLargasDerecha ? "Correcto" : "Problemas",
      LucesDelanterasSenialeroDerecho = f.LucesDelanterasSenialeroDerecho ? "Correcto" : "Problemas",
      LucesTracerasPosicionIzquierda = f.LucesTracerasPosicionIzquierda ? "Correcto" : "Problemas",
      LucesTracerasPosicionDerecha = f.LucesTracerasPosicionDerecha ? "Correcto" : "Problemas",
      LucesTracerasSenialeroIzquierdo = f.LucesTracerasSenialeroIzquierdo ? "Correcto" : "Problemas",
      LucesTracerasSenialeroDerecho = f.LucesTracerasSenialeroDerecho ? "Correcto" : "Problemas",
      LucesTracerasReversa = f.LucesTracerasReversa ? "Correcto" : "Problemas",
      LucesTracerasFreno = f.LucesTracerasFreno ? "Correcto" : "Problemas",
      NivelAgua = f.NivelAgua ? "Correcto" : "Incorrecto",
      NivelAceite = f.NivelAceite ? "Correcto" : "Incorrecto",
      ObjetoAuxiliar = f.ObjetoAuxiliar ? "Correcto" : "Incorrecto",
      ObjetoBaliza = f.ObjetoBaliza ? "Correcto" : "Incorrecto",
      ObjetoExtintor = f.ObjetoExtintor ? "Correcto" : "Incorrecto",
      ObjetoConos = f.ObjetoConos ? "Correcto" : "Incorrecto",
      Combustible = f.Combustible ? "Correcto" : "Incorrecto",
    };

    public static FormularioDesperfectoMovilDTO toFormularioDesperfectoMovilDTO(FormularioDesperfectoMovil f) => new FormularioDesperfectoMovilDTO
    {
      Id = f.Id,
      Movil = f.MovCod,
      Instructor = f.EscInsId,
      Kilometraje = f.MovilKilometraje,
      Desperfecto = f.Desperfecto,
      Fecha = f.FechaCreacion,
      FechaCreacion = f.FechaCreacion.ToShortDateString(),
    };

    public static FormularioEvaluacionAlumnoDTO toFormularioEvaluacionAlumnoDTO(FormularioEvaluacionAlumno f) => new FormularioEvaluacionAlumnoDTO
    {
      Id = f.Id,
      Instructor = f.EscInsId,
      Alumno = f.AlumnoNombreApellido,
      Clase = f.NumeroClase,
      Observaciones = f.Observaciones,
      Fecha = f.FechaCreacion,
      FechaCreacion = f.FechaCreacion.ToShortDateString(),
      ProgresoEnciendeVehiculo = Enum.GetName(typeof(ProgresoInicial), f.ProgresoEnciendeVehiculo),
      ProgresoMarchaVehiculo = Enum.GetName(typeof(ProgresoInicial), f.ProgresoMarchaVehiculo),
      ProgresoEncendidoEnNeutro = Enum.GetName(typeof(ProgresoInicial), f.ProgresoEncendidoEnNeutro),
      SeguridadCinturon = Enum.GetName(typeof(ProgresoAlumno), f.SeguridadCinturon),
      SeguridadRegulaButacaApoyaCabezas = Enum.GetName(typeof(ProgresoAlumno), f.SeguridadRegulaButacaApoyaCabezas),
      SeguridadRegulaEspejos = Enum.GetName(typeof(ProgresoAlumno), f.SeguridadRegulaEspejos),
      DominaUsoPedales = Enum.GetName(typeof(ProgresoAlumno), f.DominaUsoPedales),
      DominaAdministracionCambios = Enum.GetName(typeof(ProgresoAlumno), f.DominaAdministracionCambios),
      DominaUsoEspejos = Enum.GetName(typeof(ProgresoAlumno), f.DominaUsoEspejos),
      TieneBuenaTecnicaBrazos = Enum.GetName(typeof(ProgresoAlumno), f.TieneBuenaTecnicaBrazos),
      DominaVehiculoEnRepecho = Enum.GetName(typeof(ProgresoAlumno), f.DominaVehiculoEnRepecho),
      SenializaCorrectamenteCambioCarril = Enum.GetName(typeof(ProgresoAlumno), f.SenializaCorrectamenteCambioCarril),
      ReconoceSentidosCirculacion = Enum.GetName(typeof(ProgresoAlumno), f.ReconoceSentidosCirculacion),
      CirculaManteniendoDerecha = Enum.GetName(typeof(ProgresoAlumno), f.CirculaManteniendoDerecha),
      MantieneDistanciaSeguridad = Enum.GetName(typeof(ProgresoAlumno), f.MantieneDistanciaSeguridad),
      RespetaTodasSenialesTransito = Enum.GetName(typeof(ProgresoAlumno), f.RespetaTodasSenialesTransito),
      SenializaManiobrasARealizar = Enum.GetName(typeof(ProgresoAlumno), f.SenializaManiobrasARealizar),
      RespetaSendasPeatonales = Enum.GetName(typeof(ProgresoAlumno), f.RespetaSendasPeatonales),
      RespetaOtrosUsuariosDeLaVia = Enum.GetName(typeof(ProgresoAlumno), f.RespetaOtrosUsuariosDeLaVia),
      MantieneVelocidadAdecuada = Enum.GetName(typeof(ProgresoAlumno), f.MantieneVelocidadAdecuada),
      FrenaConSuficienteAnticipacion = Enum.GetName(typeof(ProgresoAlumno), f.FrenaConSuficienteAnticipacion),
      GiroUbicacionCorrectamente = Enum.GetName(typeof(ProgresoAlumno), f.GiroUbicacionCorrectamente),
      GiroSenializaCorrectamente = Enum.GetName(typeof(ProgresoAlumno), f.GiroSenializaCorrectamente),
      GiroIngresaCorrectamenteNuevaVia = Enum.GetName(typeof(ProgresoAlumno), f.GiroIngresaCorrectamenteNuevaVia),
      GiroVelocidadCorrecta = Enum.GetName(typeof(ProgresoAlumno), f.GiroVelocidadCorrecta),
      SaleConduciendoACU = Enum.GetName(typeof(ProgresoAlumno), f.SaleConduciendoACU),
      VuelveConduciendoACU = Enum.GetName(typeof(ProgresoAlumno), f.VuelveConduciendoACU),
      EvaluaEnfrentaAdecuadamenteDificultades = Enum.GetName(typeof(ProgresoAlumno), f.EvaluaEnfrentaAdecuadamenteDificultades),
      ToleranciaStressTransito = Enum.GetName(typeof(ProgresoAlumno), f.ToleranciaStressTransito),
      AceptaIndicacionesInstructor = Enum.GetName(typeof(ProgresoAlumno), f.AceptaIndicacionesInstructor),
      MarchaAtras = Enum.GetName(typeof(ProgresoManiobras), f.MarchaAtras),
      Slalom = Enum.GetName(typeof(ProgresoManiobras), f.Slalom),
      EstacionamientoLateralDerecho = Enum.GetName(typeof(ProgresoManiobras), f.EstacionamientoLateralDerecho),
      EstacionamientoLateralIzquierdo = Enum.GetName(typeof(ProgresoManiobras), f.EstacionamientoLateralIzquierdo),
      Estacionamient45GradosDerecho = Enum.GetName(typeof(ProgresoManiobras), f.Estacionamient45GradosDerecho),
      Estacionamient45GradosIzquierdo = Enum.GetName(typeof(ProgresoManiobras), f.Estacionamient45GradosIzquierdo),
    };

    public static FormularioResultadoExamenPracticoDTO toFormularioResultadoExamenPracticoDTO(FormularioResultadoExamenPractico f) => new FormularioResultadoExamenPracticoDTO
    {
      Id = f.Id,
      Instructor = f.EscInsId,
      Alumno = f.AlumnoNombreApellido,
      Resultado = Enum.GetName(typeof(ResultadoExamen), f.Resultado),
      Fecha = f.FechaCreacion,
      FechaCreacion = f.FechaCreacion.ToShortDateString(),
      EsAlumnoOtroInstructor = f.EsAlumnoOtroInstructor ? "Si" : "No",
      InstructorDelAlumno = f.InstructorAlumnoId,
      MotivoReprobacionPista = Enum.GetName(typeof(MotivoReprobacionPista), f.MotivoReprobacionPista),
      MotivoReprobacionCalle = Enum.GetName(typeof(MotivoReprobacionCalle), f.MotivoReprobacionCalle),
      DetalleMotivoPerdida = f.DetalleMotivoPerdida,
    };
  }
}