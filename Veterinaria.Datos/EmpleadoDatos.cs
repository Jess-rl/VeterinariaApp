using Npgsql;
using Veterinaria.Entidades;

namespace Veterinaria.Datos;

public class EmpleadoDatos
{
    public Empleado? ValidarPin(string pin)
    {
        const string query = "SELECT id_empleado, nombre, rol, clave_pin FROM empleado WHERE clave_pin = @pin LIMIT 1;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);
        comando.Parameters.AddWithValue("@pin", pin.Trim());

        using var lector = comando.ExecuteReader();
        if (lector.Read())
        {
            return new Empleado
            {
                IdEmpleado = lector.GetInt32(0),
                Nombre = lector.GetString(1),
                Rol = lector.GetString(2),
                ClavePin = lector.GetString(3)
            };
        }

        return null;
    }
}
