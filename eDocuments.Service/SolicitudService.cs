using System;
using System.Collections.Generic;

using eDocuments.ServiceContracts;
using eDocuments.Entities;
using eDocuments.BusinessLogic;

namespace eDocuments.Service
{
    public class SolicitudService : ISolicitudService
    {
        public int EliminarSolicitud(BESolicitud oParametro)
        {
            var BLSolicitud = new BLSolicitud();
            return BLSolicitud.EliminarSolicitud(oParametro);
        }

        public bool ModificarSolicitud(BESolicitud oParametro)
        {
            var BLSolicitud = new BLSolicitud();
            return BLSolicitud.ModificarSolicitud(oParametro);
        }

        public BESolicitud ObtenerSolicitud(int cod_solicitud)
        {
            var BLSolicitud = new BLSolicitud();
            return BLSolicitud.ObtenerSolicitud(cod_solicitud);
        }

        public int RegistrarSolicitud(BESolicitud oParametro)
        {
            var BLSolicitud = new BLSolicitud();
            return BLSolicitud.RegistrarSolicitud(oParametro);
        }

        public int RegistrarSeguimientoSolicitud(BESeguimientoSolicitud oParametro)
        {
            var BLSeguimientoSolicitud = new BLSeguimientoSolicitud();
            return BLSeguimientoSolicitud.RegistrarSeguimientoSolicitud(oParametro);
        }
    }
}
