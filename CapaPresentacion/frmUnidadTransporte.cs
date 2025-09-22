using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmUnidadTransporte : Form
    {
        public frmUnidadTransporte()
        {
            InitializeComponent();
        }

        private void frmUnidadTransporte_Load(object sender, EventArgs e)
        {
            // Cargar listado al iniciar
            CargarUnidades();
        }

        private void CargarUnidades()
        {
            List<UnidadTransporte> lista = new CN_UnidadTransporte().Listar();

            dgvdata.Rows.Clear();

            foreach (UnidadTransporte u in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    u.IdUnidad,
                    u.Placa,
                    u.Marca,
                    u.CapacidadToneladas,
                    u.AnioFabricacion,
                    u.Estado ? "Activo" : "Inactivo",
                    u.FechaRegistro.ToString("dd/MM/yyyy")
                });
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtplaca.Text == "")
            {
                MessageBox.Show("Debe ingresar la placa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UnidadTransporte obj = new UnidadTransporte()
            {
                Placa = txtplaca.Text.Trim(),
                Marca = txtmarca.Text.Trim(),
                CapacidadToneladas = Convert.ToDecimal(txtcapacidad.Text.Trim()),
                AnioFabricacion = Convert.ToInt32(txtanio.Text.Trim()),
                Estado = chkestado.Checked
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_UnidadTransporte().Registrar(obj, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Unidad registrada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                CargarUnidades();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscarplaca.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una placa para buscar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UnidadTransporte u = new CN_UnidadTransporte().ObtenerPorPlaca(txtbuscarplaca.Text.Trim());

            if (u != null)
            {
                MessageBox.Show($"Unidad encontrada:\nPlaca: {u.Placa}\nMarca: {u.Marca}\nAño: {u.AnioFabricacion}",
                                "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró la unidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnestado")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    int idUnidad = Convert.ToInt32(dgvdata.Rows[index].Cells["IdUnidad"].Value.ToString());
                    bool estadoActual = dgvdata.Rows[index].Cells["Estado"].Value.ToString() == "Activo";
                    bool nuevoEstado = !estadoActual;

                    bool respuesta = new CN_UnidadTransporte().CambiarEstado(idUnidad, nuevoEstado);

                    if (respuesta)
                    {
                        MessageBox.Show("Estado actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUnidades();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cambiar el estado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void limpiar()
        {
            txtplaca.Text = "";
            txtmarca.Text = "";
            txtcapacidad.Text = "";
            txtanio.Text = "";
            chkestado.Checked = true;
        }
    }
}
