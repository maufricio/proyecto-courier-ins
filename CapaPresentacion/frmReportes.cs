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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void cbCamion_CheckedChanged(object sender, EventArgs e)
        {
            txtBateria.Enabled = cbCamion.Checked;
            txtAceite.Enabled = cbCamion.Checked;
            txtLlanta.Enabled = cbCamion.Checked;
            cbNoLlantas.Enabled = cbCamion.Checked;

            if (!cbCamion.Checked)
            {
                txtBateria.Text = "";
                txtAceite.Text = "";
                txtLlanta.Text = "";
                cbNoLlantas.SelectedIndex = -1;
            }
        }

        private void cbProd_CheckedChanged(object sender, EventArgs e)
        {
            txtMotorista.Enabled = cbProd.Checked;
            txtAuxilar.Enabled = cbProd.Checked;
            txtGas.Enabled = cbProd.Checked;
            cbNoAux.Enabled = cbProd.Checked;

            if (!cbProd.Checked)
            {
                txtMotorista.Text = "";
                txtAuxilar.Text = "";
                txtGas.Text = "";
                cbNoAux.SelectedIndex = -1;
            }
        }

        private void cbVarios_CheckedChanged(object sender, EventArgs e)
        {
            txtHospedaje.Enabled = cbVarios.Checked;
            txtParqueo.Enabled = cbVarios.Checked;
            txtOtros.Enabled = cbVarios.Checked;
            cbNoHosp.Enabled = cbVarios.Checked;

            if (!cbVarios.Checked)
            {
                txtHospedaje.Text = "";
                txtParqueo.Text = "";
                txtOtros.Text = "";
                cbNoHosp.SelectedIndex = -1;
            }
        }

        private void ibtnGuardar_Click(object sender, EventArgs e)
        {
            // Se muestran los botones de editar y limpiar
            ibtnEditar.Visible = true;
            ibtnLimpiar.Visible = true;

            //Se deshabilitan los campos de texto y los combo box
            txtAceite.Enabled = false;
            txtAuxilar.Enabled = false;
            txtBateria.Enabled = false;
            txtGas.Enabled = false;
            txtHospedaje.Enabled = false;
            txtLlanta.Enabled = false;
            txtMotorista.Enabled = false;
            txtOtros.Enabled = false;
            txtParqueo.Enabled = false;
            cbCamion.Enabled = false;
            cbNoAux.Enabled = false;
            cbNoHosp.Enabled = false;
            cbNoLlantas.Enabled = false;
            cbProd.Enabled = false;
            cbVarios.Enabled = false;

            //MessageBox.Show("Reporte guardado exitosamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ibtnLimpiar_Click(object sender, EventArgs e)
        {
            //Se limpian los campos de texto y los combo box
            cbCamion.Checked = false;
            cbProd.Checked = false;
            cbVarios.Checked = false;
            cbCamion.Enabled = true;
            cbProd.Enabled = true;
            cbVarios.Enabled = true;

            //Se ocultan los botones de editar y limpiar
            ibtnLimpiar.Visible = false;
            ibtnEditar.Visible = false;
        }

        private void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (cbCamion.Checked)
            {
                txtBateria.Enabled = true;
                txtAceite.Enabled = true;
                txtLlanta.Enabled = true;
                cbNoLlantas.Enabled = true;
                cbCamion.Enabled = true;
            }
            else
            {
                cbCamion.Enabled = true;
            }
            if (cbProd.Checked)
            {
                txtMotorista.Enabled = true;
                txtAuxilar.Enabled = true;
                txtGas.Enabled = true;
                cbNoAux.Enabled = true;
                cbProd.Enabled = true;
            }
            else
            {
                cbProd.Enabled = true;
            }
            if (cbVarios.Checked)
            {
                txtHospedaje.Enabled = true;
                txtParqueo.Enabled = true;
                txtOtros.Enabled = true;
                cbNoHosp.Enabled = true;
                cbVarios.Enabled = true;
            }
            else
            {
                cbVarios.Enabled = true;
            }
        }
    }
}
