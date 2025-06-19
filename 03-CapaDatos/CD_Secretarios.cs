using _03_CapaDatos.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _03_CapaDatos
{
    public class CD_Secretarios
    {
        ConexionDB conexion = new ConexionDB();

        SqlCommand comando = new SqlCommand();

        public int ConsultaLogin (string usuario, string contrasena)
        {
            
            try
            {
                int contador;
                comando.Connection = conexion.OpenConexion();
                string query = "select Count(*) from Secretarios where Usuario = '"+usuario+"' and Contrasena = '"+contrasena+"';";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                contador = Convert.ToInt32(comando.ExecuteScalar());

                return contador;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex);
            }
            finally
            {
                conexion.CloseConexion();
            }
            return 0;
        }

    }

    
}
