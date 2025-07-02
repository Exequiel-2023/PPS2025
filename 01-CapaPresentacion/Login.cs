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
    public partial class frm_login : Form
    {
        CN_Login logueo = new CN_Login();
        VentanaPrincipal principal = new VentanaPrincipal();


        public static string nombre_login;
        public static string id_logeo; 
        public frm_login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int lParam);

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_Ingresar_Click_1(object sender, EventArgs e)
        { 
            
            loguearse();
             

        }
        public void loguearse()
        {
            DataTable tabla = new DataTable();  
            string user = txt_Usuario.Text;
            string pass = txt_Password.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {

                MessageBox.Show("Debes completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            tabla = logueo.datosLogin(user, pass);

                      
                if (tabla.Rows.Count > 0 && txt_Usuario.Text != "" && txt_Password.Text != "")
                {

                    MessageBox.Show("Bienvenido/a " + tabla.Rows[0][1].ToString() + " " + tabla.Rows[0][3].ToString(), " Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nombre_login = tabla.Rows[0][3].ToString();
                    id_logeo = tabla.Rows[0][0].ToString();

                    this.Hide();
                    principal.ShowDialog();
                    frm_login login = new frm_login();
                    //login.ShowDialog();

                    if (login.DialogResult == DialogResult.OK)
                    {
                        Application.Run(new VentanaPrincipal());
                    }

                }
                else 
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }              
            
        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "USUARIO")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "USUARIO";
                txt_Usuario.ForeColor= Color.DimGray;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "CONTRASEÑA")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.LightGray;
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "CONTRASEÑA";
                txt_Password.ForeColor = Color.DimGray;
                txt_Password.UseSystemPasswordChar= false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void limpiarInputslogin()
        {
            txt_Password.Clear();
            txt_Usuario.Clear();
        }
    }
}
