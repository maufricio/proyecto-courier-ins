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

        public int Registrar(Motorista obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.NombreMotorista == "")
            {
                Mensaje += "Es necesario el nombre del Motorista\n";
            }
            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la direccion del Motorista\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Motorista\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Motorista\n";
            }
            if (obj.PerfilSocial == "")
            {
                Mensaje += "Es necesario el perfil social del Motorista\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Motorista.Registrar(obj, out Mensaje);
            }
        }


        public bool Editar(Motorista obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.NombreMotorista == "")
            {
                Mensaje += "Es necesario el nombre del Motorista\n";
            }
            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la direccion del Motorista\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Motorista\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Motorista\n";
            }
            if (obj.PerfilSocial == "")
            {
                Mensaje += "Es necesario el perfil social del Motorista\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Motorista.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Motorista obj, out string Mensaje)
        {
            return objcd_Motorista.Eliminar(obj, out Mensaje);
        }
    }
}

