using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_UtilidadFlete
    {
        private CD_UtilidadFlete objcd_UtilidadFlete = new CD_UtilidadFlete();

        public List<UtilidadFlete> ListarUtilidadesFletes()
        {
            return objcd_UtilidadFlete.ListarUtilidadesFletes();
        }

        public DetalleGastoFlete ObtenerDetalleGastos(int idFlete)
        {
            return objcd_UtilidadFlete.ObtenerDetalleGastos(idFlete);
        }

        public List<GastoFlete> ObtenerGastosPorFlete(int idFlete)
        {
            return objcd_UtilidadFlete.ObtenerGastosPorFlete(idFlete);
        }

        public UtilidadFlete ObtenerUtilidadPorFlete(int idFlete)
        {
            return objcd_UtilidadFlete.ObtenerUtilidadPorFlete(idFlete);
        }
    }
}