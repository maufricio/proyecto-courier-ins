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
        private bool _modoEdicion = false;
        private int _indiceEdicion = -1;

        // Variable para controlar si ya se guardaron los datos
        private bool _datosGuardados = false;

        public frmReportes()
        {
            InitializeComponent();
            _idFleteActual = 2; // ID de flete de ejemplo
            _montoFleteActual = 80.00m;
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

            // Si ya se calculó antes, preguntar si quiere recalcular
            if (_datosGuardados)
            {
                DialogResult result = MessageBox.Show(
                    "Los datos ya fueron guardados anteriormente.\n\n" +
                    "¿Desea recalcular con los datos actuales?\n\n" +
                    "Esto eliminará los gastos anteriores de la base de datos y guardará los nuevos.",
                    "Confirmar recálculo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Eliminar los gastos anteriores de la BD
                CN_CalculosUtil objNegocio = new CN_CalculosUtil();
                foreach (var gasto in _listaGastos.Where(g => g.IdGasto > 0).ToList())
                {
                    string mensajeEliminar;
                    objNegocio.Eliminar(gasto, out mensajeEliminar);
                }

                // Resetear los IDs
                foreach (var gasto in _listaGastos)
                {
                    gasto.IdGasto = 0;
                }
            }

            // Guardar todos los gastos en la base de datos
            CN_CalculosUtil objNegocioGuardar = new CN_CalculosUtil();
            bool todosGuardados = true;
            string mensajeError = "";

            foreach (var gasto in _listaGastos)
            {
                // Solo guardar si no tiene ID (o sea, que no está guardado)
                if (gasto.IdGasto == 0)
                {
                    string mensaje;
                    int resultado = objNegocioGuardar.Guardar(gasto, out mensaje);

                    if (resultado > 0)
                    {
                        // Asignar el ID generado al gasto
                        gasto.IdGasto = resultado;
                    }
                    else
                    {
                        todosGuardados = false;
                        mensajeError += mensaje + "\n";
                    }
                }
            }

            if (!todosGuardados)
            {
                MessageBox.Show("Algunos gastos no pudieron guardarse:\n" + mensajeError,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Marcar que los datos ya están guardados
            _datosGuardados = true;

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

            MessageBox.Show("Cálculos realizados y datos guardados exitosamente", "Éxito",
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
                // Si ya se guardaron, eliminar de la BD
                if (_datosGuardados)
                {
                    CN_CalculosUtil objNegocio = new CN_CalculosUtil();
                    foreach (var gasto in _listaGastos)
                    {
                        if (gasto.IdGasto > 0)
                        {
                            string mensaje;
                            objNegocio.Eliminar(gasto, out mensaje);
                        }
                    }
                }

                _listaGastos.Clear();
                lbTotal.Items.Clear();
                dgvdata.Rows.Clear();
                _datosGuardados = false;

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
            _modoEdicion = true;

            // Obtener el gasto seleccionado
            CalculosUtil gastoSeleccionado = _listaGastos[_indiceEdicion];

            // Cargar los datos en los campos correspondientes
            switch (gastoSeleccionado.TipoGasto)
            {
                case "Camión":
                    cmbCamion.Text = gastoSeleccionado.Concepto;
                    mtxtCamion.Text = (gastoSeleccionado.Monto / gastoSeleccionado.Cantidad).ToString("F2");
                    mtxtCamion.Enabled = true;
                    if (gastoSeleccionado.Cantidad > 1)
                    {
                        nudCamion.Value = gastoSeleccionado.Cantidad;
                        nudCamion.Enabled = true;
                    }
                    break;
                case "Producción":
                    cmbProd.Text = gastoSeleccionado.Concepto;
                    mtxtProd.Text = (gastoSeleccionado.Monto / gastoSeleccionado.Cantidad).ToString("F2");
                    mtxtProd.Enabled = true;
                    if (gastoSeleccionado.Cantidad > 1)
                    {
                        nudProd.Value = gastoSeleccionado.Cantidad;
                        nudProd.Enabled = true;
                    }
                    break;
                case "Varios":
                    cmbVarios.Text = gastoSeleccionado.Concepto;
                    mtxtVarios.Text = (gastoSeleccionado.Monto / gastoSeleccionado.Cantidad).ToString("F2");
                    mtxtVarios.Enabled = true;
                    if (gastoSeleccionado.Cantidad > 1)
                    {
                        nudVarios.Value = gastoSeleccionado.Cantidad;
                        nudVarios.Enabled = true;
                    }
                    break;
            }

            if (_datosGuardados && gastoSeleccionado.IdGasto > 0)
            {
                // Eliminar el gasto de la BD
                CN_CalculosUtil objNegocio = new CN_CalculosUtil();
                string mensaje;
                bool resultado = objNegocio.Eliminar(gastoSeleccionado, out mensaje);

                if (!resultado)
                {
                    MessageBox.Show("Error al eliminar el gasto de la base de datos:\n" + mensaje,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Remover el item de la lista para que pueda ser agregado nuevamente
            _listaGastos.RemoveAt(_indiceEdicion);
            lbTotal.Items.RemoveAt(_indiceEdicion);
            _modoEdicion = false;

            // Si los datos estaban guardados, hay que recalcular
            if (_datosGuardados)
            {
                MessageBox.Show("Gasto eliminado. Modifique los valores y agregue nuevamente, luego presione Calcular.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        // MÉTODO GENÉRICO PARA AGREGAR GASTOS
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
    }
}
