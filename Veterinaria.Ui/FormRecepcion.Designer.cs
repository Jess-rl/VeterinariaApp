namespace Veterinaria.U;

partial class FormRecepcion
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
        btnVolver = new System.Windows.Forms.Button();
        tabRecepcion = new System.Windows.Forms.TabControl();
        tabClientes = new System.Windows.Forms.TabPage();
        lblTituloClientes = new System.Windows.Forms.Label();
        lblCedula = new System.Windows.Forms.Label();
        txtCedula = new System.Windows.Forms.TextBox();
        lblNombres = new System.Windows.Forms.Label();
        txtNombres = new System.Windows.Forms.TextBox();
        lblApellidos = new System.Windows.Forms.Label();
        txtApellidos = new System.Windows.Forms.TextBox();
        lblTelefono = new System.Windows.Forms.Label();
        txtTelefono = new System.Windows.Forms.TextBox();
        lblDireccion = new System.Windows.Forms.Label();
        txtDireccion = new System.Windows.Forms.TextBox();
        btnGuardarCliente = new System.Windows.Forms.Button();
        btnModificarCliente = new System.Windows.Forms.Button();
        btnEliminarCliente = new System.Windows.Forms.Button();
        btnLimpiarCliente = new System.Windows.Forms.Button();
        lblListaClientes = new System.Windows.Forms.Label();
        dgvClientes = new System.Windows.Forms.DataGridView();
        tabMascotas = new System.Windows.Forms.TabPage();
        lblTituloMascotas = new System.Windows.Forms.Label();
        lblCedulaDueno = new System.Windows.Forms.Label();
        txtCedulaDueno = new System.Windows.Forms.TextBox();
        lblNombreMascota = new System.Windows.Forms.Label();
        txtNombreMascota = new System.Windows.Forms.TextBox();
        lblEspecie = new System.Windows.Forms.Label();
        txtEspecie = new System.Windows.Forms.TextBox();
        lblRaza = new System.Windows.Forms.Label();
        txtRaza = new System.Windows.Forms.TextBox();
        lblSexo = new System.Windows.Forms.Label();
        cmbSexo = new System.Windows.Forms.ComboBox();
        lblFechaNacimiento = new System.Windows.Forms.Label();
        dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
        btnGuardarMascota = new System.Windows.Forms.Button();
        btnModificarMascota = new System.Windows.Forms.Button();
        btnEliminarMascota = new System.Windows.Forms.Button();
        btnLimpiarMascota = new System.Windows.Forms.Button();
        lblListaMascotas = new System.Windows.Forms.Label();
        dgvMascotasRecepcion = new System.Windows.Forms.DataGridView();
        tabCitas = new System.Windows.Forms.TabPage();
        lblTituloCitas = new System.Windows.Forms.Label();
        lblIdMascotaCita = new System.Windows.Forms.Label();
        txtIdMascotaCita = new System.Windows.Forms.TextBox();
        lblFechaCita = new System.Windows.Forms.Label();
        dtpFechaCita = new System.Windows.Forms.DateTimePicker();
        lblMotivoCita = new System.Windows.Forms.Label();
        txtMotivoCita = new System.Windows.Forms.TextBox();
        lblEstadoCita = new System.Windows.Forms.Label();
        cmbEstadoCita = new System.Windows.Forms.ComboBox();
        btnAgendarCita = new System.Windows.Forms.Button();
        btnModificarCita = new System.Windows.Forms.Button();
        btnCancelarCita = new System.Windows.Forms.Button();
        btnLimpiarCita = new System.Windows.Forms.Button();
        lblListaCitas = new System.Windows.Forms.Label();
        dgvCitas = new System.Windows.Forms.DataGridView();
        tabRecepcion.SuspendLayout();
        tabClientes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
        tabMascotas.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMascotasRecepcion).BeginInit();
        tabCitas.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
        SuspendLayout();
        // 
        // btnVolver
        // 
        btnVolver.Location = new System.Drawing.Point(15, 12);
        btnVolver.Name = "btnVolver";
        btnVolver.Size = new System.Drawing.Size(160, 32);
        btnVolver.TabIndex = 0;
        btnVolver.Text = "← Volver al Inicio";
        btnVolver.UseVisualStyleBackColor = true;
        // 
        // tabRecepcion
        // 
        tabRecepcion.Controls.Add(tabClientes);
        tabRecepcion.Controls.Add(tabMascotas);
        tabRecepcion.Controls.Add(tabCitas);
        tabRecepcion.Location = new System.Drawing.Point(15, 52);
        tabRecepcion.Name = "tabRecepcion";
        tabRecepcion.SelectedIndex = 0;
        tabRecepcion.Size = new System.Drawing.Size(990, 565);
        tabRecepcion.TabIndex = 1;
        // 
        // tabClientes
        // 
        tabClientes.Controls.Add(lblTituloClientes);
        tabClientes.Controls.Add(lblCedula);
        tabClientes.Controls.Add(txtCedula);
        tabClientes.Controls.Add(lblNombres);
        tabClientes.Controls.Add(txtNombres);
        tabClientes.Controls.Add(lblApellidos);
        tabClientes.Controls.Add(txtApellidos);
        tabClientes.Controls.Add(lblTelefono);
        tabClientes.Controls.Add(txtTelefono);
        tabClientes.Controls.Add(lblDireccion);
        tabClientes.Controls.Add(txtDireccion);
        tabClientes.Controls.Add(btnGuardarCliente);
        tabClientes.Controls.Add(btnModificarCliente);
        tabClientes.Controls.Add(btnEliminarCliente);
        tabClientes.Controls.Add(btnLimpiarCliente);
        tabClientes.Controls.Add(lblListaClientes);
        tabClientes.Controls.Add(dgvClientes);
        tabClientes.Location = new System.Drawing.Point(4, 29);
        tabClientes.Name = "tabClientes";
        tabClientes.Padding = new System.Windows.Forms.Padding(3);
        tabClientes.Size = new System.Drawing.Size(982, 532);
        tabClientes.TabIndex = 0;
        tabClientes.Text = "Clientes";
        tabClientes.UseVisualStyleBackColor = true;
        // 
        // lblTituloClientes
        // 
        lblTituloClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblTituloClientes.Location = new System.Drawing.Point(20, 15);
        lblTituloClientes.Name = "lblTituloClientes";
        lblTituloClientes.Size = new System.Drawing.Size(340, 25);
        lblTituloClientes.TabIndex = 0;
        lblTituloClientes.Text = "DATOS DEL CLIENTE";
        // 
        // lblCedula
        // 
        lblCedula.Location = new System.Drawing.Point(20, 50);
        lblCedula.Name = "lblCedula";
        lblCedula.Size = new System.Drawing.Size(120, 20);
        lblCedula.TabIndex = 1;
        lblCedula.Text = "Cédula:";
        // 
        // txtCedula
        // 
        txtCedula.Location = new System.Drawing.Point(20, 73);
        txtCedula.Name = "txtCedula";
        txtCedula.Size = new System.Drawing.Size(340, 27);
        txtCedula.TabIndex = 2;
        // 
        // lblNombres
        // 
        lblNombres.Location = new System.Drawing.Point(20, 110);
        lblNombres.Name = "lblNombres";
        lblNombres.Size = new System.Drawing.Size(120, 20);
        lblNombres.TabIndex = 3;
        lblNombres.Text = "Nombres:";
        // 
        // txtNombres
        // 
        txtNombres.Location = new System.Drawing.Point(20, 133);
        txtNombres.Name = "txtNombres";
        txtNombres.Size = new System.Drawing.Size(340, 27);
        txtNombres.TabIndex = 4;
        // 
        // lblApellidos
        // 
        lblApellidos.Location = new System.Drawing.Point(20, 170);
        lblApellidos.Name = "lblApellidos";
        lblApellidos.Size = new System.Drawing.Size(120, 20);
        lblApellidos.TabIndex = 5;
        lblApellidos.Text = "Apellidos:";
        // 
        // txtApellidos
        // 
        txtApellidos.Location = new System.Drawing.Point(20, 193);
        txtApellidos.Name = "txtApellidos";
        txtApellidos.Size = new System.Drawing.Size(340, 27);
        txtApellidos.TabIndex = 6;
        // 
        // lblTelefono
        // 
        lblTelefono.Location = new System.Drawing.Point(20, 230);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new System.Drawing.Size(120, 20);
        lblTelefono.TabIndex = 7;
        lblTelefono.Text = "Teléfono:";
        // 
        // txtTelefono
        // 
        txtTelefono.Location = new System.Drawing.Point(20, 253);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new System.Drawing.Size(340, 27);
        txtTelefono.TabIndex = 8;
        // 
        // lblDireccion
        // 
        lblDireccion.Location = new System.Drawing.Point(20, 290);
        lblDireccion.Name = "lblDireccion";
        lblDireccion.Size = new System.Drawing.Size(120, 20);
        lblDireccion.TabIndex = 9;
        lblDireccion.Text = "Dirección:";
        // 
        // txtDireccion
        // 
        txtDireccion.Location = new System.Drawing.Point(20, 313);
        txtDireccion.Name = "txtDireccion";
        txtDireccion.Size = new System.Drawing.Size(340, 27);
        txtDireccion.TabIndex = 10;
        // 
        // btnGuardarCliente
        // 
        btnGuardarCliente.Location = new System.Drawing.Point(20, 365);
        btnGuardarCliente.Name = "btnGuardarCliente";
        btnGuardarCliente.Size = new System.Drawing.Size(160, 36);
        btnGuardarCliente.TabIndex = 11;
        btnGuardarCliente.Text = "Guardar";
        btnGuardarCliente.UseVisualStyleBackColor = true;
        // 
        // btnModificarCliente
        // 
        btnModificarCliente.Location = new System.Drawing.Point(200, 365);
        btnModificarCliente.Name = "btnModificarCliente";
        btnModificarCliente.Size = new System.Drawing.Size(160, 36);
        btnModificarCliente.TabIndex = 12;
        btnModificarCliente.Text = "Modificar";
        btnModificarCliente.UseVisualStyleBackColor = true;
        // 
        // btnEliminarCliente
        // 
        btnEliminarCliente.Location = new System.Drawing.Point(20, 415);
        btnEliminarCliente.Name = "btnEliminarCliente";
        btnEliminarCliente.Size = new System.Drawing.Size(160, 36);
        btnEliminarCliente.TabIndex = 13;
        btnEliminarCliente.Text = "Eliminar";
        btnEliminarCliente.UseVisualStyleBackColor = true;
        // 
        // btnLimpiarCliente
        // 
        btnLimpiarCliente.Location = new System.Drawing.Point(200, 415);
        btnLimpiarCliente.Name = "btnLimpiarCliente";
        btnLimpiarCliente.Size = new System.Drawing.Size(160, 36);
        btnLimpiarCliente.TabIndex = 14;
        btnLimpiarCliente.Text = "Limpiar";
        btnLimpiarCliente.UseVisualStyleBackColor = true;
        // 
        // lblListaClientes
        // 
        lblListaClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblListaClientes.Location = new System.Drawing.Point(390, 15);
        lblListaClientes.Name = "lblListaClientes";
        lblListaClientes.Size = new System.Drawing.Size(560, 25);
        lblListaClientes.TabIndex = 15;
        lblListaClientes.Text = "LISTA GENERAL DE CLIENTES";
        // 
        // dgvClientes
        // 
        dgvClientes.AllowUserToAddRows = false;
        dgvClientes.AllowUserToDeleteRows = false;
        dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvClientes.Location = new System.Drawing.Point(390, 50);
        dgvClientes.Name = "dgvClientes";
        dgvClientes.ReadOnly = true;
        dgvClientes.RowHeadersVisible = false;
        dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClientes.Size = new System.Drawing.Size(570, 465);
        dgvClientes.TabIndex = 16;
        // 
        // tabMascotas
        // 
        tabMascotas.Controls.Add(lblTituloMascotas);
        tabMascotas.Controls.Add(lblCedulaDueno);
        tabMascotas.Controls.Add(txtCedulaDueno);
        tabMascotas.Controls.Add(lblNombreMascota);
        tabMascotas.Controls.Add(txtNombreMascota);
        tabMascotas.Controls.Add(lblEspecie);
        tabMascotas.Controls.Add(txtEspecie);
        tabMascotas.Controls.Add(lblRaza);
        tabMascotas.Controls.Add(txtRaza);
        tabMascotas.Controls.Add(lblSexo);
        tabMascotas.Controls.Add(cmbSexo);
        tabMascotas.Controls.Add(lblFechaNacimiento);
        tabMascotas.Controls.Add(dtpFechaNacimiento);
        tabMascotas.Controls.Add(btnGuardarMascota);
        tabMascotas.Controls.Add(btnModificarMascota);
        tabMascotas.Controls.Add(btnEliminarMascota);
        tabMascotas.Controls.Add(btnLimpiarMascota);
        tabMascotas.Controls.Add(lblListaMascotas);
        tabMascotas.Controls.Add(dgvMascotasRecepcion);
        tabMascotas.Location = new System.Drawing.Point(4, 29);
        tabMascotas.Name = "tabMascotas";
        tabMascotas.Padding = new System.Windows.Forms.Padding(3);
        tabMascotas.Size = new System.Drawing.Size(982, 532);
        tabMascotas.TabIndex = 1;
        tabMascotas.Text = "Mascotas";
        tabMascotas.UseVisualStyleBackColor = true;
        // 
        // lblTituloMascotas
        // 
        lblTituloMascotas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblTituloMascotas.Location = new System.Drawing.Point(20, 15);
        lblTituloMascotas.Name = "lblTituloMascotas";
        lblTituloMascotas.Size = new System.Drawing.Size(340, 25);
        lblTituloMascotas.TabIndex = 0;
        lblTituloMascotas.Text = "DATOS DE LA MASCOTA";
        // 
        // lblCedulaDueno
        // 
        lblCedulaDueno.Location = new System.Drawing.Point(20, 48);
        lblCedulaDueno.Name = "lblCedulaDueno";
        lblCedulaDueno.Size = new System.Drawing.Size(120, 20);
        lblCedulaDueno.TabIndex = 1;
        lblCedulaDueno.Text = "Cédula Dueño:";
        // 
        // txtCedulaDueno
        // 
        txtCedulaDueno.Location = new System.Drawing.Point(20, 70);
        txtCedulaDueno.Name = "txtCedulaDueno";
        txtCedulaDueno.Size = new System.Drawing.Size(340, 27);
        txtCedulaDueno.TabIndex = 2;
        // 
        // lblNombreMascota
        // 
        lblNombreMascota.Location = new System.Drawing.Point(20, 103);
        lblNombreMascota.Name = "lblNombreMascota";
        lblNombreMascota.Size = new System.Drawing.Size(140, 20);
        lblNombreMascota.TabIndex = 3;
        lblNombreMascota.Text = "Nombre Mascota:";
        // 
        // txtNombreMascota
        // 
        txtNombreMascota.Location = new System.Drawing.Point(20, 125);
        txtNombreMascota.Name = "txtNombreMascota";
        txtNombreMascota.Size = new System.Drawing.Size(340, 27);
        txtNombreMascota.TabIndex = 4;
        // 
        // lblEspecie
        // 
        lblEspecie.Location = new System.Drawing.Point(20, 158);
        lblEspecie.Name = "lblEspecie";
        lblEspecie.Size = new System.Drawing.Size(120, 20);
        lblEspecie.TabIndex = 5;
        lblEspecie.Text = "Especie:";
        // 
        // txtEspecie
        // 
        txtEspecie.Location = new System.Drawing.Point(20, 180);
        txtEspecie.Name = "txtEspecie";
        txtEspecie.Size = new System.Drawing.Size(340, 27);
        txtEspecie.TabIndex = 6;
        // 
        // lblRaza
        // 
        lblRaza.Location = new System.Drawing.Point(20, 213);
        lblRaza.Name = "lblRaza";
        lblRaza.Size = new System.Drawing.Size(120, 20);
        lblRaza.TabIndex = 7;
        lblRaza.Text = "Raza:";
        // 
        // txtRaza
        // 
        txtRaza.Location = new System.Drawing.Point(20, 235);
        txtRaza.Name = "txtRaza";
        txtRaza.Size = new System.Drawing.Size(340, 27);
        txtRaza.TabIndex = 8;
        // 
        // lblSexo
        // 
        lblSexo.Location = new System.Drawing.Point(20, 268);
        lblSexo.Name = "lblSexo";
        lblSexo.Size = new System.Drawing.Size(120, 20);
        lblSexo.TabIndex = 9;
        lblSexo.Text = "Sexo:";
        // 
        // cmbSexo
        // 
        cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbSexo.FormattingEnabled = true;
        cmbSexo.Items.AddRange(new object[] { "M", "H" });
        cmbSexo.Location = new System.Drawing.Point(20, 290);
        cmbSexo.Name = "cmbSexo";
        cmbSexo.Size = new System.Drawing.Size(340, 28);
        cmbSexo.TabIndex = 10;
        // 
        // lblFechaNacimiento
        // 
        lblFechaNacimiento.Location = new System.Drawing.Point(20, 325);
        lblFechaNacimiento.Name = "lblFechaNacimiento";
        lblFechaNacimiento.Size = new System.Drawing.Size(150, 20);
        lblFechaNacimiento.TabIndex = 11;
        lblFechaNacimiento.Text = "Fecha Nacimiento:";
        // 
        // dtpFechaNacimiento
        // 
        dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpFechaNacimiento.Location = new System.Drawing.Point(20, 347);
        dtpFechaNacimiento.Name = "dtpFechaNacimiento";
        dtpFechaNacimiento.Size = new System.Drawing.Size(340, 27);
        dtpFechaNacimiento.TabIndex = 12;
        // 
        // btnGuardarMascota
        // 
        btnGuardarMascota.Location = new System.Drawing.Point(20, 395);
        btnGuardarMascota.Name = "btnGuardarMascota";
        btnGuardarMascota.Size = new System.Drawing.Size(160, 36);
        btnGuardarMascota.TabIndex = 13;
        btnGuardarMascota.Text = "Guardar";
        btnGuardarMascota.UseVisualStyleBackColor = true;
        // 
        // btnModificarMascota
        // 
        btnModificarMascota.Location = new System.Drawing.Point(200, 395);
        btnModificarMascota.Name = "btnModificarMascota";
        btnModificarMascota.Size = new System.Drawing.Size(160, 36);
        btnModificarMascota.TabIndex = 14;
        btnModificarMascota.Text = "Modificar";
        btnModificarMascota.UseVisualStyleBackColor = true;
        // 
        // btnEliminarMascota
        // 
        btnEliminarMascota.Location = new System.Drawing.Point(20, 445);
        btnEliminarMascota.Name = "btnEliminarMascota";
        btnEliminarMascota.Size = new System.Drawing.Size(160, 36);
        btnEliminarMascota.TabIndex = 15;
        btnEliminarMascota.Text = "Eliminar";
        btnEliminarMascota.UseVisualStyleBackColor = true;
        // 
        // btnLimpiarMascota
        // 
        btnLimpiarMascota.Location = new System.Drawing.Point(200, 445);
        btnLimpiarMascota.Name = "btnLimpiarMascota";
        btnLimpiarMascota.Size = new System.Drawing.Size(160, 36);
        btnLimpiarMascota.TabIndex = 16;
        btnLimpiarMascota.Text = "Limpiar";
        btnLimpiarMascota.UseVisualStyleBackColor = true;
        // 
        // lblListaMascotas
        // 
        lblListaMascotas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblListaMascotas.Location = new System.Drawing.Point(390, 15);
        lblListaMascotas.Name = "lblListaMascotas";
        lblListaMascotas.Size = new System.Drawing.Size(560, 25);
        lblListaMascotas.TabIndex = 17;
        lblListaMascotas.Text = "LISTA GENERAL DE MASCOTAS";
        // 
        // dgvMascotasRecepcion
        // 
        dgvMascotasRecepcion.AllowUserToAddRows = false;
        dgvMascotasRecepcion.AllowUserToDeleteRows = false;
        dgvMascotasRecepcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvMascotasRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMascotasRecepcion.Location = new System.Drawing.Point(390, 50);
        dgvMascotasRecepcion.Name = "dgvMascotasRecepcion";
        dgvMascotasRecepcion.ReadOnly = true;
        dgvMascotasRecepcion.RowHeadersVisible = false;
        dgvMascotasRecepcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvMascotasRecepcion.Size = new System.Drawing.Size(570, 465);
        dgvMascotasRecepcion.TabIndex = 18;
        // 
        // tabCitas
        // 
        tabCitas.Controls.Add(lblTituloCitas);
        tabCitas.Controls.Add(lblIdMascotaCita);
        tabCitas.Controls.Add(txtIdMascotaCita);
        tabCitas.Controls.Add(lblFechaCita);
        tabCitas.Controls.Add(dtpFechaCita);
        tabCitas.Controls.Add(lblMotivoCita);
        tabCitas.Controls.Add(txtMotivoCita);
        tabCitas.Controls.Add(lblEstadoCita);
        tabCitas.Controls.Add(cmbEstadoCita);
        tabCitas.Controls.Add(btnAgendarCita);
        tabCitas.Controls.Add(btnModificarCita);
        tabCitas.Controls.Add(btnCancelarCita);
        tabCitas.Controls.Add(btnLimpiarCita);
        tabCitas.Controls.Add(lblListaCitas);
        tabCitas.Controls.Add(dgvCitas);
        tabCitas.Location = new System.Drawing.Point(4, 29);
        tabCitas.Name = "tabCitas";
        tabCitas.Padding = new System.Windows.Forms.Padding(3);
        tabCitas.Size = new System.Drawing.Size(982, 532);
        tabCitas.TabIndex = 2;
        tabCitas.Text = "Citas";
        tabCitas.UseVisualStyleBackColor = true;
        // 
        // lblTituloCitas
        // 
        lblTituloCitas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblTituloCitas.Location = new System.Drawing.Point(20, 15);
        lblTituloCitas.Name = "lblTituloCitas";
        lblTituloCitas.Size = new System.Drawing.Size(340, 25);
        lblTituloCitas.TabIndex = 0;
        lblTituloCitas.Text = "AGENDAR CITA";
        // 
        // lblIdMascotaCita
        // 
        lblIdMascotaCita.Location = new System.Drawing.Point(20, 48);
        lblIdMascotaCita.Name = "lblIdMascotaCita";
        lblIdMascotaCita.Size = new System.Drawing.Size(120, 20);
        lblIdMascotaCita.TabIndex = 1;
        lblIdMascotaCita.Text = "ID Mascota:";
        // 
        // txtIdMascotaCita
        // 
        txtIdMascotaCita.Location = new System.Drawing.Point(20, 70);
        txtIdMascotaCita.Name = "txtIdMascotaCita";
        txtIdMascotaCita.Size = new System.Drawing.Size(340, 27);
        txtIdMascotaCita.TabIndex = 2;
        // 
        // lblFechaCita
        // 
        lblFechaCita.Location = new System.Drawing.Point(20, 103);
        lblFechaCita.Name = "lblFechaCita";
        lblFechaCita.Size = new System.Drawing.Size(120, 20);
        lblFechaCita.TabIndex = 3;
        lblFechaCita.Text = "Fecha y Hora:";
        // 
        // dtpFechaCita
        // 
        dtpFechaCita.CustomFormat = "yyyy-MM-dd HH:mm";
        dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpFechaCita.Location = new System.Drawing.Point(20, 125);
        dtpFechaCita.Name = "dtpFechaCita";
        dtpFechaCita.Size = new System.Drawing.Size(340, 27);
        dtpFechaCita.TabIndex = 4;
        // 
        // lblMotivoCita
        // 
        lblMotivoCita.Location = new System.Drawing.Point(20, 158);
        lblMotivoCita.Name = "lblMotivoCita";
        lblMotivoCita.Size = new System.Drawing.Size(120, 20);
        lblMotivoCita.TabIndex = 5;
        lblMotivoCita.Text = "Motivo:";
        // 
        // txtMotivoCita
        // 
        txtMotivoCita.Location = new System.Drawing.Point(20, 180);
        txtMotivoCita.Multiline = true;
        txtMotivoCita.Name = "txtMotivoCita";
        txtMotivoCita.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtMotivoCita.Size = new System.Drawing.Size(340, 70);
        txtMotivoCita.TabIndex = 6;
        // 
        // lblEstadoCita
        // 
        lblEstadoCita.Location = new System.Drawing.Point(20, 258);
        lblEstadoCita.Name = "lblEstadoCita";
        lblEstadoCita.Size = new System.Drawing.Size(120, 20);
        lblEstadoCita.TabIndex = 7;
        lblEstadoCita.Text = "Estado:";
        // 
        // cmbEstadoCita
        // 
        cmbEstadoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbEstadoCita.FormattingEnabled = true;
        cmbEstadoCita.Items.AddRange(new object[] { "PENDIENTE", "ATENDIDA", "CANCELADA" });
        cmbEstadoCita.Location = new System.Drawing.Point(20, 280);
        cmbEstadoCita.Name = "cmbEstadoCita";
        cmbEstadoCita.Size = new System.Drawing.Size(340, 28);
        cmbEstadoCita.TabIndex = 8;
        // 
        // btnAgendarCita
        // 
        btnAgendarCita.Location = new System.Drawing.Point(20, 335);
        btnAgendarCita.Name = "btnAgendarCita";
        btnAgendarCita.Size = new System.Drawing.Size(160, 36);
        btnAgendarCita.TabIndex = 9;
        btnAgendarCita.Text = "Agendar";
        btnAgendarCita.UseVisualStyleBackColor = true;
        // 
        // btnModificarCita
        // 
        btnModificarCita.Location = new System.Drawing.Point(200, 335);
        btnModificarCita.Name = "btnModificarCita";
        btnModificarCita.Size = new System.Drawing.Size(160, 36);
        btnModificarCita.TabIndex = 10;
        btnModificarCita.Text = "Modificar";
        btnModificarCita.UseVisualStyleBackColor = true;
        // 
        // btnCancelarCita
        // 
        btnCancelarCita.Location = new System.Drawing.Point(20, 385);
        btnCancelarCita.Name = "btnCancelarCita";
        btnCancelarCita.Size = new System.Drawing.Size(160, 36);
        btnCancelarCita.TabIndex = 11;
        btnCancelarCita.Text = "Cancelar Cita";
        btnCancelarCita.UseVisualStyleBackColor = true;
        // 
        // btnLimpiarCita
        // 
        btnLimpiarCita.Location = new System.Drawing.Point(200, 385);
        btnLimpiarCita.Name = "btnLimpiarCita";
        btnLimpiarCita.Size = new System.Drawing.Size(160, 36);
        btnLimpiarCita.TabIndex = 12;
        btnLimpiarCita.Text = "Limpiar";
        btnLimpiarCita.UseVisualStyleBackColor = true;
        // 
        // lblListaCitas
        // 
        lblListaCitas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblListaCitas.Location = new System.Drawing.Point(390, 15);
        lblListaCitas.Name = "lblListaCitas";
        lblListaCitas.Size = new System.Drawing.Size(560, 25);
        lblListaCitas.TabIndex = 13;
        lblListaCitas.Text = "LISTA DE CITAS PROGRAMADAS";
        // 
        // dgvCitas
        // 
        dgvCitas.AllowUserToAddRows = false;
        dgvCitas.AllowUserToDeleteRows = false;
        dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCitas.Location = new System.Drawing.Point(390, 50);
        dgvCitas.Name = "dgvCitas";
        dgvCitas.ReadOnly = true;
        dgvCitas.RowHeadersVisible = false;
        dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvCitas.Size = new System.Drawing.Size(570, 465);
        dgvCitas.TabIndex = 14;
        // 
        // FormRecepcion
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1020, 635);
        Controls.Add(tabRecepcion);
        Controls.Add(btnVolver);
        Name = "FormRecepcion";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Gestión de Recepción";
        tabRecepcion.ResumeLayout(false);
        tabClientes.ResumeLayout(false);
        tabClientes.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
        tabMascotas.ResumeLayout(false);
        tabMascotas.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMascotasRecepcion).EndInit();
        tabCitas.ResumeLayout(false);
        tabCitas.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Button btnVolver;
    private System.Windows.Forms.TabControl tabRecepcion;
    private System.Windows.Forms.TabPage tabClientes;
    private System.Windows.Forms.TabPage tabMascotas;
    private System.Windows.Forms.TabPage tabCitas;

    // Clientes
    private System.Windows.Forms.Label lblTituloClientes;
    private System.Windows.Forms.Label lblCedula;
    private System.Windows.Forms.TextBox txtCedula;
    private System.Windows.Forms.Label lblNombres;
    private System.Windows.Forms.TextBox txtNombres;
    private System.Windows.Forms.Label lblApellidos;
    private System.Windows.Forms.TextBox txtApellidos;
    private System.Windows.Forms.Label lblTelefono;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.Label lblDireccion;
    private System.Windows.Forms.TextBox txtDireccion;
    private System.Windows.Forms.Button btnGuardarCliente;
    private System.Windows.Forms.Button btnModificarCliente;
    private System.Windows.Forms.Button btnEliminarCliente;
    private System.Windows.Forms.Button btnLimpiarCliente;
    private System.Windows.Forms.Label lblListaClientes;
    private System.Windows.Forms.DataGridView dgvClientes;

    // Mascotas
    private System.Windows.Forms.Label lblTituloMascotas;
    private System.Windows.Forms.Label lblCedulaDueno;
    private System.Windows.Forms.TextBox txtCedulaDueno;
    private System.Windows.Forms.Label lblNombreMascota;
    private System.Windows.Forms.TextBox txtNombreMascota;
    private System.Windows.Forms.Label lblEspecie;
    private System.Windows.Forms.TextBox txtEspecie;
    private System.Windows.Forms.Label lblRaza;
    private System.Windows.Forms.TextBox txtRaza;
    private System.Windows.Forms.Label lblSexo;
    private System.Windows.Forms.ComboBox cmbSexo;
    private System.Windows.Forms.Label lblFechaNacimiento;
    private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    private System.Windows.Forms.Button btnGuardarMascota;
    private System.Windows.Forms.Button btnModificarMascota;
    private System.Windows.Forms.Button btnEliminarMascota;
    private System.Windows.Forms.Button btnLimpiarMascota;
    private System.Windows.Forms.Label lblListaMascotas;
    private System.Windows.Forms.DataGridView dgvMascotasRecepcion;

    // Citas
    private System.Windows.Forms.Label lblTituloCitas;
    private System.Windows.Forms.Label lblIdMascotaCita;
    private System.Windows.Forms.TextBox txtIdMascotaCita;
    private System.Windows.Forms.Label lblFechaCita;
    private System.Windows.Forms.DateTimePicker dtpFechaCita;
    private System.Windows.Forms.Label lblMotivoCita;
    private System.Windows.Forms.TextBox txtMotivoCita;
    private System.Windows.Forms.Label lblEstadoCita;
    private System.Windows.Forms.ComboBox cmbEstadoCita;
    private System.Windows.Forms.Button btnAgendarCita;
    private System.Windows.Forms.Button btnModificarCita;
    private System.Windows.Forms.Button btnCancelarCita;
    private System.Windows.Forms.Button btnLimpiarCita;
    private System.Windows.Forms.Label lblListaCitas;
    private System.Windows.Forms.DataGridView dgvCitas;
}