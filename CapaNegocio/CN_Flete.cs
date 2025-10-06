using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Flete
    {
        private CD_Flete objcd_Flete = new CD_Flete();


        public List<Flete> Listar()
        {
            return objcd_Flete.Listar();
        }

        public bool Editar(Flete obj, out string Mensaje)
        {
            return new CD_Flete().Editar(obj, out Mensaje);
        }

        public bool Eliminar(Flete obj, out string Mensaje)
        {
            return new CD_Flete().Eliminar(obj, out Mensaje);
        }
    }
}
