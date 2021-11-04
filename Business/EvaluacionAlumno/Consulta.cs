using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;

namespace Business.EvaluacionAlumno
{
  public class Consulta
  {
    public class Execute : IRequest<List<FormularioEvaluacionAlumnoDTO>> { }

    public class Handler : IRequestHandler<Execute, List<FormularioEvaluacionAlumnoDTO>>
    {
      private readonly FormularioContext context;

      public Handler(FormularioContext context)
      {
        this.context = context;
      }

      public async Task<List<FormularioEvaluacionAlumnoDTO>> Handle(Execute request, CancellationToken cancellationToken)
        => await this.context.FormularioEvaluacionAlumno.Select(f => new FormularioEvaluacionAlumnoDTO
        {
          Id = f.Id,
          Instructor = f.EscInsId,
          Alumno = f.AlumnoNombreApellido,
          Clase = f.NumeroClase,
          Fecha = f.FechaCreacion,
          Observaciones = f.Observaciones
        }).ToListAsync();

    }
  }
}