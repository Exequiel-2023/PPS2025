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


        public DataTable MostrarEntrenadoresActivo ()
        {
            try
            {
                comando.Connection = conexion.OpenConexion();

                string query = "Select Id_Entrenador,Nombre as 'Nombre Entrenador',Apellido,Dni from Entrenadores where Activo = 1;";

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

        public DataTable MostrarEntrenadoresInactivos ()
        {
            try
            {
                comando.Connection = conexion.OpenConexion();

                string query = "Select Id_Entrenador,Nombre as 'Nombre Entrenador',Apellido,Dni from Entrenadores where Activo = 0;";

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

        public void InsertarEntrenador (string nombre, string apellido, string dni, string domicilio, string telefono)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "INSERT INTO Entrenadores (Nombre, Apellido, Dni, Domicilio, Telefono) VALUES " +
                    "('"+nombre+"','"+apellido+"','"+dni+"','"+domicilio+"','"+telefono+"');";
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

        public void EliminarFisico (int id)
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

        public void EliminarLogico(int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "UPDATE Entrenadores SET Activo = 0 WHERE Id_Entrenador = "+id+"";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }finally
            {
                conexion.CloseConexion() ;
            }
        }

        public void EditarEntrenador()
        {

        }


    }
}
