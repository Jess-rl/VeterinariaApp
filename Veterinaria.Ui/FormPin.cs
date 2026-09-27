using System.Net.Mime;

namespace Veterinaria.U;

public partial class FormPin : Form
{
    public FormPin()
    {
        InitializeComponent();
    }
    
    public string PinIngresado => txtPin.Text.Trim();

    private void btnAceptar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtPin.Text))
        {
            MessageBox.Show("Por favor, ingrese el Pin de seguridad");
            txtPin.Focus();
            return;
        }

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}