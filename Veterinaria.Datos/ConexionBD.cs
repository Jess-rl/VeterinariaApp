using Npgsql;

namespace Veterinaria.Datos;

public static class ConexionBD
{
    private static string? _cadenaConexion;

    /// <summary>
    /// Cadena de conexión configurada al iniciar la aplicación (por ejemplo,
    /// cargada desde appsettings.json). No contiene credenciales en el código.
    /// </summary>
    public static string CadenaConexion
    {
        get => _cadenaConexion ?? throw new InvalidOperationException(
            "La cadena de conexión no ha sido configurada. Configúrela al iniciar la aplicación " +
            "(por ejemplo, desde appsettings.json).");
        set => _cadenaConexion = string.IsNullOrWhiteSpace(value)
            ? throw new ArgumentException("La cadena de conexión no puede estar vacía.", nameof(value))
            : value;
    }

    public static NpgsqlConnection ObtenerConexion()
    {
        var conexion = new NpgsqlConnection(CadenaConexion);
        conexion.Open();
        return conexion;
    }
}
