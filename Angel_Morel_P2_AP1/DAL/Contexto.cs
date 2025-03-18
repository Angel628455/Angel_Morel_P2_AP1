global using Microsoft.EntityFrameworkCore;
using Angel_Morel_P2_AP1.Model;
using Angel_Morel_P2_AP1.Models;


namespace Angel_Morel_P2_AP1.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public virtual DbSet<Encuestas> Encuestas { get; set; }
    public virtual DbSet<Ciudades> Ciudades { get; set; }

    public virtual DbSet<EncuestaDestalles> Destalles { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ciudades>().HasData(
            new List<Ciudades>()
            {
            new()
            {
                CiudadId = 1,
                Nombre = "Nagua",                                                                    
                Monto = 0,

            },
            new()
            {
                CiudadId = 2,
                Nombre = "Samana",
                Monto = 0,
            },
            new()
            {
                CiudadId = 3,
                Nombre = "Rio San Juan",
                Monto = 0,
            }

            }
        );
        base.OnModelCreating(modelBuilder);
    }
}
