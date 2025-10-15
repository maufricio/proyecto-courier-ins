using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
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
    public partial class frmFlete : Form
    {
        private CN_Flete cn_flete;

        public frmFlete()
        {
            InitializeComponent();
            this.cn_flete = new CN_Flete();
        }

        private int idFleteSeleccionado = 0;

        private void frmFlete_Load(object sender, EventArgs e)
        {
            CD_Estado estado = new CD_Estado();
            Comboestado.DataSource = estado.ListarEstados();
            Comboestado.DisplayMember = "Descripcion"; // Lo que se muestra en el combobox
            Comboestado.ValueMember = "IdEstado";       // El valor interno que tiene este

            if (dgvflete.Columns["btnEditar"] == null)
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvflete.Columns.Add(btnEditar);
            }

            if (dgvflete.Columns["btnEliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "btnEliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvflete.Columns.Add(btnEliminar);
            }

            List<Flete> lista = this.cn_flete.Listar();

            foreach (Flete item in lista)
            {
                dgvflete.Rows.Add(new object[] {
                    item.IdFlete,                      // 0
                    item.oCliente.IdCliente,           // 1
                    item.oMotorista.IdMotorista,       // 2
                    item.oTransporte.IdUnidad,         // 3
                    item.oEstado.IdEstado,             // 4
                    item.oCliente.NombreCliente,       // 5
                    item.oMotorista.NombreMotorista,           // 6
                    item.oTransporte.Placa,            // 7
                    item.oEstado.Descripcion,          // 8
                    item.Monto,                        // 9
                    item.Lrecolecta,                   // 10
                    item.Lentrega,                     // 11
                    item.Hsalida,                      // 12
                    item.Hllegada,                     // 13
                    item.Consideraciones               // 14
                });
            }

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btneditarflete_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscarcliente1_Click(object sender, EventArgs e)
        {
            using(var modal = new mdclientes()) { 
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidcliente.Text = modal._Cliente1.IdCliente.ToString();
                    txtcliente.Text = modal._Cliente1.NombreCliente;                   
                }
                else
                {
                    txtcliente.Select();
                }
            }

        }

        private void btnbuscarmotorista_Click(object sender, EventArgs e)
        {
            using (var modal = new mdmotoristas())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidmotorista.Text = modal._Motorista.IdMotorista.ToString();
                    txtmotorista.Text = modal._Motorista.NombreMotorista;
                }
                else
                {
                    txtmotorista.Select();
                }
            }
        }

        private void btnbuscarunidad_Click(object sender, EventArgs e)
        {
            using (var modal = new mdtransporte())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidunidad.Text = modal._Transporte.IdUnidad.ToString();
                    txtunidad.Text = modal._Transporte.Placa;
                }
                else
                {
                    txtunidad.Select();
                }
            }

        }

        private void btnregistrarflete_Click(object sender, EventArgs e)
        {
            // Validación para no aceptar valores de string en algo numérico.
            decimal monto;
            if (!decimal.TryParse(txtmonto.Text, out monto))
            {
                MessageBox.Show("El monto debe ser un valor numérico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool resultado;        
            string mensaje = "";

            
            Flete objFlete = new Flete()
            {
                IdFlete = idFleteSeleccionado,
                oCliente = new Cliente() { IdCliente = Convert.ToInt32(txtidcliente.Text) },
                oTransporte = new Transporte() { IdUnidad = Convert.ToInt32(txtidunidad.Text) },
                oMotorista = new Motorista() { IdMotorista = Convert.ToInt32(txtidmotorista.Text) },
                oEstado = new Estado() { IdEstado = Convert.ToInt32(Comboestado.SelectedValue) },
                Monto = Convert.ToDecimal(txtmonto.Text),
                Lrecolecta = txtrecolecta.Text,
                Lentrega = txtentrega.Text,
                Hsalida = dateTimePicker1.Value,
                Hllegada = dateTimePicker2.Value,
                Consideraciones = txtconsideracion.Text
            };

            if (idFleteSeleccionado > 0)
            {
                resultado = this.cn_flete.Editar(objFlete, out mensaje);
                if (objFlete.oEstado.IdEstado == 3 || objFlete.oEstado.IdEstado == 4 || objFlete.oEstado.IdEstado == 5)
                {
                    decimal montoFlete = objFlete.Monto;
                    frmReportes frm = new frmReportes(idFleteSeleccionado, montoFlete);
                    frm.ShowDialog();
                }
            }
            else
            {
                // Si no se ha seleccionado ningun flete, se toma como registrar y no editar
                resultado = this.cn_flete.RegistrarFlete(
                    objFlete,
                    out mensaje
                );
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }

           
            this.RecargarFletes();
            this.LimpiarFormulario();
            idFleteSeleccionado = 0; 
        }


        private void dgvflete_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            
            if (e.RowIndex >= 0 ||dgvflete.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                idFleteSeleccionado = Convert.ToInt32(dgvflete.Rows[e.RowIndex].Cells[0].Value);

                
                txtidcliente.Text = dgvflete.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtidmotorista.Text = dgvflete.Rows[e.RowIndex].Cells[2].Value.ToString();               
                txtidunidad.Text = dgvflete.Rows[e.RowIndex].Cells[3].Value.ToString();
                Comboestado.Text = dgvflete.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtcliente.Text = dgvflete.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtmotorista.Text = dgvflete.Rows[e.RowIndex].Cells[6].Value.ToString();                
                txtunidad.Text = dgvflete.Rows[e.RowIndex].Cells[7].Value.ToString();               
                txtmonto.Text = dgvflete.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtrecolecta.Text = dgvflete.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtentrega.Text = dgvflete.Rows[e.RowIndex].Cells[11].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgvflete.Rows[e.RowIndex].Cells[12].Value);
                dateTimePicker2.Value = Convert.ToDateTime(dgvflete.Rows[e.RowIndex].Cells[13].Value);
                txtconsideracion.Text = dgvflete.Rows[e.RowIndex].Cells[14].Value.ToString();
            }

            if (dgvflete.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int idFlete = Convert.ToInt32(dgvflete.Rows[e.RowIndex].Cells[0].Value); // Asegúrate que la columna 0 es IdFlete

                var confirm = MessageBox.Show("¿Está seguro que desea eliminar este flete?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    Flete objFlete = new Flete() { IdFlete = idFlete };
                    string mensaje;
                    bool eliminado = this.cn_flete.Eliminar(objFlete, out mensaje);

                    MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, eliminado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                    if (eliminado)
                    {
                        RecargarFletes(); 
                        LimpiarFormulario();
                    }
                }
            }


        }

        private void RecargarFletes()
        {
            dgvflete.Rows.Clear();
            List<Flete> lista = this.cn_flete.Listar();
            foreach (Flete item in lista)
            {
                dgvflete.Rows.Add(new object[] {
                    item.IdFlete,                      // 0
                    item.oCliente.IdCliente,           // 1
                    item.oMotorista.IdMotorista,       // 2
                    item.oTransporte.IdUnidad,         // 3
                    item.oEstado.IdEstado,             // 4
                    item.oCliente.NombreCliente,       // 5
                    item.oMotorista.NombreMotorista,           // 6
                    item.oTransporte.Placa,            // 7
                    item.oEstado.Descripcion,          // 8
                    item.Monto,                        // 9
                    item.Lrecolecta,                   // 10
                    item.Lentrega,                     // 11
                    item.Hsalida,                      // 12
                    item.Hllegada,                     // 13
                    item.Consideraciones               // 14
                });
            }
        }

        private void LimpiarFormulario()
        {
            txtidcliente.Text = "";
            txtcliente.Text = "";
            txtidmotorista.Text = "";
            txtmotorista.Text = "";
            txtidunidad.Text = "";
            txtunidad.Text = "";
            Comboestado.SelectedIndex = 0;
            txtmonto.Text = "";
            txtrecolecta.Text = "";
            txtentrega.Text = "";
            txtconsideracion.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
