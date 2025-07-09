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

        private void Socios_Load(object sender, EventArgs e)
        {


            //DataTable tabla = socio.MostrarSocios();

            //foreach (DataRow fila in tabla.Rows)
            //{

            //    DateTime fechaAlta = dtpFechaIngreso.Value;
            //    DateTime fechaVencimiento = Convert.ToDateTime(fila["ProximoVencimiento"]);

            //    if (DateTime.Today <= fechaVencimiento)
            //    {
            //        fila["Estado"] = "Activo";
            //    }
            //    else
            //    {
            //        fila["Estado"] = "Inactivo";
            //    }
            //}

            //dgv_Socios.DataSource = null;
            //dgv_Socios.DataSource = tabla;
            //BorrarInputs();



            //gb_Socios.Enabled = false;
            //gb_Socios.Hide();



            //btn_Actualizar.Enabled = false;
            //btn_Actualizar.Hide();

            cbEstado.Enabled = false;
            cbEstado.Hide();
            lblEstado.Enabled=false;
            lblEstado.Hide();

            ListarSocio();


        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
           
            string nombreCompleto = txt_Nombre.Text;
            string dni = txt_Dni.Text;
            string email = txtEmail.Text;
            string Actividad = cboClase.Text;
            DateTime fechaAlta = dtpFechaIngreso.Value;
            DateTime fechaVencimiento = DateTime.Parse(txtProximoVencimiento.Text);
            string Estado = cbEstado.Text;
            

            if (nombreCompleto == "" || dni == "")
            {
                MessageBox.Show("Debes rellenar todos los campos");
            }
            else
            {
                socio.InsertarSocio(nombreCompleto, dni, email, Actividad, fechaAlta, fechaVencimiento, Estado);
                MessageBox.Show($"{nombreCompleto} ah sido agregado correctamente", "Nuevo Socio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarSocio();
                BorrarInputs();
            }

            gb_Socios.Enabled = false;
            gb_Socios.Hide();

            btn_EliminarLogico.Enabled = true;
            btn_EliminarLogico.Show();

            btnVer.Enabled = true;
            btnVer.Show();

            btn_Editar.Enabled = true;
            btn_Editar.Show();

            btnInsertar.Enabled = true;
            btnInsertar.Show();

            btn_Agregar.Enabled = true;
            btn_Agregar.Show();

            btnEmail.Enabled = true;
            btnEmail.Show();
          
        }

        public void ListarSocio ()
        {

            CN_Socios socio = new CN_Socios();
            //dgv_Socios.DataSource = null;

            //dgv_Socios.DataSource = socio.MostrarSocios();
            DataTable tabla = socio.MostrarSocios();

            foreach (DataRow fila in tabla.Rows)
            {
                DateTime fechaVencimiento = Convert.ToDateTime(fila["ProximoVencimiento"]);

                if (DateTime.Today <= fechaVencimiento)
                {
                    fila["Estado"] = "Activo";
                }
                else
                {
                    fila["Estado"] = "Inactivo";
                }
            }

            dgv_Socios.DataSource = null;
            dgv_Socios.DataSource = tabla;

        }


        public void BorrarInputs()
        {
            txt_Nombre.Clear();          
            txt_Dni.Clear();
            txtEmail.Clear();
            cboClase.Items.Clear();
            dtpFechaIngreso.Checked = false;
           

           
           
        }


        private void btn_EliminarLogico_Click(object sender, EventArgs e)
        {
            string identificador = dgv_Socios.CurrentRow.Cells["Id_Socio"].Value.ToString();
            socio.EliminarSocioFisicamente(identificador);
            if (dgv_Socios.CurrentRow.Cells["Estado"].Value.ToString() == "Inactivo")
            {
                MessageBox.Show("el socio fue eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarSocio();
            }
            else
            {
                MessageBox.Show("el socio no puede ser eliminado ya que esta Activo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_EliminarLogico.Enabled = false;
            btn_EliminarLogico.Hide();

            btnVer.Enabled = false;
            btnVer.Hide();

            btn_Editar.Enabled = false;
            btn_Editar.Hide();

            btn_Agregar.Enabled = false;
            btn_Agregar.Hide();

            btnEmail.Enabled = false;
            btnEmail.Hide();

            btnInsertar.Enabled = false;
            btnInsertar.Hide();

            btn_Actualizar.Enabled = true;
            btn_Actualizar.Show();

            gb_Socios.Enabled = true;
            gb_Socios.Show();

            txt_Nombre.Enabled = false;
           
            txt_Dni.Enabled = false;

            txt_Nombre.Text = dgv_Socios.CurrentRow.Cells["NombreCompleto"].Value.ToString();
            txt_Dni.Text = dgv_Socios.CurrentRow.Cells["Dni"].Value.ToString();
            txtEmail.Text = dgv_Socios.CurrentRow.Cells["Email"].Value.ToString();
            cboClase.Text = dgv_Socios.CurrentRow.Cells["Clase"].Value.ToString();
            dtpFechaIngreso.Text = dgv_Socios.CurrentRow.Cells["FechaIngreso"].Value.ToString();
            txtProximoVencimiento.Text = dgv_Socios.CurrentRow.Cells["ProximoVencimiento"].Value.ToString();

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txt_Nombre.Text;
            string dni = txt_Dni.Text;
            string email = txtEmail.Text;
            string clase = cboClase.Text;
            DateTime FechaIngreso = dtpFechaIngreso.Value;
            DateTime ProximoVencimiento = DateTime.Parse(txtProximoVencimiento.Text);
            string Estado = cbEstado.Text;
            

            string id = dgv_Socios.CurrentRow.Cells["Id_Socio"].Value.ToString();

            if (nombreCompleto == "" )
            {
                MessageBox.Show("Debes rellenar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                socio.EditarSocio(nombreCompleto, dni,email,clase, FechaIngreso.ToString(),ProximoVencimiento.ToString(), Estado, id);

                MessageBox.Show($" {nombreCompleto} fue editado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarSocio();
                BorrarInputs();
            }

            gb_Socios.Enabled = false;
            gb_Socios.Hide();

            btn_EliminarLogico.Enabled = true;
            btn_EliminarLogico.Show();

            btnVer.Enabled = true;
            btnVer.Show();

            btn_Editar.Enabled = true;
            btn_Editar.Show();

            btnInsertar.Enabled = true;
            btnInsertar.Show();

            btnEmail.Enabled = true;
            btnEmail.Show();
         
        }

      
        private void btnVer_Click(object sender, EventArgs e)
        {
            
            if (dgv_Socios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgv_Socios.SelectedRows[0];
                string id = fila.Cells["Id_Socio"].Value.ToString();
                string nombreCompleto = fila.Cells["NombreCompleto"].Value.ToString();     
                string dni = fila.Cells["Dni"].Value.ToString();
                string email = fila.Cells["Email"].Value.ToString();
                string FechaIngreso = fila.Cells["FechaIngreso"].Value.ToString();
                string ProximoVencimiento = fila.Cells["ProximoVencimiento"].Value.ToString();

                this.Hide();
                frmVerSocioActivo destino = new frmVerSocioActivo(id, nombreCompleto, dni, email, FechaIngreso, ProximoVencimiento);
                destino.ShowDialog();
              

            }

        }

        private void txbSocioActivo_TextChanged(object sender, EventArgs e)
        {
            (dgv_Socios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Dni  LIKE '{0}%'", txbSocioActivo.Text);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            gb_Socios.Enabled = true;
            gb_Socios.Show();

            btn_EliminarLogico.Enabled = false;
            btn_EliminarLogico.Hide();

            btnVer.Enabled = false;
            btnVer.Hide();

            btn_Editar.Enabled = false;
            btn_Editar.Hide();

            btnInsertar.Enabled = false;
            btnInsertar.Hide();

            btnEmail.Enabled = false;
            btnEmail.Hide();

            btn_Agregar.Enabled = true;
            btn_Agregar.Show();

            btn_Actualizar.Enabled = false;
            btn_Actualizar.Hide();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (dgv_Socios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgv_Socios.SelectedRows[0];
                string id = fila.Cells["Id_Socio"].Value.ToString();
                string email = fila.Cells["Email"].Value.ToString();


                FrmCorreo correo = new FrmCorreo(id, email);
                correo.ShowDialog();
            }
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaIngresoSocio = dtpFechaIngreso.Value;
            DateTime proximoVencimiento = fechaIngresoSocio.AddDays(31);
            txtProximoVencimiento.Text = proximoVencimiento.ToShortDateString();

            int Dia = fechaIngresoSocio.Day;
            int Mes = fechaIngresoSocio.Month;
            int Año = fechaIngresoSocio.Year;

            if (Mes == 2)
            {
                txtProximoVencimiento.Text = $"{Dia}/{Mes + 1}/{Año}";
            }
            else if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
            {
                txtProximoVencimiento.Text = $"{Dia}/{Mes + 1}/{Año}";
            }
        }

        private void gb_Socios_Enter(object sender, EventArgs e)
        {
            cboClase.Items.Add("Zumba");
            cboClase.Items.Add("Boxeo");
            cboClase.Items.Add("Spining");

            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");



        }
    }
}
