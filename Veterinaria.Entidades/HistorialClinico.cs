namespace Veterinaria.Entidades;

public class HistorialClinico
{
    public int IdHistorial { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Peso { get; set; }
    public String Diagnostico { get; set; } = String.Empty;
    public String Tratamiento { get; set; } = String.Empty;
    public int IdMascota { get; set; }
    public int IdEmpleado { get; set; }
    
}