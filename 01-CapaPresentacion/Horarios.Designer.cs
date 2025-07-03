namespace _01_CapaPresentacion
{
    partial class Horarios
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
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(84, 70);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.RowHeadersWidth = 51;
            this.dgvHorarios.RowTemplate.Height = 24;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.Size = new System.Drawing.Size(662, 429);
            this.dgvHorarios.TabIndex = 0;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(283, 13);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(78, 16);
            this.lblHorarios.TabIndex = 1;
            this.lblHorarios.Text = "HORARIOS";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(851, 577);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 628);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.dgvHorarios);
            this.Name = "Horarios";
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Button btnAtras;
    }
}