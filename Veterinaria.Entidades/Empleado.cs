namespace Veterinaria.Entidades;

public class Empleado
{
    public int IdEmpleado { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Rol { get; set; } = string.Empty;
    public string ClavePin { get; set; } = string.Empty;

    public Empleado()
    {
    }

    public Empleado(int idEmpleado, string nombre, string rol, string clavePin)
    {
        IdEmpleado = idEmpleado;
        Nombre = nombre;
        Rol = rol;
        ClavePin = clavePin;
    }
}