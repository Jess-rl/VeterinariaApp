using System;
using System.Collections.Generic;
using Veterinaria.Datos;
using Veterinaria.Entidades;

namespace Veterinaria.Negocio;

public class ClienteNegocio
{
    private readonly ClienteDatos _clienteDatos = new ClienteDatos();

    //metodo obtener
    public List<Cliente> ObtenerClientes()
    {
        return _clienteDatos.ObtenerTodos();
    }
    
    //metodo insertar/guardar
    public bool GuardarCliente(Cliente c, out String mensajeErr)
    {
        mensajeErr = String.Empty;

        if (string.IsNullOrWhiteSpace(c.Cedula) || c.Cedula.Trim().Length != 10)
        {
            mensajeErr = "La cédula debe contener exactamente 10 digitos numéricos.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(c.Nombres) || string.IsNullOrWhiteSpace(c.Apellidos))
        {
            mensajeErr = "Los Nombres y Apellidos son campos obligatorios.";
            return false;
        }

        bool resultado = _clienteDatos.Insertar(c);

        if (!resultado)
        {
            mensajeErr = "No se pudo registrar el cliente.";
            return false;
        }

        return true;
    }
    
    //metodo modificar
    public bool ModificarCliente(Cliente c, out String mensajeErr)
    {
        mensajeErr = string.Empty;

        if (string.IsNullOrWhiteSpace(c.Cedula) || c.Cedula.Trim().Length != 10)
        {
            mensajeErr = "Debe seleccionar o especificar un cliente con cédula válida para modificar.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(c.Nombres) || string.IsNullOrWhiteSpace(c.Apellidos))
        {
            mensajeErr = "Los nombres y apellidos no pueden quedar vacíos al modificar.";
            return false;
        }

        bool resultado = _clienteDatos.Modificar(c);

        if (!resultado)
        {
            mensajeErr = "No se pudo modificar el cliente (verifique que el registro aún exista)";
            return false;
        }
        
        return true;
    }
    
    //metodo eliminar
    public bool EliminarCliente(string cedula, out string mensajeErr)
    {
        mensajeErr = string.Empty;

        if (string.IsNullOrWhiteSpace(cedula) || cedula.Trim().Length != 10)
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