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


            tabla = logueo.datosLogin(user, pass);

            if (tabla.Rows.Count > 0 ) { 
               
               MessageBox.Show("Bienvenido" + tabla.Rows[0][1].ToString(),"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);

                nombre_login = tabla.Rows[0][3].ToString();
                id_logeo = tabla.Rows[0][0].ToString();

                principal.ShowDialog();
                frm_login login = new frm_login();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK) 
                {
                    Application.Run(new VentanaPrincipal());
                }

                txt_Password.Clear();
                txt_Usuario.Clear();


            }
            else 
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        
    }
}
