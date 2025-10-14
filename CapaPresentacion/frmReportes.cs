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
    public partial class frmReportes : Form
    {
        // Variable para almacenar el ID del flete actual
        private int _idFleteActual = 0;
        private decimal _montoFleteActual = 0;

        // Lista para almacenar los gastos temporalmente
        private List<CalculosUtil> _listaGastos = new List<CalculosUtil>();

        // Variable para saber si estamos editando
        private int _indiceEdicion = -1;

        public frmReportes()
        {
            InitializeComponent();
            /*-----------------------------------------*/
            /*-----------------------------------------*/
            //BORRAR ESTAS DOS LINEAS DESPUÉS DE UNIRLO CON FLETE
            _idFleteActual = 2;
            _montoFleteActual = 80.00m;
            /*-----------------------------------------*/
            /*-----------------------------------------*/
            InicializarComboBoxes();
        }

        // Constructor que recibe el ID del flete
        public frmReportes(int idFlete, decimal montoFlete)
        {
            InitializeComponent();
            _idFleteActual = idFlete;
            _montoFleteActual = montoFlete;
            InicializarComboBoxes();
        }

        private void InicializarComboBoxes()
        {
            // Habilitar los ComboBox
            cmbCamion.Enabled = true;
            cmbProd.Enabled = true;
            cmbVarios.Enabled = true;

            // Establecer índice por defecto
            cmbCamion.SelectedIndex = -1;
            cmbProd.SelectedIndex = -1;
            cmbVarios.SelectedIndex = -1;
        }

        private void cbCamion_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbProd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbVarios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ibtnGuardar_Click(object sender, EventArgs e)
        {
            if (_listaGastos.Count == 0)
            {
                MessageBox.Show("No hay gastos para calcular", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular totales
            decimal totalGastos = _listaGastos.Sum(g => g.Monto);
            decimal utilidadNeta = _montoFleteActual - totalGastos;
            decimal porcentajeUtilidad = _montoFleteActual > 0
                ? (utilidadNeta / _montoFleteActual) * 100
                : 0;

            // Limpiar y agregar fila al DataGridView
            dgvdata.Rows.Clear();
            dgvdata.Rows.Add(
                $"${_montoFleteActual:F2}",
                $"${totalGastos:F2}",
                $"${utilidadNeta:F2}",
                $"{porcentajeUtilidad:F2}%"
            );

            // Hacer visibles los botones de editar y limpiar
            ibtnEditar.Visible = true;
            ibtnLimpiar.Visible = true;

            MessageBox.Show("Cálculos realizados correctamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ibtnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea limpiar todos los gastos?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _listaGastos.Clear();
                lbTotal.Items.Clear();
                dgvdata.Rows.Clear();

                // Limpiar todos los campos
                LimpiarTodosLosCampos();

                MessageBox.Show("Todos los gastos han sido eliminados", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // LIMPIAR TODOS LOS CAMPOS
        private void LimpiarTodosLosCampos()
        {
            // Camión
            cmbCamion.SelectedIndex = -1;
            mtxtCamion.Clear();
            mtxtCamion.Enabled = false;
            nudCamion.Value = 1;
            nudCamion.Enabled = false;

            // Producción
            cmbProd.SelectedIndex = -1;
            mtxtProd.Clear();
            mtxtProd.Enabled = false;
            nudProd.Value = 1;
            nudProd.Enabled = false;

            // Varios
            cmbVarios.SelectedIndex = -1;
            mtxtVarios.Clear();
            mtxtVarios.Enabled = false;
            nudVarios.Value = 1;
            nudVarios.Enabled = false;
        }

        //BOTON EDITAR
        private void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (lbTotal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un gasto de la lista para editar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _indiceEdicion = lbTotal.SelectedIndex;

            // Obtener el gasto seleccionado
            CalculosUtil gastoSeleccionado = _listaGastos[_indiceEdicion];

            // Calcular el monto unitario
            decimal montoUnitario = gastoSeleccionado.Monto / gastoSeleccionado.Cantidad;

            // Cargar los datos en los campos correspondientes
            switch (gastoSeleccionado.TipoGasto)
            {
                case "Camión":
                    cmbCamion.Text = gastoSeleccionado.Concepto;
                    CargarMontoEnMaskedTextBox(mtxtCamion, montoUnitario);
                    if (gastoSeleccionado.Cantidad > 1)
                    {
                        nudCamion.Value = gastoSeleccionado.Cantidad;
                        nudCamion.Enabled = true;
                    }
                    break;
                case "Producción":
                    cmbProd.Text = gastoSeleccionado.Concepto;
                    CargarMontoEnMaskedTextBox(mtxtProd, montoUnitario);
                    if (gastoSeleccionado.Cantidad > 1)
                    {
                        nudProd.Value = gastoSeleccionado.Cantidad;
                        nudProd.Enabled = true;
                    }
                    break;
                case "Varios":
                    cmbVarios.Text = gastoSeleccionado.Concepto;
                    CargarMontoEnMaskedTextBox(mtxtVarios, montoUnitario);
                    if (gastoSeleccionado.Cantidad > 1)
                    {
                        nudVarios.Value = gastoSeleccionado.Cantidad;
                        nudVarios.Enabled = true;
                    }
                    break;
            }

            // Remover el item de la lista para que pueda ser agregado nuevamente
            _listaGastos.RemoveAt(_indiceEdicion);
            lbTotal.Items.RemoveAt(_indiceEdicion);
            _indiceEdicion = -1;

             MessageBox.Show("Gasto cargado para edición. Modifique los valores y presione Agregar.",
                 "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CargarMontoEnMaskedTextBox(MaskedTextBox mtxt, decimal monto)
        {
            // Guardar la máscara original
            string mascaraOriginal = mtxt.Mask;

            // Quitar temporalmente la máscara
            mtxt.Mask = "";

            // Habilitar el control
            mtxt.Enabled = true;

            // Asignar el valor formateado
            mtxt.Text = monto.ToString("0.00");

            // Restaurar la máscara
            mtxt.Mask = mascaraOriginal;
        }

        private void gbGastos_Enter(object sender, EventArgs e)
        {

        }

        /* VALIDACIONES DE CAMPOS */

        private void cmbCamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCamion.SelectedIndex == 1) // Llantas
            {
                mtxtCamion.Enabled = true;
                nudCamion.Enabled = true;
                nudCamion.Minimum = 1;
                nudCamion.Maximum = 10;
                nudCamion.Value = 1;
            }
            else if (cmbCamion.SelectedIndex == 0 || cmbCamion.SelectedIndex == 2) // Batería o Aceite
            {
                mtxtCamion.Enabled = true;
                nudCamion.Enabled = false;
                nudCamion.Value = 1;
            }
            else
            {
                mtxtCamion.Enabled = false;
                nudCamion.Enabled = false;
            }
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProd.SelectedIndex == 1) // Sueldo de ayudantes
            {
                mtxtProd.Enabled = true;
                nudProd.Enabled = true;
                nudProd.Minimum = 1;
                nudProd.Maximum = 5;
                nudProd.Value = 1;
            }
            else if (cmbProd.SelectedIndex == 0 || cmbProd.SelectedIndex == 2) // Motorista o Combustible
            {
                mtxtProd.Enabled = true;
                nudProd.Enabled = false;
                nudProd.Value = 1;
            }
            else
            {
                mtxtProd.Enabled = false;
                nudProd.Enabled = false;
            }
        }

        private void cmbVarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVarios.SelectedIndex == 1) // Hospedaje (puede ser múltiples noches)
            {
                mtxtVarios.Enabled = true;
                nudVarios.Enabled = true;
                nudVarios.Minimum = 1;
                nudVarios.Maximum = 10;
                nudVarios.Value = 1;
            }
            else if (cmbVarios.SelectedIndex == 0 || cmbVarios.SelectedIndex == 2) // Parqueo u Otros
            {
                mtxtVarios.Enabled = true;
                nudVarios.Enabled = false;
                nudVarios.Value = 1;
            }
            else
            {
                mtxtVarios.Enabled = false;
                nudVarios.Enabled = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ibtnAggCamion_Click(object sender, EventArgs e)
        {
            AgregarGasto("Camión", cmbCamion, mtxtCamion, nudCamion);
        }

        private void ibtnAggProd_Click(object sender, EventArgs e)
        {
            AgregarGasto("Producción", cmbProd, mtxtProd, nudProd);

        }

        private void ibtnAggVarios_Click(object sender, EventArgs e)
        {
            AgregarGasto("Varios", cmbVarios, mtxtVarios, nudVarios);
        }

        // MÉTODO GENÉRICO PARA AGREGAR GASTOS (SOLO EN MEMORIA)
        private void AgregarGasto(string tipoGasto, ComboBox cmb, MaskedTextBox mtxt, NumericUpDown nud)
        {
            // Validar que se haya seleccionado un concepto
            if (cmb.SelectedIndex == -1)
            {
                MessageBox.Show($"Debe seleccionar un concepto de {tipoGasto}", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya ingresado un monto
            // Limpiar el texto del MaskedTextBox quitando símbolos y espacios
            string montoTexto = mtxt.Text.Replace("$", "").Replace("S/", "").Replace("_", "").Replace(" ", "").Trim();

            if (string.IsNullOrEmpty(montoTexto))
            {
                MessageBox.Show("Debe ingresar un monto válido", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal monto;
            if (!decimal.TryParse(montoTexto, out monto) || monto <= 0)
            {
                MessageBox.Show($"El monto debe ser mayor a cero. Valor ingresado: {montoTexto}", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la cantidad
            int cantidad = nud.Enabled ? (int)nud.Value : 1;
            if (cantidad <= 0) cantidad = 1;

            // Calcular el monto total
            decimal montoTotal = monto * cantidad;

            // Crear el objeto de gasto
            CalculosUtil gasto = new CalculosUtil()
            {
                IdFlete = _idFleteActual,
                TipoGasto = tipoGasto,
                Concepto = cmb.Text,
                Monto = montoTotal,
                Cantidad = cantidad
            };

            // Agregar a la lista
            _listaGastos.Add(gasto);

            // Agregar al ListBox con formato
            string itemTexto = cantidad > 1
                ? $"{tipoGasto} - {cmb.Text} (x{cantidad}): ${montoTotal:F2}"
                : $"{tipoGasto} - {cmb.Text}: ${montoTotal:F2}";

            lbTotal.Items.Add(itemTexto);

            // Limpiar campos
            LimpiarCampos(cmb, mtxt, nud);

            MessageBox.Show("Gasto agregado correctamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // LIMPIAR CAMPOS DESPUÉS DE AGREGAR
        private void LimpiarCampos(ComboBox cmb, MaskedTextBox mtxt, NumericUpDown nud)
        {
            cmb.SelectedIndex = -1;
            mtxt.Clear();
            mtxt.Enabled = false;
            nud.Value = 1;
            nud.Enabled = false;
        }

        private void ibtnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnFinalizar_Click(object sender, EventArgs e)
        {
            if (_listaGastos.Count == 0)
            {
                MessageBox.Show(
                    "No hay gastos para guardar.\n\n" +
                    "Debe agregar al menos un gasto antes de finalizar el flete.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Verificar si ya se calculó
            if (dgvdata.Rows.Count == 0)
            {
                DialogResult resultCalcular = MessageBox.Show(
                    "Aún no ha calculado las utilidades.\n\n" +
                    "¿Desea calcular y guardar los gastos ahora?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultCalcular == DialogResult.No)
                {
                    return;
                }

                // Calcular antes de guardar
                ibtnGuardar_Click(sender, e);
            }

            // Confirmar que desea finalizar
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea finalizar este flete?\n\n" +
                "Esta acción guardará y cerrará la ventana, no podrá volver acceder una vez finalizado.\n\n" +
                "¿Desea continuar?",
                "Confirmar Finalización",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            // Guardar todos los gastos en la base de datos
            CN_CalculosUtil objNegocio = new CN_CalculosUtil();
            bool todosGuardados = true;
            string mensajeError = "";
            int gastosGuardados = 0;

            foreach (var gasto in _listaGastos)
            {
                string mensaje;
                int resultado = objNegocio.Guardar(gasto, out mensaje);

                if (resultado > 0)
                {
                    gastosGuardados++;
                }
                else
                {
                    todosGuardados = false;
                    mensajeError += $"- {gasto.Concepto}: {mensaje}\n";
                }
            }

            if (!todosGuardados)
            {
                MessageBox.Show(
                    $"Algunos gastos no pudieron guardarse:\n\n{mensajeError}\n" +
                    $"Gastos guardados exitosamente: {gastosGuardados} de {_listaGastos.Count}",
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                $"¡Flete finalizado exitosamente!\n\n" +
                $"✓ Total de gastos guardados: {gastosGuardados}\n" +
                $"✓ ID del Flete: {_idFleteActual}\n" +
                $"✓ Utilidad calculada y registrada correctamente",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Cerrar el formulario
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
