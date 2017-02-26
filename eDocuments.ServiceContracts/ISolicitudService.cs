using System;
using System.Collections.Generic;

using System.ServiceModel;
using eDocuments.Entities;

namespace eDocuments.ServiceContracts
{
    [ServiceContract]
    public interface ISolicitudService
    {
        [OperationContract]
        int RegistrarSolicitud(BESolicitud oParametro);

        [OperationContract]
        bool ModificarSolicitud(BESolicitud oParametro);

        [OperationContract]
        BESolicitud ObtenerSolicitud(int cod_solicitud);

        [OperationContract]
        int EliminarSolicitud(BESolicitud oParametro);
    }
}
