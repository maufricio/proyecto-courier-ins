using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMotorista : Form
    {
        public frmMotorista()
        {
            InitializeComponent();
        }


        private void frmMotorista_Load(object sender, EventArgs e)
        {
            CargarMotoristas();

            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;
        }
        //Corrected



        private void CargarMotoristas()
        {
            List<Motorista> lista = new CN_Motorista().Listar();
            dgvdata.Rows.Clear();

            foreach (Motorista item in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    item.IdMotorista,
                    item.NombreMotorista,
                    item.Direccion,
                    item.Correo,
                    item.Telefono,
                    item.PerfilSocial,
                    item.Estado == true ? 1 : 0 ,
                    item.FechaRegistro,
                });
            }
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Motorista objmotorista = new Motorista()
            {
                IdMotorista = Convert.ToInt32(txtid.Text),                
                NombreMotorista = txtnombrecompleto.Text,
                Direccion = txtdireccion.Text,
                Correo = txtcorreo.Text,
                Telefono = txttelefono.Text,
                PerfilSocial = txtperfilsocial.Text,
                FechaRegistro = txtfecharegistro.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objmotorista.IdMotorista == 0)
            {
                int idmotoristagenerado = new CN_Motorista().Registrar(objmotorista, out mensaje);

                if (idmotoristagenerado != 0)
                {

                    dgvdata.Rows.Add(new object[] {idmotoristagenerado,txtnombrecompleto.Text,txtdireccion.Text,txtcorreo.Text,txttelefono.Text,txtperfilsocial.Text,
                
                        ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                        
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else
            {
                bool resultado = new CN_Motorista().Editar(objmotorista, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;                    
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Direccion"].Value = txtdireccion.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Telefono"].Value = txttelefono.Text;
                    row.Cells["PerfilSocial"].Value = txtperfilsocial.Text;
                    row.Cells["FechaRegistro"].Value = txtfecharegistro.Text;                    
                    //row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }


        }
        //Corrected

        private void Limpiar()
        {

            txtindice.Text = "-1";
            txtid.Text = "0";            
            txtnombrecompleto.Text = "";
            txtdireccion.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";
            txtperfilsocial.Text = "";
            txtfecharegistro.Text = "";
            cboestado.SelectedIndex = 0;            

        }
        //Corrected

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

                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();                    
                    txtnombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtdireccion.Text = dgvdata.Rows[indice].Cells["Direccion"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txttelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtperfilsocial.Text = dgvdata.Rows[indice].Cells["PerfilSocial"].Value.ToString();
                    txtfecharegistro.Text = dgvdata.Rows[indice].Cells["FechaRegistro"].Value.ToString();                  


                    


                }


            }
        }

        //Corrected

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Motorista", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Motorista objmotorista = new Motorista()
                    {
                        IdMotorista = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Motorista().Eliminar(objmotorista, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        //Corrected

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
    }
}
