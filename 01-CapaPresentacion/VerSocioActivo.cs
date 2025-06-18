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
    public partial class frmVerSocioActivo : Form
    {
        public frmVerSocioActivo(string id, string nombre, string apellido, string dni, string telefono, string fechaIngreso)
        {
            InitializeComponent();
            txtId.Text = id;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtDni.Text = dni;
            txtTelefono.Text = telefono;
            txtFechaAlta.Text = fechaIngreso;

        }

        

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Socios V1 = new Socios();
            V1.ShowDialog();
        }

        
    }
}
