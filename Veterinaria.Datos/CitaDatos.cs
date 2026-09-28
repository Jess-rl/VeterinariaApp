using Npgsql;
using Veterinaria.Entidades;

namespace Veterinaria.Datos;

public class CitaDatos
{
    public List<Cita> ObtenerTodos()
    {
        var lista = new List<Cita>();
        const string query = "SELECT id_cita, id_mascota, id_empleado, fecha_hora, motivo, estado FROM cita ORDER BY fecha_hora DESC;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);
        using var lector = comando.ExecuteReader();

        while (lector.Read())
        {
            var c = new Cita
            {
                IdCita = lector.GetInt32(0),
                IdMascota = lector.GetInt32(1),
                IdEmpleado = lector.GetInt32(2),
                Fecha = lector.GetDateTime(3),
                Motivo = lector.GetString(4),
                Estado = lector.IsDBNull(5) ? "PENDIENTE" : lector.GetString(5).ToUpperInvariant()
            };

            lista.Add(c);
        }

        return lista;
    }

    public List<Cita> ObtenerPendientes()
    {
        var lista = new List<Cita>();
        const string query = "SELECT id_cita, id_mascota, id_empleado, fecha_hora, motivo, estado FROM cita WHERE UPPER(TRIM(estado)) = 'PENDIENTE' ORDER BY fecha_hora ASC;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);
        using var lector = comando.ExecuteReader();

        while (lector.Read())
        {
            var c = new Cita
            {
                IdCita = lector.GetInt32(0),
                IdMascota = lector.GetInt32(1),
                IdEmpleado = lector.GetInt32(2),
                Fecha = lector.GetDateTime(3),
                Motivo = lector.GetString(4),
                Estado = "PENDIENTE"
            };

            lista.Add(c);
        }

        return lista;
    }

    public bool Insertar(Cita c)
    {
        const string query = "INSERT INTO cita (id_mascota, id_empleado, fecha_hora, motivo, estado) VALUES (@idMascota, @idEmpleado, @fechaHora, @motivo, @estado);";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);

        string estadoDb = string.IsNullOrWhiteSpace(c.Estado) ? "PENDIENTE" : c.Estado.Trim().ToUpperInvariant();

        comando.Parameters.AddWithValue("@idMascota", c.IdMascota);
        comando.Parameters.AddWithValue("@idEmpleado", c.IdEmpleado > 0 ? c.IdEmpleado : 1);
        comando.Parameters.AddWithValue("@fechaHora", c.Fecha);
        comando.Parameters.AddWithValue("@motivo", c.Motivo);
        comando.Parameters.AddWithValue("@estado", estadoDb);

        return comando.ExecuteNonQuery() > 0;
    }

    public bool CambiarEstado(int idCita, string nuevoEstado)
    {
        const string query = "UPDATE cita SET estado = @estado WHERE id_cita = @id;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);

        comando.Parameters.AddWithValue("@id", idCita);
        comando.Parameters.AddWithValue("@estado", nuevoEstado.Trim().ToUpperInvariant());

        return comando.ExecuteNonQuery() > 0;
    }
}
