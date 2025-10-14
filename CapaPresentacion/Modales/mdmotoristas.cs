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
    public partial class mdmotoristas : Form
    {
        public Motorista _Motorista { get; set; }

        public mdmotoristas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mdmotoristas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvmotorista.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<Motorista> lista = new CN_Motorista().Listar();

            foreach (Motorista item in lista)
            {
                dgvmotorista.Rows.Add(new object[] { item.IdMotorista, item.NombreM, item.Correo });
            }
        }

        private void btnbuscarmotorista_Click(object sender, EventArgs e)
        {

            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvmotorista.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvmotorista.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbmotorista.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }

        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbmotorista.Text = "";
            foreach (DataGridViewRow row in dgvmotorista.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvmotorista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                _Motorista = new Motorista()
                {
                    IdMotorista = Convert.ToInt32(dgvmotorista.Rows[iRow].Cells["IdMotorista"].Value.ToString()),
                    NombreM = dgvmotorista.Rows[iRow].Cells["NombreMotorista"].Value.ToString(),
                    Correo = dgvmotorista.Rows[iRow].Cells["Correo"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
