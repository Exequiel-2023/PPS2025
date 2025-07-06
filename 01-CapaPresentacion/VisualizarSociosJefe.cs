using _02_CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_CapaPresentacion
{
    public partial class VisualizarSociosJefe : Form
    {      
        CN_Socios socios = new CN_Socios();
        public VisualizarSociosJefe()
        {
            InitializeComponent();
        }

     

        private void VisualizarSociosJefe_Load(object sender, EventArgs e)
        {
            dgvVisualizarSocios.DataSource = null;
            dgvVisualizarSocios.DataSource = socios.MostrarSocios();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvVisualizarSocios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvVisualizarSocios.SelectedRows[0];
                string id = fila.Cells["Id_Socio"].Value.ToString();
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string apellido = fila.Cells["Apellido"].Value.ToString();
                string dni = fila.Cells["Dni"].Value.ToString();
                string telefono = fila.Cells["Telefono"].Value.ToString();
                string fechaIngreso = fila.Cells["FechaIngreso"].Value.ToString();

                this.Hide();
                frmVerSocioActivo destino = new frmVerSocioActivo(id, nombre, apellido, dni, telefono, fechaIngreso);
                destino.Show();
            }
        }
    }
}
