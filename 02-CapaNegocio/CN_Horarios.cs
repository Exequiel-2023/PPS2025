using _03_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CapaNegocio
{
    public class CN_Horarios
    {

        CD_Horarios horarios = new CD_Horarios();

        public DataTable MostrarHorarios()
        {
            return horarios.ObtenerHorarios();
        }
    }
}
