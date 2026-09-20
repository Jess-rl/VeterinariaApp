using Npgsql;
namespace Veterinaria.Datos;

public class ConexionBD
{
    private const string Conexion = "Host=localhost;" +
                                    "Port=5432;Database=db_veterinaria;" +
                                    "Username=postgres;" +
                                    "Password=Admin0025j";

    public static NpgsqlConnection ObtenerConexion()
    {
        NpgsqlConnection conexion = new NpgsqlConnection(Conexion);
        conexion.Open();
        return conexion;
    }
    
}


