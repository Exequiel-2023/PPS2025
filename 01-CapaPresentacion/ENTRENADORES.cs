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
    public partial class frmEntrenadores : Form
    {
        CN_Entrenadores entrenador = new CN_Entrenadores();
        CN_Socios socio = new CN_Socios();
        public frmEntrenadores()
        {
            InitializeComponent();
        }

        private void frmEntrenadores_Load(object sender, EventArgs e)
        {
            ListarEntrenadores();
        }

        public void ListarEntrenadores ()
        {
            CN_Entrenadores entrenador = new CN_Entrenadores();

            gbEntrenadores.Enabled = false;
            gbEntrenadores.Hide();

            dgvEntrenadores.DataSource = null;
            dgvEntrenadores.DataSource = entrenador.MostrarEntrenadores();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipal principal = new VentanaPrincipal();
            principal.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gbEntrenadores.Enabled = true;
            gbEntrenadores.Show();

            btnActualizar.Enabled = false;
            btnActualizar.Hide();
            btnEliminarFisico.Enabled = false;
            btnEliminarFisico.Hide();
            btnEliminarLogico.Enabled = false;
            btnEliminarLogico.Hide();
            btnEditar.Enabled = false;
            btnEditar.Hide();

            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;

            entrenador.InsertarEntrenador(nombre, apellido, dni, domicilio, telefono);
            MessageBox.Show($"{nombre} {apellido} fue agregado correctamente");
            ListarEntrenadores();  
            BorrarInputs();

        }

        public void BorrarInputs()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            string identificador = dgvEntrenadores.CurrentRow.Cells["Id_Entrenador"].Value.ToString();

            entrenador.EliminarFisico(identificador);
            MessageBox.Show("Entrenador eliminado fisicamente correctamente");
            ListarEntrenadores();

            
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            string identificador = dgvEntrenadores.CurrentRow.Cells["Id_Entrenador"].Value.ToString();

            entrenador.EliminarLogico(identificador);
            MessageBox.Show("Entrenador eliminado logicamente correctamente");
            ListarEntrenadores();
        }
    }
}
