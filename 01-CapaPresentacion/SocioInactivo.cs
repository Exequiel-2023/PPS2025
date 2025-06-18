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
    public partial class SocioInactivo : Form
    {
        CN_Socios socios = new CN_Socios();
        public SocioInactivo()
        {
            InitializeComponent();
        }

        private void SocioInactivo_Load(object sender, EventArgs e)
        {
            ListarSocioInactivo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDni.Enabled = false;

            txtNombre.Text = dgv_SocioInactivo.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgv_SocioInactivo.CurrentRow.Cells["Apellido"].Value.ToString();
            txtDni.Text = dgv_SocioInactivo.CurrentRow.Cells["Dni"].Value.ToString();
            txtTelefono.Text = dgv_SocioInactivo.CurrentRow.Cells["Telefono"].Value.ToString();
            txtFechaAlta.Text = dgv_SocioInactivo.CurrentRow.Cells["FechaIngreso"].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SocioInactivo socioInactivo = new SocioInactivo();
            
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string fechaIngreso = txtFechaAlta.Text;
            string Activo = txtActivo.Text;

            string id = dgv_SocioInactivo.CurrentRow.Cells["Id_Socio"].Value.ToString();

            if (telefono == "" || fechaIngreso == "" || Activo == "")
            {
                MessageBox.Show("Debes rellenar todos los campos");
            }
            else
            {
                socios.DarAltaSocio(fechaIngreso, Activo, id);

                MessageBox.Show($" {nombre} fue editado con exito");

                ListarSocioInactivo();
            }

            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipal V1 = new VentanaPrincipal();
            V1.Show();
        }

        public void ListarSocioInactivo()
        {
            CN_Socios socios = new CN_Socios();
            dgv_SocioInactivo.DataSource = null;
            dgv_SocioInactivo.DataSource = socios.SociosInactivos();
        }
    }
}
