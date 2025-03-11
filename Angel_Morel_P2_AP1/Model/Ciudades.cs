using Microsoft.EntityFrameworkCore;

namespace Angel_Morel_P2_AP1.Model
{
    public class Ciudades : DbContext
    {
        public Ciudades()
        {
        }

        public Ciudades(DbContextOptions<Ciudades> options) : base(options)
        {
        }

        public DbSet<CiudadDetalle> CiudadDetalles { get; set; }
        public int CiudadId { get; internal set; }
        public string Nombre { get; internal set; }
        public int Monto { get; internal set; }
    }
}
