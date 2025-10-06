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
    public class CD_Motorista
    {
        public List<Motorista> Listar()
        {
            List<Motorista> lista = new List<Motorista>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdMotorista,NombreMotorista,Correo FROM MOTORISTA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Motorista()
                            {
                                IdMotorista = Convert.ToInt32(dr["IdMotorista"]),
                                NombreM = dr["NombreMotorista"].ToString(),
                                Correo = dr["Correo"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Motorista>();
                }
            }
            return lista;
        }
    }
}
