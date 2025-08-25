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
            LimpiarInputs();
        }

        private void btn_EditarSecretario_Click(object sender, EventArgs e)
        {
            gb_Secretarios.Enabled = true;
            gb_Secretarios.Show();

            btn_EditarSecretario.Enabled = false;
            btn_EditarSecretario.Hide();

            dgv_ObtenerInfoSecretarios.Enabled = false;
            dgv_ObtenerInfoSecretarios.Hide() ;

            btn_EliminarSecretario.Enabled = false;
            btn_EliminarSecretario.Hide();

            btnVerSecretario.Enabled = false;
            btnVerSecretario.Hide() ;

            btnAgregarSecretario.Enabled = false;
            btnAgregarSecretario.Hide() ;

            btn_ConfirmarSecretario.Enabled = false;
            btn_ConfirmarSecretario.Hide() ;

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

            if (nombreCompleto == "" || dni == "" || domicilio == "" || telefono == "")
            {
                MessageBox.Show("Debes rellenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                secretarios.EditarSecretario(nombreCompleto, dni, domicilio, telefono, id);

                MessageBox.Show($" {nombreCompleto} fue editado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarSecretarios();
                LimpiarInputs();

                gb_Secretarios.Enabled = false;
                gb_Secretarios.Hide();

                btn_EliminarSecretario.Enabled = true;
                btn_EliminarSecretario.Show();

                btnVerSecretario.Enabled = true;
                btnVerSecretario.Show();

                btn_EditarSecretario.Enabled = true;
                btn_EditarSecretario.Show();

                btnAgregarSecretario.Enabled = true;
                btnAgregarSecretario.Show();

                dgv_ObtenerInfoSecretarios.Enabled = true;
                dgv_ObtenerInfoSecretarios.Show();
            }
        }

        private void btnAgregarSecretario_Click(object sender, EventArgs e)
        {
            btnAgregarSecretario.Enabled = false;
            btnAgregarSecretario.Hide();

            gb_Secretarios.Enabled = true;
            gb_Secretarios.Show();

            btn_ActualizarSecretario.Enabled = false;
            btn_ActualizarSecretario.Hide();

            dgv_ObtenerInfoSecretarios.Enabled = false;
            dgv_ObtenerInfoSecretarios.Hide() ;

            btn_EliminarSecretario.Enabled = false;
            btn_EliminarSecretario.Hide() ;

            btn_EditarSecretario.Enabled = false;
            btn_EditarSecretario.Hide();

            btnVerSecretario .Enabled = false;
            btnVerSecretario.Hide();
        }

        private void btn_ConfirmarSecretario_Click(object sender, EventArgs e)
        {
           

            string nombreCompleto = txt_NombreSecretario.Text;
            string dni = txt_DniSecretario.Text;
            string domicilio = txtDomicilioSecretario.Text;
            string telefono = txtTelefonoSecretario.Text;


            if (nombreCompleto == "" || dni == "" || domicilio == "" || telefono == "")
            {
                MessageBox.Show("Debes rellenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                secretarios.AgregarSecretario(nombreCompleto, dni, domicilio, telefono);
                MessageBox.Show($"El secretario {nombreCompleto} ah sido agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarSecretarios();
                LimpiarInputs();

                gb_Secretarios.Enabled = false;
                gb_Secretarios.Hide();

                dgv_ObtenerInfoSecretarios.Enabled = true;
                dgv_ObtenerInfoSecretarios.Show();

                btn_EliminarSecretario.Enabled = true;
                btn_EliminarSecretario.Show();

                btnVerSecretario.Enabled = true;
                btnVerSecretario.Show();

                btn_EditarSecretario.Enabled = true;
                btn_EditarSecretario.Show();

                btnAgregarSecretario.Enabled = true;
                btnAgregarSecretario.Show();
            }           
        }

        public void LimpiarInputs ()
        {
            txt_NombreSecretario.Clear();
            txt_DniSecretario.Clear();
            txtDomicilioSecretario.Clear();
            txtTelefonoSecretario.Clear();
        }

        private void txbBuscarSecretario_TextChanged(object sender, EventArgs e)
        {
            (dgv_ObtenerInfoSecretarios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Documento  LIKE '{0}%'", txbBuscarSecretario.Text);
        }
    }
}
