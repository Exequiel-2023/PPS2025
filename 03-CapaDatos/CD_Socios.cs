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

        public DataTable MostrarSocios()
        {
            try
            {

                comando.Connection = conexion.OpenConexion();
                string query = "select * from Socios";
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


        public void InsertarSocio(string nombre, string apellido, string dni, string tel, DateTime fechaIngreso)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "INSERT INTO Socios (Nombre, Apellido, Dni, Telefono, FechaIngreso) VALUES ('" + nombre + "','" + apellido + "','" + dni + "','" + tel + "','" + fechaIngreso + "')";

                comando.CommandText = query;

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                conexion.CloseConexion();
            }
        }

        public void EliminarFisico(int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "DELETE FROM Socios WHERE Id_Socio = " + id + "";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.CloseConexion() ;
            }


        }

        public void EliminarLogico(int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "UPDATE Socios set Activo = 0 where Id_Socio = " + id + "";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.CloseConexion();
            }
        }

        public void EditarSocio(string nombre, string apellido, string dni, string telefono, string fechaIngreso, int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "UPDATE Socios set Nombre  = '" + nombre + "',Apellido = '" + apellido + "', Dni = '" + dni + "',Telefono = '" + telefono + "',FechaIngreso = '" + fechaIngreso + "'WHERE Id_Socio = " + id + "";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                conexion.CloseConexion() ;
            }
        }

        public void DarAltaSocio(string fechaAlta, string Activo, int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "UPDATE Socios set Activo = " + Activo + ", FechaIngreso = '" + fechaAlta + "' where Id_Socio = " + id + ";";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }finally
            {
                conexion.CloseConexion();
            }
        }

        public void VerDetalleSocioActivo (int id, string nombre, string apellido, string dni, string telefono, string fechaAlta)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "SELECT Id_Socio = '"+id+"', Nombre = '"+nombre+ "', Apellido = '"+apellido+ "', Dni= '"+dni+ "', Telefono= '"+telefono+ "', FechaIngreso = '"+fechaAlta+"' FROM Socios WHERE Activo = 1";
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

        public void MandarEmailSocioInactivo( int id, string email)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "SELECT Id_Socio = "+id+" , Email = '"+email+"' from Socios where activo = 0;  ";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                conexion.CloseConexion () ;
            }
        }

        public DataTable FiltroSocioInactivo (string apellido, string activo)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "SELECT * FROM Socios distint WHERE Dni LIKE '%" + apellido + "%' AND Activo = " + activo + ";";
                comando.CommandText = query;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.CloseConexion () ;
            }
            return tabla;
        }
    }
}
