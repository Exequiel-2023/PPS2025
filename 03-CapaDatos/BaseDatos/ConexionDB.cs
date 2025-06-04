using System;
using System.Data.SqlClient;

namespace _03_CapaDatos.BaseDatos
{
    public class ConexionDB
    {
        SqlConnection conexion = new SqlConnection(DatosDB.CadenaConexionSinSa);

        public SqlConnection OpenConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    
                }
                return conexion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlConnection CloseConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                return conexion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
