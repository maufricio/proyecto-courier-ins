using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_UtilidadFlete
    {
        // Listar fletes terminados con su utilidad usando el SP
        public List<UtilidadFlete> ListarUtilidadesFletes()
        {
            List<UtilidadFlete> lista = new List<UtilidadFlete>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_CalcularUtilidadFlete", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new UtilidadFlete()
                            {
                                IdFlete = Convert.ToInt32(dr["IdFlete"]),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                Placa = dr["Placa"].ToString(),
                                NombreMotorista = dr["NombreMotorista"].ToString(),
                                ValorFlete = Convert.ToDecimal(dr["ValorFlete"]),
                                TotalGastos = Convert.ToDecimal(dr["TotalGastos"]),
                                UtilidadNeta = Convert.ToDecimal(dr["UtilidadNeta"]),
                                PorcentajeUtilidad = Convert.ToDecimal(dr["PorcentajeUtilidad"]),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<UtilidadFlete>();
                    Console.WriteLine(ex.Message.ToString());
                }
            }

            return lista;
        }

        // Obtener detalle de gastos por categoría de un flete específico
        public DetalleGastoFlete ObtenerDetalleGastos(int idFlete)
        {
            DetalleGastoFlete detalle = new DetalleGastoFlete();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT ");
                    query.AppendLine("    ISNULL(SUM(CASE WHEN TipoGasto = 'Camión' THEN Monto ELSE 0 END), 0) AS TotalGastosCamion,");
                    query.AppendLine("    ISNULL(SUM(CASE WHEN TipoGasto = 'Varios' THEN Monto ELSE 0 END), 0) AS TotalGastosVarios,");
                    query.AppendLine("    ISNULL(SUM(CASE WHEN TipoGasto = 'Producción' THEN Monto ELSE 0 END), 0) AS TotalGastosProduccion");
                    query.AppendLine("FROM GASTO_FLETE");
                    query.AppendLine("WHERE IdFlete = @IdFlete");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdFlete", idFlete);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            detalle.IdFlete = idFlete;
                            detalle.TotalGastosCamion = Convert.ToDecimal(dr["TotalGastosCamion"]);
                            detalle.TotalGastosVarios = Convert.ToDecimal(dr["TotalGastosVarios"]);
                            detalle.TotalGastosProduccion = Convert.ToDecimal(dr["TotalGastosProduccion"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }

            return detalle;
        }

        // Obtener todos los gastos de un flete para el reporte detallado
        public List<GastoFlete> ObtenerGastosPorFlete(int idFlete)
        {
            List<GastoFlete> lista = new List<GastoFlete>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdGasto, IdFlete, TipoGasto, Concepto, Monto, FechaRegistro");
                    query.AppendLine("FROM GASTO_FLETE");
                    query.AppendLine("WHERE IdFlete = @IdFlete");
                    query.AppendLine("ORDER BY TipoGasto, Concepto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdFlete", idFlete);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new GastoFlete()
                            {
                                IdGasto = Convert.ToInt32(dr["IdGasto"]),
                                IdFlete = Convert.ToInt32(dr["IdFlete"]),
                                TipoGasto = dr["TipoGasto"].ToString(),
                                Concepto = dr["Concepto"].ToString(),
                                Monto = Convert.ToDecimal(dr["Monto"]),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<GastoFlete>();
                    Console.WriteLine(ex.Message.ToString());
                }
            }

            return lista;
        }

        // Obtener información completa de un flete para el PDF
        public UtilidadFlete ObtenerUtilidadPorFlete(int idFlete)
        {
            UtilidadFlete utilidad = null;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT ");
                    query.AppendLine("    f.IdFlete,");
                    query.AppendLine("    c.NombreCliente,");
                    query.AppendLine("    u.Placa,");
                    query.AppendLine("    m.NombreMotorista,");
                    query.AppendLine("    f.MontoCobro AS ValorFlete,");
                    query.AppendLine("    ISNULL(SUM(g.Monto), 0) AS TotalGastos,");
                    query.AppendLine("    (f.MontoCobro - ISNULL(SUM(g.Monto), 0)) AS UtilidadNeta,");
                    query.AppendLine("    CASE ");
                    query.AppendLine("        WHEN f.MontoCobro > 0 ");
                    query.AppendLine("        THEN ((f.MontoCobro - ISNULL(SUM(g.Monto), 0)) / f.MontoCobro) * 100");
                    query.AppendLine("        ELSE 0");
                    query.AppendLine("    END AS PorcentajeUtilidad,");
                    query.AppendLine("    f.FechaRegistro");
                    query.AppendLine("FROM FLETE f");
                    query.AppendLine("INNER JOIN CLIENTE c ON f.IdCliente = c.IdCliente");
                    query.AppendLine("INNER JOIN UNIDAD_TRANSPORTE u ON f.IdUnidad = u.IdUnidad");
                    query.AppendLine("INNER JOIN MOTORISTA m ON f.IdMotorista = m.IdMotorista");
                    query.AppendLine("LEFT JOIN GASTO_FLETE g ON f.IdFlete = g.IdFlete");
                    query.AppendLine("WHERE f.IdFlete = @IdFlete");
                    query.AppendLine("GROUP BY f.IdFlete, c.NombreCliente, u.Placa, m.NombreMotorista, f.MontoCobro, f.FechaRegistro");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdFlete", idFlete);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            utilidad = new UtilidadFlete()
                            {
                                IdFlete = Convert.ToInt32(dr["IdFlete"]),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                Placa = dr["Placa"].ToString(),
                                NombreMotorista = dr["NombreMotorista"].ToString(),
                                ValorFlete = Convert.ToDecimal(dr["ValorFlete"]),
                                TotalGastos = Convert.ToDecimal(dr["TotalGastos"]),
                                UtilidadNeta = Convert.ToDecimal(dr["UtilidadNeta"]),
                                PorcentajeUtilidad = Convert.ToDecimal(dr["PorcentajeUtilidad"]),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }

            return utilidad;
        }
    }
}