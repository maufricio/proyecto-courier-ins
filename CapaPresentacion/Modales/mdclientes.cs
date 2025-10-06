using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
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
    public partial class mdclientes : Form
    {
        public Cliente1 _Cliente1 { get; set; }
        public mdclientes()
        {
            InitializeComponent();
        }

        private void mdclientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvclientes.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<Cliente1> lista = new CN_Cliente1().Listar();

            foreach (Cliente1 item in lista)
            {
                dgvclientes.Rows.Add(new object[] { item.IdCliente, item.NombreCliente, item.Direccion });
            }
        }


        private void btnbuscarcliente2_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvclientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvclientes.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbcliente.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbcliente.Text = "";
            foreach (DataGridViewRow row in dgvclientes.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                _Cliente1 = new Cliente1()
                {
                    IdCliente = Convert.ToInt32(dgvclientes.Rows[iRow].Cells["IdCliente"].Value.ToString()),
                    NombreCliente = dgvclientes.Rows[iRow].Cells["NombreCliente"].Value.ToString(),
                    Direccion = dgvclientes.Rows[iRow].Cells["Direccion"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
