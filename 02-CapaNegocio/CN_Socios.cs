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


        public void InsertarSocio(string nombreCompleto, string dni, string email, string Clase, DateTime FechaIngreso, DateTime ProximoVencimiento, string Estado)
        {
            socio.InsertarSocio(nombreCompleto, dni, email, Clase, FechaIngreso, ProximoVencimiento, Estado);
        }


        public void EliminarSocioFisicamente(string id)
        {
            socio.EliminarSocioFisicamente(int.Parse(id));
        }

        public void EditarSocio (string nombreCompleto, string dni,string email,string clase, string FechaIngreso, string ProximoVencimiento, string Estado,string id)
        {
            socio.EditarSocio(nombreCompleto, dni, email, clase, FechaIngreso,ProximoVencimiento, Estado, int.Parse(id));
        }

        public void DarAltaSocio(string fechaAlta, string Activo, string id)
        {
            socio.DarAltaSocio(fechaAlta,Activo,int.Parse(id));
        }

        public void VerDetalleSocioActivo (string id, string nombreCompleto, string dni, string email, string clase, DateTime FechaIngreso, DateTime ProximoVencimiento, string ImagenURL)
        {
            socio.VerDetalleSocioActivo(int.Parse(id), nombreCompleto, dni, email, clase, FechaIngreso, ProximoVencimiento, ImagenURL);
        }

        public void MandarEmailSocioInactivo(string id, string email)
        {
            socio.MandarEmailSocioInactivo(int.Parse(id), email);
        }

    }
}
