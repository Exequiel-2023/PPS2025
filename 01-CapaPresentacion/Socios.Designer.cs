namespace _01_CapaPresentacion
{
    partial class Socios
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
            this.dgv_Socios = new System.Windows.Forms.DataGridView();
            this.btn_EliminarFisico = new System.Windows.Forms.Button();
            this.btn_EliminarLogico = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.gb_Socios = new System.Windows.Forms.GroupBox();
            this.txt_FechaIngreso = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_FechaIngreso = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Socios)).BeginInit();
            this.gb_Socios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Socios
            // 
            this.dgv_Socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Socios.Location = new System.Drawing.Point(24, 74);
            this.dgv_Socios.Name = "dgv_Socios";
            this.dgv_Socios.RowHeadersWidth = 51;
            this.dgv_Socios.RowTemplate.Height = 24;
            this.dgv_Socios.Size = new System.Drawing.Size(749, 427);
            this.dgv_Socios.TabIndex = 0;
            // 
            // btn_EliminarFisico
            // 
            this.btn_EliminarFisico.Location = new System.Drawing.Point(24, 571);
            this.btn_EliminarFisico.Name = "btn_EliminarFisico";
            this.btn_EliminarFisico.Size = new System.Drawing.Size(145, 23);
            this.btn_EliminarFisico.TabIndex = 1;
            this.btn_EliminarFisico.Text = "Eliminar Fisico";
            this.btn_EliminarFisico.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarLogico
            // 
            this.btn_EliminarLogico.Location = new System.Drawing.Point(268, 571);
            this.btn_EliminarLogico.Name = "btn_EliminarLogico";
            this.btn_EliminarLogico.Size = new System.Drawing.Size(147, 23);
            this.btn_EliminarLogico.TabIndex = 2;
            this.btn_EliminarLogico.Text = "Eliminar Logico";
            this.btn_EliminarLogico.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(649, 571);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(43, 385);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(203, 385);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 5;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 59);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_Nombre.TabIndex = 6;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(1057, 655);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 23);
            this.btn_Atras.TabIndex = 7;
            this.btn_Atras.Text = "Atras";
            this.btn_Atras.UseVisualStyleBackColor = true;
            // 
            // gb_Socios
            // 
            this.gb_Socios.Controls.Add(this.txt_FechaIngreso);
            this.gb_Socios.Controls.Add(this.txt_Telefono);
            this.gb_Socios.Controls.Add(this.txt_Dni);
            this.gb_Socios.Controls.Add(this.txt_Apellido);
            this.gb_Socios.Controls.Add(this.txt_Nombre);
            this.gb_Socios.Controls.Add(this.lbl_FechaIngreso);
            this.gb_Socios.Controls.Add(this.lbl_Telefono);
            this.gb_Socios.Controls.Add(this.lbl_Dni);
            this.gb_Socios.Controls.Add(this.lbl_Apellido);
            this.gb_Socios.Controls.Add(this.btn_Agregar);
            this.gb_Socios.Controls.Add(this.btn_Actualizar);
            this.gb_Socios.Controls.Add(this.lbl_Nombre);
            this.gb_Socios.Location = new System.Drawing.Point(804, 74);
            this.gb_Socios.Name = "gb_Socios";
            this.gb_Socios.Size = new System.Drawing.Size(328, 427);
            this.gb_Socios.TabIndex = 8;
            this.gb_Socios.TabStop = false;
            this.gb_Socios.Text = "Ingresa un nuevo socio:";
            // 
            // txt_FechaIngreso
            // 
            this.txt_FechaIngreso.Location = new System.Drawing.Point(114, 283);
            this.txt_FechaIngreso.Name = "txt_FechaIngreso";
            this.txt_FechaIngreso.Size = new System.Drawing.Size(173, 22);
            this.txt_FechaIngreso.TabIndex = 15;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(114, 223);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(173, 22);
            this.txt_Telefono.TabIndex = 14;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(114, 169);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(173, 22);
            this.txt_Dni.TabIndex = 13;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(114, 114);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(173, 22);
            this.txt_Apellido.TabIndex = 12;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(114, 59);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(173, 22);
            this.txt_Nombre.TabIndex = 11;
            // 
            // lbl_FechaIngreso
            // 
            this.lbl_FechaIngreso.AutoSize = true;
            this.lbl_FechaIngreso.Location = new System.Drawing.Point(6, 286);
            this.lbl_FechaIngreso.Name = "lbl_FechaIngreso";
            this.lbl_FechaIngreso.Size = new System.Drawing.Size(93, 16);
            this.lbl_FechaIngreso.TabIndex = 10;
            this.lbl_FechaIngreso.Text = "Fecha Ingreso";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(6, 229);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(61, 16);
            this.lbl_Telefono.TabIndex = 9;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(6, 169);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(27, 16);
            this.lbl_Dni.TabIndex = 8;
            this.lbl_Dni.Text = "Dni";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(6, 114);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(57, 16);
            this.lbl_Apellido.TabIndex = 7;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // Socios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 699);
            this.Controls.Add(this.gb_Socios);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_EliminarLogico);
            this.Controls.Add(this.btn_EliminarFisico);
            this.Controls.Add(this.dgv_Socios);
            this.Name = "Socios";
            this.Text = "Socios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Socios)).EndInit();
            this.gb_Socios.ResumeLayout(false);
            this.gb_Socios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Socios;
        private System.Windows.Forms.Button btn_EliminarFisico;
        private System.Windows.Forms.Button btn_EliminarLogico;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.GroupBox gb_Socios;
        private System.Windows.Forms.TextBox txt_FechaIngreso;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_FechaIngreso;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.Label lbl_Apellido;
    }
}