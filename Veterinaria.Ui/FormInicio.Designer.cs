namespace Veterinaria.U;

partial class FormInicio
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        btnRecepcion = new System.Windows.Forms.Button();
        btnVeterinario = new System.Windows.Forms.Button();
        btnSalir = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(80, 35);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(700, 48);
        label2.TabIndex = 1;
        label2.Text = "CLÍNICA VETERINARIA";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        label1.ForeColor = System.Drawing.Color.DimGray;
        label1.Location = new System.Drawing.Point(80, 88);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(700, 24);
        label1.TabIndex = 2;
        label1.Text = "SISTEMA DE GESTIÓN Y ATENCIÓN CLÍNICA";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 11F);
        label3.Location = new System.Drawing.Point(80, 130);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(700, 28);
        label3.TabIndex = 3;
        label3.Text = "Seleccione el área a la que desea ingresar:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnRecepcion
        // 
        btnRecepcion.BackColor = System.Drawing.Color.ForestGreen;
        btnRecepcion.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRecepcion.FlatAppearance.BorderSize = 0;
        btnRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRecepcion.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        btnRecepcion.ForeColor = System.Drawing.Color.White;
        btnRecepcion.Location = new System.Drawing.Point(140, 185);
        btnRecepcion.Name = "btnRecepcion";
        btnRecepcion.Size = new System.Drawing.Size(260, 155);
        btnRecepcion.TabIndex = 4;
        btnRecepcion.Text = "📋  RECEPCIÓN\r\n\r\nClientes · Mascotas\r\nCitas Programadas";
        btnRecepcion.UseVisualStyleBackColor = false;
        btnRecepcion.Click += btnRecepcion_Click;
        // 
        // btnVeterinario
        // 
        btnVeterinario.BackColor = System.Drawing.Color.RoyalBlue;
        btnVeterinario.Cursor = System.Windows.Forms.Cursors.Hand;
        btnVeterinario.FlatAppearance.BorderSize = 0;
        btnVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnVeterinario.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        btnVeterinario.ForeColor = System.Drawing.Color.White;
        btnVeterinario.Location = new System.Drawing.Point(460, 185);
        btnVeterinario.Name = "btnVeterinario";
        btnVeterinario.Size = new System.Drawing.Size(260, 155);
        btnVeterinario.TabIndex = 5;
        btnVeterinario.Text = "🩺  VETERINARIO\r\n\r\nConsultas Médicas\r\nHistorial Clínico";
        btnVeterinario.UseVisualStyleBackColor = false;
        btnVeterinario.Click += btnVeterinario_Click;
        // 
        // btnSalir
        // 
        btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnSalir.Location = new System.Drawing.Point(365, 385);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(130, 38);
        btnSalir.TabIndex = 6;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // FormInicio
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(860, 480);
        Controls.Add(btnSalir);
        Controls.Add(btnVeterinario);
        Controls.Add(btnRecepcion);
        Controls.Add(label3);
        Controls.Add(label1);
        Controls.Add(label2);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "SISTEMA DE GESTIÓN VETERINARIA";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnRecepcion;
    private System.Windows.Forms.Button btnVeterinario;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    #endregion
}