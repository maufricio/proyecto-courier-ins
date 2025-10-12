using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_CalculosUtil
    {
        private CD_CalculosUtil objcd_Calc = new CD_CalculosUtil();

        public int Guardar(CalculosUtil obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.TipoGasto == " ")
            {
                Mensaje += "Seleccione el tipo de gasto\n";
            }

            if (obj.Monto < 0)
            {
                Mensaje += "Escriba un monto real\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Calc.Guardar(obj, out Mensaje);
            }


        }


        public bool Editar(CalculosUtil obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (obj.TipoGasto == "")
            {
                Mensaje += "Seleccione el tipo de gasto\n";
            }

            if (obj.Monto < 0)
            {
                Mensaje += "Escriba un monto real\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Calc.Editar(obj, out Mensaje);
            }
        }


        public bool Eliminar(CalculosUtil obj, out string Mensaje)
        {
            return objcd_Calc.Eliminar(obj, out Mensaje);
        }
    }
}
