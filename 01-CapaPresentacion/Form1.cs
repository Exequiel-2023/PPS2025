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
        CN_Secretarios secretario = new CN_Secretarios();
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
            int contadorInteto = 1;
            do
            {
                if (txt_Usuario.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Debes completar los campos");
                }
                else if (secretario.ConsultaLogin(txt_Usuario.Text, txt_Password.Text) == 1)
                {
                    MessageBox.Show("Bienvenido Jefe");
                    this.Hide();
                    VentanaPrincipal VP = new VentanaPrincipal();
                    VP.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y Pass Invalido");
                    MessageBox.Show("intentos realizados:" +contadorInteto);
                    if (contadorInteto == 2)
                    {
                        Application.Exit();
                    }
                    
                }

                contadorInteto += 1;
            }while (contadorInteto <= 2);

            
        }
    }
}
