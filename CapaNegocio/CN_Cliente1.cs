using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente1
    {
        private CD_Cliente1 objcd_Cliente1 = new CD_Cliente1();


        public List<Cliente1> Listar()
        {
            return objcd_Cliente1.Listar();
        }
    }
}
