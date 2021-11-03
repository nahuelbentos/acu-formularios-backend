using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;

namespace Business.EvaluacionAlumno
{
    public class ConsultaByInstructor
    {
        public class Execute : IRequest<List<FormularioEvaluacionAlumno>>
        {
            public string InstructorId { get; set; }
        }

    public class Handler : IRequestHandler<Execute, List<FormularioEvaluacionAlumno>>
    {
      private readonly FormularioContext context;

      public Handler(FormularioContext context)
      {
        this.context = context;
      }

      public async Task<List<FormularioEvaluacionAlumno>> Handle(Execute request, CancellationToken cancellationToken)
        => await this.context.FormularioEvaluacionAlumno.Where(f => f.EscInsId == request.InstructorId).ToListAsync();
    }


  }
}