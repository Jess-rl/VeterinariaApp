using Veterinaria.Datos;
using Veterinaria.Entidades;

namespace Veterinaria.Negocio;

public class EmpleadoNegocio
{
    private readonly EmpleadoDatos _empleadoDatos = new();

    /// <summary>
    /// Valida el PIN de acceso contra la base de datos.
    /// Los errores de conexión se propagan para que la capa de presentación
    /// los informe; no existe ninguna clave de respaldo en el código.
    /// </summary>
    public bool ValidarPin(string pin, out Empleado? empleado, out string mensajeErr)
    {
        empleado = null;
        mensajeErr = string.Empty;

        if (string.IsNullOrWhiteSpace(pin))
        {
            mensajeErr = "Debe ingresar un PIN de acceso.";
            return false;
        }

        empleado = _empleadoDatos.ValidarPin(pin);

        if (empleado is null)
        {
            mensajeErr = "PIN de acceso incorrecto.";
            return false;
        }

        return true;
    }
}
