namespace _01_CapaPresentacion
{
    partial class SocioInactivo
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
            this.dgv_SocioInactivo = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gvSocioInactivo = new System.Windows.Forms.GroupBox();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.lblFiltrarInactivo = new System.Windows.Forms.Label();
            this.txbFiltrarInactivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SocioInactivo)).BeginInit();
            this.gvSocioInactivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_SocioInactivo
            // 
            this.dgv_SocioInactivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SocioInactivo.Location = new System.Drawing.Point(12, 56);
            this.dgv_SocioInactivo.Name = "dgv_SocioInactivo";
            this.dgv_SocioInactivo.ReadOnly = true;
            this.dgv_SocioInactivo.RowHeadersWidth = 51;
            this.dgv_SocioInactivo.RowTemplate.Height = 24;
            this.dgv_SocioInactivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SocioInactivo.Size = new System.Drawing.Size(725, 444);
            this.dgv_SocioInactivo.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(634, 537);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(77, 353);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gvSocioInactivo
            // 
            this.gvSocioInactivo.Controls.Add(this.dtpFechaAlta);
            this.gvSocioInactivo.Controls.Add(this.txtActivo);
            this.gvSocioInactivo.Controls.Add(this.lblActivo);
            this.gvSocioInactivo.Controls.Add(this.btnActualizar);
            this.gvSocioInactivo.Controls.Add(this.txtDni);
            this.gvSocioInactivo.Controls.Add(this.txtTelefono);
            this.gvSocioInactivo.Controls.Add(this.txtApellido);
            this.gvSocioInactivo.Controls.Add(this.txtNombre);
            this.gvSocioInactivo.Controls.Add(this.lblFechaAlta);
            this.gvSocioInactivo.Controls.Add(this.lblTelefono);
            this.gvSocioInactivo.Controls.Add(this.lblDni);
            this.gvSocioInactivo.Controls.Add(this.lblApellido);
            this.gvSocioInactivo.Controls.Add(this.lblNombre);
            this.gvSocioInactivo.Location = new System.Drawing.Point(755, 56);
            this.gvSocioInactivo.Name = "gvSocioInactivo";
            this.gvSocioInactivo.Size = new System.Drawing.Size(239, 444);
            this.gvSocioInactivo.TabIndex = 3;
            this.gvSocioInactivo.TabStop = false;
            this.gvSocioInactivo.Text = "Actualizar Socio";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(102, 231);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(118, 22);
            this.dtpFechaAlta.TabIndex = 13;
            // 
            // txtActivo
            // 
            this.txtActivo.Location = new System.Drawing.Point(77, 288);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(131, 22);
            this.txtActivo.TabIndex = 12;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(6, 294);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(44, 16);
            this.lblActivo.TabIndex = 11;
            this.lblActivo.Text = "Activo";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(77, 131);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(156, 22);
            this.txtDni.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(77, 179);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(156, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(77, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(156, 22);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(6, 237);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(90, 16);
            this.lblFechaAlta.TabIndex = 4;
            this.lblFechaAlta.Text = "Fecha de Alta";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 185);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(7, 137);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 16);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "Dni";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(7, 82);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(890, 537);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(269, 537);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(129, 23);
            this.btnEmail.TabIndex = 5;
            this.btnEmail.Text = "Enviar e-mail";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // lblFiltrarInactivo
            // 
            this.lblFiltrarInactivo.AutoSize = true;
            this.lblFiltrarInactivo.Location = new System.Drawing.Point(102, 19);
            this.lblFiltrarInactivo.Name = "lblFiltrarInactivo";
            this.lblFiltrarInactivo.Size = new System.Drawing.Size(95, 16);
            this.lblFiltrarInactivo.TabIndex = 14;
            this.lblFiltrarInactivo.Text = "Filtrar por DNI :";
            // 
            // txbFiltrarInactivo
            // 
            this.txbFiltrarInactivo.Location = new System.Drawing.Point(217, 19);
            this.txbFiltrarInactivo.Name = "txbFiltrarInactivo";
            this.txbFiltrarInactivo.Size = new System.Drawing.Size(309, 22);
            this.txbFiltrarInactivo.TabIndex = 15;
            this.txbFiltrarInactivo.TextChanged += new System.EventHandler(this.txbFiltrarInactivo_TextChanged);
            
            // 
            // SocioInactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 582);
            this.Controls.Add(this.txbFiltrarInactivo);
            this.Controls.Add(this.lblFiltrarInactivo);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gvSocioInactivo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgv_SocioInactivo);
            this.Name = "SocioInactivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOCIOS INACTIVOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SocioInactivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SocioInactivo)).EndInit();
            this.gvSocioInactivo.ResumeLayout(false);
            this.gvSocioInactivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SocioInactivo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gvSocioInactivo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label lblFiltrarInactivo;
        private System.Windows.Forms.TextBox txbFiltrarInactivo;
    }
}