using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CapaDatos.BaseDatos
{
    public class DatosDB
    {

        private static string Servidor = "EXEQUIEL-2024\\SQL2019";
        private static string BaseDatos = "PracticaPPS";
        private const string Usuario = "sa";
        private const string Password = "12345678";

        // FORMA DE CONECTARSE A LA BASE DE DATOS SIN USUARIO Y CONTRASEÑA
        public static string CadenaConexionSinSa = $"Server={Servidor};BD={BaseDatos};Integrated Security=True";

        // FORMA DE CONECTARSE A LA BASE DE DATOS CON USUARIO Y CONTRASEÑA
        public static string CadenaConexionConSa = $"Server={Servidor};BD={BaseDatos};User= {Usuario}, Pass = {Password}";

    }
}
