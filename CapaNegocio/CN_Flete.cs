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

        public List<Flete> ListarFletesProgramadosTop()
        {
            return objcd_Flete.ListarFletesProgramadosTop();
        }

        public List<Flete> ListarFletesEnTranscursoTop()
        {
            return this.objcd_Flete.listarFletesEnTranscursoTop();
        }

        private bool validacionCamposRegistraryEditar(Flete obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            // Validación de campos obligatorios
            if (obj.oCliente.IdCliente == 0)
                Mensaje = "Debe seleccionar un cliente para registrar el flete";
            if (obj.oMotorista.IdMotorista == 0)
                Mensaje = "Debe seleccionar un motorista para registrar el flete";
            if (obj.oTransporte.IdUnidad == 0)
                Mensaje = "Debe seleccionar una unidad de transporte para ingresar el flete";
            if (obj.Monto == 0)
                Mensaje = "Debe ingresar un monto de cobro del flete.";
            if (string.IsNullOrWhiteSpace(obj.Lrecolecta))
                Mensaje = "Debe ingresar el lugar de la recolecta.";
            if (string.IsNullOrWhiteSpace(obj.Lentrega))
                Mensaje = "Debe ingresar le lugar de entrega";

            // Validación de fechas
            if (obj.Hllegada < obj.Hsalida)
                Mensaje = "La fecha y hora de llegada no puede ser anterior a la fecha y hora de salida";

            return string.IsNullOrEmpty(Mensaje);
        }

        public bool RegistrarFlete(Flete obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            this.validacionCamposRegistraryEditar(obj, out Mensaje);


            if (string.IsNullOrEmpty(Mensaje))
                return this.objcd_Flete.RegistrarFlete(obj, out Mensaje);
            else
                return false;
        }

        public bool Editar(Flete obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            this.validacionCamposRegistraryEditar(obj, out Mensaje);


            if (string.IsNullOrEmpty(Mensaje))
                return this.objcd_Flete.Editar(obj, out Mensaje);
            else
                return false;
        }

        public bool Eliminar(Flete obj, out string Mensaje)
        {
            return new CD_Flete().Eliminar(obj, out Mensaje);
        }
    }
}
