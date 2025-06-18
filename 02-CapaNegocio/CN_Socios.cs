using _03_CapaDatos.BaseDatos;
using System.Data;

namespace _02_CapaNegocio
{
    public class CN_Socios
    {

        CD_Socios socio = new CD_Socios();

        public DataTable MostrarSociosActivos ()
        {
            DataTable tabla = new DataTable();
            tabla = socio.MostrarSociosActivos();

            return tabla;
        }

        public DataTable SociosInactivos()
        {
            DataTable tabla = new DataTable();
            tabla = socio.SociosInactivos();
            return tabla;
        }

        public void InsertarSocio(string nombre, string apellido, string dni, string tel, string fechaIngreso)
        {
            socio.InsertarSocio(nombre, apellido, dni, tel, fechaIngreso);
        }

        public void EliminarFisico(string id)
        {
            socio.EliminarFisico(int.Parse(id));
        }

        public void EliminarLogico (string id)
        {
            socio.EliminarLogico(int.Parse(id));
        }

        public void EditarSocio (string nombre, string apellido, string dni, string telefono, string fechaIngreso, string id)
        {
            socio.EditarSocio(nombre, apellido, dni, telefono, fechaIngreso, int.Parse(id));
        }

        public void DarAltaSocio(string fechaAlta, string Activo, string id)
        {
            socio.DarAltaSocio(fechaAlta,Activo,int.Parse(id));
        }

        public void VerDetalleSocioActivo (string id, string nombre, string apellido, string dni, string telefono, string fechaAlta)
        {
            socio.VerDetalleSocioActivo(int.Parse(id), nombre, apellido, dni, telefono,fechaAlta);
        }
    }
}
