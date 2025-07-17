using _03_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CapaNegocio
{
    public class CN_Entrenadores
    {
        CD_Entrenadores entrenador = new CD_Entrenadores();
        DataTable tabla = new DataTable();
        public DataTable MostrarEntrenadores()
        {
           
            tabla = entrenador.MostrarEntrenadores();

            return tabla;
        }        

        public void InsertarEntrenador(string nombreCompleto, string dni, string domicilio, string clase, string telefono, string estado)
        {
            entrenador.InsertarEntrenador(nombreCompleto, dni, domicilio, clase,  telefono, estado);
        }

        public void EliminarEntrenador(string id)
        {
            entrenador.EliminarEntrenador(int.Parse(id));
        }

        public void EditarEntrenador(string domicilio, string clase, string telefono, string estado, string id)
        {
            entrenador.EditarEntrenador(domicilio, clase, telefono, estado, int.Parse(id));
        }

        public void DarAltaEntrenador(string domicilio, string tel,string activo, string id)
        {
            entrenador.DarAltaEntrenador(domicilio,tel,activo,int.Parse(id));
        }
    }
}
