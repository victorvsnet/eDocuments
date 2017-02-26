
using System;
using System.Collections.Generic;
using System.Data;

using Npgsql;
using NpgsqlTypes;
using eDocuments.Entities;
using eDocuments.Common;

namespace eDocuments.DataAccess
{
    public class DAEstado
    {
        /// <summary>
        /// Lista los estados de solicitudes
        /// </summary>
        /// <returns>Lista de Estados</returns>
        public List<BEEstado> ListarEstado()
        {
            List<BEEstado> oListado = new List<BEEstado>();
            BEEstado oItem;

            using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
            {
                ocn.Open();
                NpgsqlTransaction tran = ocn.BeginTransaction();
                using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_listar_estados", ocn))
                {
                    ocmd.CommandType = CommandType.StoredProcedure;

                    using (NpgsqlDataReader odr = ocmd.ExecuteReader())
                    {
                        while (odr.Read())
                        {
                            oItem = new BEEstado();

                            if (!Convert.IsDBNull(odr["cod_estado"]))
                                oItem.cod_estado = Convert.ToInt32(odr["cod_estado"]);

                            if (!Convert.IsDBNull(odr["gls_estado"]))
                                oItem.gls_estado = odr["gls_estado"].ToString();

                            if (!Convert.IsDBNull(odr["cod_estado_registro"]))
                                oItem.cod_estado_registro = Convert.ToInt32(odr["cod_estado_registro"]);

                            oListado.Add(oItem);
                        }
                        odr.Close();
                    }
                }
                tran.Commit();
                ocn.Close();
            }

            return oListado;
        }
    }
}
