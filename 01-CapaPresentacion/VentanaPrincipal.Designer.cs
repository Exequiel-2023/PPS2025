namespace _01_CapaPresentacion
{
    partial class VentanaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarSociosActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosConDeudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarEntrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoEntrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.entrenadoresToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarSociosActivosToolStripMenuItem,
            this.sociosConDeudasToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // visualizarSociosActivosToolStripMenuItem
            // 
            this.visualizarSociosActivosToolStripMenuItem.Name = "visualizarSociosActivosToolStripMenuItem";
            this.visualizarSociosActivosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.visualizarSociosActivosToolStripMenuItem.Text = "Visualizar socios activos";
            this.visualizarSociosActivosToolStripMenuItem.Click += new System.EventHandler(this.visualizarSociosActivosToolStripMenuItem_Click);
            // 
            // sociosConDeudasToolStripMenuItem
            // 
            this.sociosConDeudasToolStripMenuItem.Name = "sociosConDeudasToolStripMenuItem";
            this.sociosConDeudasToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.sociosConDeudasToolStripMenuItem.Text = "Socios con deudas";
            this.sociosConDeudasToolStripMenuItem.Click += new System.EventHandler(this.sociosConDeudasToolStripMenuItem_Click);
            // 
            // entrenadoresToolStripMenuItem
            // 
            this.entrenadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarEntrenadoresToolStripMenuItem,
            this.registrarNuevoEntrenadorToolStripMenuItem});
            this.entrenadoresToolStripMenuItem.Name = "entrenadoresToolStripMenuItem";
            this.entrenadoresToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.entrenadoresToolStripMenuItem.Text = "Entrenadores";
            // 
            // visualizarEntrenadoresToolStripMenuItem
            // 
            this.visualizarEntrenadoresToolStripMenuItem.Name = "visualizarEntrenadoresToolStripMenuItem";
            this.visualizarEntrenadoresToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.visualizarEntrenadoresToolStripMenuItem.Text = "Entrenadores Activos";
            this.visualizarEntrenadoresToolStripMenuItem.Click += new System.EventHandler(this.visualizarEntrenadoresToolStripMenuItem_Click);
            // 
            // registrarNuevoEntrenadorToolStripMenuItem
            // 
            this.registrarNuevoEntrenadorToolStripMenuItem.Name = "registrarNuevoEntrenadorToolStripMenuItem";
            this.registrarNuevoEntrenadorToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.registrarNuevoEntrenadorToolStripMenuItem.Text = "Entrenadores Inactivos";
            this.registrarNuevoEntrenadorToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoEntrenadorToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarSociosActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosConDeudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarEntrenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoEntrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
    }
}