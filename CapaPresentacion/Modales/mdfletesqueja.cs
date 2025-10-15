using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdfletesqueja : Form
    {
        public mdfletesqueja()
        {
            InitializeComponent();
        }

        private void mdfletesqueja_Load(object sender, EventArgs e)
        {
            List<Flete> lista = new CN_Flete().Listar();
            foreach (Flete item in lista.Where(f => f.oEstado.IdEstado == 5))
            {
                dgvfletequeja.Rows.Add(new object[] {
                    item.IdFlete,                      // 0                   
                    item.oCliente.NombreCliente,       // 1
                    item.oMotorista.NombreMotorista,           // 2
                    item.oTransporte.Placa,            // 3
                    item.oEstado.Descripcion,          // 4
                });
            }
        }
    }
}
