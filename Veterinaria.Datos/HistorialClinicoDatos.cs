using Npgsql;
using Veterinaria.Entidades;

namespace Veterinaria.Datos;

public class HistorialClinicoDatos
{
    public List<HistorialClinico> ObtenerPorMascota(int idMascota)
    {
        var lista = new List<HistorialClinico>();
        const string query = "SELECT id_historial, id_mascota, id_empleado, fecha, peso_actual, diagnostico, tratamiento FROM historial_clinico WHERE id_mascota = @idMascota ORDER BY fecha DESC;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);
        comando.Parameters.AddWithValue("@idMascota", idMascota);
        using var lector = comando.ExecuteReader();

        while (lector.Read())
        {
            var h = new HistorialClinico
            {
                IdHistorial = lector.GetInt32(0),
                IdMascota = lector.GetInt32(1),
                IdEmpleado = lector.GetInt32(2),
                Fecha = lector.IsDBNull(3) ? DateTime.Now : lector.GetDateTime(3),
                Peso = lector.IsDBNull(4) ? 0m : lector.GetDecimal(4),
                Diagnostico = lector.GetString(5),
                Tratamiento = lector.GetString(6)
            };

            lista.Add(h);
        }

        return lista;
    }

    public bool Insertar(HistorialClinico h)
    {
        const string query = "INSERT INTO historial_clinico (id_mascota, id_empleado, fecha, peso_actual, diagnostico, tratamiento) VALUES (@idMascota, @idEmpleado, @fecha, @peso, @diagnostico, @tratamiento);";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);

        comando.Parameters.AddWithValue("@idMascota", h.IdMascota);
        comando.Parameters.AddWithValue("@idEmpleado", h.IdEmpleado > 0 ? h.IdEmpleado : 1);
        comando.Parameters.AddWithValue("@fecha", h.Fecha);
        comando.Parameters.AddWithValue("@peso", h.Peso > 0 ? (object)h.Peso : DBNull.Value);
        comando.Parameters.AddWithValue("@diagnostico", h.Diagnostico);
        comando.Parameters.AddWithValue("@tratamiento", h.Tratamiento);

        return comando.ExecuteNonQuery() > 0;
    }
}
