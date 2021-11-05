using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;

namespace Business.ResultadoExamenPractico
{
    public class Consulta
    {
        public class Execute : IRequest<List<FormularioResultadoExamenPracticoDTO>>{}

    public class Handler : IRequestHandler<Execute, List<FormularioResultadoExamenPracticoDTO>>
    {
      private readonly FormularioContext context;

      public Handler(FormularioContext context)
      {
        this.context = context;
      }

      public async Task<List<FormularioResultadoExamenPracticoDTO>> Handle(Execute request, CancellationToken cancellationToken)
        => await this.context.FormularioResultadoExamenPractico
          .Select( f => new FormularioResultadoExamenPracticoDTO {
            Id = f.Id,
            Alumno = f.AlumnoNombreApellido,
            Fecha = f.FechaCreacion,
            Instructor = f.EscInsId,
            Resultado = Enum.GetName( typeof(ResultadoExamen), f.Resultado)
          })
          .ToListAsync();
    }
  }
}