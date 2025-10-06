using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Motorista
    {
        private CD_Motorista objcd_Motorista = new CD_Motorista();


        public List<Motorista> Listar()
        {
            return objcd_Motorista.Listar();
        }
    }
}
