using System.Drawing.Printing;
using Veterinaria.Entidades;

namespace Veterinaria.UI;

public partial class FormRecepcion : Form
{
    private Cita? _citaSeleccionadaParaImprimir;
    private int _idMascotaSeleccionada = 0;
    private bool _sincronizandoCombos = false;

    public FormRecepcion()
    {
        InitializeComponent();
        ConfigurarColumnasTablas();
    }

    private void FormRecepcion_Load(object sender, EventArgs e)
    {
        ConfigurarColumnasTablas();

        cmbFiltroEstadoCitas.SelectedIndexChanged -= cmbFiltroEstadoCitas_SelectedIndexChanged;
        if (cmbFiltroEstadoCitas.Items.Count == 0)
        {
            cmbFiltroEstadoCitas.Items.AddRange(new object[] { "Todas las Citas", "Solo Pendientes", "Solo Atendidas", "Solo Canceladas" });
            cmbFiltroEstadoCitas.SelectedIndex = 0;
        }
        cmbFiltroEstadoCitas.SelectedIndexChanged += cmbFiltroEstadoCitas_SelectedIndexChanged;

        RefrescarListaClientes();
        RefrescarListaMascotas();
        RefrescarListaCitas();
        CargarCombosClientes();
    }

    private void tabRecepcion_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Al cambiar de pestaña, mantener todas las tablas y desplegables sincronizados con los datos más recientes
        RefrescarListaClientes();
        RefrescarListaMascotas();
        RefrescarListaCitas();
        CargarCombosClientes();
    }

    private void EstilarTabla(DataGridView dgv)
    {
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 24, 80);
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(85, 35, 105);
        dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 250, 254);
        dgv.GridColor = Color.FromArgb(235, 230, 240);
        dgv.BackgroundColor = Color.White;
        dgv.BorderStyle = BorderStyle.FixedSingle;
    }

    private void ConfigurarColumnasTablas()
    {
        // Configuración de tabla Clientes con anchos proporcionales
        dgvClientes.Columns.Clear();
        var colCed = new DataGridViewTextBoxColumn { Name = "Cedula", HeaderText = "Cédula", FillWeight = 90 };
        var colNom = new DataGridViewTextBoxColumn { Name = "Nombres", HeaderText = "Nombres", FillWeight = 110 };
        var colApe = new DataGridViewTextBoxColumn { Name = "Apellidos", HeaderText = "Apellidos", FillWeight = 110 };
        var colTel = new DataGridViewTextBoxColumn { Name = "Telefono", HeaderText = "Teléfono", FillWeight = 90 };
        var colDir = new DataGridViewTextBoxColumn { Name = "Direccion", HeaderText = "Dirección", FillWeight = 140 };
        dgvClientes.Columns.AddRange(colCed, colNom, colApe, colTel, colDir);
        dgvClientes.RowTemplate.Height = 32;
        EstilarTabla(dgvClientes);

        // Configuración de tabla Mascotas con anchos proporcionales
        dgvMascotasRecepcion.Columns.Clear();
        var colIdM = new DataGridViewTextBoxColumn { Name = "IdMascota", HeaderText = "ID", FillWeight = 45 };
        var colNomM = new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", FillWeight = 100 };
        var colEsp = new DataGridViewTextBoxColumn { Name = "Especie", HeaderText = "Especie", FillWeight = 85 };
        var colRaz = new DataGridViewTextBoxColumn { Name = "Raza", HeaderText = "Raza", FillWeight = 110 };
        var colSex = new DataGridViewTextBoxColumn { Name = "Sexo", HeaderText = "Sexo", FillWeight = 60 };
        var colFec = new DataGridViewTextBoxColumn { Name = "FechaNacimiento", HeaderText = "Fecha Nac.", FillWeight = 90 };
        var colDue = new DataGridViewTextBoxColumn { Name = "Dueno", HeaderText = "Dueño (Propietario)", FillWeight = 150 };
        dgvMascotasRecepcion.Columns.AddRange(colIdM, colNomM, colEsp, colRaz, colSex, colFec, colDue);
        dgvMascotasRecepcion.RowTemplate.Height = 32;
        EstilarTabla(dgvMascotasRecepcion);

        // Configuración de tabla Citas con anchos proporcionales
        dgvCitas.Columns.Clear();
        var colIdC = new DataGridViewTextBoxColumn { Name = "IdCita", HeaderText = "ID Cita", FillWeight = 50 };
        var colFecC = new DataGridViewTextBoxColumn { Name = "Fecha", HeaderText = "Fecha y Hora Programada", FillWeight = 110 };
        var colCliC = new DataGridViewTextBoxColumn { Name = "Cliente", HeaderText = "Cliente", FillWeight = 125 };
        var colMasC = new DataGridViewTextBoxColumn { Name = "Mascota", HeaderText = "Mascota", FillWeight = 100 };
        var colMotC = new DataGridViewTextBoxColumn { Name = "Motivo", HeaderText = "Motivo de Consulta", FillWeight = 155 };
        var colEstC = new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado", FillWeight = 75 };
        dgvCitas.Columns.AddRange(colIdC, colFecC, colCliC, colMasC, colMotC, colEstC);
        dgvCitas.RowTemplate.Height = 32;
        EstilarTabla(dgvCitas);
    }

    #region MÓDULO 2 - SECCIÓN CLIENTES

    private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
    {
        RefrescarListaClientes();
    }

    private void RefrescarListaClientes()
    {
        if (dgvClientes == null || dgvClientes.Columns.Count == 0) return;
        dgvClientes.Rows.Clear();
        string filtro = txtBuscarCliente?.Text.Trim().ToLowerInvariant() ?? "";
        var lista = RepositorioDatos.Clientes.AsEnumerable();
        if (!string.IsNullOrEmpty(filtro))
        {
            lista = lista.Where(c =>
                c.Cedula.ToLowerInvariant().Contains(filtro) ||
                c.Nombres.ToLowerInvariant().Contains(filtro) ||
                c.Apellidos.ToLowerInvariant().Contains(filtro) ||
                c.Telefono.ToLowerInvariant().Contains(filtro));
        }

        foreach (var c in lista)
        {
            dgvClientes.Rows.Add(c.Cedula, c.Nombres, c.Apellidos, c.Telefono, c.Direccion);
        }
    }

    public void LimpiarCampos()
    {
        txtCedula.Clear();
        txtNombre.Clear();
        txtApellidos.Clear();
        txtTelefono.Clear();
        txtDireccion.Clear();
        txtCedula.Focus();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarCampos();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        // 1. Validar campos obligatorios
        if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
            string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtApellidos.Text) ||
            string.IsNullOrWhiteSpace(txtTelefono.Text) ||
            string.IsNullOrWhiteSpace(txtDireccion.Text))
        {
            MessageBox.Show("Por favor complete todos los datos del cliente.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string cedula = txtCedula.Text.Trim();

        // 2. Verificar duplicado con .Any()
        if (RepositorioDatos.Clientes.Any(c => c.Cedula.Trim().Equals(cedula, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show($"Ya existe un cliente registrado con la cédula {cedula}.", "Cédula Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCedula.Focus();
            return;
        }

        // 3. Instanciar cliente con constructor parametrizado
        Cliente nuevoCliente = new Cliente(
            cedula,
            txtNombre.Text.Trim(),
            txtApellidos.Text.Trim(),
            txtTelefono.Text.Trim(),
            txtDireccion.Text.Trim()
        );

        // 4. Guardar en repositorio compartido
        RepositorioDatos.Clientes.Add(nuevoCliente);

        // 5. Actualizar interfaz
        RefrescarListaClientes();
        CargarCombosClientes();
        LimpiarCampos();

        MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCedula.Text))
        {
            MessageBox.Show("Seleccione o especifique la cédula del cliente a modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string cedula = txtCedula.Text.Trim();
        var cliente = RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula.Trim().Equals(cedula, StringComparison.OrdinalIgnoreCase));

        if (cliente == null)
        {
            MessageBox.Show("No se encontró ningún cliente con la cédula indicada.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        cliente.Nombres = txtNombre.Text.Trim();
        cliente.Apellidos = txtApellidos.Text.Trim();
        cliente.Telefono = txtTelefono.Text.Trim();
        cliente.Direccion = txtDireccion.Text.Trim();

        RefrescarListaClientes();
        CargarCombosClientes();
        MessageBox.Show("Datos del cliente modificados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCedula.Text))
        {
            MessageBox.Show("Seleccione un cliente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string cedula = txtCedula.Text.Trim();
        var cliente = RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula.Trim().Equals(cedula, StringComparison.OrdinalIgnoreCase));

        if (cliente == null)
        {
            MessageBox.Show("El cliente no existe o ya fue eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmacion = MessageBox.Show(
            $"¿Está seguro de eliminar al cliente '{cliente.Nombres} {cliente.Apellidos}' con cédula {cliente.Cedula}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (confirmacion == DialogResult.Yes)
        {
            RepositorioDatos.Clientes.Remove(cliente);
            RefrescarListaClientes();
            CargarCombosClientes();
            LimpiarCampos();
            MessageBox.Show("Cliente eliminado satisfactoriamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex < dgvClientes.Rows.Count)
        {
            var fila = dgvClientes.Rows[e.RowIndex];
            txtCedula.Text = fila.Cells["Cedula"].Value?.ToString() ?? string.Empty;
            txtNombre.Text = fila.Cells["Nombres"].Value?.ToString() ?? string.Empty;
            txtApellidos.Text = fila.Cells["Apellidos"].Value?.ToString() ?? string.Empty;
            txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? string.Empty;
            txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString() ?? string.Empty;
        }
    }

    #endregion

    #region GESTIÓN DE MASCOTAS

    private void txtCedulaDueno_TextChanged(object sender, EventArgs e)
    {
        if (_sincronizandoCombos) return;

        string cedula = txtCedulaDueno.Text.Trim();
        if (string.IsNullOrEmpty(cedula)) return;

        _sincronizandoCombos = true;
        for (int i = 0; i < cmbClienteMascota.Items.Count; i++)
        {
            if (cmbClienteMascota.Items[i] is ClienteItem it && it.Cedula.Trim().Equals(cedula, StringComparison.OrdinalIgnoreCase))
            {
                cmbClienteMascota.SelectedIndex = i;
                break;
            }
        }
        _sincronizandoCombos = false;
    }

    private void cmbClienteMascota_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_sincronizandoCombos) return;

        if (cmbClienteMascota.SelectedItem is ClienteItem ci && !string.IsNullOrEmpty(ci.Cedula))
        {
            _sincronizandoCombos = true;
            txtCedulaDueno.Text = ci.Cedula;
            _sincronizandoCombos = false;
        }
    }

    private void txtBuscarMascota_TextChanged(object sender, EventArgs e)
    {
        RefrescarListaMascotas();
    }

    private void RefrescarListaMascotas()
    {
        if (dgvMascotasRecepcion == null || dgvMascotasRecepcion.Columns.Count == 0) return;
        dgvMascotasRecepcion.Rows.Clear();
        string filtro = txtBuscarMascota?.Text.Trim().ToLowerInvariant() ?? "";
        var lista = RepositorioDatos.Mascotas.AsEnumerable();
        if (!string.IsNullOrEmpty(filtro))
        {
            lista = lista.Where(m =>
            {
                var dueno = RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula == m.CedulaCliente);
                string nomDueno = dueno != null ? $"{dueno.Nombres} {dueno.Apellidos}" : "";
                return m.Nombre.ToLowerInvariant().Contains(filtro) ||
                       m.Especie.ToLowerInvariant().Contains(filtro) ||
                       m.Raza.ToLowerInvariant().Contains(filtro) ||
                       m.CedulaCliente.ToLowerInvariant().Contains(filtro) ||
                       nomDueno.ToLowerInvariant().Contains(filtro);
            });
        }

        foreach (var m in lista)
        {
            var dueno = RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula == m.CedulaCliente);
            string duenoTexto = dueno != null ? $"{dueno.Nombres} {dueno.Apellidos} ({m.CedulaCliente})" : m.CedulaCliente;
            dgvMascotasRecepcion.Rows.Add(
                m.IdMascota,
                m.Nombre,
                m.Especie,
                m.Raza,
                m.Sexo,
                m.FechaNacimiento.ToString("dd/MM/yyyy"),
                duenoTexto
            );
        }
    }

    private void btnGuardarMascota_Click(object sender, EventArgs e)
    {
        string cedulaDueno = string.Empty;

        // Validar si el usuario escribió la cédula o la seleccionó del combo
        if (!string.IsNullOrWhiteSpace(txtCedulaDueno.Text))
        {
            var cliente = RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula.Trim().Equals(txtCedulaDueno.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (cliente != null)
            {
                cedulaDueno = cliente.Cedula;
            }
            else
            {
                MessageBox.Show($"No se encontró ningún cliente registrado con la cédula '{txtCedulaDueno.Text.Trim()}'.\nPor favor regístrelo primero en la pestaña 'Registro de Clientes'.", "Cliente No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedulaDueno.Focus();
                return;
            }
        }
        else if (cmbClienteMascota.SelectedItem is ClienteItem ci && !string.IsNullOrEmpty(ci.Cedula))
        {
            cedulaDueno = ci.Cedula;
        }

        if (string.IsNullOrEmpty(cedulaDueno) ||
            string.IsNullOrWhiteSpace(txtNombreMascota.Text) ||
            string.IsNullOrWhiteSpace(txtEspecie.Text) ||
            string.IsNullOrWhiteSpace(txtRaza.Text) ||
            cmbSexo.SelectedItem == null)
        {
            MessageBox.Show("Complete todos los campos de la mascota y especifique la cédula o selección de su dueño.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int nuevoId = RepositorioDatos.Mascotas.Any() ? RepositorioDatos.Mascotas.Max(m => m.IdMascota) + 1 : 1;

        Mascota nuevaMascota = new Mascota(
            nuevoId,
            txtNombreMascota.Text.Trim(),
            txtEspecie.Text.Trim(),
            txtRaza.Text.Trim(),
            dtpFechaNacimiento.Value,
            cedulaDueno,
            cmbSexo.SelectedItem?.ToString() ?? "Macho"
        );

        RepositorioDatos.Mascotas.Add(nuevaMascota);
        RefrescarListaMascotas();
        LimpiarCamposMascota();

        // Actualizar desplegables de citas
        ActualizarComboMascotasPorCedula();

        MessageBox.Show("Mascota registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnModificarMascota_Click(object sender, EventArgs e)
    {
        if (_idMascotaSeleccionada <= 0)
        {
            MessageBox.Show("Seleccione una mascota de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var mascota = RepositorioDatos.Mascotas.FirstOrDefault(m => m.IdMascota == _idMascotaSeleccionada);
        if (mascota == null)
        {
            MessageBox.Show("Mascota no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!string.IsNullOrWhiteSpace(txtCedulaDueno.Text))
        {
            var cliente = RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula.Trim().Equals(txtCedulaDueno.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (cliente != null)
            {
                mascota.CedulaCliente = cliente.Cedula;
            }
        }
        else if (cmbClienteMascota.SelectedItem is ClienteItem ci && !string.IsNullOrEmpty(ci.Cedula))
        {
            mascota.CedulaCliente = ci.Cedula;
        }

        mascota.Nombre = txtNombreMascota.Text.Trim();
        mascota.Especie = txtEspecie.Text.Trim();
        mascota.Raza = txtRaza.Text.Trim();
        mascota.Sexo = cmbSexo.SelectedItem?.ToString() ?? "Macho";
        mascota.FechaNacimiento = dtpFechaNacimiento.Value;

        RefrescarListaMascotas();
        ActualizarComboMascotasPorCedula();
        MessageBox.Show("Datos de la mascota actualizados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnEliminarMascota_Click(object sender, EventArgs e)
    {
        if (_idMascotaSeleccionada <= 0)
        {
            MessageBox.Show("Seleccione una mascota para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var mascota = RepositorioDatos.Mascotas.FirstOrDefault(m => m.IdMascota == _idMascotaSeleccionada);
        if (mascota == null) return;

        if (MessageBox.Show($"¿Desea eliminar a la mascota '{mascota.Nombre}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            RepositorioDatos.Mascotas.Remove(mascota);
            RefrescarListaMascotas();
            ActualizarComboMascotasPorCedula();
            LimpiarCamposMascota();
            MessageBox.Show("Mascota eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void LimpiarCamposMascota()
    {
        _idMascotaSeleccionada = 0;
        txtCedulaDueno.Clear();
        txtNombreMascota.Clear();
        txtEspecie.Clear();
        txtRaza.Clear();
        if (cmbSexo.Items.Count > 0) cmbSexo.SelectedIndex = 0;
        dtpFechaNacimiento.Value = DateTime.Today;
        if (cmbClienteMascota.Items.Count > 0) cmbClienteMascota.SelectedIndex = 0;
        txtCedulaDueno.Focus();
    }

    private void btnLimpiarMascota_Click(object sender, EventArgs e)
    {
        LimpiarCamposMascota();
    }

    private void dgvMascotasRecepcion_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex < dgvMascotasRecepcion.Rows.Count)
        {
            var fila = dgvMascotasRecepcion.Rows[e.RowIndex];
            if (int.TryParse(fila.Cells["IdMascota"].Value?.ToString(), out int id))
            {
                _idMascotaSeleccionada = id;
                var mascota = RepositorioDatos.Mascotas.FirstOrDefault(m => m.IdMascota == id);
                if (mascota != null)
                {
                    txtCedulaDueno.Text = mascota.CedulaCliente;
                    txtNombreMascota.Text = mascota.Nombre;
                    txtEspecie.Text = mascota.Especie;
                    txtRaza.Text = mascota.Raza;
                    cmbSexo.SelectedItem = mascota.Sexo;
                    dtpFechaNacimiento.Value = mascota.FechaNacimiento;

                    // Seleccionar dueño en combo
                    for (int i = 0; i < cmbClienteMascota.Items.Count; i++)
                    {
                        if (cmbClienteMascota.Items[i] is ClienteItem it && it.Cedula == mascota.CedulaCliente)
                        {
                            cmbClienteMascota.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }
    }

    #endregion

    #region MÓDULO 2 - SECCIÓN CITAS

    private void CargarCombosClientes()
    {
        _sincronizandoCombos = true;

        string? cedulaDuenoMascotaPrevio = (cmbClienteMascota.SelectedItem as ClienteItem)?.Cedula;

        cmbClienteMascota.Items.Clear();

        // 1. Combo Dueño en Pestaña Mascotas
        foreach (var c in RepositorioDatos.Clientes)
        {
            var item = new ClienteItem(c.Cedula, $"{c.Nombres} {c.Apellidos} ({c.Cedula})");
            cmbClienteMascota.Items.Add(item);
        }

        // Restaurar selección previa en Mascotas
        if (!string.IsNullOrEmpty(cedulaDuenoMascotaPrevio))
        {
            for (int i = 0; i < cmbClienteMascota.Items.Count; i++)
            {
                if (cmbClienteMascota.Items[i] is ClienteItem ci && ci.Cedula == cedulaDuenoMascotaPrevio)
                {
                    cmbClienteMascota.SelectedIndex = i;
                    break;
                }
            }
        }
        if (cmbClienteMascota.SelectedIndex < 0 && cmbClienteMascota.Items.Count > 0)
        {
            cmbClienteMascota.SelectedIndex = 0;
            if (string.IsNullOrWhiteSpace(txtCedulaDueno.Text) && cmbClienteMascota.SelectedItem is ClienteItem ci)
            {
                txtCedulaDueno.Text = ci.Cedula;
            }
        }

        _sincronizandoCombos = false;
        ActualizarComboMascotasPorCedula();
    }

    private void txtCedulaCita_TextChanged(object sender, EventArgs e)
    {
        if (_sincronizandoCombos) return;
        ActualizarComboMascotasPorCedula();
    }

    private void ActualizarComboMascotasPorCedula()
    {
        _sincronizandoCombos = true;
        cmbMascotas.Items.Clear();

        string cedula = txtCedulaCita.Text.Trim();

        if (string.IsNullOrEmpty(cedula))
        {
            lblNombreDuenoCita.Text = "Propietario: (Escriba la cédula arriba)";
            lblNombreDuenoCita.ForeColor = Color.FromArgb(64, 24, 80);
            cmbMascotas.Items.Add(new MascotaItem(0, "-- Ingrese cédula para ver mascotas --", ""));
            cmbMascotas.SelectedIndex = 0;
            _sincronizandoCombos = false;
            return;
        }

        var cliente = RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula.Trim().Equals(cedula, StringComparison.OrdinalIgnoreCase));
        if (cliente != null)
        {
            lblNombreDuenoCita.Text = $"Propietario: {cliente.Nombres} {cliente.Apellidos}";
            lblNombreDuenoCita.ForeColor = Color.FromArgb(64, 24, 80);

            var listaMascotas = RepositorioDatos.Mascotas
                .Where(m => m.CedulaCliente.Trim().Equals(cliente.Cedula.Trim(), StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (listaMascotas.Count == 0)
            {
                cmbMascotas.Items.Add(new MascotaItem(0, "(Este cliente aún no registra mascotas)", ""));
                cmbMascotas.SelectedIndex = 0;
            }
            else
            {
                foreach (var m in listaMascotas)
                {
                    cmbMascotas.Items.Add(new MascotaItem(m.IdMascota, $"{m.Nombre} ({m.Especie} - {m.Raza})", m.CedulaCliente));
                }

                if (cmbMascotas.Items.Count > 0)
                {
                    cmbMascotas.SelectedIndex = 0;
                }
            }
        }
        else
        {
            lblNombreDuenoCita.Text = "Cliente no encontrado";
            lblNombreDuenoCita.ForeColor = Color.FromArgb(64, 24, 80);
            cmbMascotas.Items.Add(new MascotaItem(0, "(No registrado en el sistema)", ""));
            cmbMascotas.SelectedIndex = 0;
        }

        _sincronizandoCombos = false;
    }

    private void cmbFiltroEstadoCitas_SelectedIndexChanged(object? sender, EventArgs e)
    {
        RefrescarListaCitas();
    }

    private void RefrescarListaCitas()
    {
        if (dgvCitas == null || dgvCitas.Columns.Count == 0) return;
        dgvCitas.Rows.Clear();
        string filtro = cmbFiltroEstadoCitas?.SelectedItem?.ToString() ?? "Todas las Citas";
        var lista = RepositorioDatos.Citas.OrderByDescending(c => c.Fecha).AsEnumerable();

        if (filtro == "Solo Pendientes")
            lista = lista.Where(c => c.Estado.Equals("Pendiente", StringComparison.OrdinalIgnoreCase));
        else if (filtro == "Solo Atendidas")
            lista = lista.Where(c => c.Estado.Equals("Atendida", StringComparison.OrdinalIgnoreCase));
        else if (filtro == "Solo Canceladas")
            lista = lista.Where(c => c.Estado.Equals("Cancelada", StringComparison.OrdinalIgnoreCase));

        foreach (var cita in lista)
        {
            var mascota = RepositorioDatos.Mascotas.FirstOrDefault(m => m.IdMascota == cita.IdMascota);
            string nombreMascota = mascota != null ? mascota.Nombre : $"ID #{cita.IdMascota}";
            string nombreCliente = "Desconocido";

            if (mascota != null)
            {
                var cliente = RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula == mascota.CedulaCliente);
                if (cliente != null)
                {
                    nombreCliente = $"{cliente.Nombres} {cliente.Apellidos}";
                }
            }

            dgvCitas.Rows.Add(
                cita.IdCita,
                cita.Fecha.ToString("dd/MM/yyyy HH:mm"),
                nombreCliente,
                nombreMascota,
                cita.Motivo,
                cita.Estado
            );
        }
    }

    private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvCitas.Rows.Count) return;

        var fila = dgvCitas.Rows[e.RowIndex];
        if (int.TryParse(fila.Cells["IdCita"].Value?.ToString(), out int idCita))
        {
            var cita = RepositorioDatos.Citas.FirstOrDefault(c => c.IdCita == idCita);
            if (cita != null)
            {
                var mascota = RepositorioDatos.Mascotas.FirstOrDefault(m => m.IdMascota == cita.IdMascota);
                if (mascota != null)
                {
                    txtCedulaCita.Text = mascota.CedulaCliente;
                    for (int i = 0; i < cmbMascotas.Items.Count; i++)
                    {
                        if (cmbMascotas.Items[i] is MascotaItem mi && mi.IdMascota == mascota.IdMascota)
                        {
                            cmbMascotas.SelectedIndex = i;
                            break;
                        }
                    }
                }
                dtpFechaCita.Value = cita.Fecha;
                txtMotivo.Text = cita.Motivo;
            }
        }
    }

    private void btnAgendarCita_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCedulaCita.Text))
        {
            MessageBox.Show("Por favor ingrese la cédula del cliente/dueño.", "Cédula requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCedulaCita.Focus();
            return;
        }

        var cliente = RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula.Trim().Equals(txtCedulaCita.Text.Trim(), StringComparison.OrdinalIgnoreCase));
        if (cliente == null)
        {
            MessageBox.Show("No se encontró ningún cliente registrado con esa cédula.\nRegístrelo primero en la pestaña 'Registro de Clientes'.", "Cliente No Registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCedulaCita.Focus();
            return;
        }

        // 1. Validar selección de mascota válida
        if (cmbMascotas.SelectedItem is not MascotaItem mascotaItem || mascotaItem.IdMascota <= 0)
        {
            MessageBox.Show("Por favor seleccione una mascota válida para agendar la cita.", "Mascota no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtMotivo.Text))
        {
            MessageBox.Show("Por favor ingrese el motivo de la consulta médica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMotivo.Focus();
            return;
        }

        var mascota = RepositorioDatos.Mascotas.FirstOrDefault(m => m.IdMascota == mascotaItem.IdMascota);
        if (mascota == null)
        {
            MessageBox.Show("No se encontró el registro de la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // 2. Crear objeto Cita con estado "Pendiente"
        int nuevoId = RepositorioDatos.Citas.Count != 0 ? RepositorioDatos.Citas.Max(c => c.IdCita) + 1 : 1;
        var nuevaCita = new Cita(
            nuevoId,
            dtpFechaCita.Value,
            txtMotivo.Text.Trim(),
            "Pendiente",
            mascota.IdMascota,
            1
        );

        // 3. Guardar en lista compartida y refrescar dgvCitas
        RepositorioDatos.Citas.Add(nuevaCita);
        RefrescarListaCitas();

        txtMotivo.Clear();
        dtpFechaCita.Value = DateTime.Now.AddHours(1);

        MessageBox.Show($"Cita N° {nuevoId} agendada exitosamente con estado 'Pendiente' para {mascota.Nombre}.", "Cita Agendada", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnCancelarCita_Click(object sender, EventArgs e)
    {
        if (dgvCitas.CurrentRow == null)
        {
            MessageBox.Show("Seleccione una cita de la tabla para cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (int.TryParse(dgvCitas.CurrentRow.Cells["IdCita"].Value?.ToString(), out int idCita))
        {
            var cita = RepositorioDatos.Citas.FirstOrDefault(c => c.IdCita == idCita);
            if (cita != null)
            {
                if (MessageBox.Show($"¿Desea marcar como Cancelada la cita #{cita.IdCita}?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cita.Estado = "Cancelada";
                    RefrescarListaCitas();
                    MessageBox.Show("Cita cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    private void btnImprimirCita_Click(object sender, EventArgs e)
    {
        // 1. Validar que haya una cita seleccionada en dgvCitas
        if (dgvCitas.CurrentRow == null)
        {
            MessageBox.Show("Por favor, seleccione una cita de la tabla para imprimir el comprobante.", "Cita no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!int.TryParse(dgvCitas.CurrentRow.Cells["IdCita"].Value?.ToString(), out int idCita))
        {
            MessageBox.Show("No se pudo identificar la cita seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _citaSeleccionadaParaImprimir = RepositorioDatos.Citas.FirstOrDefault(c => c.IdCita == idCita);
        if (_citaSeleccionadaParaImprimir == null)
        {
            MessageBox.Show("La cita seleccionada no existe en el repositorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // 2. Usar PrintDocument y PrintPreviewDialog
        using var printDoc = new PrintDocument();
        printDoc.DocumentName = $"Comprobante_Cita_{_citaSeleccionadaParaImprimir.IdCita}";
        printDoc.PrintPage += ImprimirComprobanteCita_PrintPage;

        using var previewDialog = new PrintPreviewDialog
        {
            Document = printDoc,
            Width = 900,
            Height = 700,
            StartPosition = FormStartPosition.CenterScreen
        };

        previewDialog.ShowDialog();
    }

    private void ImprimirComprobanteCita_PrintPage(object sender, PrintPageEventArgs e)
    {
        if (_citaSeleccionadaParaImprimir == null || e.Graphics == null) return;

        Graphics g = e.Graphics;
        var cita = _citaSeleccionadaParaImprimir;
        var mascota = RepositorioDatos.Mascotas.FirstOrDefault(m => m.IdMascota == cita.IdMascota);
        var cliente = mascota != null ? RepositorioDatos.Clientes.FirstOrDefault(c => c.Cedula == mascota.CedulaCliente) : null;

        // Fuentes
        using var fontTitulo = new Font("Segoe UI", 18, FontStyle.Bold);
        using var fontSubtitulo = new Font("Segoe UI", 12, FontStyle.Regular);
        using var fontSeccion = new Font("Segoe UI", 12, FontStyle.Bold);
        using var fontNegrita = new Font("Segoe UI", 10.5f, FontStyle.Bold);
        using var fontTexto = new Font("Segoe UI", 10.5f, FontStyle.Regular);
        using var fontPequena = new Font("Segoe UI", 9, FontStyle.Italic);
        using var fontHora = new Font("Segoe UI", 12, FontStyle.Bold);

        // Brochas y plumas
        using var brushHeader = new SolidBrush(Color.FromArgb(64, 24, 80));
        using var brushFondoCaja = new SolidBrush(Color.FromArgb(252, 250, 254));
        using var brushFondoCita = new SolidBrush(Color.FromArgb(248, 244, 252));
        using var penSeparador = new Pen(Color.FromArgb(64, 24, 80), 2);
        using var penCaja = new Pen(Color.FromArgb(220, 210, 230), 1);
        using var penCajaCita = new Pen(Color.FromArgb(64, 24, 80), 1);

        Brush brushTexto = Brushes.Black;

        int x = 60;
        int y = 50;
        int anchoContenido = e.PageBounds.Width - (x * 2);

        // ENCABEZADO DE LA CLÍNICA VETERINARIA
        g.DrawString("CLÍNICA VETERINARIA", fontTitulo, brushHeader, x, y);
        y += 35;
        g.DrawString("Servicios Médicos Veterinarios y Atención Integral", fontSubtitulo, Brushes.DimGray, x, y);
        y += 25;
        g.DrawString("Av. Principal 123 | Tel: 0991234567 | Email: recepcion@veterinaria.com", fontPequena, Brushes.DimGray, x, y);
        y += 30;

        g.DrawLine(penSeparador, x, y, x + anchoContenido, y);
        y += 20;

        // TÍTULO DEL DOCUMENTO
        g.DrawString("COMPROBANTE DE AGENDAMIENTO DE CITA", fontSeccion, brushHeader, x, y);
        y += 25;
        g.DrawString($"Fecha de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm}    |    Cita N°: #{cita.IdCita:D4}", fontTexto, brushTexto, x, y);
        y += 35;

        // CAJA 1: DATOS DEL CLIENTE
        g.FillRectangle(brushFondoCaja, x, y, anchoContenido, 80);
        g.DrawRectangle(penCaja, x, y, anchoContenido, 80);
        g.DrawString("DATOS DEL CLIENTE / PROPIETARIO", fontNegrita, brushHeader, x + 15, y + 10);
        string nomCliente = cliente != null ? $"{cliente.Nombres} {cliente.Apellidos}" : "No registrado";
        string cedCliente = cliente != null ? cliente.Cedula : "N/D";
        string telCliente = cliente != null ? cliente.Telefono : "N/D";
        string dirCliente = cliente != null ? cliente.Direccion : "N/D";
        g.DrawString($"Propietario: {nomCliente}", fontTexto, brushTexto, x + 15, y + 35);
        g.DrawString($"Cédula: {cedCliente}", fontTexto, brushTexto, x + 400, y + 35);
        g.DrawString($"Teléfono: {telCliente}", fontTexto, brushTexto, x + 15, y + 55);
        g.DrawString($"Dirección: {dirCliente}", fontTexto, brushTexto, x + 400, y + 55);
        y += 95;

        // CAJA 2: DATOS DE LA MASCOTA
        g.FillRectangle(brushFondoCaja, x, y, anchoContenido, 80);
        g.DrawRectangle(penCaja, x, y, anchoContenido, 80);
        g.DrawString("DATOS DEL PACIENTE", fontNegrita, brushHeader, x + 15, y + 10);
        string nomMascota = mascota != null ? mascota.Nombre : "No registrado";
        string espMascota = mascota != null ? mascota.Especie : "N/D";
        string razMascota = mascota != null ? mascota.Raza : "N/D";
        g.DrawString($"Nombre del Paciente: {nomMascota}", fontTexto, brushTexto, x + 15, y + 35);
        g.DrawString($"Especie: {espMascota}", fontTexto, brushTexto, x + 400, y + 35);
        g.DrawString($"Raza: {razMascota}", fontTexto, brushTexto, x + 15, y + 55);
        y += 95;

        // CAJA 3: DETALLES DE LA CITA
        g.FillRectangle(brushFondoCita, x, y, anchoContenido, 130);
        g.DrawRectangle(penCajaCita, x, y, anchoContenido, 130);
        g.DrawString("PROGRAMACIÓN DE LA ATENCIÓN", fontNegrita, brushHeader, x + 15, y + 12);
        g.DrawString($"Fecha y Hora Programada: {cita.Fecha:dd/MM/yyyy  hh:mm tt}", fontHora, brushHeader, x + 15, y + 38);
        g.DrawString($"Estado: {cita.Estado}", fontNegrita, brushHeader, x + 480, y + 40);
        g.DrawString($"Motivo de Consulta: {cita.Motivo}", fontTexto, brushTexto, new RectangleF(x + 15, y + 70, anchoContenido - 30, 50));
        y += 150;

        // INDICACIONES Y NOTA AL PIE
        g.DrawLine(penCaja, x, y, x + anchoContenido, y);
        y += 15;
        g.DrawString("IMPORTANTE:", fontNegrita, Brushes.Black, x, y);
        y += 22;
        g.DrawString("• Por favor presentarse 10 minutos antes del horario programado.", fontPequena, Brushes.Black, x + 10, y);
        y += 18;
        g.DrawString("• Por seguridad, perros deben asistir con collar/correa y gatos en su respectivo transportín.", fontPequena, Brushes.Black, x + 10, y);
        y += 18;
        g.DrawString("• En caso de no poder asistir, favor comunicarse a recepción para reprogramar.", fontPequena, Brushes.Black, x + 10, y);

        y += 60;
        g.DrawString("__________________________________________", fontTexto, Brushes.Black, x + 200, y);
        y += 20;
        g.DrawString("Firma y Sello de Recepción", fontNegrita, brushHeader, x + 240, y);
    }

    #endregion

    private void btnVolver_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    // Clases auxiliares para representación en ComboBox
    private class ClienteItem
    {
        public string Cedula { get; }
        public string Texto { get; }

        public ClienteItem(string cedula, string texto)
        {
            Cedula = cedula;
            Texto = texto;
        }

        public override string ToString() => Texto;
    }

    private class MascotaItem
    {
        public int IdMascota { get; }
        public string Texto { get; }
        public string CedulaCliente { get; }

        public MascotaItem(int idMascota, string texto, string cedulaCliente = "")
        {
            IdMascota = idMascota;
            Texto = texto;
            CedulaCliente = cedulaCliente;
        }

        public override string ToString() => Texto;
    }
}