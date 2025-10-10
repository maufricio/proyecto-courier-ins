using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class frmUnidadesTransporte : Form
    {
        public frmUnidadesTransporte()
        {
            InitializeComponent();
        }

        private void frmUnidadesTransporte_Load(object sender, EventArgs e)
        {
            // Configurar CheckBox de Estado por defecto
            chkActivo.Checked = true;
            chkInactivo.Checked = false;

            // Configurar ComboBox de Búsqueda con las opciones específicas
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "Placa", Texto = "Placa" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "Marca", Texto = "Marca" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "CapacidadToneladas", Texto = "Capacidad" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "AnioFabricacion", Texto = "Año de Fabricación" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "Estado", Texto = "Activo" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "Estado", Texto = "Inactivo" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = "FechaRegistro", Texto = "Fecha de Registro" });

            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            // MOSTRAR TODAS LAS UNIDADES DE TRANSPORTE
            List<UnidadTransporte> listaUnidades = new CN_UnidadTransporte().Listar();

            foreach (UnidadTransporte item in listaUnidades)
            {
                dgvData.Rows.Add(new object[] {
                    "",
                    item.IdUnidad,
                    item.Placa,
                    item.Marca,
                    item.CapacidadToneladas,
                    item.AnioFabricacion,
                    item.Estado == true ? 1:0,
                    item.Estado == true ? "Activo" : "Inactivo",
                    item.FechaRegistro.ToString("dd/MM/yyyy")
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("Debe ingresar la placa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlaca.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Debe ingresar la marca", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return;
            }

            if (nudCapacidad.Value <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudCapacidad.Focus();
                return;
            }

            // Validar que solo un CheckBox esté seleccionado
            if (!chkActivo.Checked && !chkInactivo.Checked)
            {
                MessageBox.Show("Debe seleccionar el estado de la unidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UnidadTransporte objunidad = new UnidadTransporte()
            {
                IdUnidad = Convert.ToInt32(txtid.Text),
                Placa = txtPlaca.Text.Trim().ToUpper(),
                Marca = txtMarca.Text.Trim(),
                CapacidadToneladas = nudCapacidad.Value,
                AnioFabricacion = Convert.ToInt32(nudAnio.Value),
                Estado = chkActivo.Checked
            };

            if (objunidad.IdUnidad == 0)
            {
                // REGISTRAR NUEVA UNIDAD
                int idgenerado = new CN_UnidadTransporte().Registrar(objunidad, out mensaje);

                if (idgenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {
                        "",
                        idgenerado,
                        txtPlaca.Text.Trim().ToUpper(),
                        txtMarca.Text.Trim(),
                        nudCapacidad.Value,
                        nudAnio.Value,
                        chkActivo.Checked ? 1 : 0,
                        chkActivo.Checked ? "Activo" : "Inactivo",
                        DateTime.Now.ToString("dd/MM/yyyy")
                    });

                    Limpiar();
                    MessageBox.Show("Unidad registrada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // EDITAR UNIDAD EXISTENTE
                bool resultado = new CN_UnidadTransporte().Editar(objunidad, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Placa"].Value = txtPlaca.Text.Trim().ToUpper();
                    row.Cells["Marca"].Value = txtMarca.Text.Trim();
                    row.Cells["CapacidadToneladas"].Value = nudCapacidad.Value;
                    row.Cells["AnioFabricacion"].Value = nudAnio.Value;
                    row.Cells["EstadoValor"].Value = chkActivo.Checked ? 1 : 0;
                    row.Cells["Estado"].Value = chkActivo.Checked ? "Activo" : "Inactivo";

                    Limpiar();
                    MessageBox.Show("Unidad actualizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtPlaca.Text = "";
            txtMarca.Text = "";
            nudCapacidad.Value = 0;
            nudAnio.Value = DateTime.Now.Year;
            chkActivo.Checked = true;
            chkInactivo.Checked = false;
            txtFechaRegistro.Text = "";

            txtPlaca.Select();
        }

        // Evento para CheckBox Activo
        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivo.Checked)
            {
                chkInactivo.Checked = false;
            }
        }

        // Evento para CheckBox Inactivo
        private void chkInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInactivo.Checked)
            {
                chkActivo.Checked = false;
            }
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtPlaca.Text = dgvData.Rows[indice].Cells["Placa"].Value.ToString();
                    txtMarca.Text = dgvData.Rows[indice].Cells["Marca"].Value.ToString();
                    nudCapacidad.Value = Convert.ToDecimal(dgvData.Rows[indice].Cells["CapacidadToneladas"].Value);
                    nudAnio.Value = Convert.ToInt32(dgvData.Rows[indice].Cells["AnioFabricacion"].Value);
                    txtFechaRegistro.Text = dgvData.Rows[indice].Cells["FechaRegistro"].Value.ToString();

                    // Establecer el estado en los CheckBox
                    int estadoValor = Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value);
                    if (estadoValor == 1)
                    {
                        chkActivo.Checked = true;
                        chkInactivo.Checked = false;
                    }
                    else
                    {
                        chkActivo.Checked = false;
                        chkInactivo.Checked = true;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la unidad de transporte?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    UnidadTransporte objunidad = new UnidadTransporte()
                    {
                        IdUnidad = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_UnidadTransporte().Eliminar(objunidad, out mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                        MessageBox.Show("Unidad eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una unidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txtBusqueda.Text.Trim().ToUpper();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    // Búsqueda especial para "Activo" e "Inactivo"
                    if (((OpcionCombo)cboBusqueda.SelectedItem).Texto == "Activo")
                    {
                        row.Visible = row.Cells["Estado"].Value.ToString() == "Activo";
                    }
                    else if (((OpcionCombo)cboBusqueda.SelectedItem).Texto == "Inactivo")
                    {
                        row.Visible = row.Cells["Estado"].Value.ToString() == "Inactivo";
                    }
                    else
                    {
                        // Búsqueda normal para otras columnas
                        if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textoBusqueda))
                            row.Visible = true;
                        else
                            row.Visible = false;
                    }
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
