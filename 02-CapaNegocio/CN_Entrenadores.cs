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
           
            tabla = entrenador.MostrarEntrenadoresActivo();

            return tabla;
        }

        public DataTable MostrarEntrenadoresInactivos()
        {

            tabla = entrenador.MostrarEntrenadoresInactivos();

            return tabla;
        }


        public void InsertarEntrenador(string nombre, string apellido, string dni, string domicilio, string telefono)
        {
            entrenador.InsertarEntrenador(nombre,apellido,dni,domicilio,telefono);
        }

        public void EliminarFisico(string id)
        {
            entrenador.EliminarFisico(int.Parse(id));
        }

        public void EliminarLogico(string id)
        {
            entrenador.EliminarLogico(int.Parse(id));
        }

        public void EditarEntrenador(string nombre,string apellido,string dni, string domicilio, string telefono, string id)
        {
            entrenador.EditarEntrenador(nombre,apellido,dni,domicilio,telefono,int.Parse(id));
        }

        public void DarAltaEntrenador(string domicilio, string tel,string activo, string id)
        {
            entrenador.DarAltaEntrenador(domicilio,tel,activo,int.Parse(id));
        }
    }
}
