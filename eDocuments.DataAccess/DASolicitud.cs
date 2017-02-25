using eDocuments.Common;
using eDocuments.Entities;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDocuments.DataAccess
{
    public class DASolicitud
    {
        public int RegistrarSolicitud(BESolicitud oParametro)
        {
            int idRegistro = 0;
            try
            {
                using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
                {
                    ocn.Open();
                    NpgsqlTransaction tran = ocn.BeginTransaction();
                    using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_registrar_doc_solicitud", ocn))
                    {
                        ocmd.CommandType = CommandType.StoredProcedure;
                        ocmd.Parameters.Add("@p_gls_solicitud", NpgsqlDbType.Varchar).Value = oParametro.gls_solicitud;
                        ocmd.Parameters.Add("@p_cod_estado", NpgsqlDbType.Varchar).Value = oParametro.cod_estado;
                        ocmd.Parameters.Add("@p_cod_documento", NpgsqlDbType.Integer).Value = oParametro.cod_documento;
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

        public bool ModificarSolicitud(BESolicitud oParametro)
        {
            bool estadoIngreso = false;
            try
            {
                using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
                {
                    using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_actualizar_doc_solicitud", ocn))
                    {
                        ocmd.CommandType = CommandType.StoredProcedure;
                        ocmd.Parameters.Add("@p_cod_solicitud", NpgsqlDbType.Integer).Value = oParametro.cod_solicitud;
                        ocmd.Parameters.Add("@p_gls_solicitud", NpgsqlDbType.Varchar).Value = oParametro.gls_solicitud;
                        ocmd.Parameters.Add("@p_cod_estado", NpgsqlDbType.Integer).Value = oParametro.cod_estado;
                        ocmd.Parameters.Add("@p_cod_documento", NpgsqlDbType.Integer).Value = oParametro.cod_documento;
                        ocmd.Parameters.Add("@p_aud_usr_modificacion", NpgsqlDbType.Varchar).Value = oParametro.aud_usr_modificacion;
                        ocmd.Parameters.Add("@p_cod_estado_registro", NpgsqlDbType.Integer).Value = oParametro.cod_estado_registro;

                        ocn.Open();
                        ocmd.ExecuteNonQuery();
                        estadoIngreso = true;
                    }
                    ocn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return estadoIngreso;
        }

        public BESolicitud ObtenerSolicitud(int cod_solicitud)
        {
            BESolicitud oUsuario = new BESolicitud();

            using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
            {
                ocn.Open();
                NpgsqlTransaction tran = ocn.BeginTransaction();
                using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_obtener_doc_solicitud", ocn))
                {
                    ocmd.CommandType = CommandType.StoredProcedure;
                    ocmd.Parameters.Add("@p_cod_solicitud", NpgsqlDbType.Integer).Value = cod_solicitud;

                    using (NpgsqlDataReader odr = ocmd.ExecuteReader())
                    {
                        while (odr.Read())
                        {

                            if (!Convert.IsDBNull(odr["cod_solicitud"]))
                                oUsuario.cod_solicitud = Convert.ToInt32(odr["cod_solicitud"]);

                            if (!Convert.IsDBNull(odr["gls_solicitud"]))
                                oUsuario.gls_solicitud = odr["gls_solicitud"].ToString();

                            if (!Convert.IsDBNull(odr["cod_estado"]))
                                oUsuario.cod_estado = Convert.ToInt32(odr["cod_estado"]);

                            if (!Convert.IsDBNull(odr["cod_documento"]))
                                oUsuario.cod_documento = Convert.ToInt32(odr["cod_documento"]);

                            if (!Convert.IsDBNull(odr["cod_estado_registro"]))
                                oUsuario.cod_estado_registro = Convert.ToInt32(odr["cod_estado_registro"]);

                        }
                        odr.Close();
                    }
                }
                tran.Commit();
                ocn.Close();
            }

            return oUsuario;
        }

        public int EliminarSolicitud(BESolicitud solicitud)
        {
            int iResultado;

            try
            {
                using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
                {
                    ocn.Open();
                    NpgsqlTransaction tran = ocn.BeginTransaction();
                    using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_eliminar_doc_solicitud", ocn))
                    {
                        ocmd.CommandType = CommandType.StoredProcedure;
                        ocmd.Parameters.Add("@p_cod_solicitud", NpgsqlDbType.Integer).Value = solicitud.cod_solicitud;
                        ocmd.Parameters.Add("@p_aud_usr_modificacion", NpgsqlDbType.Varchar).Value = solicitud.aud_usr_modificacion;

                        iResultado = ocmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    ocn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //estadoIngreso = false;
            }

            return iResultado;
        }

    }
}
