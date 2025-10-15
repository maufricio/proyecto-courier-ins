using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_CalculosUtil
    {
        // GUARDAR DATOS DE GASTOS
        public int Guardar(CalculosUtil obj, out string Mensaje)
        {
            int idCalculoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_GuardarGastos", oconexion);
                    cmd.Parameters.AddWithValue("IdFlete", obj.IdFlete);
                    cmd.Parameters.AddWithValue("TipoGasto", obj.TipoGasto);
                    cmd.Parameters.AddWithValue("Concepto", obj.Concepto);
                    cmd.Parameters.AddWithValue("Monto", obj.Monto);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idCalculoGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCalculoGenerado = 0;
                Mensaje = ex.Message;
            }

            return idCalculoGenerado;
        }

        // EDITAR DATOS DE GASTOS
        public bool Editar(CalculosUtil obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_EditarGastos", oconexion);
                    cmd.Parameters.AddWithValue("IdGasto", obj.IdGasto);
                    cmd.Parameters.AddWithValue("TipoGasto", obj.TipoGasto);
                    cmd.Parameters.AddWithValue("Concepto", obj.Concepto);
                    cmd.Parameters.AddWithValue("Monto", obj.Monto);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        // ELIMINAR DATOS DE GASTOS
        public bool Eliminar(CalculosUtil obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarGastos", oconexion);
                    cmd.Parameters.AddWithValue("IdGasto", obj.IdGasto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        // OBTENER DATOS DEL FLETE
        public decimal ObtenerMontoFlete(int idFlete)
        {
            decimal monto = 0;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SELECT MontoCobro FROM FLETE WHERE IdFlete = @IdFlete", oconexion);
                    cmd.Parameters.AddWithValue("@IdFlete", idFlete);
                    oconexion.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        monto = Convert.ToDecimal(result);
                    }
                }
            }
            catch
            {
                monto = 0;
            }
            return monto;
        }

        //LISTAR GASTOS POR ID DE FLETE
        /*public List<CalculosUtil> Listar(int idFlete)
        {
            List<CalculosUtil> oLista = new List<CalculosUtil>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ObtenerGastos", oconexion);
                    cmd.Parameters.AddWithValue("IdFlete", idFlete);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new CalculosUtil()
                            {
                                IdGasto = Convert.ToInt32(dr["IdGasto"]),
                                IdFlete = Convert.ToInt32(dr["IdFlete"]),
                                TipoGasto = dr["TipoGasto"].ToString(),
                                Concepto = dr["Concepto"].ToString(),
                                Monto = Convert.ToDecimal(dr["Monto"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<CalculosUtil>();
            }
            return oLista;
        }*/
    }
}
