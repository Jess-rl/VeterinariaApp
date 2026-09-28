using Veterinaria.Datos;
using Veterinaria.Entidades;

namespace Veterinaria.Negocio;

public class HistorialClinicoNegocio
{
    private readonly HistorialClinicoDatos _historialDatos = new();

    public List<HistorialClinico> ObtenerHistorialPorMascota(int idMascota)
    {
        if (idMascota <= 0) return [];
        return _historialDatos.ObtenerPorMascota(idMascota);
    }

    public bool RegistrarAtencion(HistorialClinico historial, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (historial.IdMascota <= 0)
        {
            mensajeErr = "Debe seleccionar un paciente de la lista para registrar la atención.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(historial.Diagnostico))
        {
            mensajeErr = "El diagnóstico médico es un campo obligatorio.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(historial.Tratamiento))
        {
            mensajeErr = "El tratamiento y receta médica es un campo obligatorio.";
            return false;
        }

        bool ok = _historialDatos.Insertar(historial);
        if (!ok)
        {
            mensajeErr = "No se pudo registrar la consulta médica en el historial clínico.";
            return false;
        }

        return true;
    }
}
