using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace CapaDatos
{
 

     public class CD_Flete
    {
        public bool RegistrarFlete(
            int idCliente,
            int idUnidad,
            int idMotorista,
            int idEstado,
            decimal monto,
            string lugarRecolecta,
            string lugarEntrega,
            string consideraciones,
            DateTime horaSalida,
            DateTime horaDestino
        )
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("INSERT INTO FLETE (IdCliente, IdUnidad, IdMotorista, IdEstado, MontoCobro, LugarRecolecta, LugarEntrega, Consideraciones, HoraSalida, HoraDestino)");
                    query.AppendLine("VALUES (@IdCliente, @IdUnidad, @IdMotorista, @IdEstado, @Monto, @LugarRecolecta, @LugarEntrega, @Consideraciones, @HoraSalida, @HoraDestino)");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@IdUnidad", idUnidad);
                    cmd.Parameters.AddWithValue("@IdMotorista", idMotorista);
                    cmd.Parameters.AddWithValue("@IdEstado", idEstado);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@LugarRecolecta", lugarRecolecta);
                    cmd.Parameters.AddWithValue("@LugarEntrega", lugarEntrega);
                    cmd.Parameters.AddWithValue("@Consideraciones", consideraciones);
                    cmd.Parameters.AddWithValue("@HoraSalida", horaSalida);
                    cmd.Parameters.AddWithValue("@HoraDestino", horaDestino);


                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex) 
                {
                    //MessageBox.Show("Error al registrar flete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public List<Flete> Listar()
        {
            List<Flete> Lista = new List<Flete>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT");
                    query.AppendLine("  f.IdFlete,");
                    query.AppendLine("  f.IdCliente,");
                    query.AppendLine("  f.IdUnidad,");
                    query.AppendLine("  f.IdMotorista,");
                    query.AppendLine("  f.IdEstado,");
                    query.AppendLine("  c.NombreCliente,");
                    query.AppendLine("  m.NombreMotorista,");
                    query.AppendLine("  u.Placa,");
                    query.AppendLine("  e.Descripcion,");
                    query.AppendLine("  f.MontoCobro,");
                    query.AppendLine("  f.LugarRecolecta,");
                    query.AppendLine("  f.LugarEntrega,");
                    query.AppendLine("  f.HoraSalida,");
                    query.AppendLine("  f.HoraDestino,");
                    query.AppendLine("  f.Consideraciones");
                    query.AppendLine("FROM FLETE f");
                    query.AppendLine("INNER JOIN CLIENTE c ON f.IdCliente = c.IdCliente");
                    query.AppendLine("INNER JOIN MOTORISTA m ON f.IdMotorista = m.IdMotorista");
                    query.AppendLine("INNER JOIN UNIDAD_TRANSPORTE u ON f.IdUnidad = u.IdUnidad");
                    query.AppendLine("INNER JOIN ESTADO_FLETE e ON f.IdEstado = e.IdEstado");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);                    
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Flete()
                            {
                                IdFlete = Convert.ToInt32(dr["IdFlete"]),
                                oCliente = new Cliente()
                                {
                                    IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                    NombreCliente = dr["NombreCliente"].ToString()
                                },
                                oMotorista = new Motorista()
                                {
                                    IdMotorista = Convert.ToInt32(dr["IdMotorista"]),
                                    NombreM = dr["NombreMotorista"].ToString()
                                },
                                oTransporte = new Transporte()
                                {
                                    IdUnidad = Convert.ToInt32(dr["IdUnidad"]),
                                    Placa = dr["Placa"].ToString()
                                },
                                oEstado = new Estado()
                                {
                                    IdEstado = Convert.ToInt32(dr["IdEstado"]),
                                    Descripcion = dr["Descripcion"].ToString()
                                },
                                Monto = Convert.ToDecimal(dr["MontoCobro"]),
                                Lrecolecta = dr["LugarRecolecta"].ToString(),
                                Lentrega = dr["LugarEntrega"].ToString(),
                                Hsalida = Convert.ToDateTime(dr["HoraSalida"]),
                                Hllegada = Convert.ToDateTime(dr["HoraDestino"]),
                                Consideraciones = dr["Consideraciones"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Lista = new List<Flete>();
            }
            return Lista;
        }


        public bool Editar(Flete obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE FLETE SET");
                    query.AppendLine("  IdCliente = @IdCliente,");
                    query.AppendLine("  IdUnidad = @IdUnidad,");
                    query.AppendLine("  IdMotorista = @IdMotorista,");
                    query.AppendLine("  IdEstado = @IdEstado,");
                    query.AppendLine("  MontoCobro = @MontoCobro,");
                    query.AppendLine("  LugarRecolecta = @LugarRecolecta,");
                    query.AppendLine("  LugarEntrega = @LugarEntrega,");
                    query.AppendLine("  HoraSalida = @HoraSalida,");
                    query.AppendLine("  HoraDestino = @HoraDestino,");
                    query.AppendLine("  Consideraciones = @Consideraciones");
                    query.AppendLine("WHERE IdFlete = @IdFlete");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdFlete", obj.IdFlete);
                    cmd.Parameters.AddWithValue("@IdCliente", obj.oCliente.IdCliente);
                    cmd.Parameters.AddWithValue("@IdUnidad", obj.oTransporte.IdUnidad);
                    cmd.Parameters.AddWithValue("@IdMotorista", obj.oMotorista.IdMotorista);
                    cmd.Parameters.AddWithValue("@IdEstado", obj.oEstado.IdEstado);
                    cmd.Parameters.AddWithValue("@MontoCobro", obj.Monto);
                    cmd.Parameters.AddWithValue("@LugarRecolecta", obj.Lrecolecta);
                    cmd.Parameters.AddWithValue("@LugarEntrega", obj.Lentrega);
                    cmd.Parameters.AddWithValue("@HoraSalida", obj.Hsalida);
                    cmd.Parameters.AddWithValue("@HoraDestino", obj.Hllegada);
                    cmd.Parameters.AddWithValue("@Consideraciones", obj.Consideraciones);

                    oconexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    respuesta = filasAfectadas > 0;
                    Mensaje = respuesta ? "Flete editado correctamente." : "No se pudo editar el flete.";
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(Flete obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM FLETE WHERE IdFlete = @IdFlete");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdFlete", obj.IdFlete);

                    oconexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    respuesta = filasAfectadas > 0;
                    Mensaje = respuesta ? "Flete eliminado correctamente." : "No se pudo eliminar el flete.";
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

    }

}

