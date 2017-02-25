
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLArea
    {
        public List<BEArea> ListarArea()
        {
            return new DAArea().ListarArea();
        }
    }
}
