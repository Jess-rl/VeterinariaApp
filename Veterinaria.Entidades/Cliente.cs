namespace Veterinaria.Entidades;

public class Cliente
{
    public string Cedula { get; set; } = string.Empty;
    public string Nombres { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;

    public Cliente()
    {
    }

    public Cliente(string cedula, string nombres, string apellidos, string telefono, string direccion)
    {
        Cedula = cedula;
        Nombres = nombres;
        Apellidos = apellidos;
        Telefono = telefono;
        Direccion = direccion;
    }
}