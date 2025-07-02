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
    public partial class Horarios : Form
    {
        CN_Horarios horarios = new CN_Horarios();
        public Horarios()
        {
            InitializeComponent();
        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            dgvHorarios.DataSource = null;
            dgvHorarios.DataSource = horarios.MostrarHorarios();
        }
    }
}
