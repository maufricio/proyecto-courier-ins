using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_UnidadTransporte
    {
        private CD_UnidadTransporte objcd_UnidadTransporte = new CD_UnidadTransporte();

        public List<UnidadTransporte> Listar()
        {
            return objcd_UnidadTransporte.Listar();
        }

        public int Registrar(UnidadTransporte obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(obj.Placa))
            {
                Mensaje += "Es necesaria la placa de la unidad\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Marca))
            {
                Mensaje += "Es necesaria la marca de la unidad\n";
            }

            if (obj.CapacidadToneladas <= 0)
            {
                Mensaje += "La capacidad debe ser mayor a 0\n";
            }

            if (obj.AnioFabricacion < 1900 || obj.AnioFabricacion > DateTime.Now.Year)
            {
                Mensaje += "El año de fabricación no es válido\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_UnidadTransporte.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(UnidadTransporte obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(obj.Placa))
            {
                Mensaje += "Es necesaria la placa de la unidad\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Marca))
            {
                Mensaje += "Es necesaria la marca de la unidad\n";
            }

            if (obj.CapacidadToneladas <= 0)
            {
                Mensaje += "La capacidad debe ser mayor a 0\n";
            }

            if (obj.AnioFabricacion < 1900 || obj.AnioFabricacion > DateTime.Now.Year)
            {
                Mensaje += "El año de fabricación no es válido\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_UnidadTransporte.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(UnidadTransporte obj, out string Mensaje)
        {
            return objcd_UnidadTransporte.Eliminar(obj, out Mensaje);
        }
    }
}