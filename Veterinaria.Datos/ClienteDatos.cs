using Npgsql;
using Veterinaria.Entidades;

namespace Veterinaria.Datos;

public class ClienteDatos
{
    public List<Cliente> ObtenerTodos()
    {
        List<Cliente> lista = new List<Cliente>();

        string query = "SELECT cedula, nombre, apellido, telefono, direccion FROM cliente;";

        using (var conexion = ConexionBD.ObtenerConexion())
        using (var comando = new NpgsqlCommand(query, conexion))
        {
            using (var lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    Cliente c = new Cliente();

                    c.Cedula = lector.GetString(0);
                    c.Nombres = lector.GetString(1);
                    c.Apellidos = lector.GetString(2);
                    c.Telefono = lector.IsDBNull(3) ? string.Empty : lector.GetString(3);
                    c.Direccion = lector.IsDBNull(4) ? string.Empty : lector.GetString(4);
                    
                    lista.Add(c);
                }
            }
        }

        return lista;
    }

    public bool Insertar(Cliente c)
    {
        string query = "INSERT INTO cliente(cedula, nombres, apellidos, telefono, direccion) VALUES (@cedula, @nombres, @apellidos, @telefono, @direccion);)";
            
        using (var conexion = ConexionBD.ObtenerConexion())
        using (var comando = new NpgsqlCommand(query, conexion))
        {
            comando.Parameters.AddWithValue("@cedula", c.Cedula);
            comando.Parameters.AddWithValue("@nombres", c.Nombres);
            comando.Parameters.AddWithValue("@apellidos", c.Apellidos);
            comando.Parameters.AddWithValue("@telefono", c.Telefono);
            comando.Parameters.AddWithValue("@direccion", c.Direccion);
            
            int filasAfectadas = comando.ExecuteNonQuery();

            return filasAfectadas > 0;
        }
    }

    public bool Modificar(Cliente c)
    {
        string query = "UPDATE cliente SET nombres = @nombres, apellidos = @apellidos, telefono = @telefono, direccion = @direccion WHERE cedula = @cedula;";
        
        using (var conexion = ConexionBD.ObtenerConexion())
        using (var comando = new NpgsqlCommand(query, conexion))
        {
            comando.Parameters.AddWithValue("@cedula", c.Cedula);
            comando.Parameters.AddWithValue("@nombres", c.Nombres);
            comando.Parameters.AddWithValue("@apellidos", c.Apellidos);
            comando.Parameters.AddWithValue("@telefono", (object)c.Telefono ?? DBNull.Value);
            comando.Parameters.AddWithValue("@direccion", (object)c.Direccion ?? DBNull.Value);

            int filasAfectadas = comando.ExecuteNonQuery();
            
            return filasAfectadas > 0;
        }
    }

    public bool Eliminar(String cedula)
    {
        string query = "DELETE FROM cliente WHERE cedula = @cedula;";
        
        using (var conexion = ConexionBD.ObtenerConexion())
        using (var comando = new NpgsqlCommand(query, conexion))
        {
            comando.Parameters.AddWithValue("@Cedula", cedula);
            
            int filasAfectadas = comando.ExecuteNonQuery();
            
            return filasAfectadas > 0;
        }    
    }
    
}