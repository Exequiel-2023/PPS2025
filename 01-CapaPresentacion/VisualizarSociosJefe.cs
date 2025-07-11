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
               
                string nombreCompleto = fila.Cells["NombreCompleto"].Value.ToString();
                string Dni = fila.Cells["Documento"].Value.ToString();
                string email = fila.Cells["Email"].Value.ToString();
                string Clase = fila.Cells["Clase"].Value.ToString();
                DateTime FechaIngreso = Convert.ToDateTime(fila.Cells["FechaIngreso"].Value);
                DateTime ProximoVencimiento = Convert.ToDateTime(fila.Cells["ProximoVencimiento"].Value);
                string ImagenURL = fila.Cells["ImagenURL"].Value.ToString();


                this.Hide();
                frmVerSocioActivo destino = new frmVerSocioActivo(nombreCompleto, Dni, email, Clase, FechaIngreso, ProximoVencimiento, ImagenURL);
                destino.Show();
            }
        }
    }
}
