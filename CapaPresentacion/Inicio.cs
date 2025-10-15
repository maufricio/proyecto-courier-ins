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

        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        private CN_Flete fleteCN;

        public Inicio()
        {
            InitializeComponent();
            this.fleteCN = new CN_Flete();
        }



        private void Inicio_Load(object sender, EventArgs e)
        {

            if (dgvfletetranscurso.Columns["btnquejas"] == null)
            {
                DataGridViewButtonColumn btnquejas = new DataGridViewButtonColumn();
                btnquejas.Name = "btnquejas";
                btnquejas.HeaderText = "";
                btnquejas.Text = "Ver";
                btnquejas.UseColumnTextForButtonValue = true;
                dgvfletetranscurso.Columns.Add(btnquejas);
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
                dgvfletetranscurso.Rows.Add(new object[] {
                    item.IdFlete,                      // 0                   
                    item.oCliente.NombreCliente,       // 1
                    item.oMotorista.NombreMotorista,           // 2
                    item.oTransporte.Placa,            // 3
                    item.oEstado.Descripcion,          // 4
                });
            }
            foreach (Flete item in lista.Where(f => f.oEstado.IdEstado == 1))
            {
                dgvfleteprogramado.Rows.Add(new object[] {
                    item.IdFlete,                      // 0                   
                    item.oCliente.NombreCliente,       // 1
                    item.oMotorista.NombreMotorista,           // 2
                    item.oTransporte.Placa,            // 3
                    item.oEstado.Descripcion,          // 4
                });
            }

            for (int i = 3; i < dgvfletetranscurso.Rows.Count; i++)
            {
                dgvfletetranscurso.Rows[i].Visible = false;
            }

            for (int i = 3; i < dgvfleteprogramado.Rows.Count; i++)
            {
                dgvfleteprogramado.Rows[i].Visible = false;
            }

            
        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

            dgvfleteprogramado.Visible = false;
            dgvfletetranscurso.Visible = false;
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
            //AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
           // AbrirFormulario(menumantenedor, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(menumantenedor, new frmProducto());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(menuventas, new frmVentas(usuarioActual));
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(menuventas, new frmDetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(menucompras, new frmFlete());
        }

        private void submenutverdetallecompra_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(menucompras, new frmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmMotorista());
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
            dgvfletetranscurso.Visible = true;
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
            dgvfletetranscurso.Rows.Clear();
            List<Flete> listaFletesProgramados = this.fleteCN.ListarFletesProgramadosTop();
            List<Flete> listaFletesQuejas = this.fleteCN.ListarFletesEnTranscursoTop();
            foreach (Flete item in listaFletesQuejas)
            {
                dgvfletetranscurso.Rows.Add(new object[] {
                    item.IdFlete,                      // 0                   
                    item.oCliente.NombreCliente,       // 1
                    item.oMotorista.NombreMotorista,           // 2
                    item.oTransporte.Placa,            // 3
                    item.oEstado.Descripcion,          // 4
                });
            }
            foreach (Flete item in listaFletesProgramados)
            {
                dgvfleteprogramado.Rows.Add(new object[] {
                    item.IdFlete,                      // 0                   
                    item.oCliente.NombreCliente,       // 1
                    item.oMotorista.NombreMotorista,           // 2
                    item.oTransporte.Placa,            // 3
                    item.oEstado.Descripcion,          // 4
                });
            }

        }

        private void dgvfletequeja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvfletetranscurso.Columns[e.ColumnIndex].Name == "btnquejas")
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

        private void menutitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menucompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmFlete());
        }

        private void menuventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmUnidadesTransporte());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmUtilidadesFletes());
        }
    }
}
