using Microsoft.EntityFrameworkCore;
using Models;

namespace Persistance
{
  public class FormularioContext : DbContext
  {

    public FormularioContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    public DbSet<FormularioDesperfectoMovil> FormularioDesperfectoMovil {get; set;}
    public DbSet<FormularioDiarioMovil> FormularioDiarioMovil {get; set;}
    public DbSet<FormularioEvaluacionAlumno> FormularioEvaluacionAlumno {get; set;}
    public DbSet<FormularioResultadoExamenPractico> FormularioResultadoExamenPractico {get; set;}

  }
}