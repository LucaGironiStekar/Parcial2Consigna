namespace Parcial2Consigna
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCargarPersona = new System.Windows.Forms.Button();
            this.btCalcularEdad = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxDNI = new System.Windows.Forms.TextBox();
            this.tboxNacimiento = new System.Windows.Forms.TextBox();
            this.lblEdadResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCargarPersona
            // 
            this.btCargarPersona.Location = new System.Drawing.Point(435, 110);
            this.btCargarPersona.Name = "btCargarPersona";
            this.btCargarPersona.Size = new System.Drawing.Size(104, 31);
            this.btCargarPersona.TabIndex = 0;
            this.btCargarPersona.Text = "Cargar Persona";
            this.btCargarPersona.UseVisualStyleBackColor = true;
            // 
            // btCalcularEdad
            // 
            this.btCalcularEdad.Location = new System.Drawing.Point(435, 166);
            this.btCalcularEdad.Name = "btCalcularEdad";
            this.btCalcularEdad.Size = new System.Drawing.Size(104, 31);
            this.btCalcularEdad.TabIndex = 1;
            this.btCalcularEdad.Text = "Calcular Edad";
            this.btCalcularEdad.UseVisualStyleBackColor = true;
            this.btCalcularEdad.Click += new System.EventHandler(this.btCalcularEdad_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(46, 128);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(46, 184);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblNacimiento.TabIndex = 4;
            this.lblNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(130, 250);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad:";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(190, 69);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 6;
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(190, 125);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(100, 20);
            this.tboxDNI.TabIndex = 7;
            this.tboxDNI.Leave += new System.EventHandler(this.tboxDNI_Leave);
            // 
            // tboxNacimiento
            // 
            this.tboxNacimiento.Location = new System.Drawing.Point(190, 181);
            this.tboxNacimiento.Name = "tboxNacimiento";
            this.tboxNacimiento.Size = new System.Drawing.Size(100, 20);
            this.tboxNacimiento.TabIndex = 8;
            // 
            // lblEdadResultado
            // 
            this.lblEdadResultado.AutoSize = true;
            this.lblEdadResultado.Location = new System.Drawing.Point(317, 250);
            this.lblEdadResultado.Name = "lblEdadResultado";
            this.lblEdadResultado.Size = new System.Drawing.Size(13, 13);
            this.lblEdadResultado.TabIndex = 9;
            this.lblEdadResultado.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEdadResultado);
            this.Controls.Add(this.tboxNacimiento);
            this.Controls.Add(this.tboxDNI);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btCalcularEdad);
            this.Controls.Add(this.btCargarPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCargarPersona;
        private System.Windows.Forms.Button btCalcularEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.TextBox tboxNacimiento;
        private System.Windows.Forms.Label lblEdadResultado;
    }
}

