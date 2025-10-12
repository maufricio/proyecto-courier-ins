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
using CapaPresentacion.Modales;
using FontAwesome.Sharp;


namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if (dgvfletequeja.Columns["btnquejas"] == null)
            {
                DataGridViewButtonColumn btnquejas = new DataGridViewButtonColumn();
                btnquejas.Name = "btnquejas";
                btnquejas.HeaderText = "";
                btnquejas.Text = "Ver";
                btnquejas.UseColumnTextForButtonValue = true;
                dgvfletequeja.Columns.Add(btnquejas);
            }

            if (dgvfleteprogramado.Columns["btnprogramado"] == null)
            {
                DataGridViewButtonColumn btnprogramado = new DataGridViewButtonColumn();
                btnprogramado.Name = "btnprogramado";
                btnprogramado.HeaderText = "";
                btnprogramado.Text = "Ver";
                btnprogramado.UseColumnTextForButtonValue = true;
                dgvfleteprogramado.Columns.Add(btnprogramado);
            }

            List<Flete> lista = new CN_Flete().Listar();

            foreach (Flete item in lista.Where(f => f.oEstado.IdEstado == 5))
            {
                dgvfletequeja.Rows.Add(new object[] {
                    item.IdFlete,                      // 0                   
                    item.oCliente.NombreCliente,       // 1
                    item.oMotorista.NombreM,           // 2
                    item.oTransporte.Placa,            // 3
                    item.oEstado.Descripcion,          // 4
                });
            }
            foreach (Flete item in lista.Where(f => f.oEstado.IdEstado == 1))
            {
                dgvfleteprogramado.Rows.Add(new object[] {
                    item.IdFlete,                      // 0                   
                    item.oCliente.NombreCliente,       // 1
                    item.oMotorista.NombreM,           // 2
                    item.oTransporte.Placa,            // 3
                    item.oEstado.Descripcion,          // 4
                });
            }

            for (int i = 3; i < dgvfletequeja.Rows.Count; i++)
            {
                dgvfletequeja.Rows[i].Visible = false;
            }

            for (int i = 3; i < dgvfleteprogramado.Rows.Count; i++)
            {
                dgvfleteprogramado.Rows[i].Visible = false;
            }

            lblusuario.Text = usuarioActual.NombreCompleto;
        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

            dgvfleteprogramado.Visible = false;
            dgvfletequeja.Visible = false;
            labelprogramado.Visible = false;
            labelqueja.Visible = false;

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();


        }


        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmProducto());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(usuarioActual));
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmFlete());
        }

        private void submenutverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }



        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmNegocio());
        }

        private void submenureportecompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteCompras());
        }

        private void submenureporteventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteVentas());
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            mdAcercade md = new mdAcercade();
            md.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvfletequeja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dash_Click(object sender, EventArgs e)
        {
            dgvfletequeja.Visible = true;
            dgvfleteprogramado.Visible = true;
            labelqueja.Visible = true;
            labelprogramado.Visible = true;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                FormularioActivo = null;
            }

            RecargarFLete();
        }

        private void RecargarFLete()
        {
            dgvfleteprogramado.Rows.Clear();
            dgvfletequeja.Rows.Clear();
            List<Flete> lista = new CN_Flete().Listar();
            foreach (Flete item in lista.Where(f => f.oEstado.IdEstado == 5))
            {
                dgvfletequeja.Rows.Add(new object[] {
                    item.IdFlete,                      // 0                   
                    item.oCliente.NombreCliente,       // 1
                    item.oMotorista.NombreM,           // 2
                    item.oTransporte.Placa,            // 3
                    item.oEstado.Descripcion,          // 4
                });
            }
            foreach (Flete item in lista.Where(f => f.oEstado.IdEstado == 1))
            {
                dgvfleteprogramado.Rows.Add(new object[] {
                    item.IdFlete,                      // 0                   
                    item.oCliente.NombreCliente,       // 1
                    item.oMotorista.NombreM,           // 2
                    item.oTransporte.Placa,            // 3
                    item.oEstado.Descripcion,          // 4
                });
            }
            for (int i = 3; i < dgvfletequeja.Rows.Count; i++)
            {
                dgvfletequeja.Rows[i].Visible = false;
            }

            for (int i = 3; i < dgvfleteprogramado.Rows.Count; i++)
            {
                dgvfleteprogramado.Rows[i].Visible = false;
            }

        }

        private void dgvfletequeja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvfletequeja.Columns[e.ColumnIndex].Name == "btnquejas")
            {
                mdfletesqueja md = new mdfletesqueja();
                md.ShowDialog();
            }
           
        }

        private void dgvfleteprogramado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvfleteprogramado.Columns[e.ColumnIndex].Name == "btnprogramado")
            {
                mdfletesprogramado md = new mdfletesprogramado();
                md.ShowDialog();
            }
        }
    }
}
