using _03_CapaDatos.BaseDatos;
using System;
using System.Data;

namespace _02_CapaNegocio
{
    public class CN_Socios
    {

        CD_Socios socio = new CD_Socios();

        public DataTable MostrarSocios ()
        {
            DataTable tabla = new DataTable();
            tabla = socio.MostrarSocios();

            return tabla;
        }


        public void InsertarSocio(string nombreCompleto, string dni, string email, string Clase, DateTime FechaIngreso, DateTime ProximoVencimiento)
        {
            socio.InsertarSocio(nombreCompleto, dni, email, Clase, FechaIngreso, ProximoVencimiento);
        }

        public void EliminarFisico(string id)
        {
            socio.EliminarFisico(int.Parse(id));
        }

        public void EliminarLogico (string id)
        {
            socio.EliminarLogico(int.Parse(id));
        }

        public void EditarSocio (string nombreCompleto, string dni,string email,string clase, string FechaIngreso, string ProximoVencimiento,string id)
        {
            socio.EditarSocio(nombreCompleto, dni, email, clase, FechaIngreso,ProximoVencimiento, int.Parse(id));
        }

        public void DarAltaSocio(string fechaAlta, string Activo, string id)
        {
            socio.DarAltaSocio(fechaAlta,Activo,int.Parse(id));
        }

        public void VerDetalleSocioActivo (string id, string nombreCompleto, string dni, string telefono, string fechaAlta)
        {
            socio.VerDetalleSocioActivo(int.Parse(id), nombreCompleto, dni, telefono,fechaAlta);
        }

        public void MandarEmailSocioInactivo(string id, string email)
        {
            socio.MandarEmailSocioInactivo(int.Parse(id), email);
        }

    }
}
