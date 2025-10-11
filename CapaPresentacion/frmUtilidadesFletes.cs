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
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUtilidadesFletes : Form
    {
        public frmUtilidadesFletes()
        {
            InitializeComponent();
        }

        private void frmUtilidadesFletes_Load(object sender, EventArgs e)
        {
            // Configurar ComboBox de Búsqueda
            cbobusqueda.Items.Add(new OpcionCombo() { Valor = "NombreCliente", Texto = "Cliente" });
            cbobusqueda.Items.Add(new OpcionCombo() { Valor = "Placa", Texto = "Placa" });
            cbobusqueda.Items.Add(new OpcionCombo() { Valor = "NombreMotorista", Texto = "Motorista" });
            cbobusqueda.Items.Add(new OpcionCombo() { Valor = "FechaRegistro", Texto = "Fecha" });

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            CargarUtilidadesFletes();
        }

        private void CargarUtilidadesFletes()
        {
            dgvdata.Rows.Clear();

            // MOSTRAR TODAS LAS UTILIDADES DE FLETES TERMINADOS
            List<UtilidadFlete> listaUtilidades = new CN_UtilidadFlete().ListarUtilidadesFletes();

            foreach (UtilidadFlete item in listaUtilidades)
            {
                dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdFlete,
                    item.NombreCliente,
                    item.Placa,
                    item.NombreMotorista,
                    "$" + item.ValorFlete.ToString("N2"),
                    "$" + item.TotalGastos.ToString("N2"),
                    "$" + item.UtilidadNeta.ToString("N2"),
                    item.PorcentajeUtilidad.ToString("0.00") + "%",
                    item.FechaRegistro.ToString("dd/MM/yyyy")
                });

                // Colorear fila según rentabilidad
                int indice = dgvdata.Rows.Count - 1;
                if (item.UtilidadNeta < 0)
                {
                    dgvdata.Rows[indice].DefaultCellStyle.BackColor = Color.LightCoral; // Pérdida
                }
                else if (item.PorcentajeUtilidad >= 20)
                {
                    dgvdata.Rows[indice].DefaultCellStyle.BackColor = Color.LightGreen; // Alta rentabilidad
                }
                else if (item.PorcentajeUtilidad < 10)
                {
                    dgvdata.Rows[indice].DefaultCellStyle.BackColor = Color.LightYellow; // Baja rentabilidad
                }
            }

            // Calcular totales
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            decimal totalValorFletes = 0;
            decimal totalGastos = 0;
            decimal totalUtilidad = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.Visible && !row.IsNewRow)
                {
                    try
                    {
                        // Obtener valores y limpiar formato de moneda
                        string valorFlete = row.Cells["ValorFlete"].Value?.ToString() ?? "0";
                        string gastos = row.Cells["TotalGastos"].Value?.ToString() ?? "0";
                        string utilidad = row.Cells["UtilidadNeta"].Value?.ToString() ?? "0";

                        // Remover símbolos de moneda y espacios
                        valorFlete = System.Text.RegularExpressions.Regex.Replace(valorFlete, @"[^\d.-]", "");
                        gastos = System.Text.RegularExpressions.Regex.Replace(gastos, @"[^\d.-]", "");
                        utilidad = System.Text.RegularExpressions.Regex.Replace(utilidad, @"[^\d.-]", "");

                        totalValorFletes += string.IsNullOrEmpty(valorFlete) ? 0 : decimal.Parse(valorFlete);
                        totalGastos += string.IsNullOrEmpty(gastos) ? 0 : decimal.Parse(gastos);
                        totalUtilidad += string.IsNullOrEmpty(utilidad) ? 0 : decimal.Parse(utilidad);
                    }
                    catch (Exception ex)
                    {
                        // Ignorar filas con errores y continuar
                        Console.WriteLine($"Error al procesar fila: {ex.Message}");
                    }
                }
            }

            lbltotalvalor.Text = "Total valor de fletes: $" + totalValorFletes.ToString("N2");
            lbltotalgastos.Text = "Total de gastos: $" + totalGastos.ToString("N2");
            lbltotalutilidad.Text = "Total de utilidad: $" + totalUtilidad.ToString("N2");

            // Calcular porcentaje promedio
            if (totalValorFletes > 0)
            {
                decimal porcentajePromedio = (totalUtilidad / totalValorFletes) * 100;
                lblporcentajepromedio.Text = "Porcentaje total: " + porcentajePromedio.ToString("0.00") + "%";
            }
            else
            {
                lblporcentajepromedio.Text = "0.00%";
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    int idFlete = Convert.ToInt32(dgvdata.Rows[indice].Cells["IdFlete"].Value);
                    MostrarDetalleGastos(idFlete);
                }
            }
        }

        private void MostrarDetalleGastos(int idFlete)
        {
            DetalleGastoFlete detalle = new CN_UtilidadFlete().ObtenerDetalleGastos(idFlete);

            string mensaje = $"DETALLE DE GASTOS - FLETE #{idFlete}\n\n";
            mensaje += $"Gastos Camión: {detalle.TotalGastosCamion.ToString("C2")}\n";
            mensaje += $"   (Batería, Llantas, Cambio de Aceite)\n\n";
            mensaje += $"Gastos Varios: {detalle.TotalGastosVarios.ToString("C2")}\n";
            mensaje += $"   (Parqueo, Hospedaje)\n\n";
            mensaje += $"Gastos Producción: {detalle.TotalGastosProduccion.ToString("C2")}\n";
            mensaje += $"   (Pago Motorista, Ayudantes, Combustible)\n\n";
            mensaje += $"TOTAL GASTOS: {(detalle.TotalGastosCamion + detalle.TotalGastosVarios + detalle.TotalGastosProduccion).ToString("C2")}";

            MessageBox.Show(mensaje, "Detalle de Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txtbusqueda.Text.Trim().ToUpper();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textoBusqueda))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }

            CalcularTotales();
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
            CalcularTotales();
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un flete para generar el PDF", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idFlete = Convert.ToInt32(dgvdata.SelectedRows[0].Cells["IdFlete"].Value);
            GenerarReportePDF(idFlete);
        }

        private void GenerarReportePDF(int idFlete)
        {
            try
            {
                // Obtener información del flete
                UtilidadFlete utilidad = new CN_UtilidadFlete().ObtenerUtilidadPorFlete(idFlete);

                if (utilidad == null)
                {
                    MessageBox.Show("No se encontró información del flete seleccionado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DetalleGastoFlete detalle = new CN_UtilidadFlete().ObtenerDetalleGastos(idFlete);
                List<GastoFlete> gastos = new CN_UtilidadFlete().ObtenerGastosPorFlete(idFlete);

                // Diálogo para guardar el archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = $"Utilidad_Flete_{idFlete}_{DateTime.Now:yyyyMMdd}.pdf";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar Reporte de Utilidad";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Generar el PDF
                    GeneradorPDFUtilidades.GenerarReporteUtilidad(utilidad, detalle, gastos, saveFileDialog.FileName);

                    // Preguntar si desea abrir el archivo
                    if (MessageBox.Show($"PDF generado exitosamente en:\n{saveFileDialog.FileName}\n\n¿Desea abrir el archivo?",
                        "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            CargarUtilidadesFletes();
        }
    }
}