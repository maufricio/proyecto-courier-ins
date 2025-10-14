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
    public class CD_Transporte
    {
        public List<Transporte> Listar()
        {
            List<Transporte> lista = new List<Transporte>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdUnidad, Placa, Marca from UNIDAD_TRANSPORTE");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Transporte()
                            {
                                IdUnidad = Convert.ToInt32(dr["IdUnidad"]),
                                Placa = dr["Placa"].ToString(),
                                Marca = dr["Marca"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Transporte>();
                }
            }
            return lista;
        }
    }
}
