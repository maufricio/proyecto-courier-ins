namespace CapaPresentacion
{
    partial class frmUnidadesTransporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.chkInactivo = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadToneladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioFabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Placa,
            this.Marca,
            this.CapacidadToneladas,
            this.AnioFabricacion,
            this.EstadoValor,
            this.Estado,
            this.FechaRegistro});
            this.dgvData.Location = new System.Drawing.Point(259, 114);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(841, 435);
            this.dgvData.TabIndex = 221;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 217;
            this.label2.Text = "Registro Transporte ";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(228, 540);
            this.label10.TabIndex = 216;
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.BackColor = System.Drawing.Color.White;
            this.btnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscador.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 18;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(1043, 49);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(42, 23);
            this.btnLimpiarBuscador.TabIndex = 227;
            this.btnLimpiarBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(995, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 23);
            this.btnBuscar.TabIndex = 226;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(835, 51);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(152, 20);
            this.txtBusqueda.TabIndex = 225;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(696, 51);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(116, 21);
            this.cboBusqueda.TabIndex = 224;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(629, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 223;
            this.label11.Text = "Buscar por:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 33);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(841, 57);
            this.label8.TabIndex = 222;
            this.label8.Text = "Lista de Transportes:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(6, 142);
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(192, 21);
            this.nudCapacidad.TabIndex = 222;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(6, 93);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(192, 21);
            this.txtMarca.TabIndex = 226;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Placa:";
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRegistro.Location = new System.Drawing.Point(6, 301);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.ReadOnly = true;
            this.txtFechaRegistro.Size = new System.Drawing.Size(192, 21);
            this.txtFechaRegistro.TabIndex = 215;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 92;
            this.label1.Text = "Capacidad (Ton):";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(6, 250);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 19);
            this.chkActivo.TabIndex = 227;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 228;
            this.label6.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 228;
            this.label5.Text = "Año de Fabriación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 229;
            this.label7.Text = "Fecha de Registro: ";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(6, 195);
            this.nudAnio.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(192, 21);
            this.nudAnio.TabIndex = 230;
            this.nudAnio.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(6, 39);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(192, 21);
            this.txtPlaca.TabIndex = 231;
            // 
            // chkInactivo
            // 
            this.chkInactivo.AutoSize = true;
            this.chkInactivo.Location = new System.Drawing.Point(95, 250);
            this.chkInactivo.Name = "chkInactivo";
            this.chkInactivo.Size = new System.Drawing.Size(67, 19);
            this.chkInactivo.TabIndex = 232;
            this.chkInactivo.Text = "Inactivo";
            this.chkInactivo.UseVisualStyleBackColor = true;
            this.chkInactivo.CheckedChanged += new System.EventHandler(this.chkInactivo_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(6, 349);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(192, 25);
            this.btnGuardar.TabIndex = 222;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 18;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 380);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(192, 25);
            this.btnLimpiar.TabIndex = 233;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.chkInactivo);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.nudAnio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFechaRegistro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudCapacidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 460);
            this.groupBox1.TabIndex = 218;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 16;
            this.btnEliminar.Location = new System.Drawing.Point(6, 411);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 25);
            this.btnEliminar.TabIndex = 234;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(171, 55);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(25, 20);
            this.txtindice.TabIndex = 229;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(202, 55);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(25, 20);
            this.txtid.TabIndex = 228;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnseleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnseleccionar.Width = 45;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 130;
            // 
            // CapacidadToneladas
            // 
            this.CapacidadToneladas.HeaderText = "Capacidad (Ton)";
            this.CapacidadToneladas.Name = "CapacidadToneladas";
            this.CapacidadToneladas.Width = 75;
            // 
            // AnioFabricacion
            // 
            this.AnioFabricacion.HeaderText = "Año_Fabricación";
            this.AnioFabricacion.Name = "AnioFabricacion";
            this.AnioFabricacion.Width = 130;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 110;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha_Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.Width = 130;
            // 
            // frmUnidadesTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 561);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "frmUnidadesTransporte";
            this.Text = "frmUnidadTransporte";
            this.Load += new System.EventHandler(this.frmUnidadesTransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.CheckBox chkInactivo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidadToneladas;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioFabricacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}