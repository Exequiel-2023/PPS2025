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
using System.Runtime.InteropServices;

namespace _01_CapaPresentacion
{
    public partial class VentanaPrincipalSecretarios : Form
    {
        public VentanaPrincipalSecretarios()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand,int wmsg, int wparam, int Iparam);

        private void visualizarSociosActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Socios socios = new Socios();
            socios.ShowDialog();
        }


        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            if (frm_login.id_logeo  == "1")
            {
                //MessageBox.Show("Bienvenido jefe");
            }
            if (frm_login.id_logeo == "2" || frm_login.id_logeo == "3")
            {
                //MessageBox.Show("Bienvenido secretario");
            }
        }

        private void AbrirFormSocios(object socio1)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = socio1 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();


        }
        private void btnSocios_Click(object sender, EventArgs e)
        {
            AbrirFormSocios(new Socios());
        }

        private void AbrirFormEntrenadores(object entrenador1)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = entrenador1 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();


        }

        private void btnEntrenadores_Click(object sender, EventArgs e)
        {
            AbrirFormEntrenadores(new Entrenador());
        }

        public void AbrirFormularioEnPanelDetallesSocioSecretario(Form formHijo2)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            formHijo2.TopLevel = false;
            formHijo2.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(formHijo2);
            this.PanelContenedor.Tag = formHijo2;
            formHijo2.Show();
        }

        private void AbrirFormHorarios(object horario1)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = horario1 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();


        }
        private void btnHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormHorarios(new Horarios());
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible= true;
            iconmaximizar.Visible= false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible= false;
            iconmaximizar.Visible= true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnslide_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
        }

        
    }
}
