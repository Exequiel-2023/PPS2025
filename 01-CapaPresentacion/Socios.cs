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
            string fechaIngreso = txt_FechaIngreso.Text;

            socio.InsertarSocio(nombre,apellido, dni, telefono, fechaIngreso);
            MessageBox.Show($"{nombre} ah sido agregado correctamente");
            ListarSocio();
            BorrarInputs();

            
        }

        public void ListarSocio ()
        {
            CN_Socios socio = new CN_Socios();
            dgv_Socios.DataSource = null;
            dgv_Socios.DataSource = socio.GetSocios();
        }

        public void BorrarInputs()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Dni.Clear();
            txt_Telefono.Clear();
            txt_FechaIngreso.Clear();
        }

        private void btn_EliminarFisico_Click(object sender, EventArgs e)
        {
            string identificador = dgv_Socios.CurrentRow.Cells["Id_Socio"].Value.ToString();
            socio.EliminarFisico(identificador);
            
            MessageBox.Show($"El socio fue eliminado con exito....");
            ListarSocio();
        }

        private void btn_EliminarLogico_Click(object sender, EventArgs e)
        {
            string identificador = dgv_Socios.CurrentRow.Cells["Id_Socio"].Value.ToString();
            socio.EliminarLogico(identificador);
            MessageBox.Show("el socio fue eliminado logicamente");
            ListarSocio();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = false;
            btn_Agregar.Hide();

            btn_Actualizar.Enabled = true;
            btn_Actualizar.Show();

            txt_Nombre.Text = dgv_Socios.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_Apellido.Text = dgv_Socios.CurrentRow.Cells["Apellido"].Value.ToString();
            txt_Dni.Text = dgv_Socios.CurrentRow.Cells["Dni"].Value.ToString();
            txt_Telefono.Text = dgv_Socios.CurrentRow.Cells["Telefono"].Value.ToString();
            txt_FechaIngreso.Text = dgv_Socios.CurrentRow.Cells["FechaIngreso"].Value.ToString();
           
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            string dni = txt_Dni.Text;
            string telefono = txt_Telefono.Text;
            string fechaIngreso = txt_FechaIngreso.Text;

            string id = dgv_Socios.CurrentRow.Cells["Id_Socio"].Value.ToString();

            socio.EditarSocio(nombre,apellido,dni,telefono,fechaIngreso,id);

            MessageBox.Show($" {nombre} fue editado con exito");

            ListarSocio();
            BorrarInputs();
            
        }
    }
}
