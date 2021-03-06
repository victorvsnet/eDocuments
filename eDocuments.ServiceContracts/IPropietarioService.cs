﻿using System;
using System.Collections.Generic;

using System.ServiceModel;
using eDocuments.Entities;

namespace eDocuments.ServiceContracts
{
    [ServiceContract]
    public interface IPropietarioService
    {
        [OperationContract]
        List<BEPropietario> ListarPropietario(string propietario);

        [OperationContract]
        int Registrar(BEPropietario oParametro);

        [OperationContract]
        int Actualizar(BEPropietario oParametro);

        [OperationContract]
        int Eliminar(BEPropietario oParametro);

    }
}
