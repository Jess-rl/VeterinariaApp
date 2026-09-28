namespace Veterinaria.UI;

partial class FormRecepcion
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
        lblHeader = new System.Windows.Forms.Label();
        tabRecepcion = new System.Windows.Forms.TabControl();
        tabClientes = new System.Windows.Forms.TabPage();
        lblTituloClientes = new System.Windows.Forms.Label();
        lblCedula = new System.Windows.Forms.Label();
        txtCedula = new System.Windows.Forms.TextBox();
        lblNombre = new System.Windows.Forms.Label();
        txtNombre = new System.Windows.Forms.TextBox();
        lblApellidos = new System.Windows.Forms.Label();
        txtApellidos = new System.Windows.Forms.TextBox();
        lblTelefono = new System.Windows.Forms.Label();
        txtTelefono = new System.Windows.Forms.TextBox();
        lblDireccion = new System.Windows.Forms.Label();
        txtDireccion = new System.Windows.Forms.TextBox();
        btnGuardar = new System.Windows.Forms.Button();
        btnModificar = new System.Windows.Forms.Button();
        btnEliminar = new System.Windows.Forms.Button();
        btnLimpiar = new System.Windows.Forms.Button();
        lblListaClientes = new System.Windows.Forms.Label();
        txtBuscarCliente = new System.Windows.Forms.TextBox();
        dgvClientes = new System.Windows.Forms.DataGridView();
        tabMascotas = new System.Windows.Forms.TabPage();
        lblTituloMascotas = new System.Windows.Forms.Label();
        txtBuscarMascota = new System.Windows.Forms.TextBox();
        lblCedulaDueno = new System.Windows.Forms.Label();
        txtCedulaDueno = new System.Windows.Forms.TextBox();
        lblClienteMascota = new System.Windows.Forms.Label();
        cmbClienteMascota = new System.Windows.Forms.ComboBox();
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
        lblCedulaCita = new System.Windows.Forms.Label();
        txtCedulaCita = new System.Windows.Forms.TextBox();
        lblNombreDuenoCita = new System.Windows.Forms.Label();
        lblMascotaCita = new System.Windows.Forms.Label();
        cmbMascotas = new System.Windows.Forms.ComboBox();
        lblFechaCita = new System.Windows.Forms.Label();
        dtpFechaCita = new System.Windows.Forms.DateTimePicker();
        lblMotivo = new System.Windows.Forms.Label();
        txtMotivo = new System.Windows.Forms.TextBox();
        btnAgendarCita = new System.Windows.Forms.Button();
        btnImprimirCita = new System.Windows.Forms.Button();
        btnCancelarCita = new System.Windows.Forms.Button();
        lblListaCitas = new System.Windows.Forms.Label();
        cmbFiltroEstadoCitas = new System.Windows.Forms.ComboBox();
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
        // lblHeader
        // 
        lblHeader.AutoSize = true;
        lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblHeader.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblHeader.Location = new System.Drawing.Point(205, 16);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new System.Drawing.Size(730, 35);
        lblHeader.TabIndex = 1;
        lblHeader.Text = "CLÍNICA VETERINARIA — RECEPCIÓN Y CITAS";
        // 
        // tabRecepcion
        // 
        tabRecepcion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tabRecepcion.Controls.Add(tabClientes);
        tabRecepcion.Controls.Add(tabMascotas);
        tabRecepcion.Controls.Add(tabCitas);
        tabRecepcion.Font = new System.Drawing.Font("Segoe UI", 10F);
        tabRecepcion.Location = new System.Drawing.Point(25, 62);
        tabRecepcion.Name = "tabRecepcion";
        tabRecepcion.SelectedIndex = 0;
        tabRecepcion.Size = new System.Drawing.Size(1365, 725);
        tabRecepcion.TabIndex = 2;
        tabRecepcion.SelectedIndexChanged += tabRecepcion_SelectedIndexChanged;
        // 
        // tabClientes
        // 
        tabClientes.Controls.Add(lblTituloClientes);
        tabClientes.Controls.Add(lblCedula);
        tabClientes.Controls.Add(txtCedula);
        tabClientes.Controls.Add(lblNombre);
        tabClientes.Controls.Add(txtNombre);
        tabClientes.Controls.Add(lblApellidos);
        tabClientes.Controls.Add(txtApellidos);
        tabClientes.Controls.Add(lblTelefono);
        tabClientes.Controls.Add(txtTelefono);
        tabClientes.Controls.Add(lblDireccion);
        tabClientes.Controls.Add(txtDireccion);
        tabClientes.Controls.Add(btnGuardar);
        tabClientes.Controls.Add(btnModificar);
        tabClientes.Controls.Add(btnEliminar);
        tabClientes.Controls.Add(btnLimpiar);
        tabClientes.Controls.Add(lblListaClientes);
        tabClientes.Controls.Add(txtBuscarCliente);
        tabClientes.Controls.Add(dgvClientes);
        tabClientes.Location = new System.Drawing.Point(4, 32);
        tabClientes.Name = "tabClientes";
        tabClientes.Padding = new System.Windows.Forms.Padding(3);
        tabClientes.Size = new System.Drawing.Size(1357, 689);
        tabClientes.TabIndex = 0;
        tabClientes.Text = "  Registro de Clientes  ";
        tabClientes.UseVisualStyleBackColor = true;
        // 
        // lblTituloClientes
        // 
        lblTituloClientes.AutoSize = true;
        lblTituloClientes.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblTituloClientes.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblTituloClientes.Location = new System.Drawing.Point(25, 18);
        lblTituloClientes.Name = "lblTituloClientes";
        lblTituloClientes.Size = new System.Drawing.Size(222, 30);
        lblTituloClientes.TabIndex = 0;
        lblTituloClientes.Text = "DATOS DEL CLIENTE";
        // 
        // lblCedula
        // 
        lblCedula.AutoSize = true;
        lblCedula.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblCedula.Location = new System.Drawing.Point(25, 60);
        lblCedula.Name = "lblCedula";
        lblCedula.Size = new System.Drawing.Size(61, 21);
        lblCedula.TabIndex = 1;
        lblCedula.Text = "Cédula:";
        // 
        // txtCedula
        // 
        txtCedula.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtCedula.Location = new System.Drawing.Point(25, 84);
        txtCedula.Name = "txtCedula";
        txtCedula.Size = new System.Drawing.Size(280, 30);
        txtCedula.TabIndex = 2;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblNombre.Location = new System.Drawing.Point(25, 126);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new System.Drawing.Size(71, 21);
        lblNombre.TabIndex = 3;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtNombre.Location = new System.Drawing.Point(25, 150);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new System.Drawing.Size(280, 30);
        txtNombre.TabIndex = 4;
        // 
        // lblApellidos
        // 
        lblApellidos.AutoSize = true;
        lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblApellidos.Location = new System.Drawing.Point(25, 192);
        lblApellidos.Name = "lblApellidos";
        lblApellidos.Size = new System.Drawing.Size(77, 21);
        lblApellidos.TabIndex = 5;
        lblApellidos.Text = "Apellidos:";
        // 
        // txtApellidos
        // 
        txtApellidos.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtApellidos.Location = new System.Drawing.Point(25, 216);
        txtApellidos.Name = "txtApellidos";
        txtApellidos.Size = new System.Drawing.Size(280, 30);
        txtApellidos.TabIndex = 6;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTelefono.Location = new System.Drawing.Point(25, 258);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new System.Drawing.Size(71, 21);
        lblTelefono.TabIndex = 7;
        lblTelefono.Text = "Teléfono:";
        // 
        // txtTelefono
        // 
        txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtTelefono.Location = new System.Drawing.Point(25, 282);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new System.Drawing.Size(280, 30);
        txtTelefono.TabIndex = 8;
        // 
        // lblDireccion
        // 
        lblDireccion.AutoSize = true;
        lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblDireccion.Location = new System.Drawing.Point(25, 324);
        lblDireccion.Name = "lblDireccion";
        lblDireccion.Size = new System.Drawing.Size(78, 21);
        lblDireccion.TabIndex = 9;
        lblDireccion.Text = "Dirección:";
        // 
        // txtDireccion
        // 
        txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtDireccion.Location = new System.Drawing.Point(25, 348);
        txtDireccion.Name = "txtDireccion";
        txtDireccion.Size = new System.Drawing.Size(280, 30);
        txtDireccion.TabIndex = 10;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnGuardar.FlatAppearance.BorderSize = 0;
        btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnGuardar.ForeColor = System.Drawing.Color.White;
        btnGuardar.Location = new System.Drawing.Point(25, 410);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new System.Drawing.Size(135, 40);
        btnGuardar.TabIndex = 11;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnModificar
        // 
        btnModificar.BackColor = System.Drawing.Color.White;
        btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnModificar.FlatAppearance.BorderSize = 1;
        btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnModificar.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnModificar.Location = new System.Drawing.Point(170, 410);
        btnModificar.Name = "btnModificar";
        btnModificar.Size = new System.Drawing.Size(135, 40);
        btnModificar.TabIndex = 12;
        btnModificar.Text = "Modificar";
        btnModificar.UseVisualStyleBackColor = false;
        btnModificar.Click += btnModificar_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.BackColor = System.Drawing.Color.White;
        btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnEliminar.FlatAppearance.BorderSize = 1;
        btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnEliminar.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnEliminar.Location = new System.Drawing.Point(25, 465);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new System.Drawing.Size(135, 40);
        btnEliminar.TabIndex = 13;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.BackColor = System.Drawing.Color.White;
        btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnLimpiar.FlatAppearance.BorderSize = 1;
        btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnLimpiar.Location = new System.Drawing.Point(170, 465);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new System.Drawing.Size(135, 40);
        btnLimpiar.TabIndex = 14;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = false;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // lblListaClientes
        // 
        lblListaClientes.AutoSize = true;
        lblListaClientes.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblListaClientes.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblListaClientes.Location = new System.Drawing.Point(340, 18);
        lblListaClientes.Name = "lblListaClientes";
        lblListaClientes.Size = new System.Drawing.Size(306, 30);
        lblListaClientes.TabIndex = 15;
        lblListaClientes.Text = "LISTA GENERAL DE CLIENTES";
        // 
        // txtBuscarCliente
        // 
        txtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtBuscarCliente.Location = new System.Drawing.Point(680, 16);
        txtBuscarCliente.Name = "txtBuscarCliente";
        txtBuscarCliente.PlaceholderText = "🔍 Buscar por cédula, nombre o teléfono...";
        txtBuscarCliente.Size = new System.Drawing.Size(350, 29);
        txtBuscarCliente.TabIndex = 17;
        txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
        // 
        // dgvClientes
        // 
        dgvClientes.AllowUserToAddRows = false;
        dgvClientes.AllowUserToDeleteRows = false;
        dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvClientes.Location = new System.Drawing.Point(340, 52);
        dgvClientes.MultiSelect = false;
        dgvClientes.Name = "dgvClientes";
        dgvClientes.ReadOnly = true;
        dgvClientes.RowHeadersVisible = false;
        dgvClientes.RowHeadersWidth = 51;
        dgvClientes.RowTemplate.Height = 32;
        dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClientes.Size = new System.Drawing.Size(995, 620);
        dgvClientes.TabIndex = 16;
        dgvClientes.CellClick += dgvClientes_CellClick;
        // 
        // tabMascotas
        // 
        tabMascotas.Controls.Add(lblTituloMascotas);
        tabMascotas.Controls.Add(lblCedulaDueno);
        tabMascotas.Controls.Add(txtCedulaDueno);
        tabMascotas.Controls.Add(lblClienteMascota);
        tabMascotas.Controls.Add(cmbClienteMascota);
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
        tabMascotas.Controls.Add(txtBuscarMascota);
        tabMascotas.Controls.Add(dgvMascotasRecepcion);
        tabMascotas.Location = new System.Drawing.Point(4, 32);
        tabMascotas.Name = "tabMascotas";
        tabMascotas.Padding = new System.Windows.Forms.Padding(3);
        tabMascotas.Size = new System.Drawing.Size(1357, 689);
        tabMascotas.TabIndex = 1;
        tabMascotas.Text = "  Registro de Mascotas  ";
        tabMascotas.UseVisualStyleBackColor = true;
        // 
        // lblTituloMascotas
        // 
        lblTituloMascotas.AutoSize = true;
        lblTituloMascotas.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblTituloMascotas.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblTituloMascotas.Location = new System.Drawing.Point(25, 18);
        lblTituloMascotas.Name = "lblTituloMascotas";
        lblTituloMascotas.Size = new System.Drawing.Size(262, 30);
        lblTituloMascotas.TabIndex = 0;
        lblTituloMascotas.Text = "DATOS DE LA MASCOTA";
        // 
        // lblCedulaDueno
        // 
        lblCedulaDueno.AutoSize = true;
        lblCedulaDueno.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblCedulaDueno.Location = new System.Drawing.Point(25, 52);
        lblCedulaDueno.Name = "lblCedulaDueno";
        lblCedulaDueno.Size = new System.Drawing.Size(201, 21);
        lblCedulaDueno.TabIndex = 1;
        lblCedulaDueno.Text = "Cédula del Dueño (Buscar):";
        // 
        // txtCedulaDueno
        // 
        txtCedulaDueno.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtCedulaDueno.Location = new System.Drawing.Point(25, 75);
        txtCedulaDueno.Name = "txtCedulaDueno";
        txtCedulaDueno.PlaceholderText = "Escriba la cédula...";
        txtCedulaDueno.Size = new System.Drawing.Size(280, 30);
        txtCedulaDueno.TabIndex = 2;
        txtCedulaDueno.TextChanged += txtCedulaDueno_TextChanged;
        // 
        // lblClienteMascota
        // 
        lblClienteMascota.AutoSize = true;
        lblClienteMascota.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblClienteMascota.Location = new System.Drawing.Point(25, 114);
        lblClienteMascota.Name = "lblClienteMascota";
        lblClienteMascota.Size = new System.Drawing.Size(183, 21);
        lblClienteMascota.TabIndex = 3;
        lblClienteMascota.Text = "Dueño / Propietario (Sel):";
        // 
        // cmbClienteMascota
        // 
        cmbClienteMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbClienteMascota.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cmbClienteMascota.FormattingEnabled = true;
        cmbClienteMascota.Location = new System.Drawing.Point(25, 137);
        cmbClienteMascota.Name = "cmbClienteMascota";
        cmbClienteMascota.Size = new System.Drawing.Size(280, 29);
        cmbClienteMascota.TabIndex = 4;
        cmbClienteMascota.SelectedIndexChanged += cmbClienteMascota_SelectedIndexChanged;
        // 
        // lblNombreMascota
        // 
        lblNombreMascota.AutoSize = true;
        lblNombreMascota.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblNombreMascota.Location = new System.Drawing.Point(25, 176);
        lblNombreMascota.Name = "lblNombreMascota";
        lblNombreMascota.Size = new System.Drawing.Size(133, 21);
        lblNombreMascota.TabIndex = 5;
        lblNombreMascota.Text = "Nombre Mascota:";
        // 
        // txtNombreMascota
        // 
        txtNombreMascota.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtNombreMascota.Location = new System.Drawing.Point(25, 199);
        txtNombreMascota.Name = "txtNombreMascota";
        txtNombreMascota.Size = new System.Drawing.Size(280, 30);
        txtNombreMascota.TabIndex = 6;
        // 
        // lblEspecie
        // 
        lblEspecie.AutoSize = true;
        lblEspecie.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblEspecie.Location = new System.Drawing.Point(25, 238);
        lblEspecie.Name = "lblEspecie";
        lblEspecie.Size = new System.Drawing.Size(64, 21);
        lblEspecie.TabIndex = 7;
        lblEspecie.Text = "Especie:";
        // 
        // txtEspecie
        // 
        txtEspecie.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtEspecie.Location = new System.Drawing.Point(25, 261);
        txtEspecie.Name = "txtEspecie";
        txtEspecie.Size = new System.Drawing.Size(280, 30);
        txtEspecie.TabIndex = 8;
        // 
        // lblRaza
        // 
        lblRaza.AutoSize = true;
        lblRaza.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRaza.Location = new System.Drawing.Point(25, 300);
        lblRaza.Name = "lblRaza";
        lblRaza.Size = new System.Drawing.Size(46, 21);
        lblRaza.TabIndex = 9;
        lblRaza.Text = "Raza:";
        // 
        // txtRaza
        // 
        txtRaza.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtRaza.Location = new System.Drawing.Point(25, 323);
        txtRaza.Name = "txtRaza";
        txtRaza.Size = new System.Drawing.Size(280, 30);
        txtRaza.TabIndex = 10;
        // 
        // lblSexo
        // 
        lblSexo.AutoSize = true;
        lblSexo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSexo.Location = new System.Drawing.Point(25, 362);
        lblSexo.Name = "lblSexo";
        lblSexo.Size = new System.Drawing.Size(46, 21);
        lblSexo.TabIndex = 11;
        lblSexo.Text = "Sexo:";
        // 
        // cmbSexo
        // 
        cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbSexo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cmbSexo.FormattingEnabled = true;
        cmbSexo.Items.AddRange(new object[] { "Macho", "Hembra" });
        cmbSexo.Location = new System.Drawing.Point(25, 385);
        cmbSexo.Name = "cmbSexo";
        cmbSexo.Size = new System.Drawing.Size(280, 29);
        cmbSexo.TabIndex = 12;
        // 
        // lblFechaNacimiento
        // 
        lblFechaNacimiento.AutoSize = true;
        lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblFechaNacimiento.Location = new System.Drawing.Point(25, 424);
        lblFechaNacimiento.Name = "lblFechaNacimiento";
        lblFechaNacimiento.Size = new System.Drawing.Size(137, 21);
        lblFechaNacimiento.TabIndex = 13;
        lblFechaNacimiento.Text = "Fecha Nacimiento:";
        // 
        // dtpFechaNacimiento
        // 
        dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
        dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpFechaNacimiento.Location = new System.Drawing.Point(25, 447);
        dtpFechaNacimiento.Name = "dtpFechaNacimiento";
        dtpFechaNacimiento.Size = new System.Drawing.Size(280, 30);
        dtpFechaNacimiento.TabIndex = 14;
        // 
        // btnGuardarMascota
        // 
        btnGuardarMascota.BackColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnGuardarMascota.FlatAppearance.BorderSize = 0;
        btnGuardarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnGuardarMascota.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnGuardarMascota.ForeColor = System.Drawing.Color.White;
        btnGuardarMascota.Location = new System.Drawing.Point(25, 498);
        btnGuardarMascota.Name = "btnGuardarMascota";
        btnGuardarMascota.Size = new System.Drawing.Size(135, 40);
        btnGuardarMascota.TabIndex = 15;
        btnGuardarMascota.Text = "Guardar";
        btnGuardarMascota.UseVisualStyleBackColor = false;
        btnGuardarMascota.Click += btnGuardarMascota_Click;
        // 
        // btnModificarMascota
        // 
        btnModificarMascota.BackColor = System.Drawing.Color.White;
        btnModificarMascota.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnModificarMascota.FlatAppearance.BorderSize = 1;
        btnModificarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnModificarMascota.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnModificarMascota.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnModificarMascota.Location = new System.Drawing.Point(170, 498);
        btnModificarMascota.Name = "btnModificarMascota";
        btnModificarMascota.Size = new System.Drawing.Size(135, 40);
        btnModificarMascota.TabIndex = 16;
        btnModificarMascota.Text = "Modificar";
        btnModificarMascota.UseVisualStyleBackColor = false;
        btnModificarMascota.Click += btnModificarMascota_Click;
        // 
        // btnEliminarMascota
        // 
        btnEliminarMascota.BackColor = System.Drawing.Color.White;
        btnEliminarMascota.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnEliminarMascota.FlatAppearance.BorderSize = 1;
        btnEliminarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEliminarMascota.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnEliminarMascota.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnEliminarMascota.Location = new System.Drawing.Point(25, 550);
        btnEliminarMascota.Name = "btnEliminarMascota";
        btnEliminarMascota.Size = new System.Drawing.Size(135, 40);
        btnEliminarMascota.TabIndex = 17;
        btnEliminarMascota.Text = "Eliminar";
        btnEliminarMascota.UseVisualStyleBackColor = false;
        btnEliminarMascota.Click += btnEliminarMascota_Click;
        // 
        // btnLimpiarMascota
        // 
        btnLimpiarMascota.BackColor = System.Drawing.Color.White;
        btnLimpiarMascota.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnLimpiarMascota.FlatAppearance.BorderSize = 1;
        btnLimpiarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLimpiarMascota.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnLimpiarMascota.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnLimpiarMascota.Location = new System.Drawing.Point(170, 550);
        btnLimpiarMascota.Name = "btnLimpiarMascota";
        btnLimpiarMascota.Size = new System.Drawing.Size(135, 40);
        btnLimpiarMascota.TabIndex = 18;
        btnLimpiarMascota.Text = "Limpiar";
        btnLimpiarMascota.UseVisualStyleBackColor = false;
        btnLimpiarMascota.Click += btnLimpiarMascota_Click;
        // 
        // lblListaMascotas
        // 
        lblListaMascotas.AutoSize = true;
        lblListaMascotas.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblListaMascotas.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblListaMascotas.Location = new System.Drawing.Point(340, 18);
        lblListaMascotas.Name = "lblListaMascotas";
        lblListaMascotas.Size = new System.Drawing.Size(326, 30);
        lblListaMascotas.TabIndex = 19;
        lblListaMascotas.Text = "LISTA GENERAL DE MASCOTAS";
        // 
        // txtBuscarMascota
        // 
        txtBuscarMascota.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtBuscarMascota.Location = new System.Drawing.Point(680, 16);
        txtBuscarMascota.Name = "txtBuscarMascota";
        txtBuscarMascota.PlaceholderText = "🔍 Buscar mascota por nombre, especie o dueño...";
        txtBuscarMascota.Size = new System.Drawing.Size(350, 29);
        txtBuscarMascota.TabIndex = 21;
        txtBuscarMascota.TextChanged += txtBuscarMascota_TextChanged;
        // 
        // dgvMascotasRecepcion
        // 
        dgvMascotasRecepcion.AllowUserToAddRows = false;
        dgvMascotasRecepcion.AllowUserToDeleteRows = false;
        dgvMascotasRecepcion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvMascotasRecepcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvMascotasRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMascotasRecepcion.Location = new System.Drawing.Point(340, 52);
        dgvMascotasRecepcion.MultiSelect = false;
        dgvMascotasRecepcion.Name = "dgvMascotasRecepcion";
        dgvMascotasRecepcion.ReadOnly = true;
        dgvMascotasRecepcion.RowHeadersVisible = false;
        dgvMascotasRecepcion.RowHeadersWidth = 51;
        dgvMascotasRecepcion.RowTemplate.Height = 32;
        dgvMascotasRecepcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvMascotasRecepcion.Size = new System.Drawing.Size(995, 620);
        dgvMascotasRecepcion.TabIndex = 20;
        dgvMascotasRecepcion.CellClick += dgvMascotasRecepcion_CellClick;
        // 
        // tabCitas
        // 
        tabCitas.Controls.Add(lblTituloCitas);
        tabCitas.Controls.Add(lblCedulaCita);
        tabCitas.Controls.Add(txtCedulaCita);
        tabCitas.Controls.Add(lblNombreDuenoCita);
        tabCitas.Controls.Add(lblMascotaCita);
        tabCitas.Controls.Add(cmbMascotas);
        tabCitas.Controls.Add(lblFechaCita);
        tabCitas.Controls.Add(dtpFechaCita);
        tabCitas.Controls.Add(lblMotivo);
        tabCitas.Controls.Add(txtMotivo);
        tabCitas.Controls.Add(btnAgendarCita);
        tabCitas.Controls.Add(btnImprimirCita);
        tabCitas.Controls.Add(btnCancelarCita);
        tabCitas.Controls.Add(lblListaCitas);
        tabCitas.Controls.Add(cmbFiltroEstadoCitas);
        tabCitas.Controls.Add(dgvCitas);
        tabCitas.Location = new System.Drawing.Point(4, 32);
        tabCitas.Name = "tabCitas";
        tabCitas.Padding = new System.Windows.Forms.Padding(3);
        tabCitas.Size = new System.Drawing.Size(1357, 689);
        tabCitas.TabIndex = 2;
        tabCitas.Text = "  Agendamiento de Citas  ";
        tabCitas.UseVisualStyleBackColor = true;
        // 
        // lblTituloCitas
        // 
        lblTituloCitas.AutoSize = true;
        lblTituloCitas.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblTituloCitas.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblTituloCitas.Location = new System.Drawing.Point(25, 18);
        lblTituloCitas.Name = "lblTituloCitas";
        lblTituloCitas.Size = new System.Drawing.Size(175, 30);
        lblTituloCitas.TabIndex = 0;
        lblTituloCitas.Text = "AGENDAR CITA";
        // 
        // lblCedulaCita
        // 
        lblCedulaCita.AutoSize = true;
        lblCedulaCita.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblCedulaCita.Location = new System.Drawing.Point(25, 52);
        lblCedulaCita.Name = "lblCedulaCita";
        lblCedulaCita.Size = new System.Drawing.Size(201, 21);
        lblCedulaCita.TabIndex = 1;
        lblCedulaCita.Text = "Cédula del Cliente / Dueño:";
        // 
        // txtCedulaCita
        // 
        txtCedulaCita.Font = new System.Drawing.Font("Segoe UI", 10F);
        txtCedulaCita.Location = new System.Drawing.Point(25, 75);
        txtCedulaCita.Name = "txtCedulaCita";
        txtCedulaCita.PlaceholderText = "Escriba la cédula del dueño...";
        txtCedulaCita.Size = new System.Drawing.Size(280, 30);
        txtCedulaCita.TabIndex = 2;
        txtCedulaCita.TextChanged += txtCedulaCita_TextChanged;
        // 
        // lblNombreDuenoCita
        // 
        lblNombreDuenoCita.AutoSize = true;
        lblNombreDuenoCita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        lblNombreDuenoCita.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblNombreDuenoCita.Location = new System.Drawing.Point(25, 110);
        lblNombreDuenoCita.Name = "lblNombreDuenoCita";
        lblNombreDuenoCita.Size = new System.Drawing.Size(225, 20);
        lblNombreDuenoCita.TabIndex = 3;
        lblNombreDuenoCita.Text = "Propietario: (Escriba la cédula)";
        // 
        // lblMascotaCita
        // 
        lblMascotaCita.AutoSize = true;
        lblMascotaCita.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblMascotaCita.Location = new System.Drawing.Point(25, 136);
        lblMascotaCita.Name = "lblMascotaCita";
        lblMascotaCita.Size = new System.Drawing.Size(71, 21);
        lblMascotaCita.TabIndex = 4;
        lblMascotaCita.Text = "Mascota:";
        // 
        // cmbMascotas
        // 
        cmbMascotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbMascotas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cmbMascotas.FormattingEnabled = true;
        cmbMascotas.Location = new System.Drawing.Point(25, 159);
        cmbMascotas.Name = "cmbMascotas";
        cmbMascotas.Size = new System.Drawing.Size(280, 29);
        cmbMascotas.TabIndex = 5;
        // 
        // lblFechaCita
        // 
        lblFechaCita.AutoSize = true;
        lblFechaCita.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblFechaCita.Location = new System.Drawing.Point(25, 204);
        lblFechaCita.Name = "lblFechaCita";
        lblFechaCita.Size = new System.Drawing.Size(104, 21);
        lblFechaCita.TabIndex = 6;
        lblFechaCita.Text = "Fecha y Hora:";
        // 
        // dtpFechaCita
        // 
        dtpFechaCita.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpFechaCita.Font = new System.Drawing.Font("Segoe UI", 10F);
        dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpFechaCita.Location = new System.Drawing.Point(25, 227);
        dtpFechaCita.Name = "dtpFechaCita";
        dtpFechaCita.Size = new System.Drawing.Size(280, 30);
        dtpFechaCita.TabIndex = 7;
        // 
        // lblMotivo
        // 
        lblMotivo.AutoSize = true;
        lblMotivo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblMotivo.Location = new System.Drawing.Point(25, 272);
        lblMotivo.Name = "lblMotivo";
        lblMotivo.Size = new System.Drawing.Size(150, 21);
        lblMotivo.TabIndex = 8;
        lblMotivo.Text = "Motivo de Consulta:";
        // 
        // txtMotivo
        // 
        txtMotivo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtMotivo.Location = new System.Drawing.Point(25, 295);
        txtMotivo.Multiline = true;
        txtMotivo.Name = "txtMotivo";
        txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtMotivo.Size = new System.Drawing.Size(280, 105);
        txtMotivo.TabIndex = 9;
        // 
        // btnAgendarCita
        // 
        btnAgendarCita.BackColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnAgendarCita.FlatAppearance.BorderSize = 0;
        btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAgendarCita.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAgendarCita.ForeColor = System.Drawing.Color.White;
        btnAgendarCita.Location = new System.Drawing.Point(25, 418);
        btnAgendarCita.Name = "btnAgendarCita";
        btnAgendarCita.Size = new System.Drawing.Size(280, 42);
        btnAgendarCita.TabIndex = 10;
        btnAgendarCita.Text = "Agendar Cita";
        btnAgendarCita.UseVisualStyleBackColor = false;
        btnAgendarCita.Click += btnAgendarCita_Click;
        // 
        // btnImprimirCita
        // 
        btnImprimirCita.BackColor = System.Drawing.Color.White;
        btnImprimirCita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnImprimirCita.FlatAppearance.BorderSize = 1;
        btnImprimirCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnImprimirCita.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnImprimirCita.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnImprimirCita.Location = new System.Drawing.Point(25, 472);
        btnImprimirCita.Name = "btnImprimirCita";
        btnImprimirCita.Size = new System.Drawing.Size(280, 42);
        btnImprimirCita.TabIndex = 11;
        btnImprimirCita.Text = "🖨 Imprimir Cita";
        btnImprimirCita.UseVisualStyleBackColor = false;
        btnImprimirCita.Click += btnImprimirCita_Click;
        // 
        // btnCancelarCita
        // 
        btnCancelarCita.BackColor = System.Drawing.Color.White;
        btnCancelarCita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnCancelarCita.FlatAppearance.BorderSize = 1;
        btnCancelarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelarCita.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCancelarCita.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        btnCancelarCita.Location = new System.Drawing.Point(25, 526);
        btnCancelarCita.Name = "btnCancelarCita";
        btnCancelarCita.Size = new System.Drawing.Size(280, 42);
        btnCancelarCita.TabIndex = 12;
        btnCancelarCita.Text = "Cancelar Cita Seleccionada";
        btnCancelarCita.UseVisualStyleBackColor = false;
        btnCancelarCita.Click += btnCancelarCita_Click;
        // 
        // lblListaCitas
        // 
        lblListaCitas.AutoSize = true;
        lblListaCitas.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblListaCitas.ForeColor = System.Drawing.Color.FromArgb(64, 24, 80);
        lblListaCitas.Location = new System.Drawing.Point(340, 18);
        lblListaCitas.Name = "lblListaCitas";
        lblListaCitas.Size = new System.Drawing.Size(347, 30);
        lblListaCitas.TabIndex = 13;
        lblListaCitas.Text = "LISTA DE CITAS PROGRAMADAS";
        // 
        // cmbFiltroEstadoCitas
        // 
        cmbFiltroEstadoCitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbFiltroEstadoCitas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cmbFiltroEstadoCitas.FormattingEnabled = true;
        cmbFiltroEstadoCitas.Location = new System.Drawing.Point(720, 16);
        cmbFiltroEstadoCitas.Name = "cmbFiltroEstadoCitas";
        cmbFiltroEstadoCitas.Size = new System.Drawing.Size(200, 29);
        cmbFiltroEstadoCitas.TabIndex = 15;
        cmbFiltroEstadoCitas.SelectedIndexChanged += cmbFiltroEstadoCitas_SelectedIndexChanged;
        // 
        // dgvCitas
        // 
        dgvCitas.AllowUserToAddRows = false;
        dgvCitas.AllowUserToDeleteRows = false;
        dgvCitas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCitas.Location = new System.Drawing.Point(340, 52);
        dgvCitas.MultiSelect = false;
        dgvCitas.Name = "dgvCitas";
        dgvCitas.ReadOnly = true;
        dgvCitas.RowHeadersVisible = false;
        dgvCitas.RowHeadersWidth = 51;
        dgvCitas.RowTemplate.Height = 32;
        dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvCitas.Size = new System.Drawing.Size(995, 620);
        dgvCitas.TabIndex = 14;
        dgvCitas.CellClick += dgvCitas_CellClick;
        // 
        // FormRecepcion
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(1420, 810);
        Controls.Add(tabRecepcion);
        Controls.Add(lblHeader);
        Controls.Add(btnVolver);
        Font = new System.Drawing.Font("Segoe UI", 9.5F);
        MinimumSize = new System.Drawing.Size(1200, 750);
        Name = "FormRecepcion";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Clínica Veterinaria - Recepción y Citas";
        Load += FormRecepcion_Load;
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
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button btnVolver;
    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.TabControl tabRecepcion;
    private System.Windows.Forms.TabPage tabClientes;
    private System.Windows.Forms.TabPage tabMascotas;
    private System.Windows.Forms.TabPage tabCitas;

    // Sección Clientes
    private System.Windows.Forms.Label lblTituloClientes;
    private System.Windows.Forms.Label lblCedula;
    private System.Windows.Forms.TextBox txtCedula;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblApellidos;
    private System.Windows.Forms.TextBox txtApellidos;
    private System.Windows.Forms.Label lblTelefono;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.Label lblDireccion;
    private System.Windows.Forms.TextBox txtDireccion;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Label lblListaClientes;
    private System.Windows.Forms.TextBox txtBuscarCliente;
    private System.Windows.Forms.DataGridView dgvClientes;

    // Sección Mascotas
    private System.Windows.Forms.Label lblTituloMascotas;
    private System.Windows.Forms.Label lblCedulaDueno;
    private System.Windows.Forms.TextBox txtCedulaDueno;
    private System.Windows.Forms.Label lblClienteMascota;
    private System.Windows.Forms.ComboBox cmbClienteMascota;
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
    private System.Windows.Forms.TextBox txtBuscarMascota;
    private System.Windows.Forms.DataGridView dgvMascotasRecepcion;

    // Sección Citas
    private System.Windows.Forms.Label lblTituloCitas;
    private System.Windows.Forms.Label lblCedulaCita;
    private System.Windows.Forms.TextBox txtCedulaCita;
    private System.Windows.Forms.Label lblNombreDuenoCita;
    private System.Windows.Forms.Label lblMascotaCita;
    private System.Windows.Forms.ComboBox cmbMascotas;
    private System.Windows.Forms.Label lblFechaCita;
    private System.Windows.Forms.DateTimePicker dtpFechaCita;
    private System.Windows.Forms.Label lblMotivo;
    private System.Windows.Forms.TextBox txtMotivo;
    private System.Windows.Forms.Button btnAgendarCita;
    private System.Windows.Forms.Button btnImprimirCita;
    private System.Windows.Forms.Button btnCancelarCita;
    private System.Windows.Forms.Label lblListaCitas;
    private System.Windows.Forms.ComboBox cmbFiltroEstadoCitas;
    private System.Windows.Forms.DataGridView dgvCitas;
}