using Veterinaria.Entidades;
using Veterinaria.Negocio;

namespace Veterinaria.UI;

public partial class FormInicio : Form
{
    private readonly EmpleadoNegocio _empleadoNegocio = new();

    public FormInicio()
    {
        InitializeComponent();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnRecepcion_Click(object sender, EventArgs e)
    {
        FormRecepcion recepcion = new FormRecepcion();
        this.Hide();
        recepcion.ShowDialog();
        this.Show();
    }

    private void btnVeterinario_Click(object sender, EventArgs e)
    {
        using var formPin = new FormPin();

        if (formPin.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            if (_empleadoNegocio.ValidarPin(formPin.PinIngresado, out Empleado? empleado, out string mensajeErr))
            {
                FormVeterinario veterinario = new FormVeterinario();
                this.Hide();
                veterinario.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(mensajeErr, "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo validar el PIN contra la base de datos: " + ex.Message,
                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
