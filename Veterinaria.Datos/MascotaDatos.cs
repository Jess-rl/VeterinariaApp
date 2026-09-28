using Npgsql;
using Veterinaria.Entidades;

namespace Veterinaria.Datos;

public class MascotaDatos
{
    public List<Mascota> ObtenerTodos()
    {
        var lista = new List<Mascota>();
        const string query = "SELECT id_mascota, cedula_dueno, nombre, especie, raza, sexo, fecha_nacimiento FROM mascota ORDER BY id_mascota;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);
        using var lector = comando.ExecuteReader();

        while (lector.Read())
        {
            char sexoChar = lector.IsDBNull(5) ? 'M' : lector.GetString(5)[0];
            string sexoStr = (sexoChar == 'H' || sexoChar == 'h') ? "Hembra" : "Macho";

            var m = new Mascota
            {
                IdMascota = lector.GetInt32(0),
                CedulaCliente = lector.GetString(1),
                Nombre = lector.GetString(2),
                Especie = lector.GetString(3),
                Raza = lector.IsDBNull(4) ? string.Empty : lector.GetString(4),
                Sexo = sexoStr,
                FechaNacimiento = lector.IsDBNull(6) ? DateTime.MinValue : lector.GetDateTime(6)
            };

            lista.Add(m);
        }

        return lista;
    }

    public List<Mascota> ObtenerPorCedulaDueno(string cedula)
    {
        var lista = new List<Mascota>();
        const string query = "SELECT id_mascota, cedula_dueno, nombre, especie, raza, sexo, fecha_nacimiento FROM mascota WHERE LOWER(TRIM(cedula_dueno)) = LOWER(TRIM(@cedula)) ORDER BY id_mascota;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);
        comando.Parameters.AddWithValue("@cedula", cedula.Trim());
        using var lector = comando.ExecuteReader();

        while (lector.Read())
        {
            char sexoChar = lector.IsDBNull(5) ? 'M' : lector.GetString(5)[0];
            string sexoStr = (sexoChar == 'H' || sexoChar == 'h') ? "Hembra" : "Macho";

            var m = new Mascota
            {
                IdMascota = lector.GetInt32(0),
                CedulaCliente = lector.GetString(1),
                Nombre = lector.GetString(2),
                Especie = lector.GetString(3),
                Raza = lector.IsDBNull(4) ? string.Empty : lector.GetString(4),
                Sexo = sexoStr,
                FechaNacimiento = lector.IsDBNull(6) ? DateTime.MinValue : lector.GetDateTime(6)
            };

            lista.Add(m);
        }

        return lista;
    }

    public bool Insertar(Mascota m)
    {
        const string query = "INSERT INTO mascota (cedula_dueno, nombre, especie, raza, sexo, fecha_nacimiento) VALUES (@cedula, @nombre, @especie, @raza, @sexo, @fechaNac);";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);

        string sexoChar = m.Sexo.StartsWith("H", StringComparison.OrdinalIgnoreCase) ? "H" : "M";

        comando.Parameters.AddWithValue("@cedula", m.CedulaCliente);
        comando.Parameters.AddWithValue("@nombre", m.Nombre);
        comando.Parameters.AddWithValue("@especie", m.Especie);
        comando.Parameters.AddWithValue("@raza", (object?)m.Raza ?? DBNull.Value);
        comando.Parameters.AddWithValue("@sexo", sexoChar);
        comando.Parameters.AddWithValue("@fechaNac", m.FechaNacimiento != DateTime.MinValue ? (object)m.FechaNacimiento : DBNull.Value);

        return comando.ExecuteNonQuery() > 0;
    }

    public bool Modificar(Mascota m)
    {
        const string query = "UPDATE mascota SET cedula_dueno = @cedula, nombre = @nombre, especie = @especie, raza = @raza, sexo = @sexo, fecha_nacimiento = @fechaNac WHERE id_mascota = @id;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);

        string sexoChar = m.Sexo.StartsWith("H", StringComparison.OrdinalIgnoreCase) ? "H" : "M";

        comando.Parameters.AddWithValue("@id", m.IdMascota);
        comando.Parameters.AddWithValue("@cedula", m.CedulaCliente);
        comando.Parameters.AddWithValue("@nombre", m.Nombre);
        comando.Parameters.AddWithValue("@especie", m.Especie);
        comando.Parameters.AddWithValue("@raza", (object?)m.Raza ?? DBNull.Value);
        comando.Parameters.AddWithValue("@sexo", sexoChar);
        comando.Parameters.AddWithValue("@fechaNac", m.FechaNacimiento != DateTime.MinValue ? (object)m.FechaNacimiento : DBNull.Value);

        return comando.ExecuteNonQuery() > 0;
    }

    public bool Eliminar(int idMascota)
    {
        const string query = "DELETE FROM mascota WHERE id_mascota = @id;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);
        comando.Parameters.AddWithValue("@id", idMascota);

        return comando.ExecuteNonQuery() > 0;
    }
}
