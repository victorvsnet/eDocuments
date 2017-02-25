
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLRol
    {
        public List<BERol> ListarRol()
        {
            return new DARol().ListarRol();
        }
    }
}
