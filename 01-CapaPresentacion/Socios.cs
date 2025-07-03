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
    public partial class Socios : Form
    {
        
        CN_Socios socio = new CN_Socios();

        //public MessageBoxButtons MessageBoxButton { get; private set; }

        public Socios()
        {
            InitializeComponent();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipal V1 = new VentanaPrincipal();
            V1.Show();

            
        }

        private void Socios_Load(object sender, EventArgs e)
        {
            cboClase.Items.Add("Zumba");
            cboClase.Items.Add("Boxeo");
            cboClase.Items.Add("Spining");

            btn_Actualizar.Enabled = false;
            btn_Actualizar.Hide();
            ListarSocio();


        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            string dni = txt_Dni.Text;
            string telefono = txt_Telefono.Text;
            DateTime fecha = dtpFechaIngreso.Value;

            if (nombre == "" || apellido == "" || dni == "" || telefono == "")
            {
                MessageBox.Show("Debes rellenar todos los campos");
            }
            else
            {
                socio.InsertarSocio(nombre, apellido, dni, telefono, fecha);
                MessageBox.Show($"{nombre} ah sido agregado correctamente", "Nuevo Socio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarSocio();
                BorrarInputs();
            }
          
        }

        public void ListarSocio ()
        {
            CN_Socios socio = new CN_Socios();
            dgv_Socios.DataSource = null;
            dgv_Socios.DataSource = socio.MostrarSocios();
        }

        public void BorrarInputs()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Dni.Clear();
            txt_Telefono.Clear();
           
        }

        private void btn_EliminarFisico_Click(object sender, EventArgs e)
        {
            string identificador = dgv_Socios.CurrentRow.Cells["Id_Socio"].Value.ToString();
            socio.EliminarFisico(identificador);
            
            MessageBox.Show($"El socio fue eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarSocio();
        }

        private void btn_EliminarLogico_Click(object sender, EventArgs e)
        {
            string identificador = dgv_Socios.CurrentRow.Cells["Id_Socio"].Value.ToString();
            socio.EliminarLogico(identificador);
            MessageBox.Show("el socio fue eliminado logicamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarSocio();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = false;
            btn_Agregar.Hide();

            btn_Actualizar.Enabled = true;
            btn_Actualizar.Show();

            txt_Nombre.Enabled = false;
            txt_Apellido.Enabled = false;
            txt_Dni.Enabled = false;

            txt_Nombre.Text = dgv_Socios.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_Apellido.Text = dgv_Socios.CurrentRow.Cells["Apellido"].Value.ToString();
            txt_Dni.Text = dgv_Socios.CurrentRow.Cells["Dni"].Value.ToString();
            txt_Telefono.Text = dgv_Socios.CurrentRow.Cells["Telefono"].Value.ToString();
            dtpFechaIngreso.Text = dgv_Socios.CurrentRow.Cells["FechaIngreso"].Value.ToString();

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            string dni = txt_Dni.Text;
            string telefono = txt_Telefono.Text;
            DateTime fecha = dtpFechaIngreso.Value;

            string id = dgv_Socios.CurrentRow.Cells["Id_Socio"].Value.ToString();

            if (telefono == "" )
            {
                MessageBox.Show("Debes rellenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                socio.EditarSocio(nombre, apellido, dni, telefono, fecha.ToString(), id);

                MessageBox.Show($" {nombre} fue editado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarSocio();
                BorrarInputs();
            }

            
            
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgv_Socios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgv_Socios.SelectedRows[0];
                string id = fila.Cells["Id_Socio"].Value.ToString();
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string apellido = fila.Cells["Apellido"].Value.ToString();
                string dni = fila.Cells["Dni"].Value.ToString();
                string telefono = fila.Cells["Telefono"].Value.ToString();
                string fechaIngreso = fila.Cells["FechaIngreso"].Value.ToString();

                this.Hide();
                frmVerSocioActivo destino = new frmVerSocioActivo(id,nombre,apellido,dni,telefono, fechaIngreso);
                destino.Show();
            }






        }

        private void txbSocioActivo_TextChanged(object sender, EventArgs e)
        {
            (dgv_Socios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre  LIKE '{0}%'", txbSocioActivo.Text);
        }
    }
}
