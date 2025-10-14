using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Transporte
    {
        private CD_Transporte objcd_Transporte = new CD_Transporte();


        public List<Transporte> Listar()
        {
            return objcd_Transporte.Listar();
        }
    }
}
