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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SocioInactivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SocioInactivo
            // 
            this.dgv_SocioInactivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SocioInactivo.Location = new System.Drawing.Point(57, 48);
            this.dgv_SocioInactivo.Name = "dgv_SocioInactivo";
            this.dgv_SocioInactivo.ReadOnly = true;
            this.dgv_SocioInactivo.RowHeadersWidth = 51;
            this.dgv_SocioInactivo.RowTemplate.Height = 24;
            this.dgv_SocioInactivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SocioInactivo.Size = new System.Drawing.Size(573, 316);
            this.dgv_SocioInactivo.TabIndex = 0;
            // 
            // SocioInactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_SocioInactivo);
            this.Name = "SocioInactivo";
            this.Text = "SocioInactivo";
            this.Load += new System.EventHandler(this.SocioInactivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SocioInactivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SocioInactivo;
    }
}