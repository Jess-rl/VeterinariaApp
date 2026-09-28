namespace Veterinaria.Entidades;

public class Cita
{
    public int IdCita { get; set; }
    public DateTime Fecha { get; set; }
    public string Motivo { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public int IdMascota { get; set; }
    public int IdEmpleado { get; set; }

    public Cita()
    {
    }

    public Cita(int idCita, DateTime fecha, int idMascota, int idEmpleado)
    {
        IdCita = idCita;
        Fecha = fecha;
        IdMascota = idMascota;
        IdEmpleado = idEmpleado;
    }

    public Cita(int idCita, DateTime fecha, string motivo, string estado, int idMascota, int idEmpleado = 1)
    {
        IdCita = idCita;
        Fecha = fecha;
        Motivo = motivo;
        Estado = estado;
        IdMascota = idMascota;
        IdEmpleado = idEmpleado;
    }
}
