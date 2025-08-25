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
            this.components = new System.ComponentModel.Container();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.LogoMorado = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnSecretarios = new System.Windows.Forms.Button();
            this.btnSocio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInventarios = new System.Windows.Forms.Button();
            this.btnEntrenador = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.timeFechaHora = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMorado)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.MenuVertical.Controls.Add(this.btnFacturacion);
            this.MenuVertical.Controls.Add(this.LogoMorado);
            this.MenuVertical.Controls.Add(this.lblFecha);
            this.MenuVertical.Controls.Add(this.lblHora);
            this.MenuVertical.Controls.Add(this.btnSecretarios);
            this.MenuVertical.Controls.Add(this.btnSocio);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.btnInventarios);
            this.MenuVertical.Controls.Add(this.btnEntrenador);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 711);
            this.MenuVertical.TabIndex = 4;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Image = global::_01_CapaPresentacion.Properties.Resources.Dolar;
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(24, 456);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(250, 40);
            this.btnFacturacion.TabIndex = 15;
            this.btnFacturacion.Text = "          Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // LogoMorado
            // 
            this.LogoMorado.BackColor = System.Drawing.Color.Transparent;
            this.LogoMorado.Image = global::_01_CapaPresentacion.Properties.Resources.Logo_Morado1;
            this.LogoMorado.Location = new System.Drawing.Point(-54, 12);
            this.LogoMorado.Name = "LogoMorado";
            this.LogoMorado.Size = new System.Drawing.Size(371, 226);
            this.LogoMorado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoMorado.TabIndex = 5;
            this.LogoMorado.TabStop = false;
            
            this.LogoMorado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(12, 625);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 21);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(90, 593);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(66, 27);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "Hora";
            // 
            // btnSecretarios
            // 
            this.btnSecretarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSecretarios.FlatAppearance.BorderSize = 0;
            this.btnSecretarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSecretarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecretarios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecretarios.ForeColor = System.Drawing.Color.White;
            this.btnSecretarios.Image = global::_01_CapaPresentacion.Properties.Resources.PngUserBlanco;
            this.btnSecretarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecretarios.Location = new System.Drawing.Point(24, 285);
            this.btnSecretarios.Name = "btnSecretarios";
            this.btnSecretarios.Size = new System.Drawing.Size(250, 40);
            this.btnSecretarios.TabIndex = 12;
            this.btnSecretarios.Text = "       Secretarios";
            this.btnSecretarios.UseVisualStyleBackColor = true;
            this.btnSecretarios.Click += new System.EventHandler(this.btnSecretarios_Click);
            // 
            // btnSocio
            // 
            this.btnSocio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSocio.FlatAppearance.BorderSize = 0;
            this.btnSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocio.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocio.ForeColor = System.Drawing.Color.White;
            this.btnSocio.Image = global::_01_CapaPresentacion.Properties.Resources.pngSocios;
            this.btnSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocio.Location = new System.Drawing.Point(24, 228);
            this.btnSocio.Name = "btnSocio";
            this.btnSocio.Size = new System.Drawing.Size(250, 40);
            this.btnSocio.TabIndex = 10;
            this.btnSocio.Text = "Socios";
            this.btnSocio.UseVisualStyleBackColor = true;
            this.btnSocio.Click += new System.EventHandler(this.btnSocio_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::_01_CapaPresentacion.Properties.Resources.pngCerrarSesion;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "       Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInventarios
            // 
            this.btnInventarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnInventarios.FlatAppearance.BorderSize = 0;
            this.btnInventarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInventarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventarios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarios.ForeColor = System.Drawing.Color.White;
            this.btnInventarios.Image = global::_01_CapaPresentacion.Properties.Resources.pngInventario;
            this.btnInventarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventarios.Location = new System.Drawing.Point(24, 400);
            this.btnInventarios.Name = "btnInventarios";
            this.btnInventarios.Size = new System.Drawing.Size(250, 40);
            this.btnInventarios.TabIndex = 8;
            this.btnInventarios.Text = "    Inventario";
            this.btnInventarios.UseVisualStyleBackColor = true;
            this.btnInventarios.Click += new System.EventHandler(this.btnInventarios_Click);
            // 
            // btnEntrenador
            // 
            this.btnEntrenador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEntrenador.FlatAppearance.BorderSize = 0;
            this.btnEntrenador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrenador.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrenador.ForeColor = System.Drawing.Color.White;
            this.btnEntrenador.Image = global::_01_CapaPresentacion.Properties.Resources.pngEntrenador;
            this.btnEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrenador.Location = new System.Drawing.Point(24, 343);
            this.btnEntrenador.Name = "btnEntrenador";
            this.btnEntrenador.Size = new System.Drawing.Size(250, 40);
            this.btnEntrenador.TabIndex = 7;
            this.btnEntrenador.Text = "          Entrenadores";
            this.btnEntrenador.UseVisualStyleBackColor = true;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.LightGray;
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.btnslide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1611, 50);
            this.BarraTitulo.TabIndex = 5;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = global::_01_CapaPresentacion.Properties.Resources.pngRestaurar;
            this.iconrestaurar.Location = new System.Drawing.Point(1553, 12);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 10;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = global::_01_CapaPresentacion.Properties.Resources.pngMinimizar;
            this.iconminimizar.Location = new System.Drawing.Point(1527, 12);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(20, 20);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 9;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = global::_01_CapaPresentacion.Properties.Resources.pngMaximizar;
            this.iconmaximizar.Location = new System.Drawing.Point(1553, 12);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 7;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = global::_01_CapaPresentacion.Properties.Resources.pngCerrar;
            this.iconcerrar.Location = new System.Drawing.Point(1579, 12);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(20, 20);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 6;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = global::_01_CapaPresentacion.Properties.Resources.pngMenu;
            this.btnslide.Location = new System.Drawing.Point(7, 4);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(35, 35);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 1;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // timeFechaHora
            // 
            this.timeFechaHora.Enabled = true;
            this.timeFechaHora.Tick += new System.EventHandler(this.timeFechaHora_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackgroundImage = global::_01_CapaPresentacion.Properties.Resources.FondoGym1;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1611, 661);
            this.panelContenedor.TabIndex = 6;
            // 
            // VentanaPrincipalJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 711);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaPrincipalJefe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMorado)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox LogoMorado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInventarios;
        private System.Windows.Forms.Button btnEntrenador;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button btnSocio;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.Button btnSecretarios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timeFechaHora;
        private System.Windows.Forms.Button btnFacturacion;
    }
}