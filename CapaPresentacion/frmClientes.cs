using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmClientes : Form
    {


        public frmClientes()
        {
            InitializeComponent();
        }

        private static string _guardarText = "Guardar";
        private static string _editarText = "Editar";

        private void frmClientes_Load(object sender, EventArgs e)
        {

            cboestadocliente.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestadocliente.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestadocliente.DisplayMember = "Texto";
            cboestadocliente.ValueMember = "Valor";
            cboestadocliente.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;



            //MOSTRAR TODOS LOS USUARIOS
            List<Cliente> lista = new CN_Cliente().Listar();

            foreach (Cliente item in lista)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdCliente,item.NombreCliente,item.Direccion,item.Correo, item.Estado == 1 ? "Activo" : "No Activo" });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            string id_cliente_field = txtid.Text.Trim();

            string nombreCliente = txtnombrecliente.Text.Trim();
            string dirCliente = txtdireccioncliente.Text.Trim();
            string correoCliente = txtcorreocliente.Text.Trim();
            int estadoCliente = ((OpcionCombo)cboestadocliente.SelectedItem).Valor != null ? Convert.ToInt32(((OpcionCombo)cboestadocliente.SelectedItem).Valor) : 1;

            Cliente obj = new Cliente()
            {
                IdCliente = Convert.ToInt32(id_cliente_field == "" ? "0" : id_cliente_field),
                NombreCliente = nombreCliente,
                Direccion = dirCliente,
                Correo = correoCliente,
                Estado = estadoCliente
            };

            if (btnguardar.Text == _guardarText)
            {
                int idgenerado = new CN_Cliente().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    dgvdata.Rows.Add(
                        new object[] {"",
                            idgenerado,
                            txtnombrecliente.Text,
                            txtdireccioncliente.Text,
                            txtcorreocliente.Text,
                            ((OpcionCombo)cboestadocliente.SelectedItem).Texto.ToString()
                    }); // Con esto agrega una nueva fila al DataGridView

                    MessageBox.Show(mensaje);

                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else if(btnguardar.Text == _editarText)
            {
                bool resultado = new CN_Cliente().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["IdCliente"].Value = txtid.Text;
                    row.Cells["NombreCliente"].Value = txtnombrecliente.Text;
                    row.Cells["DireccionCliente"].Value = txtdireccioncliente.Text;
                    row.Cells["CorreoCliente"].Value = txtcorreocliente.Text;
                    row.Cells["EstadoCliente"].Value = ((OpcionCombo)cboestadocliente.SelectedItem).Valor.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }


        }


        private void Limpiar()
        {
            txtnombrecliente.Text = "";
            txtdireccioncliente.Text = "";
            txtcorreocliente.Text = "";
            cboestadocliente.SelectedIndex = 0;
            txtnombrecliente.Select();
            btnguardar.Text = "Guardar";
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
            // Verifica que el clic fue en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvdata.Rows[e.RowIndex];

                txtindice.Text = e.RowIndex.ToString();

                // Usa los nombres de columnas que realmente tienes en el DataGridView
                txtid.Text = fila.Cells["IdCliente"].Value?.ToString();
                txtnombrecliente.Text = fila.Cells["NombreCliente"].Value?.ToString();
                txtdireccioncliente.Text = fila.Cells["DireccionCliente"].Value?.ToString();
                txtcorreocliente.Text = fila.Cells["CorreoCliente"].Value?.ToString();

                // Para Estado del Cliente, asumiendo que guardas 0/1 en otra columna oculta o en el mismo texto
                if (fila.Cells["EstadoCliente"].Value != null)
                {
                    foreach (OpcionCombo oc in cboestadocliente.Items)
                    {
                        if (oc.Valor.ToString() == fila.Cells["EstadoCliente"].Value.ToString())
                        {
                            cboestadocliente.SelectedItem = oc;
                            break;
                        }
                    }
                }

                btnguardar.Text = _editarText;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el cliente", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Cliente obj = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Cliente().Eliminar(obj.IdCliente, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboestadocliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
