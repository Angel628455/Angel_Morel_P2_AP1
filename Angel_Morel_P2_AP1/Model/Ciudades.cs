using System.ComponentModel.DataAnnotations;

namespace Angel_Morel_P2_AP1.Model;

public class Ciudades
{
    [Key]
    public int CiudadId { get; set; }  
    public string Nombre { get; set; } = string.Empty;
    public int Monto { get; set; }
}
