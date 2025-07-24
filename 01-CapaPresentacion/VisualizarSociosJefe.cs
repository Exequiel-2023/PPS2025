using _01_CapaPresentacion;
using _02_CapaNegocio;
using iTextSharp.text.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _01_CapaPresentacion
{
    public partial class VisualizarSociosJefe : Form
    {      
        CN_Socios socios = new CN_Socios();
        VentanaPrincipalJefe principal = new VentanaPrincipalJefe();
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


            DataGridViewRow fila = dgvVisualizarSocios.SelectedRows[0];

            string id = fila.Cells["Id_Socio"].Value.ToString();
            string nombreCompleto = fila.Cells["NombreCompleto"].Value.ToString();
            string Dni = fila.Cells["Dni"].Value.ToString();
            string email = fila.Cells["Email"].Value.ToString();
            string clase = fila.Cells["Clase"].Value.ToString();
            DateTime FechaIngreso = Convert.ToDateTime(fila.Cells["FechaIngreso"].Value);
            DateTime ProximoVencimiento = Convert.ToDateTime(fila.Cells["ProximoVencimiento"].Value);
            string Estado = fila.Cells["Estado"].Value.ToString();
            string ImagenURL = fila.Cells["ImagenURL"].Value.ToString();


            VerDetalleSocioJefe destino = new VerDetalleSocioJefe();
            destino.CargarDatos(id, nombreCompleto, Dni, email, clase, FechaIngreso, ProximoVencimiento, Estado, ImagenURL);
            
            VentanaPrincipalJefe principal = (VentanaPrincipalJefe)this.ParentForm;

            principal.AbrirFormularioEnPanel(destino);
        }
        
    }
}

