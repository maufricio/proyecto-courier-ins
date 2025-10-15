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
    public partial class mdtransporte : Form
    {

        public Transporte _Transporte { get; set; }
        public mdtransporte()
        {
            InitializeComponent();
        }

        private void mdtransporte_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvtransporte.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<Transporte> lista = new CN_Transporte().Listar();

            foreach (Transporte item in lista)
            {
                dgvtransporte.Rows.Add(new object[] { item.IdUnidad, item.Placa, item.Marca });
            }
        }

        private void btnbuscartransporte_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvtransporte.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvtransporte.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbtransporte.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbtransporte.Text = "";
            foreach (DataGridViewRow row in dgvtransporte.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvtransporte_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                _Transporte = new Transporte()
                {
                    IdUnidad = Convert.ToInt32(dgvtransporte.Rows[iRow].Cells["IdUnidad"].Value.ToString()),
                    Placa = dgvtransporte.Rows[iRow].Cells["Placa"].Value.ToString(),
                    Marca = dgvtransporte.Rows[iRow].Cells["Marca"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
