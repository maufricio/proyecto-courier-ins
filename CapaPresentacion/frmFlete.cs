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
        public frmFlete()
        {
            InitializeComponent();
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

            List<Flete> lista = new CN_Flete().Listar();

            foreach (Flete item in lista)
            {
                dgvflete.Rows.Add(new object[] {
                    item.IdFlete,                      // 0
                    item.oCliente.IdCliente,           // 1
                    item.oMotorista.IdMotorista,       // 2
                    item.oTransporte.IdUnidad,         // 3
                    item.oEstado.IdEstado,             // 4
                    item.oCliente.NombreCliente,       // 5
                    item.oMotorista.NombreM,           // 6
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
                    txtmotorista.Text = modal._Motorista.NombreM;
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
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtidcliente.Text) || Convert.ToInt32(txtidcliente.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtidmotorista.Text) || Convert.ToInt32(txtidmotorista.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un motorista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtidunidad.Text) || Convert.ToInt32(txtidunidad.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar una unidad de transporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtmonto.Text))
            {
                MessageBox.Show("Debe ingresar el monto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtrecolecta.Text))
            {
                MessageBox.Show("Debe ingresar el lugar de recolecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtentrega.Text))
            {
                MessageBox.Show("Debe ingresar el lugar de entrega", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }            
            decimal monto;
            if (!decimal.TryParse(txtmonto.Text, out monto))
            {
                MessageBox.Show("El monto debe ser un valor numérico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Validación de fechas
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("La fecha y hora de llegada no puede ser anterior a la fecha y hora de salida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool resultado;        
            string mensaje = "";

            if (idFleteSeleccionado > 0)
            {
                // Si se ha seleccionado un flete, se edita
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
                resultado = new CN_Flete().Editar(objFlete, out mensaje);
            }
            else
            {
                // Si no se ha seleccionado ningun flete, se toma como registrar y no editar
                resultado = new CD_Flete().RegistrarFlete(
                    Convert.ToInt32(txtidcliente.Text),
                    Convert.ToInt32(txtidunidad.Text),
                    Convert.ToInt32(txtidmotorista.Text),
                    Convert.ToInt32(Comboestado.SelectedValue),
                    Convert.ToDecimal(txtmonto.Text),
                    txtrecolecta.Text,
                    txtentrega.Text,
                    txtconsideracion.Text,
                    dateTimePicker1.Value,
                    dateTimePicker2.Value
                );
                mensaje = resultado ? "Flete registrado correctamente." : "Error al registrar el flete.";
            }

            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

           
            RecargarFletes();
            LimpiarFormulario();
            idFleteSeleccionado = 0; 
        }


        private void dgvflete_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            
            if (dgvflete.Columns[e.ColumnIndex].Name == "btnEditar")
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
                    bool eliminado = new CN_Flete().Eliminar(objFlete, out mensaje);

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
            List<Flete> lista = new CN_Flete().Listar();
            foreach (Flete item in lista)
            {
                dgvflete.Rows.Add(new object[] {
                    item.IdFlete,                      // 0
                    item.oCliente.IdCliente,           // 1
                    item.oMotorista.IdMotorista,       // 2
                    item.oTransporte.IdUnidad,         // 3
                    item.oEstado.IdEstado,             // 4
                    item.oCliente.NombreCliente,       // 5
                    item.oMotorista.NombreM,           // 6
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
