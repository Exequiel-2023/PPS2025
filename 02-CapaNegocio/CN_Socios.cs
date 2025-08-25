using _03_CapaDatos.BaseDatos;
using System;
using System.Data;
using System.Net;

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


        public void InsertarSocio(string nombreCompleto, string dni, string direccion, string telefono, DateTime FechaIngreso, string ProximoVencimiento, string clase, string Estado, DateTime FechaDePago, string Anticipo, string Resto, string Total)
        {
            socio.InsertarSocio(nombreCompleto, dni, direccion, telefono, FechaIngreso, ProximoVencimiento, clase, Estado, FechaDePago, Anticipo, Resto, Total);
        }


        public void EliminarSocioFisicamente(string id)
        {
            socio.EliminarSocioFisicamente(int.Parse(id));
        }

        public void EditarSocio (string nombreCompleto, string dni,string clase, string FechaIngreso, string ProximoVencimiento, string Estado, string ImagenURL, string id)
        {
            socio.EditarSocio(nombreCompleto, dni, clase, FechaIngreso,ProximoVencimiento, Estado, ImagenURL, int.Parse(id));
        }

        public void DarAltaSocio(string fechaAlta, string Activo, string id)
        {
            socio.DarAltaSocio(fechaAlta,Activo,int.Parse(id));
        }

        public void VerDetalleSocioActivo (string id, string nombreCompleto, string Dni, string email, string clase, string Estado, DateTime FechaPago, string Resto)
        {
            socio.VerDetalleSocioActivo(int.Parse(id), nombreCompleto, Dni, clase, Estado, FechaPago, int.Parse(Resto));
        }

        public void MandarEmailSocioInactivo(string id, string email)
        {
            socio.MandarEmailSocioInactivo(int.Parse(id), email);
        }
        
    }
}
