namespace Veterinaria.Entidades;

public class Mascota
{
    public int IdMascota { get; set; }
    public String Nombre { get; set; } = String.Empty;
    public String Especie { get; set; } = String.Empty;
    public String Raza { get; set; } = String.Empty;
    public DateTime FechaNacimiento { get; set; }
    public String CedulaCliente { get; set; } = String.Empty;
    
}
