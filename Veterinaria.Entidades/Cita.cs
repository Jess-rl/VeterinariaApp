using System.Runtime.InteropServices.JavaScript;

namespace Veterinaria.Entidades;

public class Cita
{
    public int IdCita { get; set; }
    public DateTime Fecha { get; set; }
    public String Motivo { get; set; } = String.Empty;
    public String Estado { get; set; } = String.Empty;
    public int IdMascota { get; set; }
    public int IdEmpleado { get; set; }
    
}
