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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void visualizarSociosActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Socios socios = new Socios();
            socios.ShowDialog();
        }

        private void sociosConDeudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocioInactivo socioInactivo = new SocioInactivo();
            socioInactivo.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
