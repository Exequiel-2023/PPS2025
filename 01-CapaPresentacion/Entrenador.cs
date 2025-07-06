using _02_CapaNegocio;
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
    public partial class Entrenador : Form
    {
        CN_Entrenadores entrenador = new CN_Entrenadores();
        public Entrenador()
        {
            InitializeComponent();
        }

    

        private void Entrenador_Load(object sender, EventArgs e)
        {
            ListarEntrenadores();
        }

        public void ListarEntrenadores()
        {
            CN_Entrenadores entrenador = new CN_Entrenadores();

            gbEntrenadores.Enabled = false;
            gbEntrenadores.Hide();

            dgvEntrenadores.DataSource = null;
            dgvEntrenadores.DataSource = entrenador.MostrarEntrenadores();
        }
        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            string identificador = dgvEntrenadores.CurrentRow.Cells["Id_Entrenador"].Value.ToString();

            entrenador.EliminarLogico(identificador);
            MessageBox.Show("Entrenador eliminado logicamente correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarEntrenadores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbEntrenadores.Enabled = true;
            gbEntrenadores.Show();
            btnActualizar.Enabled = true;
            btnActualizar.Show();
            btnEliminarLogico.Enabled = false;
            btnEliminarLogico.Hide();
            btnAgregar.Enabled = false;
            btnAgregar.Hide();
            btnConfirmar.Enabled = false;
            btnConfirmar.Hide();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtNombre.Text = dgvEntrenadores.CurrentRow.Cells["Nombre Entrenador"].Value.ToString();
            txtApellido.Text = dgvEntrenadores.CurrentRow.Cells["Apellido"].Value.ToString();
            txtDni.Text = dgvEntrenadores.CurrentRow.Cells["Dni"].Value.ToString();
            txtDomicilio.Text = dgvEntrenadores.CurrentRow.Cells["Domicilio"].Value.ToString();
            txtTelefono.Text = dgvEntrenadores.CurrentRow.Cells["Telefono"].Value.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;

            if (nombre == "" || apellido == "" || dni == "" || domicilio == "" || telefono == "")
            {
                MessageBox.Show("Debes completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                entrenador.InsertarEntrenador(nombre, apellido, dni, domicilio, telefono);
                MessageBox.Show($"{nombre} {apellido} fue agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarEntrenadores();
                BorrarInputs();

                btnEliminarLogico.Enabled = true;
                btnEliminarLogico.Show();
                btnEditar.Enabled = true;
                btnEditar.Show();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            string identificador = dgvEntrenadores.CurrentRow.Cells["Id_Entrenador"].Value.ToString();

            entrenador.EditarEntrenador(nombre, apellido, dni, domicilio, telefono, identificador);

            MessageBox.Show("Entrenador editado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListarEntrenadores();
            BorrarInputs();

     
            btnEliminarLogico.Enabled = true;
            btnEliminarLogico.Show();
            btnEditar.Enabled = true;
            btnEditar.Show();
            btnAgregar.Enabled = true;
            btnAgregar.Show();
        }

        public void BorrarInputs()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gbEntrenadores.Enabled = true;
            gbEntrenadores.Show();

            btnActualizar.Enabled = false;
            btnActualizar.Hide();
            btnEliminarLogico.Enabled = false;
            btnEliminarLogico.Hide();
            btnEditar.Enabled = false;
            btnEditar.Hide();
        }
    }
}
