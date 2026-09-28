using Veterinaria.Datos;
using Veterinaria.Entidades;

namespace Veterinaria.Negocio;

public class CitaNegocio
{
    private readonly CitaDatos _citaDatos = new();

    public List<Cita> ObtenerCitas()
    {
        return _citaDatos.ObtenerTodos();
    }

    public List<Cita> ObtenerCitasPendientes()
    {
        return _citaDatos.ObtenerPendientes();
    }

    public bool AgendarCita(Cita cita, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (cita.IdMascota <= 0)
        {
            mensajeErr = "Debe seleccionar un paciente / mascota para agendar la cita.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(cita.Motivo))
        {
            mensajeErr = "El motivo de la consulta es obligatorio.";
            return false;
        }

        if (cita.Fecha < DateTime.Now.AddMinutes(-10))
        {
            mensajeErr = "La fecha y hora de la cita no puede ser anterior al momento actual.";
            return false;
        }

        bool ok = _citaDatos.Insertar(cita);
        if (!ok)
        {
            mensajeErr = "No se pudo registrar la cita médica en la base de datos.";
            return false;
        }

        return true;
    }

    public bool AtenderCita(int idCita, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (idCita <= 0)
        {
            mensajeErr = "ID de cita inválido.";
            return false;
        }

        bool ok = _citaDatos.CambiarEstado(idCita, "ATENDIDA");
        if (!ok)
        {
            mensajeErr = "No se pudo actualizar el estado de la cita a 'ATENDIDA'.";
            return false;
        }

        return true;
    }

    public bool CancelarCita(int idCita, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (idCita <= 0)
        {
            mensajeErr = "Seleccione una cita válida para cancelar.";
            return false;
        }

        bool ok = _citaDatos.CambiarEstado(idCita, "CANCELADA");
        if (!ok)
        {
            mensajeErr = "No se pudo cancelar la cita médica.";
            return false;
        }

        return true;
    }
}
