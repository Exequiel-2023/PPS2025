namespace _01_CapaPresentacion
{
    partial class FrmCorreo
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
            this.lblPara = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblArchivosCargados = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblCargarArchivo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(61, 50);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(36, 16);
            this.lblPara.TabIndex = 0;
            this.lblPara.Text = "Para";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(61, 115);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(48, 16);
            this.lblAsunto.TabIndex = 1;
            this.lblAsunto.Text = "Asunto";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(61, 193);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(59, 16);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Mensaje";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(208, 43);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(268, 22);
            this.txtPara.TabIndex = 3;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(208, 109);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(268, 22);
            this.txtAsunto.TabIndex = 4;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(208, 178);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(268, 124);
            this.txtMensaje.TabIndex = 5;
            // 
            // lblArchivosCargados
            // 
            this.lblArchivosCargados.AutoSize = true;
            this.lblArchivosCargados.Location = new System.Drawing.Point(61, 347);
            this.lblArchivosCargados.Name = "lblArchivosCargados";
            this.lblArchivosCargados.Size = new System.Drawing.Size(120, 16);
            this.lblArchivosCargados.TabIndex = 6;
            this.lblArchivosCargados.Text = "Archivos cargados";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(690, 405);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblCargarArchivo
            // 
            this.lblCargarArchivo.Location = new System.Drawing.Point(64, 396);
            this.lblCargarArchivo.Name = "lblCargarArchivo";
            this.lblCargarArchivo.Size = new System.Drawing.Size(124, 23);
            this.lblCargarArchivo.TabIndex = 8;
            this.lblCargarArchivo.Text = "Cargar Archivos";
            this.lblCargarArchivo.UseVisualStyleBackColor = true;
            this.lblCargarArchivo.Click += new System.EventHandler(this.lblCargarArchivo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(328, 396);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblCargarArchivo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblArchivosCargados);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.lblPara);
            this.Name = "FrmCorreo";
            this.Text = "FrmCorreo";
            this.Load += new System.EventHandler(this.FrmCorreo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblArchivosCargados;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button lblCargarArchivo;
        private System.Windows.Forms.Button btnEnviar;
    }
}