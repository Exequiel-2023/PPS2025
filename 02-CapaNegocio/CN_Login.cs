using _03_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CapaNegocio
{
    public class CN_Login
    {
        CD_Login login = new CD_Login();
        public DataTable datosLogin(string usuario, string contraseña)
        {
            return login.ConsultaLogin(usuario, contraseña);
        }
        


    }
}
