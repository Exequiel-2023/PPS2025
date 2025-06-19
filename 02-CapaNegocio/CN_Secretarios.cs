using _03_CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CapaNegocio
{
    public class CN_Secretarios
    {
        CD_Secretarios secretario = new CD_Secretarios();

        public int ConsultaLogin(string usuario, string contrasena)
        {
           return  secretario.ConsultaLogin(usuario, contrasena);

           
        }


    }
}
