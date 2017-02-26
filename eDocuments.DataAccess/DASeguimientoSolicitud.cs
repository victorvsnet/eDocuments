
using System;
using System.Collections.Generic;
using System.Data;

using Npgsql;
using NpgsqlTypes;
using eDocuments.Entities;
using eDocuments.Common;

namespace eDocuments.DataAccess
{
    public class DASeguimientoSolicitud
    {
        public int RegistrarSeguimientoSolicitud(BESeguimientoSolicitud oParametro)
        {
            int idRegistro = 0;
            try
            {
                using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
                {
                    ocn.Open();
                    NpgsqlTransaction tran = ocn.BeginTransaction();
                    using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_registrar_doc_seg_solicitud", ocn))
                    {
                        ocmd.CommandType = CommandType.StoredProcedure;
                        ocmd.Parameters.Add("@p_cod_solicitud", NpgsqlDbType.Varchar).Value = oParametro.cod_solicitud;
                        ocmd.Parameters.Add("@p_cod_estado", NpgsqlDbType.Integer).Value = oParametro.cod_estado;
                        ocmd.Parameters.Add("@p_gls_observacion", NpgsqlDbType.Varchar).Value = oParametro.gls_observacion;
                        ocmd.Parameters.Add("@p_aud_usr_ingreso", NpgsqlDbType.Varchar).Value = oParametro.aud_usr_ingreso;

                        using (NpgsqlDataReader odr = ocmd.ExecuteReader())
                        {
                            while (odr.Read())
                            {
                                idRegistro = Convert.ToInt32(odr[0]);
                            }
                        }

                    }
                    tran.Commit();
                    ocn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return idRegistro;
        }
    }
}
