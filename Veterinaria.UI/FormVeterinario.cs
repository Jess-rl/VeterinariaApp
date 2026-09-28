using System.Drawing.Printing;
using Veterinaria.Entidades;
using Veterinaria.Negocio;

namespace Veterinaria.UI;

public partial class FormVeterinario : Form
{
    private readonly CitaNegocio _citaNegocio = new();
    private readonly MascotaNegocio _mascotaNegocio = new();
    private readonly ClienteNegocio _clienteNegocio = new();
    private readonly HistorialClinicoNegocio _historialNegocio = new();

    private Cita? _citaSeleccionada;
    private Mascota? _mascotaSeleccionada;
    private Cliente? _duenoSeleccionado;

    public FormVeterinario()
    {
        InitializeComponent();
        ConfigurarColumnasTablas();
    }

    private void FormVeterinario_Load(object sender, EventArgs e)
    {
        ConfigurarColumnasTablas();
        CargarPacientesEnEspera();
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
        // Columnas para pacientes en espera con anchos mínimos y proporcionales
        dgvPacientesEspera.Columns.Clear();
        var colCitaId = new DataGridViewTextBoxColumn { Name = "IdCita", HeaderText = "ID", FillWeight = 40, MinimumWidth = 50 };
        var colCitaHora = new DataGridViewTextBoxColumn { Name = "Hora", HeaderText = "Fecha y Hora Programada", FillWeight = 90, MinimumWidth = 130 };
        var colCitaMascota = new DataGridViewTextBoxColumn { Name = "Mascota", HeaderText = "Paciente (Mascota)", FillWeight = 90, MinimumWidth = 120 };
        var colCitaEspRaza = new DataGridViewTextBoxColumn { Name = "EspecieRaza", HeaderText = "Especie / Raza", FillWeight = 95, MinimumWidth = 120 };
        var colCitaDueno = new DataGridViewTextBoxColumn { Name = "Dueno", HeaderText = "Propietario", FillWeight = 110, MinimumWidth = 130 };
        var colCitaTel = new DataGridViewTextBoxColumn { Name = "Telefono", HeaderText = "Teléfono", FillWeight = 75, MinimumWidth = 95 };
        var colCitaMotivo = new DataGridViewTextBoxColumn { Name = "Motivo", HeaderText = "Motivo de Consulta", FillWeight = 140, MinimumWidth = 150 };
        var colCitaEstado = new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado", FillWeight = 60, MinimumWidth = 75 };

        dgvPacientesEspera.Columns.AddRange(colCitaId, colCitaHora, colCitaMascota, colCitaEspRaza, colCitaDueno, colCitaTel, colCitaMotivo, colCitaEstado);
        dgvPacientesEspera.RowTemplate.Height = 32;
        EstilarTabla(dgvPacientesEspera);

        // Columnas para historial clínico: amplias, legibles y adaptativas
        dgvHistorial.Columns.Clear();
        var colFecha = new DataGridViewTextBoxColumn { Name = "Fecha", HeaderText = "Fecha Consulta", FillWeight = 75, MinimumWidth = 115 };
        var colPeso = new DataGridViewTextBoxColumn { Name = "Peso", HeaderText = "Peso", FillWeight = 45, MinimumWidth = 65 };
        var colTemp = new DataGridViewTextBoxColumn { Name = "Temperatura", HeaderText = "Temp.", FillWeight = 45, MinimumWidth = 65 };
        var colDiag = new DataGridViewTextBoxColumn { Name = "Diagnostico", HeaderText = "Diagnóstico Médico", FillWeight = 135, MinimumWidth = 150 };
        var colTrat = new DataGridViewTextBoxColumn { Name = "Tratamiento", HeaderText = "Tratamiento / Receta Prescrita", FillWeight = 155, MinimumWidth = 180 };
        var colObs = new DataGridViewTextBoxColumn { Name = "Observaciones", HeaderText = "Observaciones Médicas", FillWeight = 100, MinimumWidth = 120 };

        dgvHistorial.Columns.AddRange(colFecha, colPeso, colTemp, colDiag, colTrat, colObs);
        dgvHistorial.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        dgvHistorial.RowTemplate.Height = 36;
        dgvHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        EstilarTabla(dgvHistorial);
    }

