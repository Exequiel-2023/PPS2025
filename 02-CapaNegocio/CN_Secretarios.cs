using _03_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CapaNegocio
{
    public class CN_Secretarios
    {
        CD_Secretarios secretarios = new CD_Secretarios();

        public DataTable ObtenerInfoSecretarios ()
        {
            return secretarios.ObtenerInformacionSecretarios();
        }

        public void EliminarSecretario (string id)
        {
            secretarios.EliminarSecretario(int.Parse(id));
        }

        public void EditarSecretario(string nombreCompleto, string dni, string domicilio, string telefono, string id)
        {
            secretarios.EditarSecretario(nombreCompleto, dni, domicilio, telefono, int.Parse(id));
        }

        public void AgregarSecretario(string nombreCompleto, string documento, string domicilio, string telefono)
        {
            secretarios.AgregarSecretario(nombreCompleto,documento, domicilio,telefono);
        }
    }
}
