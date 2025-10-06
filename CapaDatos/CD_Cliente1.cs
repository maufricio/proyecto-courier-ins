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
    public class CD_Cliente1
    {
        public List<Cliente1> Listar()
        {
            List<Cliente1> lista = new List<Cliente1>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdCliente,NombreCliente,Direccion from CLIENTE");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente1()
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                Direccion = dr["Direccion"].ToString(),                        
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente1>();
                }
            }
            return lista;
        }
    }
}
