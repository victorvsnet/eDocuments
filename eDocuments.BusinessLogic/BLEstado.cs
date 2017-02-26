
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLEstado
    {
        public List<BEEstado> ListarEstado()
        {
            return new DAEstado().ListarEstado();
        }
    }
}
