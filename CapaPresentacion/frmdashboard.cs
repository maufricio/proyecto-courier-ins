using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            if (dgvfletequeja.Columns["btnquejas"] == null)
            {
                DataGridViewButtonColumn btnquejas = new DataGridViewButtonColumn();
                btnquejas.Name = "btnquejas";
                btnquejas.HeaderText = "quejas";
                btnquejas.Text = "Ver Panel";
                btnquejas.UseColumnTextForButtonValue = true;
                dgvfletequeja.Columns.Add(btnquejas);
            }

            if (dgvfleteprogramado.Columns["btnprogramado"] == null)
            {
                DataGridViewButtonColumn btnprogramado = new DataGridViewButtonColumn();
                btnprogramado.Name = "btnprogramado";
                btnprogramado.HeaderText = "Programados";
                btnprogramado.Text = "Ver Panel";
                btnprogramado.UseColumnTextForButtonValue = true;
                dgvfleteprogramado.Columns.Add(btnprogramado);
            }
        }
    }
}
