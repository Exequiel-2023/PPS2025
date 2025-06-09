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
            CN_Socios socios = new CN_Socios();
            dgv_SocioInactivo.DataSource = null;
            dgv_SocioInactivo.DataSource = socios.SociosInactivos();
        }
    }
}
