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

      

        private void visualizarEntrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEntrenadores frmEntrenadores = new frmEntrenadores();
            frmEntrenadores.ShowDialog();
        }

        private void registrarNuevoEntrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntrenadorInactivo EntrenadorInactivo = new EntrenadorInactivo();
            EntrenadorInactivo.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inventario = new Inventario();
            inventario.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            if (frm_login.id_logeo  == "1")
            {
                //MessageBox.Show("Bienvenido jefe");
            }
            if (frm_login.id_logeo == "2" || frm_login.id_logeo == "3")
            {
                //MessageBox.Show("Bienvenido secretario");
            }
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Horarios MostrarHorarios = new Horarios();
            this.Hide();
            MostrarHorarios.ShowDialog();
        }
    }
}
