using _02_CapaNegocio;
using iTextSharp.text.pdf.codec.wmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_CapaPresentacion
{
    public partial class Socios : Form
    {
        
            CN_Socios socio = new CN_Socios();
            VentanaPrincipalSecretarios VentanaPpalSecretarios = new VentanaPrincipalSecretarios();
     
   
        public Socios()
        {
            InitializeComponent();
        }

        private void Socios_Load(object sender, EventArgs e)
        {

            gb_Socios.Enabled = false;
            gb_Socios.Hide();

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
            string fechaVencimiento = txtProximoVencimiento.Text;
            string Estado = cbEstado.Text;
            

            if (nombreCompleto == "" || dni == "" || email == "" || Actividad == "" || fechaVencimiento == "" )
            {
                MessageBox.Show("Debes rellenar todos los campos");
            }
            else
            {
                socio.InsertarSocio(nombreCompleto, dni, email, Actividad, fechaAlta, fechaVencimiento, Estado);
                MessageBox.Show($"{nombreCompleto} ah sido agregado correctamente", "Nuevo Socio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             
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

                dgv_Socios.Enabled = true;
                dgv_Socios.Show();

                lblBuscar.Enabled = true;
                lblBuscar.Show();

                txbSocioActivo.Enabled = true;
                txbSocioActivo.Show();

                BorrarInputs();
                ListarSocio();             

            }            
        }

        public void ListarSocio ()
        {

            CN_Socios socio = new CN_Socios();    
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
            cboClase.Text = ""; 
            cboClase.Items.Clear();
            dtpFechaIngreso.Value = DateTime.Now;
            txtProximoVencimiento.Clear();
        }


        private void btn_EliminarLogico_Click(object sender, EventArgs e)
        {
            string nombreCompleto = dgv_Socios.CurrentRow.Cells["NombreCompleto"].Value.ToString();
            string identificador = dgv_Socios.CurrentRow.Cells["Id_Socio"].Value.ToString();
           
            socio.EliminarSocioFisicamente(identificador);
            if (dgv_Socios.CurrentRow.Cells["Estado"].Value.ToString() == "Inactivo")
            {
                MessageBox.Show($"El socio {nombreCompleto} fue eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarSocio();
            }
            else
            {
                //MessageBox.Show($"el socio{nombre} no puede ser eliminado ya que esta Activo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"El socio {nombreCompleto} no puede ser eliminado ya que esta Activo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            lblBuscar.Enabled = false;
            lblBuscar.Hide();

            txbSocioActivo.Enabled = false;
            txbSocioActivo.Hide();

            dgv_Socios.Enabled = false;
            dgv_Socios.Hide();

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

                lblBuscar.Enabled = true;
                lblBuscar.Show();

                txbSocioActivo.Enabled = true;
                txbSocioActivo.Show();

                dgv_Socios.Enabled = true;
                dgv_Socios.Show();

                ListarSocio();
                BorrarInputs();

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

            lblBuscar.Enabled = false;
            lblBuscar.Hide();

            txbSocioActivo.Enabled = false;
            txbSocioActivo.Hide();

            dgv_Socios.Enabled = false;
            dgv_Socios.Hide();
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

        private void btnVer_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgv_Socios.SelectedRows[0];

            string id = fila.Cells["Id_Socio"].Value.ToString();
            string nombreCompleto = fila.Cells["NombreCompleto"].Value.ToString();
            string Dni = fila.Cells["Dni"].Value.ToString();
            string email = fila.Cells["Email"].Value.ToString();
            string clase = fila.Cells["Clase"].Value.ToString();
            DateTime FechaIngreso = Convert.ToDateTime(fila.Cells["FechaIngreso"].Value);
            DateTime ProximoVencimiento = Convert.ToDateTime(fila.Cells["ProximoVencimiento"].Value);
            string Estado = fila.Cells["Estado"].Value.ToString();
            string ImagenURL = fila.Cells["ImagenURL"].Value.ToString();


            VerDetalleSocioJefe destino = new VerDetalleSocioJefe();
            destino.CargarDatos(id, nombreCompleto, Dni, email, clase, FechaIngreso, ProximoVencimiento, Estado, ImagenURL);

            VentanaPrincipalSecretarios principal = (VentanaPrincipalSecretarios)this.ParentForm;

            principal.AbrirFormularioEnPanelDetallesSocioSecretario(destino);
        }

    }
}
