using Veterinaria.Datos;
using Veterinaria.Entidades;

namespace Veterinaria.Negocio;

public class ClienteNegocio
{
    private readonly ClienteDatos _clienteDatos = new();

    private static bool CedulaValida(string? cedula)
    {
        if (string.IsNullOrWhiteSpace(cedula)) return false;
        string limpia = cedula.Trim();
        return limpia.Length == 10 && limpia.All(char.IsDigit);
    }

    // Metodo obtener
    public List<Cliente> ObtenerClientes()
    {
        return _clienteDatos.ObtenerTodos();
    }

    // Metodo insertar/guardar
    public bool GuardarCliente(Cliente cliente, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (!CedulaValida(cliente.Cedula))
        {
            mensajeErr = "La cédula debe contener exactamente 10 digitos numéricos.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(cliente.Nombres) || string.IsNullOrWhiteSpace(cliente.Apellidos))
        {
            mensajeErr = "Los Nombres y Apellidos son campos obligatorios.";
            return false;
        }

        bool resultado = _clienteDatos.Insertar(cliente);

        if (!resultado)
        {
            mensajeErr = "No se pudo registrar el cliente.";
            return false;
        }

        return true;
    }

    // Metodo modificar
    public bool ModificarCliente(Cliente cliente, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (!CedulaValida(cliente.Cedula))
        {
            mensajeErr = "Debe seleccionar o especificar un cliente con cédula válida para modificar.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(cliente.Nombres) || string.IsNullOrWhiteSpace(cliente.Apellidos))
        {
            mensajeErr = "Los nombres y apellidos no pueden quedar vacíos al modificar.";
            return false;
        }

        bool resultado = _clienteDatos.Modificar(cliente);

        if (!resultado)
        {
            mensajeErr = "No se pudo modificar el cliente (verifique que el registro aún exista)";
            return false;
        }

        return true;
    }

    // Metodo eliminar
    public bool EliminarCliente(string cedula, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (!CedulaValida(cedula))
        {
            mensajeErr = "La cédula debe contener exactamente 10 dígitos numéricos.";
            return false;
        }

        bool resultado = _clienteDatos.Eliminar(cedula);

        if (!resultado)
        {
            mensajeErr = "No se pudo eliminar el cliente. Verifique que exista o que no tenga registros vinculados.";
            return false;
        }

        return true;
    }
}