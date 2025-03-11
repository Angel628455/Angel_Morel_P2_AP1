using System;
using System.ComponentModel.DataAnnotations;

namespace Angel_Morel_P2_AP1.Model
{
    public class CiudadDetalle
    {
        [Key]
        public int DetalleId { get; set; }

        public decimal Monto { get; set; }

        public int NombreId { get; set; }

        public int AsignaturaId { get; set; }

        public DateTime Fecha { get; set; }
    }
}
