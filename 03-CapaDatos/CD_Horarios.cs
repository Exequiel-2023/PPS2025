using _03_CapaDatos.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_CapaDatos
{
    public class CD_Horarios
    {

        ConexionDB conexion = new ConexionDB();

        SqlCommand comando = new SqlCommand();

        DataTable tabla = new DataTable();

        SqlDataReader lector;


        public DataTable ObtenerHorarios()
        {
            try
            {
                comando.Connection = conexion.OpenConexion();

                string query = "SELECT Clase,Horario,Dias,Sede FROM HorariosClases;";

                comando.CommandText = query;

                lector = comando.ExecuteReader();

                tabla.Load(lector);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex);
            }
            finally
            {
                conexion.CloseConexion();
            }
            return tabla;
        }
    }
}
