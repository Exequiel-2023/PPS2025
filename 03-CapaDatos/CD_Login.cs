using _03_CapaDatos.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _03_CapaDatos
{
    public class CD_Login
    {
        ConexionDB conexion = new ConexionDB();

        SqlCommand comando = new SqlCommand();

        SqlDataAdapter adaptador = new SqlDataAdapter();   
        
        DataTable tabla = new DataTable();  
        public DataTable ConsultaLogin (string usuario, string contrasena)
        {
            
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "select * from UsuarioLogin where Usuario = '" + usuario + "' and Contrasena = '"+contrasena+"'";
                comando.CommandText = query;
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex);
            }
            finally
            {
                conexion.CloseConexion();
            }
            return tabla;
        }

    }

    
}
