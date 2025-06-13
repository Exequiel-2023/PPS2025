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
    public partial class EntrenadorInactivo : Form
    {
        CN_Entrenadores entrenador = new CN_Entrenadores();
        public EntrenadorInactivo()
        {
            InitializeComponent();
        }

        private void EntrenadorInactivo_Load(object sender, EventArgs e)
        {
            dgvEntrenadorInactivo.DataSource = null;
            dgvEntrenadorInactivo.DataSource = entrenador.MostrarEntrenadoresInactivos();
        }
    }
}
