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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbEntrenadores.Enabled = true;
            gbEntrenadores.Show();

            btnEditar.Enabled = false;
            btnEditar.Hide();

            btnActualizar.Enabled = true;
            btnActualizar.Show();

            btnEliminarFisico.Enabled = false;
            btnEliminarFisico.Hide();

            btnAgregar.Enabled = false;
            btnAgregar.Hide();

            btnConfirmar.Enabled = false;
            btnConfirmar.Hide();

            dgvEntrenadores.Enabled = false;
            dgvEntrenadores.Hide();

            lblBuscarEntrenador.Enabled = false;
            lblBuscarEntrenador.Hide();

            txbBuscarEntrenador.Enabled = false;
            txbBuscarEntrenador.Hide();

            txtNombre.Enabled = false;
          
            txtDni.Enabled = false;
            txtNombre.Text = dgvEntrenadores.CurrentRow.Cells["NombreCompleto"].Value.ToString();
            txtDni.Text = dgvEntrenadores.CurrentRow.Cells["Dni"].Value.ToString();
            txtDomicilio.Text = dgvEntrenadores.CurrentRow.Cells["Domicilio"].Value.ToString();
            cboClaseEntrenador.Text = dgvEntrenadores.CurrentRow.Cells["Clase"].Value.ToString();
            txtTelefono.Text = dgvEntrenadores.CurrentRow.Cells["Telefono"].Value.ToString();
            cboEstadoEntrenador.Text = dgvEntrenadores.CurrentRow.Cells["Estado"].Value.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtNombre.Text;
            string dni = txtDni.Text;
            string domicilio = txtDomicilio.Text;
            string clase = cboClaseEntrenador.Text;
            string telefono = txtTelefono.Text;
            string estado = cboEstadoEntrenador.Text;

            if (nombreCompleto == "" || dni == "" || domicilio == "" || clase == "" || telefono == "")
            {
                MessageBox.Show("Debes completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                entrenador.InsertarEntrenador(nombreCompleto, dni, domicilio, clase, telefono, estado);
                MessageBox.Show($"{nombreCompleto} fue agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarEntrenadores();
                BorrarInputs();

                btnEliminarFisico.Enabled = true;
                btnEliminarFisico.Show();

                btnEditar.Enabled = true;
                btnEditar.Show();

                btnAgregar.Enabled = true;
                btnAgregar.Show();

                dgvEntrenadores.Enabled = true;
                dgvEntrenadores.Show();

                lblBuscarEntrenador.Enabled = true;
                lblBuscarEntrenador.Show();

                txbBuscarEntrenador.Enabled = true;
                txbBuscarEntrenador.Show();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //string nombreCompleto = txtNombre.Text;
            //string dni = txtDni.Text;
            string domicilio = txtDomicilio.Text;
            string clase = cboClaseEntrenador.Text;
            string telefono = txtTelefono.Text;
            string estado = cboEstadoEntrenador.Text;
            string identificador = dgvEntrenadores.CurrentRow.Cells["Id_Entrenador"].Value.ToString();

            entrenador.EditarEntrenador(domicilio, clase, telefono, estado, identificador);

            MessageBox.Show("Entrenador editado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BorrarInputs();
            ListarEntrenadores();
       

            dgvEntrenadores.Enabled = true;
            dgvEntrenadores.Show();

            lblBuscarEntrenador.Enabled = true;
            lblBuscarEntrenador.Show();

            txbBuscarEntrenador.Enabled = true;
            txbBuscarEntrenador.Show();
            
            btnEliminarFisico.Enabled = true;
            btnEliminarFisico.Show();

            btnEditar.Enabled = true;
            btnEditar.Show();

            btnAgregar.Enabled = true;
            btnAgregar.Show();
        }

        public void BorrarInputs()
        {
            txtNombre.Clear();
            txtDni.Clear();
            txtDomicilio.Clear();
            cboEstadoEntrenador.Text = "";
            cboEstadoEntrenador.Items.Clear();
            txtTelefono.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            gbEntrenadores.Enabled = true;
            gbEntrenadores.Show();

            btnAgregar.Enabled = false;
            btnAgregar.Hide();

            btnActualizar.Enabled = false;
            btnActualizar.Hide();

            btnEliminarFisico.Enabled = false;
            btnEliminarFisico.Hide();

            btnEditar.Enabled = false;
            btnEditar.Hide();

            dgvEntrenadores.Enabled = false;
            dgvEntrenadores.Hide();

            lblBuscarEntrenador.Enabled = false;
            lblBuscarEntrenador.Hide();

            txbBuscarEntrenador.Enabled = false;
            txbBuscarEntrenador.Hide();

        }

        private void txbBuscarEntrenador_TextChanged(object sender, EventArgs e)
        {            
            (dgvEntrenadores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Dni  LIKE '{0}%'", txbBuscarEntrenador.Text);
        }

        private void gbEntrenadores_Enter(object sender, EventArgs e)
        {
            cboClaseEntrenador.Items.Add("Zumba");
            cboClaseEntrenador.Items.Add("Boxeo");
            cboClaseEntrenador.Items.Add("Spining");

            cboEstadoEntrenador.Items.Add("Activo");
            cboEstadoEntrenador.Items.Add("Inactivo");
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            string identificador = dgvEntrenadores.CurrentRow.Cells["Id_Entrenador"].Value.ToString();
            entrenador.EliminarEntrenador(identificador);

            MessageBox.Show("Entrenador eliminado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListarEntrenadores();
        }
    }
}
