using _03_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CapaNegocio
{
    public class CN_Inventario
    {
        CD_Inventario inventario = new CD_Inventario();
        DataTable tabla = new DataTable();
        public DataTable ListarInventario()
        {
           
            return tabla = inventario.MostrarInventario();
        }



    }
}
