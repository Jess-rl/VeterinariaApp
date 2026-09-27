namespace Veterinaria.U;

partial class FormVeterinario
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnVolverVet = new System.Windows.Forms.Button();
        lblBuscarMascota = new System.Windows.Forms.Label();
        txtBuscarMascota = new System.Windows.Forms.TextBox();
        btnBuscarMascota = new System.Windows.Forms.Button();
        dgvMascotas = new System.Windows.Forms.DataGridView();
        lblTituloConsulta = new System.Windows.Forms.Label();
        lblInfoMascota = new System.Windows.Forms.Label();
        lblPeso = new System.Windows.Forms.Label();
        txtPeso = new System.Windows.Forms.TextBox();
        lblDiagnostico = new System.Windows.Forms.Label();
        txtDiagnostico = new System.Windows.Forms.TextBox();
        lblTratamiento = new System.Windows.Forms.Label();
        txtTratamiento = new System.Windows.Forms.TextBox();
        btnGuardarConsulta = new System.Windows.Forms.Button();
        btnLimpiarConsulta = new System.Windows.Forms.Button();
        lblTituloHistorial = new System.Windows.Forms.Label();
        dgvHistorial = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
        SuspendLayout();
        // 
        // btnVolverVet
        // 
        btnVolverVet.Location = new System.Drawing.Point(15, 15);
        btnVolverVet.Name = "btnVolverVet";
        btnVolverVet.Size = new System.Drawing.Size(160, 32);
        btnVolverVet.TabIndex = 0;
        btnVolverVet.Text = "← Volver al Inicio";
        btnVolverVet.UseVisualStyleBackColor = true;
        // 
        // lblBuscarMascota
        // 
        lblBuscarMascota.Location = new System.Drawing.Point(200, 20);
        lblBuscarMascota.Name = "lblBuscarMascota";
        lblBuscarMascota.Size = new System.Drawing.Size(230, 20);
        lblBuscarMascota.TabIndex = 1;
        lblBuscarMascota.Text = "Buscar Mascota (Nombre o ID):";
        // 
        // txtBuscarMascota
        // 
        txtBuscarMascota.Location = new System.Drawing.Point(435, 17);
        txtBuscarMascota.Name = "txtBuscarMascota";
        txtBuscarMascota.Size = new System.Drawing.Size(320, 27);
        txtBuscarMascota.TabIndex = 2;
        // 
        // btnBuscarMascota
        // 
        btnBuscarMascota.Location = new System.Drawing.Point(765, 15);
        btnBuscarMascota.Name = "btnBuscarMascota";
        btnBuscarMascota.Size = new System.Drawing.Size(100, 31);
        btnBuscarMascota.TabIndex = 3;
        btnBuscarMascota.Text = "Buscar";
        btnBuscarMascota.UseVisualStyleBackColor = true;
        // 
        // dgvMascotas
        // 
        dgvMascotas.AllowUserToAddRows = false;
        dgvMascotas.AllowUserToDeleteRows = false;
        dgvMascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMascotas.Location = new System.Drawing.Point(15, 58);
        dgvMascotas.Name = "dgvMascotas";
        dgvMascotas.ReadOnly = true;
        dgvMascotas.RowHeadersVisible = false;
        dgvMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvMascotas.Size = new System.Drawing.Size(990, 165);
        dgvMascotas.TabIndex = 4;
        // 
        // lblTituloConsulta
        // 
        lblTituloConsulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblTituloConsulta.Location = new System.Drawing.Point(15, 240);
        lblTituloConsulta.Name = "lblTituloConsulta";
        lblTituloConsulta.Size = new System.Drawing.Size(470, 25);
        lblTituloConsulta.TabIndex = 5;
        lblTituloConsulta.Text = "CONSULTA MÉDICA ACTUAL";
        // 
        // lblInfoMascota
        // 
        lblInfoMascota.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblInfoMascota.Location = new System.Drawing.Point(15, 273);
        lblInfoMascota.Name = "lblInfoMascota";
        lblInfoMascota.Size = new System.Drawing.Size(470, 22);
        lblInfoMascota.TabIndex = 6;
        lblInfoMascota.Text = "Paciente: Ninguno seleccionado";
        // 
        // lblPeso
        // 
        lblPeso.Location = new System.Drawing.Point(15, 305);
        lblPeso.Name = "lblPeso";
        lblPeso.Size = new System.Drawing.Size(150, 20);
        lblPeso.TabIndex = 7;
        lblPeso.Text = "Peso actual (kg):";
        // 
        // txtPeso
        // 
        txtPeso.Location = new System.Drawing.Point(15, 327);
        txtPeso.Name = "txtPeso";
        txtPeso.Size = new System.Drawing.Size(470, 27);
        txtPeso.TabIndex = 8;
        // 
        // lblDiagnostico
        // 
        lblDiagnostico.Location = new System.Drawing.Point(15, 365);
        lblDiagnostico.Name = "lblDiagnostico";
        lblDiagnostico.Size = new System.Drawing.Size(150, 20);
        lblDiagnostico.TabIndex = 9;
        lblDiagnostico.Text = "Diagnóstico:";
        // 
        // txtDiagnostico
        // 
        txtDiagnostico.Location = new System.Drawing.Point(15, 387);
        txtDiagnostico.Multiline = true;
        txtDiagnostico.Name = "txtDiagnostico";
        txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtDiagnostico.Size = new System.Drawing.Size(470, 75);
        txtDiagnostico.TabIndex = 10;
        // 
        // lblTratamiento
        // 
        lblTratamiento.Location = new System.Drawing.Point(15, 472);
        lblTratamiento.Name = "lblTratamiento";
        lblTratamiento.Size = new System.Drawing.Size(180, 20);
        lblTratamiento.TabIndex = 11;
        lblTratamiento.Text = "Tratamiento / Receta:";
        // 
        // txtTratamiento
        // 
        txtTratamiento.Location = new System.Drawing.Point(15, 494);
        txtTratamiento.Multiline = true;
        txtTratamiento.Name = "txtTratamiento";
        txtTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtTratamiento.Size = new System.Drawing.Size(470, 75);
        txtTratamiento.TabIndex = 12;
        // 
        // btnGuardarConsulta
        // 
        btnGuardarConsulta.Location = new System.Drawing.Point(15, 590);
        btnGuardarConsulta.Name = "btnGuardarConsulta";
        btnGuardarConsulta.Size = new System.Drawing.Size(225, 38);
        btnGuardarConsulta.TabIndex = 13;
        btnGuardarConsulta.Text = "Guardar Consulta";
        btnGuardarConsulta.UseVisualStyleBackColor = true;
        // 
        // btnLimpiarConsulta
        // 
        btnLimpiarConsulta.Location = new System.Drawing.Point(260, 590);
        btnLimpiarConsulta.Name = "btnLimpiarConsulta";
        btnLimpiarConsulta.Size = new System.Drawing.Size(225, 38);
        btnLimpiarConsulta.TabIndex = 14;
        btnLimpiarConsulta.Text = "Limpiar";
        btnLimpiarConsulta.UseVisualStyleBackColor = true;
        // 
        // lblTituloHistorial
        // 
        lblTituloHistorial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblTituloHistorial.Location = new System.Drawing.Point(515, 240);
        lblTituloHistorial.Name = "lblTituloHistorial";
        lblTituloHistorial.Size = new System.Drawing.Size(490, 25);
        lblTituloHistorial.TabIndex = 15;
        lblTituloHistorial.Text = "HISTORIAL CLÍNICO PREVIO";
        // 
        // dgvHistorial
        // 
        dgvHistorial.AllowUserToAddRows = false;
        dgvHistorial.AllowUserToDeleteRows = false;
        dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvHistorial.Location = new System.Drawing.Point(515, 273);
        dgvHistorial.Name = "dgvHistorial";
        dgvHistorial.ReadOnly = true;
        dgvHistorial.RowHeadersVisible = false;
        dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvHistorial.Size = new System.Drawing.Size(490, 355);
        dgvHistorial.TabIndex = 16;
        // 
        // FormVeterinario
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1020, 650);
        Controls.Add(dgvHistorial);
        Controls.Add(lblTituloHistorial);
        Controls.Add(btnLimpiarConsulta);
        Controls.Add(btnGuardarConsulta);
        Controls.Add(txtTratamiento);
        Controls.Add(lblTratamiento);
        Controls.Add(txtDiagnostico);
        Controls.Add(lblDiagnostico);
        Controls.Add(txtPeso);
        Controls.Add(lblPeso);
        Controls.Add(lblInfoMascota);
        Controls.Add(lblTituloConsulta);
        Controls.Add(dgvMascotas);
        Controls.Add(btnBuscarMascota);
        Controls.Add(txtBuscarMascota);
        Controls.Add(lblBuscarMascota);
        Controls.Add(btnVolverVet);
        Name = "FormVeterinario";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Atención Veterinaria";
        ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    // Cabecera y Búsqueda
    private System.Windows.Forms.Button btnVolverVet;
    private System.Windows.Forms.Label lblBuscarMascota;
    private System.Windows.Forms.TextBox txtBuscarMascota;
    private System.Windows.Forms.Button btnBuscarMascota;
    private System.Windows.Forms.DataGridView dgvMascotas;

    // Panel de Consulta Actual
    private System.Windows.Forms.Label lblTituloConsulta;
    private System.Windows.Forms.Label lblInfoMascota;
    private System.Windows.Forms.Label lblPeso;
    private System.Windows.Forms.TextBox txtPeso;
    private System.Windows.Forms.Label lblDiagnostico;
    private System.Windows.Forms.TextBox txtDiagnostico;
    private System.Windows.Forms.Label lblTratamiento;
    private System.Windows.Forms.TextBox txtTratamiento;
    private System.Windows.Forms.Button btnGuardarConsulta;
    private System.Windows.Forms.Button btnLimpiarConsulta;

    // Panel de Historial Clínico
    private System.Windows.Forms.Label lblTituloHistorial;
    private System.Windows.Forms.DataGridView dgvHistorial;
}
