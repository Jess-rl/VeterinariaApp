namespace Veterinaria.UI;

partial class FormVeterinario
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        btnVolver = new System.Windows.Forms.Button();
        lblTituloForm = new System.Windows.Forms.Label();
        grpPacientesEspera = new System.Windows.Forms.GroupBox();
        dgvPacientesEspera = new System.Windows.Forms.DataGridView();
        lblInfoPaciente = new System.Windows.Forms.Label();
        grpAtencion = new System.Windows.Forms.GroupBox();
        lblPeso = new System.Windows.Forms.Label();
        txtPeso = new System.Windows.Forms.TextBox();
        lblTemperatura = new System.Windows.Forms.Label();
        txtTemperatura = new System.Windows.Forms.TextBox();
        lblDiagnostico = new System.Windows.Forms.Label();
        txtDiagnostico = new System.Windows.Forms.TextBox();
        lblTratamiento = new System.Windows.Forms.Label();
        txtTratamiento = new System.Windows.Forms.TextBox();
        lblObservaciones = new System.Windows.Forms.Label();
        txtObservaciones = new System.Windows.Forms.TextBox();
        btnGuardarConsulta = new System.Windows.Forms.Button();
        btnImprimirHistorial = new System.Windows.Forms.Button();
        btnLimpiarCampos = new System.Windows.Forms.Button();
        grpHistorial = new System.Windows.Forms.GroupBox();
        dgvHistorial = new System.Windows.Forms.DataGridView();
        grpPacientesEspera.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPacientesEspera).BeginInit();
        grpAtencion.SuspendLayout();
        grpHistorial.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
        SuspendLayout();
        // 
        // btnVolver
        // 
        btnVolver.BackColor = System.Drawing.Color.White;
        btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnVolver.FlatAppearance.BorderSize = 1;
        btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnVolver.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnVolver.Location = new System.Drawing.Point(25, 15);
        btnVolver.Name = "btnVolver";
        btnVolver.Size = new System.Drawing.Size(160, 38);
        btnVolver.TabIndex = 0;
        btnVolver.Text = "← Menú Principal";
        btnVolver.UseVisualStyleBackColor = false;
        btnVolver.Click += btnVolver_Click;
        // 
        // lblTituloForm
        // 
        lblTituloForm.AutoSize = true;
        lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblTituloForm.Location = new System.Drawing.Point(205, 16);
        lblTituloForm.Name = "lblTituloForm";
        lblTituloForm.Size = new System.Drawing.Size(760, 35);
        lblTituloForm.TabIndex = 1;
        lblTituloForm.Text = "CLÍNICA VETERINARIA — ATENCIÓN MÉDICA VETERINARIA";
        // 
        // grpPacientesEspera
        // 
        grpPacientesEspera.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        grpPacientesEspera.Controls.Add(dgvPacientesEspera);
        grpPacientesEspera.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        grpPacientesEspera.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        grpPacientesEspera.Location = new System.Drawing.Point(25, 60);
        grpPacientesEspera.Name = "grpPacientesEspera";
        grpPacientesEspera.Size = new System.Drawing.Size(1210, 190);
        grpPacientesEspera.TabIndex = 2;
        grpPacientesEspera.TabStop = false;
        grpPacientesEspera.Text = "Pacientes en Sala de Espera (Citas Pendientes)";
        // 
        // dgvPacientesEspera
        // 
        dgvPacientesEspera.AllowUserToAddRows = false;
        dgvPacientesEspera.AllowUserToDeleteRows = false;
        dgvPacientesEspera.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvPacientesEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvPacientesEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPacientesEspera.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dgvPacientesEspera.Location = new System.Drawing.Point(15, 28);
        dgvPacientesEspera.MultiSelect = false;
        dgvPacientesEspera.Name = "dgvPacientesEspera";
        dgvPacientesEspera.ReadOnly = true;
        dgvPacientesEspera.RowHeadersVisible = false;
        dgvPacientesEspera.RowHeadersWidth = 51;
        dgvPacientesEspera.RowTemplate.Height = 32;
        dgvPacientesEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvPacientesEspera.Size = new System.Drawing.Size(1180, 150);
        dgvPacientesEspera.TabIndex = 0;
        dgvPacientesEspera.CellClick += dgvPacientesEspera_CellClick;
        // 
        // lblInfoPaciente
        // 
        lblInfoPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        lblInfoPaciente.BackColor = System.Drawing.Color.FromArgb(252, 250, 254);
        lblInfoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        lblInfoPaciente.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblInfoPaciente.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblInfoPaciente.Location = new System.Drawing.Point(25, 260);
        lblInfoPaciente.Name = "lblInfoPaciente";
        lblInfoPaciente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        lblInfoPaciente.Size = new System.Drawing.Size(1210, 38);
        lblInfoPaciente.TabIndex = 3;
        lblInfoPaciente.Text = "Paciente seleccionado: Ninguno (Haga clic en una cita pendiente en la tabla superior)";
        lblInfoPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // grpAtencion
        // 
        grpAtencion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        grpAtencion.Controls.Add(lblPeso);
        grpAtencion.Controls.Add(txtPeso);
        grpAtencion.Controls.Add(lblTemperatura);
        grpAtencion.Controls.Add(txtTemperatura);
        grpAtencion.Controls.Add(lblDiagnostico);
        grpAtencion.Controls.Add(txtDiagnostico);
        grpAtencion.Controls.Add(lblTratamiento);
        grpAtencion.Controls.Add(txtTratamiento);
        grpAtencion.Controls.Add(lblObservaciones);
        grpAtencion.Controls.Add(txtObservaciones);
        grpAtencion.Controls.Add(btnGuardarConsulta);
        grpAtencion.Controls.Add(btnImprimirHistorial);
        grpAtencion.Controls.Add(btnLimpiarCampos);
        grpAtencion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        grpAtencion.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        grpAtencion.Location = new System.Drawing.Point(25, 308);
        grpAtencion.Name = "grpAtencion";
        grpAtencion.Size = new System.Drawing.Size(470, 512);
        grpAtencion.TabIndex = 4;
        grpAtencion.TabStop = false;
        grpAtencion.Text = "Panel de Consulta Médica Actual";
        // 
        // lblPeso
        // 
        lblPeso.AutoSize = true;
        lblPeso.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblPeso.ForeColor = System.Drawing.Color.Black;
        lblPeso.Location = new System.Drawing.Point(20, 32);
        lblPeso.Name = "lblPeso";
        lblPeso.Size = new System.Drawing.Size(75, 21);
        lblPeso.TabIndex = 0;
        lblPeso.Text = "Peso (kg):";
        // 
        // txtPeso
        // 
        txtPeso.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtPeso.Location = new System.Drawing.Point(100, 28);
        txtPeso.Name = "txtPeso";
        txtPeso.Size = new System.Drawing.Size(100, 30);
        txtPeso.TabIndex = 1;
        // 
        // lblTemperatura
        // 
        lblTemperatura.AutoSize = true;
        lblTemperatura.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTemperatura.ForeColor = System.Drawing.Color.Black;
        lblTemperatura.Location = new System.Drawing.Point(225, 32);
        lblTemperatura.Name = "lblTemperatura";
        lblTemperatura.Size = new System.Drawing.Size(80, 21);
        lblTemperatura.TabIndex = 2;
        lblTemperatura.Text = "Temp (°C):";
        // 
        // txtTemperatura
        // 
        txtTemperatura.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtTemperatura.Location = new System.Drawing.Point(310, 28);
        txtTemperatura.Name = "txtTemperatura";
        txtTemperatura.Size = new System.Drawing.Size(100, 30);
        txtTemperatura.TabIndex = 3;
        // 
        // lblDiagnostico
        // 
        lblDiagnostico.AutoSize = true;
        lblDiagnostico.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblDiagnostico.ForeColor = System.Drawing.Color.Black;
        lblDiagnostico.Location = new System.Drawing.Point(20, 68);
        lblDiagnostico.Name = "lblDiagnostico";
        lblDiagnostico.Size = new System.Drawing.Size(206, 21);
        lblDiagnostico.TabIndex = 4;
        lblDiagnostico.Text = "Diagnóstico (Obligatorio):";
        // 
        // txtDiagnostico
        // 
        txtDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtDiagnostico.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtDiagnostico.Location = new System.Drawing.Point(20, 92);
        txtDiagnostico.Multiline = true;
        txtDiagnostico.Name = "txtDiagnostico";
        txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtDiagnostico.Size = new System.Drawing.Size(430, 90);
        txtDiagnostico.TabIndex = 5;
        // 
        // lblTratamiento
        // 
        lblTratamiento.AutoSize = true;
        lblTratamiento.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblTratamiento.ForeColor = System.Drawing.Color.Black;
        lblTratamiento.Location = new System.Drawing.Point(20, 190);
        lblTratamiento.Name = "lblTratamiento";
        lblTratamiento.Size = new System.Drawing.Size(273, 21);
        lblTratamiento.TabIndex = 6;
        lblTratamiento.Text = "Tratamiento / Receta (Obligatorio):";
        // 
        // txtTratamiento
        // 
        txtTratamiento.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtTratamiento.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtTratamiento.Location = new System.Drawing.Point(20, 214);
        txtTratamiento.Multiline = true;
        txtTratamiento.Name = "txtTratamiento";
        txtTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtTratamiento.Size = new System.Drawing.Size(430, 90);
        txtTratamiento.TabIndex = 7;
        // 
        // lblObservaciones
        // 
        lblObservaciones.AutoSize = true;
        lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblObservaciones.ForeColor = System.Drawing.Color.Black;
        lblObservaciones.Location = new System.Drawing.Point(20, 312);
        lblObservaciones.Name = "lblObservaciones";
        lblObservaciones.Size = new System.Drawing.Size(193, 21);
        lblObservaciones.TabIndex = 8;
        lblObservaciones.Text = "Observaciones Adicionales:";
        // 
        // txtObservaciones
        // 
        txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtObservaciones.Location = new System.Drawing.Point(20, 336);
        txtObservaciones.Multiline = true;
        txtObservaciones.Name = "txtObservaciones";
        txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtObservaciones.Size = new System.Drawing.Size(430, 95);
        txtObservaciones.TabIndex = 9;
        // 
        // btnGuardarConsulta
        // 
        btnGuardarConsulta.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        btnGuardarConsulta.BackColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnGuardarConsulta.FlatAppearance.BorderSize = 0;
        btnGuardarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnGuardarConsulta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnGuardarConsulta.ForeColor = System.Drawing.Color.White;
        btnGuardarConsulta.Location = new System.Drawing.Point(20, 448);
        btnGuardarConsulta.Name = "btnGuardarConsulta";
        btnGuardarConsulta.Size = new System.Drawing.Size(135, 45);
        btnGuardarConsulta.TabIndex = 10;
        btnGuardarConsulta.Text = "Guardar";
        btnGuardarConsulta.UseVisualStyleBackColor = false;
        btnGuardarConsulta.Click += btnGuardarConsulta_Click;
        // 
        // btnImprimirHistorial
        // 
        btnImprimirHistorial.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        btnImprimirHistorial.BackColor = System.Drawing.Color.White;
        btnImprimirHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnImprimirHistorial.FlatAppearance.BorderSize = 1;
        btnImprimirHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnImprimirHistorial.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnImprimirHistorial.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnImprimirHistorial.Location = new System.Drawing.Point(165, 448);
        btnImprimirHistorial.Name = "btnImprimirHistorial";
        btnImprimirHistorial.Size = new System.Drawing.Size(165, 45);
        btnImprimirHistorial.TabIndex = 11;
        btnImprimirHistorial.Text = "🖨 Imprimir";
        btnImprimirHistorial.UseVisualStyleBackColor = false;
        btnImprimirHistorial.Click += btnImprimirHistorial_Click;
        // 
        // btnLimpiarCampos
        // 
        btnLimpiarCampos.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        btnLimpiarCampos.BackColor = System.Drawing.Color.White;
        btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnLimpiarCampos.FlatAppearance.BorderSize = 1;
        btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnLimpiarCampos.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnLimpiarCampos.Location = new System.Drawing.Point(340, 448);
        btnLimpiarCampos.Name = "btnLimpiarCampos";
        btnLimpiarCampos.Size = new System.Drawing.Size(110, 45);
        btnLimpiarCampos.TabIndex = 12;
        btnLimpiarCampos.Text = "Limpiar";
        btnLimpiarCampos.UseVisualStyleBackColor = false;
        btnLimpiarCampos.Click += btnLimpiarCampos_Click;
        // 
        // grpHistorial
        // 
        grpHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        grpHistorial.Controls.Add(dgvHistorial);
        grpHistorial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        grpHistorial.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        grpHistorial.Location = new System.Drawing.Point(510, 308);
        grpHistorial.Name = "grpHistorial";
        grpHistorial.Size = new System.Drawing.Size(725, 512);
        grpHistorial.TabIndex = 5;
        grpHistorial.TabStop = false;
        grpHistorial.Text = "Historial Clínico Previo del Paciente";
        // 
        // dgvHistorial
        // 
        dgvHistorial.AllowUserToAddRows = false;
        dgvHistorial.AllowUserToDeleteRows = false;
        dgvHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvHistorial.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dgvHistorial.Location = new System.Drawing.Point(15, 28);
        dgvHistorial.MultiSelect = false;
        dgvHistorial.Name = "dgvHistorial";
        dgvHistorial.ReadOnly = true;
        dgvHistorial.RowHeadersVisible = false;
        dgvHistorial.RowHeadersWidth = 51;
        dgvHistorial.RowTemplate.Height = 36;
        dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvHistorial.Size = new System.Drawing.Size(695, 468);
        dgvHistorial.TabIndex = 0;
        // 
        // FormVeterinario
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(1260, 840);
        Controls.Add(grpHistorial);
        Controls.Add(grpAtencion);
        Controls.Add(lblInfoPaciente);
        Controls.Add(grpPacientesEspera);
        Controls.Add(lblTituloForm);
        Controls.Add(btnVolver);
        Font = new System.Drawing.Font("Segoe UI", 9.5F);
        MinimumSize = new System.Drawing.Size(1150, 750);
        Name = "FormVeterinario";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Clínica Veterinaria - Atención Médica";
        Load += FormVeterinario_Load;
        grpPacientesEspera.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvPacientesEspera).EndInit();
        grpAtencion.ResumeLayout(false);
        grpAtencion.PerformLayout();
        grpHistorial.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button btnVolver;
    private System.Windows.Forms.Label lblTituloForm;
    private System.Windows.Forms.GroupBox grpPacientesEspera;
    private System.Windows.Forms.DataGridView dgvPacientesEspera;
    private System.Windows.Forms.Label lblInfoPaciente;
    private System.Windows.Forms.GroupBox grpAtencion;
    private System.Windows.Forms.Label lblPeso;
    private System.Windows.Forms.TextBox txtPeso;
    private System.Windows.Forms.Label lblTemperatura;
    private System.Windows.Forms.TextBox txtTemperatura;
    private System.Windows.Forms.Label lblDiagnostico;
    private System.Windows.Forms.TextBox txtDiagnostico;
    private System.Windows.Forms.Label lblTratamiento;
    private System.Windows.Forms.TextBox txtTratamiento;
    private System.Windows.Forms.Label lblObservaciones;
    private System.Windows.Forms.TextBox txtObservaciones;
    private System.Windows.Forms.Button btnGuardarConsulta;
    private System.Windows.Forms.Button btnImprimirHistorial;
    private System.Windows.Forms.Button btnLimpiarCampos;
    private System.Windows.Forms.GroupBox grpHistorial;
    private System.Windows.Forms.DataGridView dgvHistorial;
}
