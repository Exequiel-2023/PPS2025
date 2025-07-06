using _02_CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_CapaPresentacion
{
    public partial class VentanaPrincipalJefe : Form
    {   
       
        Inventario VentanaInventario = new Inventario();
    
        public VentanaPrincipalJefe()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int Iparam);

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    VisualizarSociosJefe visualizarSocio = new VisualizarSociosJefe();
        //    visualizarSocio.ShowDialog();
        //}

        //private void btnSocios_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    VisualizarSociosJefe visualizarSocio = new VisualizarSociosJefe();
        //    visualizarSocio.ShowDialog();
        //}

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInventario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
        }

        private void btnslide_Click(object sender, EventArgs e)
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

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }


        private void AbrirFormSociosJefe(object socioJefe)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = socioJefe as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();


        }
        private void btnSocio_Click(object sender, EventArgs e)
        {
            AbrirFormSociosJefe(new VisualizarSociosJefe());

        }

    }
}
