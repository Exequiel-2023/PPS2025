using _03_CapaDatos.BaseDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _03_CapaDatos
{
    public class CD_Inventario
    {


        ConexionDB conexion = new ConexionDB();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        DataTable tabla = new DataTable();

        public DataTable MostrarInventario ()
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "SELECT * FROM Inventario;";
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
