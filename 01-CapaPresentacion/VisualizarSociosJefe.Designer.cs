namespace _01_CapaPresentacion
{
    partial class VisualizarSociosJefe
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
            this.dgvVisualizarSocios = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisualizarSocios
            // 
            this.dgvVisualizarSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarSocios.Location = new System.Drawing.Point(75, 28);
            this.dgvVisualizarSocios.Name = "dgvVisualizarSocios";
            this.dgvVisualizarSocios.ReadOnly = true;
            this.dgvVisualizarSocios.RowHeadersWidth = 51;
            this.dgvVisualizarSocios.RowTemplate.Height = 24;
            this.dgvVisualizarSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizarSocios.Size = new System.Drawing.Size(535, 287);
            this.dgvVisualizarSocios.TabIndex = 0;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(295, 352);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(699, 415);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // VisualizarSociosJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dgvVisualizarSocios);
            this.Name = "VisualizarSociosJefe";
            this.Text = "VisualizarSociosJefe";
            this.Load += new System.EventHandler(this.VisualizarSociosJefe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisualizarSocios;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAtras;
    }
}