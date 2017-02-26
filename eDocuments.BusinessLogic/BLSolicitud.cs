
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLSolicitud
    {
        public int RegistrarSolicitud(BESolicitud oParametro)
        {
            return new DASolicitud().RegistrarSolicitud(oParametro);
        }

        public bool ModificarSolicitud(BESolicitud oParametro)
        {
            return new DASolicitud().ModificarSolicitud(oParametro);
        }

        public BESolicitud ObtenerSolicitud(int cod_solicitud)
        {
            return new DASolicitud().ObtenerSolicitud(cod_solicitud);
        }

        public int EliminarSolicitud(BESolicitud oParametro)
        {
            return new DASolicitud().EliminarSolicitud(oParametro);
        }

    }
}
