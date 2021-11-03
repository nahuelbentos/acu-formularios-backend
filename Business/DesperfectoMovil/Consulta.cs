
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistance;
using System;

namespace Business.DesperfectoMovil
{
  public class Consulta
  {
    public class Ejecuta : IRequest<List<FormularioDesperfectoMovil>> { }

    public class Manejador : IRequestHandler<Ejecuta, List<FormularioDesperfectoMovil>>
    {
      private readonly FormularioContext context;

      public Manejador(FormularioContext context)
      {
        this.context = context;
      }
      public async Task<List<FormularioDesperfectoMovil>> Handle(Ejecuta request, CancellationToken cancellationToken) 
        =>  await this.context.FormularioDesperfectoMovil.ToListAsync();
      
    }

  }
}