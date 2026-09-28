using Veterinaria.Datos;
using Veterinaria.Entidades;

namespace Veterinaria.Negocio;

public class MascotaNegocio
{
    private readonly MascotaDatos _mascotaDatos = new();

    public List<Mascota> ObtenerMascotas()
    {
        return _mascotaDatos.ObtenerTodos();
    }

    public List<Mascota> ObtenerMascotasPorDueno(string cedula)
    {
        if (string.IsNullOrWhiteSpace(cedula)) return [];
        return _mascotaDatos.ObtenerPorCedulaDueno(cedula);
    }

    public bool GuardarMascota(Mascota mascota, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (string.IsNullOrWhiteSpace(mascota.Nombre))
        {
            mensajeErr = "El nombre de la mascota es obligatorio.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(mascota.Especie))
        {
            mensajeErr = "La especie es un campo obligatorio.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(mascota.CedulaCliente))
        {
            mensajeErr = "Debe asignar un cliente / dueño a la mascota.";
            return false;
        }

        bool ok = _mascotaDatos.Insertar(mascota);
        if (!ok)
        {
            mensajeErr = "No se pudo registrar la mascota en la base de datos.";
            return false;
        }

        return true;
    }

    public bool ModificarMascota(Mascota mascota, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (mascota.IdMascota <= 0)
        {
            mensajeErr = "Debe seleccionar una mascota válida para modificar.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(mascota.Nombre) || string.IsNullOrWhiteSpace(mascota.Especie))
        {
            mensajeErr = "El nombre y la especie no pueden quedar vacíos.";
            return false;
        }

        bool ok = _mascotaDatos.Modificar(mascota);
        if (!ok)
        {
            mensajeErr = "No se pudo actualizar los datos de la mascota.";
            return false;
        }

        return true;
    }

    public bool EliminarMascota(int idMascota, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (idMascota <= 0)
        {
            mensajeErr = "ID de mascota no válido.";
            return false;
        }

        bool ok = _mascotaDatos.Eliminar(idMascota);
        if (!ok)
        {
            mensajeErr = "No se pudo eliminar la mascota. Verifique si tiene citas o historial registrado.";
            return false;
        }

        return true;
    }
}
