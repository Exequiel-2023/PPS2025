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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Socios = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.gb_Socios = new System.Windows.Forms.GroupBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.cboClase = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_FechaIngreso = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txbSocioActivo = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_EliminarLogico = new System.Windows.Forms.Button();
            this.btn_EliminarFisico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Socios)).BeginInit();
            this.gb_Socios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Socios
            // 
            this.dgv_Socios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Socios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Socios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Socios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Socios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Socios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Socios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Socios.ColumnHeadersHeight = 30;
            this.dgv_Socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Socios.EnableHeadersVisualStyles = false;
            this.dgv_Socios.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_Socios.Location = new System.Drawing.Point(1, 47);
            this.dgv_Socios.Name = "dgv_Socios";
            this.dgv_Socios.ReadOnly = true;
            this.dgv_Socios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Socios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Socios.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Socios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Socios.RowTemplate.Height = 24;
            this.dgv_Socios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Socios.Size = new System.Drawing.Size(1001, 586);
            this.dgv_Socios.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_Agregar.Location = new System.Drawing.Point(25, 477);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(100, 36);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.btn_Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_Actualizar.Location = new System.Drawing.Point(251, 483);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(114, 30);
            this.btn_Actualizar.TabIndex = 5;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 59);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(84, 24);
            this.lbl_Nombre.TabIndex = 6;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // gb_Socios
            // 
            this.gb_Socios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.gb_Socios.Controls.Add(this.lblClase);
            this.gb_Socios.Controls.Add(this.cboClase);
            this.gb_Socios.Controls.Add(this.dtpFechaIngreso);
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
            this.gb_Socios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Socios.ForeColor = System.Drawing.Color.White;
            this.gb_Socios.Location = new System.Drawing.Point(1008, 47);
            this.gb_Socios.Name = "gb_Socios";
            this.gb_Socios.Size = new System.Drawing.Size(389, 586);
            this.gb_Socios.TabIndex = 8;
            this.gb_Socios.TabStop = false;
            this.gb_Socios.Text = "Ingresa un nuevo socio:";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(6, 342);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(62, 24);
            this.lblClase.TabIndex = 17;
            this.lblClase.Text = "Clase:";
            // 
            // cboClase
            // 
            this.cboClase.FormattingEnabled = true;
            this.cboClase.Location = new System.Drawing.Point(144, 336);
            this.cboClase.Name = "cboClase";
            this.cboClase.Size = new System.Drawing.Size(121, 30);
            this.cboClase.TabIndex = 16;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(144, 281);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(233, 28);
            this.dtpFechaIngreso.TabIndex = 15;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(144, 223);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(233, 28);
            this.txt_Telefono.TabIndex = 14;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(144, 169);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(233, 28);
            this.txt_Dni.TabIndex = 13;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(144, 114);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(233, 28);
            this.txt_Apellido.TabIndex = 12;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(144, 59);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(233, 28);
            this.txt_Nombre.TabIndex = 11;
            // 
            // lbl_FechaIngreso
            // 
            this.lbl_FechaIngreso.AutoSize = true;
            this.lbl_FechaIngreso.Location = new System.Drawing.Point(6, 286);
            this.lbl_FechaIngreso.Name = "lbl_FechaIngreso";
            this.lbl_FechaIngreso.Size = new System.Drawing.Size(137, 24);
            this.lbl_FechaIngreso.TabIndex = 10;
            this.lbl_FechaIngreso.Text = "Fecha Ingreso:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(6, 223);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(90, 24);
            this.lbl_Telefono.TabIndex = 9;
            this.lbl_Telefono.Text = "Telefono:";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(6, 169);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(43, 24);
            this.lbl_Dni.TabIndex = 8;
            this.lbl_Dni.Text = "Dni:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_Apellido.Location = new System.Drawing.Point(6, 114);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(84, 24);
            this.lbl_Apellido.TabIndex = 7;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(108, 13);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(68, 24);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Buscar";
            // 
            // txbSocioActivo
            // 
            this.txbSocioActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSocioActivo.Location = new System.Drawing.Point(185, 13);
            this.txbSocioActivo.Name = "txbSocioActivo";
            this.txbSocioActivo.Size = new System.Drawing.Size(412, 28);
            this.txbSocioActivo.TabIndex = 11;
            this.txbSocioActivo.TextChanged += new System.EventHandler(this.txbSocioActivo_TextChanged);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = global::_01_CapaPresentacion.Properties.Resources.edit1;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(590, 689);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(94, 40);
            this.btnVer.TabIndex = 9;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_Atras.FlatAppearance.BorderSize = 0;
            this.btn_Atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atras.Image = global::_01_CapaPresentacion.Properties.Resources.skip_back1;
            this.btn_Atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Atras.Location = new System.Drawing.Point(1299, 711);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(98, 30);
            this.btn_Atras.TabIndex = 7;
            this.btn_Atras.Text = "Atras";
            this.btn_Atras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Atras.UseVisualStyleBackColor = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Image = global::_01_CapaPresentacion.Properties.Resources.edit2;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(790, 689);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(111, 40);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_EliminarLogico
            // 
            this.btn_EliminarLogico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_EliminarLogico.FlatAppearance.BorderSize = 0;
            this.btn_EliminarLogico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_EliminarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarLogico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarLogico.Image = global::_01_CapaPresentacion.Properties.Resources.trash__1_;
            this.btn_EliminarLogico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarLogico.Location = new System.Drawing.Point(282, 689);
            this.btn_EliminarLogico.Name = "btn_EliminarLogico";
            this.btn_EliminarLogico.Size = new System.Drawing.Size(187, 40);
            this.btn_EliminarLogico.TabIndex = 2;
            this.btn_EliminarLogico.Text = "Eliminar Logico";
            this.btn_EliminarLogico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EliminarLogico.UseVisualStyleBackColor = false;
            this.btn_EliminarLogico.Click += new System.EventHandler(this.btn_EliminarLogico_Click);
            // 
            // btn_EliminarFisico
            // 
            this.btn_EliminarFisico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_EliminarFisico.FlatAppearance.BorderSize = 0;
            this.btn_EliminarFisico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_EliminarFisico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_EliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarFisico.Image = global::_01_CapaPresentacion.Properties.Resources.trash__1_;
            this.btn_EliminarFisico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarFisico.Location = new System.Drawing.Point(48, 689);
            this.btn_EliminarFisico.Name = "btn_EliminarFisico";
            this.btn_EliminarFisico.Size = new System.Drawing.Size(182, 40);
            this.btn_EliminarFisico.TabIndex = 1;
            this.btn_EliminarFisico.Text = "Eliminar Fisico";
            this.btn_EliminarFisico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EliminarFisico.UseVisualStyleBackColor = false;
            this.btn_EliminarFisico.Click += new System.EventHandler(this.btn_EliminarFisico_Click);
            // 
            // Socios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1409, 768);
            this.Controls.Add(this.txbSocioActivo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.gb_Socios);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_EliminarLogico);
            this.Controls.Add(this.btn_EliminarFisico);
            this.Controls.Add(this.dgv_Socios);
            this.Name = "Socios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOCIOS ACTIVO";
            this.Load += new System.EventHandler(this.Socios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Socios)).EndInit();
            this.gb_Socios.ResumeLayout(false);
            this.gb_Socios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_FechaIngreso;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.ComboBox cboClase;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txbSocioActivo;
    }
}