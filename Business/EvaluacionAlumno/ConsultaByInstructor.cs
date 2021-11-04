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
  public class ConsultaByInstructor
  {
    public class Execute : IRequest<List<FormularioEvaluacionAlumnoDTO>>
    {
      public string InstructorId { get; set; }
    }

    public class Handler : IRequestHandler<Execute, List<FormularioEvaluacionAlumnoDTO>>
    {
      private readonly FormularioContext context;

      public Handler(FormularioContext context)
      {
        this.context = context;
      }

      public async Task<List<FormularioEvaluacionAlumnoDTO>> Handle(Execute request, CancellationToken cancellationToken)
        => await this.context.FormularioEvaluacionAlumno
          .Where(f => f.EscInsId == request.InstructorId)
          .Select(f => new FormularioEvaluacionAlumnoDTO
          {
            Id = f.Id,
            Alumno = f.AlumnoNombreApellido,
            Clase = f.NumeroClase,
            Fecha = f.FechaCreacion,
            Instructor = f.EscInsId,
            Observaciones = f.Observaciones
          })
          .ToListAsync();
    }


  }
}