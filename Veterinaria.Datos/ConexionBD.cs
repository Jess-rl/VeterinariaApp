using Npgsql;

namespace Veterinaria.Datos;

public static class ConexionBD
{
    private const string Conexion = "Host=localhost;" +
                                    "Port=5432;Database=db_veterinaria;" +
                                    "Username=postgres;" +
                                    "Password=Admin0025j";

    public static NpgsqlConnection ObtenerConexion()
    {
        var conexion = new NpgsqlConnection(Conexion);
        conexion.Open();
        return conexion;
    }
}
