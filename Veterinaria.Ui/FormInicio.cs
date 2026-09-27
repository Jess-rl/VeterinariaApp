namespace Veterinaria.U;

public partial class FormInicio : Form
{
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
        FormPin formPin = new FormPin();

        if (formPin.ShowDialog() == DialogResult.OK)
        {
            string pin = formPin.PinIngresado;

            if (pin == "1234")
            {
                FormVeterinario veterinario = new FormVeterinario();
                this.Hide();
                veterinario.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("PIN de acceso incorrecto.", "Acceso denegado");
            }
        }
        
    }
}