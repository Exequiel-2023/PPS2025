using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _03_CapaDatos.BaseDatos
{
    public class ConexionDB
    {
        private SqlConnection conexion = new SqlConnection(DatosDB.CadenaConexionSinSa);


        public SqlConnection OpenConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();   
            }
            return conexion;
        }

        public SqlConnection CloseConexion()
        {
            
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                return conexion;
            
        }

    }
}
