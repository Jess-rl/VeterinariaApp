using Npgsql;
using Veterinaria.Entidades;

namespace Veterinaria.Datos;

public class ClienteDatos
{
    public List<Cliente> ObtenerTodos()
    {
        var lista = new List<Cliente>();
        const string query = "SELECT cedula, nombres, apellidos, telefono, direccion FROM cliente;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);
        using var lector = comando.ExecuteReader();

        while (lector.Read())
        {
            var cliente = new Cliente
            {
                Cedula = lector.GetString(0),
                Nombres = lector.GetString(1),
                Apellidos = lector.GetString(2),
                Telefono = lector.IsDBNull(3) ? string.Empty : lector.GetString(3),
                Direccion = lector.IsDBNull(4) ? string.Empty : lector.GetString(4)
            };

            lista.Add(cliente);
        }

        return lista;
    }

    public bool Insertar(Cliente cliente)
    {
        const string query = "INSERT INTO cliente(cedula, nombres, apellidos, telefono, direccion) VALUES (@cedula, @nombres, @apellidos, @telefono, @direccion);";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);

        comando.Parameters.AddWithValue("@cedula", cliente.Cedula);
        comando.Parameters.AddWithValue("@nombres", cliente.Nombres);
        comando.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
        comando.Parameters.AddWithValue("@telefono", (object?)cliente.Telefono ?? DBNull.Value);
        comando.Parameters.AddWithValue("@direccion", (object?)cliente.Direccion ?? DBNull.Value);

        int filasAfectadas = comando.ExecuteNonQuery();
        return filasAfectadas > 0;
    }

    public bool Modificar(Cliente cliente)
    {
        const string query = "UPDATE cliente SET nombres = @nombres, apellidos = @apellidos, telefono = @telefono, direccion = @direccion WHERE cedula = @cedula;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);

        comando.Parameters.AddWithValue("@cedula", cliente.Cedula);
        comando.Parameters.AddWithValue("@nombres", cliente.Nombres);
        comando.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
        comando.Parameters.AddWithValue("@telefono", (object?)cliente.Telefono ?? DBNull.Value);
        comando.Parameters.AddWithValue("@direccion", (object?)cliente.Direccion ?? DBNull.Value);

        int filasAfectadas = comando.ExecuteNonQuery();
        return filasAfectadas > 0;
    }

    public bool Eliminar(string cedula)
    {
        const string query = "DELETE FROM cliente WHERE cedula = @cedula;";

        using var conexion = ConexionBD.ObtenerConexion();
        using var comando = new NpgsqlCommand(query, conexion);

        comando.Parameters.AddWithValue("@cedula", cedula);

        int filasAfectadas = comando.ExecuteNonQuery();
        return filasAfectadas > 0;
    }
}