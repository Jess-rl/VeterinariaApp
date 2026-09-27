namespace Veterinaria.U;

partial class FormPin
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
        label1 = new System.Windows.Forms.Label();
        txtPin = new System.Windows.Forms.TextBox();
        btnAceptar = new System.Windows.Forms.Button();
        btnCancelar = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(20, 20);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(380, 25);
        label1.TabIndex = 0;
        label1.Text = "INGRESE EL PIN DE AUTENTICACIÓN:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtPin
        // 
        txtPin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        txtPin.Location = new System.Drawing.Point(120, 60);
        txtPin.MaxLength = 10;
        txtPin.Name = "txtPin";
        txtPin.PasswordChar = '*';
        txtPin.Size = new System.Drawing.Size(180, 39);
        txtPin.TabIndex = 1;
        txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // btnAceptar
        // 
        btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnAceptar.Location = new System.Drawing.Point(90, 120);
        btnAceptar.Name = "btnAceptar";
        btnAceptar.Size = new System.Drawing.Size(110, 36);
        btnAceptar.TabIndex = 2;
        btnAceptar.Text = "Aceptar";
        btnAceptar.UseVisualStyleBackColor = true;
        // 
        // btnCancelar
        // 
        btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelar.Location = new System.Drawing.Point(220, 120);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new System.Drawing.Size(110, 36);
        btnCancelar.TabIndex = 3;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += btnCancelar_Click;
        // 
        // FormPin
        // 
        AcceptButton = btnAceptar;
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        CancelButton = btnCancelar;
        ClientSize = new System.Drawing.Size(420, 185);
        Controls.Add(btnCancelar);
        Controls.Add(btnAceptar);
        Controls.Add(txtPin);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Acceso de Seguridad";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtPin;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
}