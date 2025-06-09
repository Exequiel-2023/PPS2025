using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_CapaDatos.BaseDatos
{
    public class CD_Socios
    {   
        ConexionDB conexion = new ConexionDB();

        SqlCommand comando = new SqlCommand();

        DataTable tabla = new DataTable();

        SqlDataReader lector;

        public DataTable GetSocios()
        {
            try
            {

                comando.Connection = conexion.OpenConexion();
                string query = "select * from Socios where Activo = 1;";
                comando.CommandText = query;
                lector = comando.ExecuteReader();
                tabla.Load(lector);

               
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error:" + ex);

            }
            finally
            {
                conexion.CloseConexion();
            }
            return tabla;

        }


        public DataTable SociosInactivos() {

            try
            {
                comando.Connection = conexion.OpenConexion();

                string query = "select * from Socios where Activo = 0;";

                comando.CommandText = query;

                lector = comando.ExecuteReader();

                tabla.Load(lector);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.CloseConexion() ;
            }
            return tabla;
            
        }

        public void InsertarSocio(string nombre, string apellido, string dni, string tel, string fechaIngreso)
        {
            comando.Connection = conexion.OpenConexion();
            string query = "INSERT INTO Socios (Nombre, Apellido, Dni, Telefono, FechaIngreso) VALUES ('"+nombre+"','"+apellido+"','"+dni+"','"+tel+"','"+fechaIngreso+ "')";

            comando.CommandText = query;

            comando.ExecuteNonQuery();
        }

        public void EliminarFisico(int id)
        { 
            comando.Connection = conexion.OpenConexion();
            string query = "DELETE FROM Socios WHERE Id_Socio = "+id+"";
            comando.CommandText = query;
            comando.ExecuteNonQuery();


        }

        public void EliminarLogico(int id)
        {
            comando.Connection = conexion.OpenConexion();
            string query = "UPDATE Socios set Activo = 0 where Id_Socio = "+id+"";
            comando.CommandText = query;
            comando.ExecuteNonQuery();
        }

        public void EditarSocio(string nombre, string apellido, string dni, string telefono, string fechaIngreso, int id)
        {
            comando.Connection = conexion.OpenConexion();
            string query = "UPDATE Socios set Nombre  = '" + nombre + "',Apellido = '" + apellido + "', Dni = '" + dni + "',Telefono = '" + telefono + "',FechaIngreso = '" + fechaIngreso + "'WHERE Id_Socio = "+id+"";
            comando.CommandText = query;
            comando.ExecuteNonQuery();
        }

        public void ActualizarSocio()
        {

        }
    }
}
