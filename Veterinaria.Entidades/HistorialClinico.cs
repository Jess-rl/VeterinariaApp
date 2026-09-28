namespace Veterinaria.Entidades;

public class HistorialClinico
{
    public int IdHistorial { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public decimal Peso { get; set; }
    public string Diagnostico { get; set; } = string.Empty;
    public string Tratamiento { get; set; } = string.Empty;
    public int IdMascota { get; set; }
    public int IdEmpleado { get; set; }

    public HistorialClinico()
    {
    }

    public HistorialClinico(int idHistorial, DateTime fecha, decimal peso, int idMascota, int idEmpleado)
    {
        IdHistorial = idHistorial;
        Fecha = fecha;
        Peso = peso;
        IdMascota = idMascota;
        IdEmpleado = idEmpleado;
    }

    public HistorialClinico(int idHistorial, DateTime fecha, decimal peso, string diagnostico, string tratamiento, int idMascota, int idEmpleado = 1)
    {
        IdHistorial = idHistorial;
        Fecha = fecha;
        Peso = peso;
        Diagnostico = diagnostico;
        Tratamiento = tratamiento;
        IdMascota = idMascota;
        IdEmpleado = idEmpleado;
    }
}