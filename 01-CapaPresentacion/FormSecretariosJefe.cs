using _02_CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _01_CapaPresentacion
{
    public partial class FormSecretariosJefe : Form
    {
        CN_Secretarios secretarios = new CN_Secretarios();
        public FormSecretariosJefe()
        {
            InitializeComponent();
        }

        private void FormSecretariosJefe_Load(object sender, EventArgs e)
        {
            ListarSecretarios();
        }

        public void ListarSecretarios ()
        {
            CN_Secretarios secretarios = new CN_Secretarios();

            gb_Secretarios.Enabled = false;
            gb_Secretarios.Hide();

            dgv_ObtenerInfoSecretarios.DataSource = null;
            dgv_ObtenerInfoSecretarios.DataSource = secretarios.ObtenerInfoSecretarios();
        }

        private void btn_EliminarSecretario_Click(object sender, EventArgs e)
        {
            string nombreCompleto = dgv_ObtenerInfoSecretarios.CurrentRow.Cells["NombreCompleto"].Value.ToString();
            string identificador = dgv_ObtenerInfoSecretarios.CurrentRow.Cells["Id_Secretario"].Value.ToString();

            secretarios.EliminarSecretario(identificador);

            MessageBox.Show($"El secretario {nombreCompleto} fue eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListarSecretarios();
        }

        private void btn_EditarSecretario_Click(object sender, EventArgs e)
        {
            gb_Secretarios.Enabled = true;
            gb_Secretarios.Show();

            txt_NombreSecretario.Text = dgv_ObtenerInfoSecretarios.CurrentRow.Cells["NombreCompleto"].Value.ToString();
            txt_DniSecretario.Text = dgv_ObtenerInfoSecretarios.CurrentRow.Cells["Documento"].Value.ToString();
            txtDomicilioSecretario.Text = dgv_ObtenerInfoSecretarios.CurrentRow.Cells["Domicilio"].Value.ToString();
            txtTelefonoSecretario.Text = dgv_ObtenerInfoSecretarios.CurrentRow.Cells["Telefono"].Value.ToString();

        }

        private void btn_ActualizarSecretario_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txt_NombreSecretario.Text;
            string dni = txt_DniSecretario.Text;
            string domicilio = txtDomicilioSecretario.Text;
            string telefono = txtTelefonoSecretario.Text;



            string id = dgv_ObtenerInfoSecretarios.CurrentRow.Cells["Id_Secretario"].Value.ToString();

            if (nombreCompleto == "")
            {
                MessageBox.Show("Debes rellenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                secretarios.EditarSecretario(nombreCompleto, dni, domicilio, telefono, id);

                MessageBox.Show($" {nombreCompleto} fue editado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarSecretarios();
            }
        }

        private void btnAgregarSecretario_Click(object sender, EventArgs e)
        {
            gb_Secretarios.Enabled = true;
            gb_Secretarios.Show();
        }

        private void btn_ConfirmarSecretario_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txt_NombreSecretario.Text;
            string dni = txt_DniSecretario.Text;
            string domicilio = txtDomicilioSecretario.Text;
            string telefono = txtTelefonoSecretario.Text;


            if (nombreCompleto == "" || dni == "" || domicilio == "" || telefono == "")
            {
                MessageBox.Show("Debes rellenar todos los campos");
            }
            else
            {
                secretarios.AgregarSecretario(nombreCompleto, dni, domicilio, telefono);
                MessageBox.Show($"{nombreCompleto} ah sido agregado correctamente", "Nuevo Socio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarSecretarios();
        }
    }
}
