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
    public class CD_Secretarios
    {

       ConexionDB conexion = new ConexionDB();

        SqlCommand comando = new SqlCommand();

        SqlDataReader lector;

        DataTable tabla = new DataTable();

        public DataTable ObtenerInformacionSecretarios ()
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "select Id_Secretario, NombreCompleto, Documento, Domicilio, Telefono from UsuarioLogin where Id_Secretario > 1";
                comando.CommandText = query;
                lector = comando.ExecuteReader();
                tabla.Load(lector);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex);
            }
            finally
            {
                conexion.CloseConexion();
            }
            return tabla;
        }

        public void EliminarSecretario (int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "Delete From UsuarioLogin where Id_Secretario = '"+id+"'";
                comando.CommandText = query;
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " +ex);
            }
            finally
            {
                conexion.CloseConexion ();
            }
            
        }

        public void EditarSecretario(string nombreCompleto, string dni, string domicilio, string telefono, int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "UPDATE UsuarioLogin SET NombreCompleto = '"+nombreCompleto+"', Documento = '"+dni+"', Domicilio = '"+domicilio+"', Telefono = '"+telefono+"' where Id_Secretario = "+id+"";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }
            finally
            {
                conexion.CloseConexion();
            }
        }

        public void AgregarSecretario(string nombreCompleto, string documento, string domicilio, string telefono)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = " INSERT INTO UsuarioLogin (NombreCompleto, Documento, Domicilio, Telefono) Values ('"+nombreCompleto+"', '"+documento+"','"+domicilio+"', '"+telefono+"')";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex )
            {

                MessageBox.Show("Error " + ex);
            }
            finally
            {
                conexion.CloseConexion();
            }
        }
    }
}
       
