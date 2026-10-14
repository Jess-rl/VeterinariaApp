using System.Text.Json;
using Veterinaria.Datos;

namespace Veterinaria.UI;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        CargarConfiguracion();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormInicio());
    }

    /// <summary>
    /// Carga la cadena de conexión desde appsettings.json y la entrega a la
    /// capa de datos. Al no estar las credenciales en el código, pueden cambiarse
    /// sin recompilar la aplicación.
    /// </summary>
    private static void CargarConfiguracion()
    {
        string ruta = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

        if (!File.Exists(ruta))
        {
            MessageBox.Show(
                $"No se encontró el archivo de configuración:\n{ruta}\n\n" +
                "Copie appsettings.example.json como appsettings.json y ajuste la cadena de conexión.",
                "Configuración faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
            return;
        }

        using var documento = JsonDocument.Parse(File.ReadAllText(ruta));

        if (!documento.RootElement.TryGetProperty("ConnectionStrings", out var conexiones) ||
            !conexiones.TryGetProperty("Veterinaria", out var cadenaElemento) ||
            string.IsNullOrWhiteSpace(cadenaElemento.GetString()))
        {
            MessageBox.Show(
                "La cadena de conexión 'Veterinaria' no está definida en appsettings.json.",
                "Configuración inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
            return;
        }

        ConexionBD.CadenaConexion = cadenaElemento.GetString()!;
    }
}
