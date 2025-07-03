namespace _01_CapaPresentacion
{
    partial class VentanaPrincipalJefe
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
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnEntrenadores = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSocios
            // 
            this.btnSocios.Location = new System.Drawing.Point(12, 83);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(75, 23);
            this.btnSocios.TabIndex = 0;
            this.btnSocios.Text = "Socios";
            this.btnSocios.UseVisualStyleBackColor = true;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // btnEntrenadores
            // 
            this.btnEntrenadores.Location = new System.Drawing.Point(12, 131);
            this.btnEntrenadores.Name = "btnEntrenadores";
            this.btnEntrenadores.Size = new System.Drawing.Size(101, 23);
            this.btnEntrenadores.TabIndex = 1;
            this.btnEntrenadores.Text = "Entrenadores";
            this.btnEntrenadores.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(12, 188);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(75, 23);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(12, 249);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(101, 23);
            this.btnEstadisticas.TabIndex = 3;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipalJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnEntrenadores);
            this.Controls.Add(this.btnSocios);
            this.Name = "VentanaPrincipalJefe";
            this.Text = "VentanaPrincipalJefe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnEntrenadores;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}