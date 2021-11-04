
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;
using System;
using System.Linq;
using Business.DTOs;

namespace Business.DesperfectoMovil
{
  public class Consulta
  {
    public class Ejecuta : IRequest<List<FormularioDesperfectoMovilDTO>> { }

    public class Manejador : IRequestHandler<Ejecuta, List<FormularioDesperfectoMovilDTO>>
    {
      private readonly FormularioContext context;

      public Manejador(FormularioContext context)
      {
        this.context = context;
      }
      public async Task<List<FormularioDesperfectoMovilDTO>> Handle(Ejecuta request, CancellationToken cancellationToken) 
        =>  await this.context.FormularioDesperfectoMovil
        .Select(f => new FormularioDesperfectoMovilDTO {
          Id = f.Id,
          Desperfecto = f.Desperfecto,
          Fecha = f.FechaCreacion,
          Instructor = f.EscInsId,
          Kilometraje = f.MovilKilometraje,
          Movil = f.MovCod
        })
        .ToListAsync();
      
    }

  }
}