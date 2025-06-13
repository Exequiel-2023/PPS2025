﻿using _02_CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_CapaPresentacion
{
    public partial class EntrenadorInactivo : Form
    {
        CN_Entrenadores entrenador = new CN_Entrenadores();
        public EntrenadorInactivo()
        {
            InitializeComponent();
        }

        private void EntrenadorInactivo_Load(object sender, EventArgs e)
        {
            dgvEntrenadorInactivo.DataSource = null;
            dgvEntrenadorInactivo.DataSource = entrenador.MostrarEntrenadoresInactivos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipal V1 = new VentanaPrincipal();
            V1.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbEntrenadorInactivo.Enabled = true;
            gbEntrenadorInactivo.Show();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtNombre.Text = dgvEntrenadorInactivo.CurrentRow.Cells["Nombre Entrenador"].Value.ToString();
            txtApellido.Text = dgvEntrenadorInactivo.CurrentRow.Cells["Apellido"].Value.ToString();
            txtDni.Text = dgvEntrenadorInactivo.CurrentRow.Cells["Dni"].Value.ToString();
            txtDomicilio.Text = dgvEntrenadorInactivo.CurrentRow.Cells["Domicilio"].Value.ToString();
            txtTelefono.Text = dgvEntrenadorInactivo.CurrentRow.Cells["Telefono"].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EntrenadorInactivo entrenadorInactivo = new EntrenadorInactivo();



            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            string activo = txtActivo.Text;
            

            string identificador = dgvEntrenadorInactivo.CurrentRow.Cells["Id_Entrenador"].Value.ToString();

            entrenador.DarAltaEntrenador(domicilio, telefono,activo,identificador);

            MessageBox.Show("Entrenador editado correctamente");

            entrenadorInactivo.ShowDialog();





        }
    }
}
