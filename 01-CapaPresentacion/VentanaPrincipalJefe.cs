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
    public partial class VentanaPrincipalJefe : Form
    {   
       
        Inventario VentanaInventario = new Inventario();
        public VentanaPrincipalJefe()
        {
            InitializeComponent();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {   
            this.Hide();
            VisualizarSociosJefe visualizarSocio = new VisualizarSociosJefe();
            visualizarSocio.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInventario.ShowDialog();
        }
    }
}
