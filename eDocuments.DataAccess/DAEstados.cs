using eDocuments.Common;
using eDocuments.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDocuments.DataAccess
{
    public class DAEstados
    {
        /// <summary>
        /// Lista los estados de solicitudes
        /// </summary>
        /// <returns>Lista de Estados</returns>
        public List<BEEstados> ListarEstados()
        {
            List<BEEstados> oListado = new List<BEEstados>();
            BEEstados oItem;

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
                            oItem = new BEEstados();

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
