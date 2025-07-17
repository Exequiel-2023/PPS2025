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
    public class CD_Entrenadores
    {
        ConexionDB conexion = new ConexionDB();

        SqlCommand comando = new SqlCommand();

        DataTable tabla = new DataTable();

        SqlDataReader lector;


        public DataTable MostrarEntrenadores ()
        {
            try
            {
                comando.Connection = conexion.OpenConexion();

                string query = "SELECT Id_Entrenador, NombreCompleto, Dni, Domicilio, Clase, Telefono, Estado FROM Entrenadores;";

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

        public void InsertarEntrenador (string nombreCompleto, string dni, string domicilio, string clase, string telefono, string estado)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "INSERT INTO Entrenadores (NombreCompleto, Dni, Domicilio, Clase, Telefono, Estado) VALUES " +
                    "('"+ nombreCompleto + "','"+dni+"','"+domicilio+ "','"+clase+"','" + telefono+ "','" + estado+"');";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                conexion.CloseConexion ();
            }
        }

        public void EliminarEntrenador (int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "DELETE from Entrenadores where Id_Entrenador = " + id + "";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("error: " + ex.Message);
            }
            finally
            {
                conexion.CloseConexion();
            }
            
        }

        public void EditarEntrenador(string domicilio, string clase, string telefono, string estado, int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "UPDATE Entrenadores SET Domicilio = '" + domicilio + "', Clase = '"+clase+"',Telefono = '" + telefono + "', Estado = '"+estado+"' where Id_Entrenador = " + id + ";";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }finally
            {
                conexion.CloseConexion();
            }
        }

        public void DarAltaEntrenador(string domicilio,string telefono, string Activo, int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "UPDATE Entrenadores set Activo = 1, Domicilio = '" + domicilio + "', Telefono = '" + telefono + "' where Id_Entrenador =  " + id + " ; ";
            comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex);
            }
            finally
            {
                conexion.CloseConexion();
            }
            
        }
    }
}
