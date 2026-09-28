namespace Veterinaria.Entidades;

public class Consulta
{
    public int IdConsulta { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public decimal Peso { get; set; }
    public decimal Temperatura { get; set; }
    public string Diagnostico { get; set; } = string.Empty;
    public string Tratamiento { get; set; } = string.Empty;
    public string Observaciones { get; set; } = string.Empty;
    public int IdMascota { get; set; }
    public int IdEmpleado { get; set; }

    public Consulta()
    {
    }

    public Consulta(int idConsulta, DateTime fecha, decimal peso, string diagnostico, string tratamiento, string observaciones, int idMascota, int idEmpleado = 1, decimal temperatura = 0m)
    {
        IdConsulta = idConsulta;
        Fecha = fecha;
        Peso = peso;
        Temperatura = temperatura;
        Diagnostico = diagnostico;
        Tratamiento = tratamiento;
        Observaciones = observaciones;
        IdMascota = idMascota;
        IdEmpleado = idEmpleado;
    }
}