    // 1. Filtrar y cargar en dgvPacientesEspera las citas con estado "Pendiente"
    public void CargarPacientesEnEspera()
    {
        if (dgvPacientesEspera == null || dgvPacientesEspera.Columns.Count == 0) return;
        dgvPacientesEspera.Rows.Clear();

        try
        {
            var citasPendientes = _citaNegocio.ObtenerCitasPendientes();
            var mascotas = _mascotaNegocio.ObtenerMascotas();
            var clientes = _clienteNegocio.ObtenerClientes();

            foreach (var cita in citasPendientes)
            {
                var mascota = mascotas.FirstOrDefault(m => m.IdMascota == cita.IdMascota);
                string nombreMascota = mascota != null ? mascota.Nombre : $"ID #{cita.IdMascota}";
                string especieRaza = mascota != null ? $"{mascota.Especie} ({mascota.Raza})" : "N/D";
                string nombreDueno = "N/D";
                string telDueno = "N/D";

                if (mascota != null)
                {
                    var dueno = clientes.FirstOrDefault(c => c.Cedula.Trim().Equals(mascota.CedulaCliente.Trim(), StringComparison.OrdinalIgnoreCase));
                    if (dueno != null)
                    {
                        nombreDueno = $"{dueno.Nombres} {dueno.Apellidos}";
                        telDueno = dueno.Telefono;
                    }
                }

                dgvPacientesEspera.Rows.Add(
                    cita.IdCita,
                    cita.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    nombreMascota,
                    especieRaza,
                    nombreDueno,
                    telDueno,
                    cita.Motivo,
                    cita.Estado
                );
            }

            if (citasPendientes.Count == 0)
            {
                lblInfoPaciente.Text = "No hay pacientes en espera en este momento.";
                dgvHistorial.Rows.Clear();
                _citaSeleccionada = null;
                _mascotaSeleccionada = null;
                _duenoSeleccionado = null;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar pacientes en espera desde la base de datos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // 2. dgvPacientesEspera_CellClick: Seleccionar paciente y listar su historial clínico previo
    private void dgvPacientesEspera_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvPacientesEspera.Rows.Count) return;

        var fila = dgvPacientesEspera.Rows[e.RowIndex];
        if (!int.TryParse(fila.Cells["IdCita"].Value?.ToString(), out int idCita)) return;

        _citaSeleccionada = _citaNegocio.ObtenerCitas().FirstOrDefault(c => c.IdCita == idCita);
        if (_citaSeleccionada == null) return;

        _mascotaSeleccionada = _mascotaNegocio.ObtenerMascotas().FirstOrDefault(m => m.IdMascota == _citaSeleccionada.IdMascota);
        _duenoSeleccionado = _mascotaSeleccionada != null
            ? _clienteNegocio.ObtenerClientes().FirstOrDefault(c => c.Cedula.Trim().Equals(_mascotaSeleccionada.CedulaCliente.Trim(), StringComparison.OrdinalIgnoreCase))
            : null;

        if (_mascotaSeleccionada != null)
        {
            string duenoInfo = _duenoSeleccionado != null ? $"{_duenoSeleccionado.Nombres} {_duenoSeleccionado.Apellidos} (Tel: {_duenoSeleccionado.Telefono})" : "Sin dueño";
            lblInfoPaciente.Text = $"Paciente Seleccionado: {_mascotaSeleccionada.Nombre} ({_mascotaSeleccionada.Especie} - {_mascotaSeleccionada.Raza} - {_mascotaSeleccionada.Sexo}) | Dueño: {duenoInfo} | Motivo: {_citaSeleccionada.Motivo}";

            CargarHistorialClinico(_mascotaSeleccionada.IdMascota);
        }
    }

    private void CargarHistorialClinico(int idMascota)
    {
        if (dgvHistorial == null || dgvHistorial.Columns.Count == 0) return;
        dgvHistorial.Rows.Clear();

        try
        {
            var historial = _historialNegocio.ObtenerHistorialPorMascota(idMascota);

            foreach (var h in historial)
            {
                dgvHistorial.Rows.Add(
                    h.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    h.Peso > 0 ? $"{h.Peso:0.0} kg" : "N/D",
                    "-",
                    h.Diagnostico,
                    h.Tratamiento,
                    "-"
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar historial clínico: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // 3. btnGuardarConsulta_Click: Validar diagnóstico y tratamiento obligatorios, registrar atención, actualizar cita a "Atendida"
    private void btnGuardarConsulta_Click(object sender, EventArgs e)
    {
        if (_mascotaSeleccionada == null || _citaSeleccionada == null)
        {
            MessageBox.Show("Por favor seleccione un paciente de la lista de espera para atender su consulta.", "Paciente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
        {
            MessageBox.Show("El diagnóstico médico es un campo obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDiagnostico.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtTratamiento.Text))
        {
            MessageBox.Show("El tratamiento y receta médica es un campo obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTratamiento.Focus();
            return;
        }

        decimal peso = 0;
        if (!string.IsNullOrWhiteSpace(txtPeso.Text))
        {
            decimal.TryParse(txtPeso.Text.Trim().Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out peso);
        }

        string tratamientoCompleto = txtTratamiento.Text.Trim();
        if (!string.IsNullOrWhiteSpace(txtObservaciones.Text))
        {
            tratamientoCompleto += $"\n[Obs: {txtObservaciones.Text.Trim()}]";
        }
        if (!string.IsNullOrWhiteSpace(txtTemperatura.Text))
        {
            tratamientoCompleto += $" [Temp: {txtTemperatura.Text.Trim()}°C]";
        }

        var nuevoHistorial = new HistorialClinico(
            0,
            DateTime.Now,
            peso,
            txtDiagnostico.Text.Trim(),
            tratamientoCompleto,
            _mascotaSeleccionada.IdMascota,
            1
        );

        if (!_historialNegocio.RegistrarAtencion(nuevoHistorial, out string mensajeErr))
        {
            MessageBox.Show(mensajeErr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Cambiar estado de la cita a "ATENDIDA" en la base de datos
        _citaNegocio.AtenderCita(_citaSeleccionada.IdCita, out _);

        int idMascotaAtendida = _mascotaSeleccionada.IdMascota;
        CargarPacientesEnEspera();
        CargarHistorialClinico(idMascotaAtendida);

        LimpiarCamposConsulta();

        MessageBox.Show($"Atención médica guardada con éxito en la base de datos.\nLa cita fue actualizada a estado 'ATENDIDA'.", "Consulta Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LimpiarCamposConsulta()
    {
        txtPeso.Clear();
        txtTemperatura.Clear();
        txtDiagnostico.Clear();
        txtTratamiento.Clear();
        txtObservaciones.Clear();
        txtDiagnostico.Focus();
    }

    private void btnLimpiarCampos_Click(object sender, EventArgs e)
    {
        LimpiarCamposConsulta();
    }

    private void btnImprimirHistorial_Click(object sender, EventArgs e)
    {
        if (_mascotaSeleccionada == null)
        {
            MessageBox.Show("Por favor seleccione un paciente para imprimir su reporte e historial médico.", "Paciente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var printDoc = new PrintDocument();
        printDoc.DocumentName = $"Reporte_Medico_{_mascotaSeleccionada.Nombre}";
        printDoc.PrintPage += ImprimirHistorialMedico_PrintPage;

        using var previewDialog = new PrintPreviewDialog
        {
            Document = printDoc,
            Width = 950,
            Height = 720,
            StartPosition = FormStartPosition.CenterScreen
        };

        previewDialog.ShowDialog();
    }

    private void ImprimirHistorialMedico_PrintPage(object sender, PrintPageEventArgs e)
    {
        if (_mascotaSeleccionada == null || e.Graphics == null) return;

        Graphics g = e.Graphics;
        var mascota = _mascotaSeleccionada;
        var dueno = _duenoSeleccionado ?? _clienteNegocio.ObtenerClientes().FirstOrDefault(c => c.Cedula.Trim().Equals(mascota.CedulaCliente.Trim(), StringComparison.OrdinalIgnoreCase));
        var historial = _historialNegocio.ObtenerHistorialPorMascota(mascota.IdMascota);

        // Tipografías con liberación adecuada de recursos
        using var fontTitulo = new Font("Segoe UI", 18, FontStyle.Bold);
        using var fontSubtitulo = new Font("Segoe UI", 11, FontStyle.Regular);
        using var fontSeccion = new Font("Segoe UI", 12, FontStyle.Bold);
        using var fontNegrita = new Font("Segoe UI", 10, FontStyle.Bold);
        using var fontTexto = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        using var fontPequena = new Font("Segoe UI", 8.5f, FontStyle.Italic);

        Color moradoOscuro = Color.FromArgb(64, 24, 80);
        using var brushTitulo = new SolidBrush(moradoOscuro);
        using var brushFondoFicha = new SolidBrush(Color.FromArgb(253, 250, 255));
        using var brushFondoReceta = new SolidBrush(Color.White);
        using var brushFondoHeaderTabla = new SolidBrush(moradoOscuro);
        using var penSeparador = new Pen(moradoOscuro, 2);
        using var penFicha = new Pen(moradoOscuro, 1);
        using var penCaja = new Pen(Color.FromArgb(220, 210, 230), 1);

        Brush brushTexto = Brushes.Black;

        int x = 60;
        int y = 50;
        int anchoContenido = e.PageBounds.Width - (x * 2);

        // MEMBRETE DE LA CLÍNICA
        g.DrawString("CLÍNICA VETERINARIA", fontTitulo, brushTitulo, x, y);
        y += 32;
        g.DrawString("HISTORIAL CLÍNICO Y REPORTE MÉDICO VETERINARIO", fontSubtitulo, Brushes.DimGray, x, y);
        y += 22;
        g.DrawString($"Fecha de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm}   |   Dr. Veterinario en Turno: M.V.Z. Clínica Central", fontPequena, Brushes.DimGray, x, y);
        y += 25;

        g.DrawLine(penSeparador, x, y, x + anchoContenido, y);
        y += 15;

        // FICHA TÉCNICA DEL PACIENTE
        g.FillRectangle(brushFondoFicha, x, y, anchoContenido, 100);
        g.DrawRectangle(penFicha, x, y, anchoContenido, 100);
        g.DrawString("FICHA TÉCNICA DEL PACIENTE", fontNegrita, brushTitulo, x + 15, y + 8);

        // Cálculo de edad aproximada
        string edadTexto = "Menor de 1 año";
        if (mascota.FechaNacimiento != DateTime.MinValue)
        {
            int anos = DateTime.Now.Year - mascota.FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < mascota.FechaNacimiento.DayOfYear) anos--;
            edadTexto = anos > 0 ? $"{anos} año(s)" : "Menor de 1 año";
        }

        g.DrawString($"Nombre del Paciente: {mascota.Nombre} ({mascota.Sexo})", fontNegrita, brushTexto, x + 15, y + 32);
        g.DrawString($"Especie: {mascota.Especie}", fontTexto, brushTexto, x + 350, y + 32);
        g.DrawString($"Raza: {mascota.Raza}", fontTexto, brushTexto, x + 15, y + 54);
        string fechaNacStr = mascota.FechaNacimiento != DateTime.MinValue ? mascota.FechaNacimiento.ToString("dd/MM/yyyy") : "N/D";
        g.DrawString($"Edad Aprox.: {edadTexto} (Nac: {fechaNacStr})", fontTexto, brushTexto, x + 350, y + 54);

        string nomDueno = dueno != null ? $"{dueno.Nombres} {dueno.Apellidos}" : "N/D";
        string telDueno = dueno != null ? dueno.Telefono : "N/D";
        string cedDueno = dueno != null ? dueno.Cedula : "N/D";
        g.DrawString($"Propietario: {nomDueno}  |  Cédula: {cedDueno}  |  Tel: {telDueno}", fontTexto, brushTexto, x + 15, y + 76);
        y += 120;

        // ÚLTIMO TRATAMIENTO / RECETA ACTUAL (si hay texto en pantalla o última consulta)
        string diagActual = !string.IsNullOrWhiteSpace(txtDiagnostico.Text) ? txtDiagnostico.Text.Trim() : (historial.FirstOrDefault()?.Diagnostico ?? "Sin registro");
        string tratActual = !string.IsNullOrWhiteSpace(txtTratamiento.Text) ? txtTratamiento.Text.Trim() : (historial.FirstOrDefault()?.Tratamiento ?? "Sin registro");
        string obsActual = !string.IsNullOrWhiteSpace(txtObservaciones.Text) ? txtObservaciones.Text.Trim() : "Ninguna";

        g.DrawString("TRATAMIENTO Y PRESCRIPCIÓN MÉDICA ACTUAL", fontSeccion, brushTitulo, x, y);
        y += 24;

        g.FillRectangle(brushFondoReceta, x, y, anchoContenido, 130);
        g.DrawRectangle(penCaja, x, y, anchoContenido, 130);

        g.DrawString($"• Diagnóstico: {diagActual}", fontNegrita, brushTexto, x + 12, y + 10);
        g.DrawString("• Tratamiento / Receta:", fontNegrita, brushTexto, x + 12, y + 35);
        g.DrawString(tratActual, fontTexto, brushTexto, new RectangleF(x + 25, y + 55, anchoContenido - 40, 45));
        g.DrawString($"• Observaciones: {obsActual}", fontPequena, Brushes.DimGray, x + 12, y + 105);
        y += 150;

        // HISTORIAL CRONOLÓGICO DE CONSULTAS PREVIAS
        g.DrawString("HISTORIAL CRONOLÓGICO DE ATENCIONES", fontSeccion, brushTitulo, x, y);
        y += 24;

        // Encabezado de tabla
        g.FillRectangle(brushFondoHeaderTabla, x, y, anchoContenido, 25);
        g.DrawString("Fecha", fontNegrita, Brushes.White, x + 10, y + 4);
        g.DrawString("Peso", fontNegrita, Brushes.White, x + 95, y + 4);
        g.DrawString("Diagnóstico", fontNegrita, Brushes.White, x + 175, y + 4);
        g.DrawString("Tratamiento Prescrito", fontNegrita, Brushes.White, x + 400, y + 4);
        y += 25;

        if (historial.Count == 0)
        {
            g.DrawString("No registra consultas previas en el sistema.", fontPequena, Brushes.DimGray, x + 10, y + 10);
            y += 35;
        }
        else
        {
            int limiteHistorial = Math.Min(historial.Count, 5);
            for (int i = 0; i < limiteHistorial; i++)
            {
                var reg = historial[i];
                Color fondoFila = (i % 2 == 0) ? Color.White : Color.FromArgb(252, 250, 254);
                using var brushFila = new SolidBrush(fondoFila);
                g.FillRectangle(brushFila, x, y, anchoContenido, 36);
                g.DrawRectangle(penCaja, x, y, anchoContenido, 36);

                g.DrawString(reg.Fecha.ToString("dd/MM/yyyy"), fontTexto, brushTexto, x + 10, y + 8);
                g.DrawString(reg.Peso > 0 ? $"{reg.Peso:0.0} kg" : "-", fontTexto, brushTexto, x + 95, y + 8);

                string diagCorto = reg.Diagnostico.Length > 28 ? reg.Diagnostico[..25] + "..." : reg.Diagnostico;
                g.DrawString(diagCorto, fontTexto, brushTexto, x + 175, y + 8);

                string tratCorto = reg.Tratamiento.Length > 38 ? reg.Tratamiento[..35] + "..." : reg.Tratamiento;
                g.DrawString(tratCorto, fontTexto, brushTexto, x + 400, y + 8);

                y += 36;
            }
        }

        // ESPACIO PARA FIRMA DEL VETERINARIO
        y = Math.Max(y + 35, e.PageBounds.Height - 160);
        g.DrawLine(penCaja, x + 380, y, x + anchoContenido - 30, y);
        y += 8;
        g.DrawString("Firma y Sello del Médico Veterinario", fontNegrita, brushTitulo, x + 410, y);
        y += 18;
        g.DrawString("Registro Profesional Veterinario N° 09-8472", fontPequena, Brushes.DimGray, x + 415, y);
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
