namespace Veterinaria.Entidades;

public class Mascota
{
    public int IdMascota { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Especie { get; set; } = string.Empty;
    public string Raza { get; set; } = string.Empty;
    public string Sexo { get; set; } = "Macho";
    public DateTime FechaNacimiento { get; set; }
    public string CedulaCliente { get; set; } = string.Empty;

    public Mascota()
    {
    }

    public Mascota(int idMascota, string nombre, string especie, string raza, DateTime fechaNacimiento, string cedulaCliente, string sexo = "Macho")
    {
        IdMascota = idMascota;
        Nombre = nombre;
        Especie = especie;
        Raza = raza;
        FechaNacimiento = fechaNacimiento;
        CedulaCliente = cedulaCliente;
        Sexo = sexo;
    }
}
