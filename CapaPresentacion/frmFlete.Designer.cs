namespace CapaPresentacion
{
    partial class frmFlete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.btnbuscarcliente1 = new FontAwesome.Sharp.IconButton();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidunidad = new System.Windows.Forms.TextBox();
            this.btnbuscarunidad = new FontAwesome.Sharp.IconButton();
            this.txtunidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtidmotorista = new System.Windows.Forms.TextBox();
            this.btnbuscarmotorista = new FontAwesome.Sharp.IconButton();
            this.txtmotorista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtconsideracion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtentrega = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtrecolecta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Comboestado = new System.Windows.Forms.ComboBox();
            this.dgvflete = new System.Windows.Forms.DataGridView();
            this.IdFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mcobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lrecolecta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lentrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consideraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnregistrarflete = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1671, 789);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTRAR FLETE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtidcliente);
            this.groupBox1.Controls.Add(this.btnbuscarcliente1);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Cliente";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(319, 21);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(49, 22);
            this.txtidcliente.TabIndex = 89;
            this.txtidcliente.Visible = false;
            // 
            // btnbuscarcliente1
            // 
            this.btnbuscarcliente1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarcliente1.IconColor = System.Drawing.Color.Black;
            this.btnbuscarcliente1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarcliente1.IconSize = 18;
            this.btnbuscarcliente1.Location = new System.Drawing.Point(319, 60);
            this.btnbuscarcliente1.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarcliente1.Name = "btnbuscarcliente1";
            this.btnbuscarcliente1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnbuscarcliente1.Size = new System.Drawing.Size(49, 28);
            this.btnbuscarcliente1.TabIndex = 88;
            this.btnbuscarcliente1.UseVisualStyleBackColor = true;
            this.btnbuscarcliente1.Click += new System.EventHandler(this.btnbuscarcliente1_Click);
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(6, 63);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(297, 22);
            this.txtcliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre del cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtidunidad);
            this.groupBox2.Controls.Add(this.btnbuscarunidad);
            this.groupBox2.Controls.Add(this.txtunidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(432, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Unidad de Transporte";
            // 
            // txtidunidad
            // 
            this.txtidunidad.Location = new System.Drawing.Point(185, 31);
            this.txtidunidad.Name = "txtidunidad";
            this.txtidunidad.Size = new System.Drawing.Size(49, 22);
            this.txtidunidad.TabIndex = 89;
            this.txtidunidad.Visible = false;
            // 
            // btnbuscarunidad
            // 
            this.btnbuscarunidad.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarunidad.IconColor = System.Drawing.Color.Black;
            this.btnbuscarunidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarunidad.IconSize = 18;
            this.btnbuscarunidad.Location = new System.Drawing.Point(185, 60);
            this.btnbuscarunidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarunidad.Name = "btnbuscarunidad";
            this.btnbuscarunidad.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnbuscarunidad.Size = new System.Drawing.Size(49, 28);
            this.btnbuscarunidad.TabIndex = 88;
            this.btnbuscarunidad.UseVisualStyleBackColor = true;
            this.btnbuscarunidad.Click += new System.EventHandler(this.btnbuscarunidad_Click);
            // 
            // txtunidad
            // 
            this.txtunidad.Location = new System.Drawing.Point(6, 63);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.ReadOnly = true;
            this.txtunidad.Size = new System.Drawing.Size(161, 22);
            this.txtunidad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Placa del vehiculo:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txtidmotorista);
            this.groupBox3.Controls.Add(this.btnbuscarmotorista);
            this.groupBox3.Controls.Add(this.txtmotorista);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(708, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Motorista";
            // 
            // txtidmotorista
            // 
            this.txtidmotorista.Location = new System.Drawing.Point(319, 18);
            this.txtidmotorista.Name = "txtidmotorista";
            this.txtidmotorista.Size = new System.Drawing.Size(49, 22);
            this.txtidmotorista.TabIndex = 89;
            this.txtidmotorista.Visible = false;
            // 
            // btnbuscarmotorista
            // 
            this.btnbuscarmotorista.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarmotorista.IconColor = System.Drawing.Color.Black;
            this.btnbuscarmotorista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarmotorista.IconSize = 18;
            this.btnbuscarmotorista.Location = new System.Drawing.Point(319, 60);
            this.btnbuscarmotorista.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarmotorista.Name = "btnbuscarmotorista";
            this.btnbuscarmotorista.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnbuscarmotorista.Size = new System.Drawing.Size(49, 28);
            this.btnbuscarmotorista.TabIndex = 88;
            this.btnbuscarmotorista.UseVisualStyleBackColor = true;
            this.btnbuscarmotorista.Click += new System.EventHandler(this.btnbuscarmotorista_Click);
            // 
            // txtmotorista
            // 
            this.txtmotorista.Location = new System.Drawing.Point(6, 63);
            this.txtmotorista.Name = "txtmotorista";
            this.txtmotorista.ReadOnly = true;
            this.txtmotorista.Size = new System.Drawing.Size(297, 22);
            this.txtmotorista.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre del motorista:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtconsideracion);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtentrega);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtrecolecta);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtmonto);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(29, 190);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 455);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion Flete";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 411);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(166, 22);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Hora y fecha de llegada:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 411);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Hora y fecha de salida:";
            // 
            // txtconsideracion
            // 
            this.txtconsideracion.Location = new System.Drawing.Point(6, 289);
            this.txtconsideracion.Multiline = true;
            this.txtconsideracion.Name = "txtconsideracion";
            this.txtconsideracion.Size = new System.Drawing.Size(371, 71);
            this.txtconsideracion.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Consideraciones:";
            // 
            // txtentrega
            // 
            this.txtentrega.Location = new System.Drawing.Point(6, 207);
            this.txtentrega.Name = "txtentrega";
            this.txtentrega.Size = new System.Drawing.Size(371, 22);
            this.txtentrega.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lugar de entrega:";
            // 
            // txtrecolecta
            // 
            this.txtrecolecta.Location = new System.Drawing.Point(6, 133);
            this.txtrecolecta.Name = "txtrecolecta";
            this.txtrecolecta.Size = new System.Drawing.Size(371, 22);
            this.txtrecolecta.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Lugar de recolecta:";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(6, 63);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(194, 22);
            this.txtmonto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto a cobrar por el viaje:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.Comboestado);
            this.groupBox5.Location = new System.Drawing.Point(1117, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estado";
            // 
            // Comboestado
            // 
            this.Comboestado.FormattingEnabled = true;
            this.Comboestado.Location = new System.Drawing.Point(6, 46);
            this.Comboestado.Name = "Comboestado";
            this.Comboestado.Size = new System.Drawing.Size(185, 24);
            this.Comboestado.TabIndex = 0;
            // 
            // dgvflete
            // 
            this.dgvflete.AllowUserToAddRows = false;
            this.dgvflete.AllowUserToDeleteRows = false;
            this.dgvflete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvflete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFlete,
            this.IdC,
            this.IdM,
            this.IdU,
            this.IdE,
            this.IdCliente,
            this.IdMotorista,
            this.Placa,
            this.IdEstado,
            this.Mcobro,
            this.Lrecolecta,
            this.Lentrega,
            this.Hsalida,
            this.HDestino,
            this.Consideraciones});
            this.dgvflete.Location = new System.Drawing.Point(441, 190);
            this.dgvflete.Name = "dgvflete";
            this.dgvflete.ReadOnly = true;
            this.dgvflete.RowHeadersWidth = 51;
            this.dgvflete.RowTemplate.Height = 24;
            this.dgvflete.Size = new System.Drawing.Size(1230, 601);
            this.dgvflete.TabIndex = 10;
            this.dgvflete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvflete_CellClick);
            // 
            // IdFlete
            // 
            this.IdFlete.HeaderText = "IdFlete";
            this.IdFlete.MinimumWidth = 6;
            this.IdFlete.Name = "IdFlete";
            this.IdFlete.ReadOnly = true;
            this.IdFlete.Visible = false;
            this.IdFlete.Width = 125;
            // 
            // IdC
            // 
            this.IdC.HeaderText = "IdCliente";
            this.IdC.MinimumWidth = 6;
            this.IdC.Name = "IdC";
            this.IdC.ReadOnly = true;
            this.IdC.Visible = false;
            this.IdC.Width = 125;
            // 
            // IdM
            // 
            this.IdM.HeaderText = "IdMotorista";
            this.IdM.MinimumWidth = 6;
            this.IdM.Name = "IdM";
            this.IdM.ReadOnly = true;
            this.IdM.Visible = false;
            this.IdM.Width = 125;
            // 
            // IdU
            // 
            this.IdU.HeaderText = "IdUnidad";
            this.IdU.MinimumWidth = 6;
            this.IdU.Name = "IdU";
            this.IdU.ReadOnly = true;
            this.IdU.Visible = false;
            this.IdU.Width = 125;
            // 
            // IdE
            // 
            this.IdE.HeaderText = "IdEstado";
            this.IdE.MinimumWidth = 6;
            this.IdE.Name = "IdE";
            this.IdE.ReadOnly = true;
            this.IdE.Visible = false;
            this.IdE.Width = 125;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Cliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 200;
            // 
            // IdMotorista
            // 
            this.IdMotorista.HeaderText = "Motorista";
            this.IdMotorista.MinimumWidth = 6;
            this.IdMotorista.Name = "IdMotorista";
            this.IdMotorista.ReadOnly = true;
            this.IdMotorista.Width = 200;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa Vehiculo";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 125;
            // 
            // IdEstado
            // 
            this.IdEstado.HeaderText = "Estado";
            this.IdEstado.MinimumWidth = 6;
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            this.IdEstado.Width = 150;
            // 
            // Mcobro
            // 
            this.Mcobro.HeaderText = "Monto cobro";
            this.Mcobro.MinimumWidth = 6;
            this.Mcobro.Name = "Mcobro";
            this.Mcobro.ReadOnly = true;
            this.Mcobro.Width = 125;
            // 
            // Lrecolecta
            // 
            this.Lrecolecta.HeaderText = "Lugar de recolecta";
            this.Lrecolecta.MinimumWidth = 6;
            this.Lrecolecta.Name = "Lrecolecta";
            this.Lrecolecta.ReadOnly = true;
            this.Lrecolecta.Width = 200;
            // 
            // Lentrega
            // 
            this.Lentrega.HeaderText = "Lugar de entrega";
            this.Lentrega.MinimumWidth = 6;
            this.Lentrega.Name = "Lentrega";
            this.Lentrega.ReadOnly = true;
            this.Lentrega.Width = 200;
            // 
            // Hsalida
            // 
            this.Hsalida.HeaderText = "Fecha y hora de salida";
            this.Hsalida.MinimumWidth = 6;
            this.Hsalida.Name = "Hsalida";
            this.Hsalida.ReadOnly = true;
            this.Hsalida.Width = 200;
            // 
            // HDestino
            // 
            this.HDestino.HeaderText = "Fecha y hora de destido";
            this.HDestino.MinimumWidth = 6;
            this.HDestino.Name = "HDestino";
            this.HDestino.ReadOnly = true;
            this.HDestino.Width = 200;
            // 
            // Consideraciones
            // 
            this.Consideraciones.HeaderText = "Consideraciones";
            this.Consideraciones.MinimumWidth = 6;
            this.Consideraciones.Name = "Consideraciones";
            this.Consideraciones.ReadOnly = true;
            this.Consideraciones.Width = 250;
            // 
            // btnregistrarflete
            // 
            this.btnregistrarflete.BackColor = System.Drawing.Color.PaleGreen;
            this.btnregistrarflete.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            this.btnregistrarflete.IconColor = System.Drawing.Color.DarkGreen;
            this.btnregistrarflete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistrarflete.Location = new System.Drawing.Point(112, 675);
            this.btnregistrarflete.Name = "btnregistrarflete";
            this.btnregistrarflete.Size = new System.Drawing.Size(220, 90);
            this.btnregistrarflete.TabIndex = 11;
            this.btnregistrarflete.Text = "REGISTRAR";
            this.btnregistrarflete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnregistrarflete.UseVisualStyleBackColor = false;
            this.btnregistrarflete.Click += new System.EventHandler(this.btnregistrarflete_Click);
            // 
            // frmFlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1695, 819);
            this.Controls.Add(this.btnregistrarflete);
            this.Controls.Add(this.dgvflete);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFlete";
            this.Text = "frmFlete";
            this.Load += new System.EventHandler(this.frmFlete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvflete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnbuscarcliente1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnbuscarunidad;
        private System.Windows.Forms.TextBox txtunidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnbuscarmotorista;
        private System.Windows.Forms.TextBox txtmotorista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtconsideracion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtentrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtrecolecta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox Comboestado;
        private System.Windows.Forms.DataGridView dgvflete;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtidunidad;
        private System.Windows.Forms.TextBox txtidmotorista;
        private FontAwesome.Sharp.IconButton btnregistrarflete;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdU;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mcobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lrecolecta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lentrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consideraciones;
    }
}