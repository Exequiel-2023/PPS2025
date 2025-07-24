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
                string query = "SELECT Id_Socio, NombreCompleto, Dni, Email, Clase, FechaIngreso,ProximoVencimiento, Estado, ImagenURL FROM Socios;";
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


        public void InsertarSocio(string nombreCompleto, string dni, string email,string Clase, DateTime FechaIngreso, string ProximoVencimiento, string Estado)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "INSERT INTO Socios (NombreCompleto, Dni, Email, Clase, FechaIngreso, ProximoVencimiento, Estado ) VALUES ('" + nombreCompleto + "','" + dni + "','"+email+"','"+Clase+"','"+FechaIngreso+"','" + ProximoVencimiento + "', '"+Estado+"')";

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

     
        public void EliminarSocioFisicamente(int id)
        {
            try
            {
                
                comando.Connection = conexion.OpenConexion();
                string query = "DELETE FROM Socios WHERE (Estado IS NULL OR Estado = '') AND Id_Socio = "+id+"";
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

        public void EditarSocio(string nombreCompleto, string dni,string email,string clase, string FechaIngreso, string ProximoVencimiento, string Estado, int id)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "UPDATE Socios set NombreCompleto  = '" + nombreCompleto + "', Dni = '" + dni + "',Email = '"+email+"',Clase = '"+clase+"',FechaIngreso = '" + FechaIngreso + "',ProximoVencimiento = '"+ProximoVencimiento+"', Estado = '"+Estado+"' WHERE Id_Socio = " + id + "";
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

        public void VerDetalleSocioActivo (int id, string nombreCompleto, string dni, string email, string clase, DateTime FechaIngreso, DateTime ProximoVencimiento, string Estado, string ImagenURL)
        {
            try
            {
                comando.Connection = conexion.OpenConexion();
                string query = "SELECT Id_Socio = '"+id+"', NombreCompleto = '"+nombreCompleto+ "', Dni= '"+dni+ "', Telefono= '"+email+ "', Clase = '"+clase+"', FechaIngreso = '"+FechaIngreso+"', ProximoVencimiento = '"+ProximoVencimiento+ "', Estado = '"+Estado+"', ImagenURL = '"+ ImagenURL + "' FROM Socios";
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

       
    }
}
