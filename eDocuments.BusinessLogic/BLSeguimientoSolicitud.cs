
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLSeguimientoSolicitud
    {
        public int RegistrarSeguimientoSolicitud(BESeguimientoSolicitud oParametro)
        {
            return new DASeguimientoSolicitud().RegistrarSeguimientoSolicitud(oParametro);
        }
    }
}
