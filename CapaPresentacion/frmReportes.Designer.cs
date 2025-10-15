namespace CapaPresentacion
{
    partial class frmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbGastos = new System.Windows.Forms.GroupBox();
            this.gbProd = new System.Windows.Forms.GroupBox();
            this.ibtnAggProd = new FontAwesome.Sharp.IconButton();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.mtxtProd = new System.Windows.Forms.MaskedTextBox();
            this.nudProd = new System.Windows.Forms.NumericUpDown();
            this.gbVarios = new System.Windows.Forms.GroupBox();
            this.ibtnAggVarios = new FontAwesome.Sharp.IconButton();
            this.nudVarios = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtxtVarios = new System.Windows.Forms.MaskedTextBox();
            this.cmbVarios = new System.Windows.Forms.ComboBox();
            this.pCamion = new System.Windows.Forms.Panel();
            this.gbCamion = new System.Windows.Forms.GroupBox();
            this.ibtnAggCamion = new FontAwesome.Sharp.IconButton();
            this.mtxtCamion = new System.Windows.Forms.MaskedTextBox();
            this.cmbCamion = new System.Windows.Forms.ComboBox();
            this.nudCamion = new System.Windows.Forms.NumericUpDown();
            this.ibtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.ibtnEditar = new FontAwesome.Sharp.IconButton();
            this.ibtnGuardar = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.valorFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadNeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeUtilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.ListBox();
            this.gblist = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ibtnFinalizar = new FontAwesome.Sharp.IconButton();
            this.gbGastos.SuspendLayout();
            this.gbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProd)).BeginInit();
            this.gbVarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVarios)).BeginInit();
            this.gbCamion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.gblist.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGastos
            // 
            this.gbGastos.BackColor = System.Drawing.Color.White;
            this.gbGastos.Controls.Add(this.gbProd);
            this.gbGastos.Controls.Add(this.gbVarios);
            this.gbGastos.Controls.Add(this.pCamion);
            this.gbGastos.Controls.Add(this.gbCamion);
            this.gbGastos.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGastos.Location = new System.Drawing.Point(40, 95);
            this.gbGastos.Name = "gbGastos";
            this.gbGastos.Size = new System.Drawing.Size(524, 280);
            this.gbGastos.TabIndex = 252;
            this.gbGastos.TabStop = false;
            this.gbGastos.Text = "Tipos de gastos";
            this.gbGastos.Enter += new System.EventHandler(this.gbGastos_Enter);
            // 
            // gbProd
            // 
            this.gbProd.BackColor = System.Drawing.Color.White;
            this.gbProd.Controls.Add(this.ibtnAggProd);
            this.gbProd.Controls.Add(this.cmbProd);
            this.gbProd.Controls.Add(this.mtxtProd);
            this.gbProd.Controls.Add(this.nudProd);
            this.gbProd.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProd.Location = new System.Drawing.Point(15, 105);
            this.gbProd.Name = "gbProd";
            this.gbProd.Size = new System.Drawing.Size(493, 63);
            this.gbProd.TabIndex = 275;
            this.gbProd.TabStop = false;
            this.gbProd.Text = "Producción";
            // 
            // ibtnAggProd
            // 
            this.ibtnAggProd.BackColor = System.Drawing.Color.YellowGreen;
            this.ibtnAggProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAggProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAggProd.IconColor = System.Drawing.Color.Black;
            this.ibtnAggProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAggProd.IconSize = 17;
            this.ibtnAggProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnAggProd.Location = new System.Drawing.Point(327, 22);
            this.ibtnAggProd.Name = "ibtnAggProd";
            this.ibtnAggProd.Size = new System.Drawing.Size(139, 26);
            this.ibtnAggProd.TabIndex = 278;
            this.ibtnAggProd.Text = "Agregar";
            this.ibtnAggProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAggProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAggProd.UseVisualStyleBackColor = false;
            this.ibtnAggProd.Click += new System.EventHandler(this.ibtnAggProd_Click);
            // 
            // cmbProd
            // 
            this.cmbProd.Enabled = false;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Items.AddRange(new object[] {
            "Sueldo de motorista",
            "Sueldo de ayudantes",
            "Combustible"});
            this.cmbProd.Location = new System.Drawing.Point(25, 22);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(155, 23);
            this.cmbProd.TabIndex = 260;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            // 
            // mtxtProd
            // 
            this.mtxtProd.Enabled = false;
            this.mtxtProd.Location = new System.Drawing.Point(197, 22);
            this.mtxtProd.Mask = "$###.##";
            this.mtxtProd.Name = "mtxtProd";
            this.mtxtProd.Size = new System.Drawing.Size(57, 23);
            this.mtxtProd.TabIndex = 275;
            // 
            // nudProd
            // 
            this.nudProd.Enabled = false;
            this.nudProd.Location = new System.Drawing.Point(270, 22);
            this.nudProd.Name = "nudProd";
            this.nudProd.Size = new System.Drawing.Size(38, 23);
            this.nudProd.TabIndex = 276;
            // 
            // gbVarios
            // 
            this.gbVarios.BackColor = System.Drawing.Color.White;
            this.gbVarios.Controls.Add(this.ibtnAggVarios);
            this.gbVarios.Controls.Add(this.nudVarios);
            this.gbVarios.Controls.Add(this.panel2);
            this.gbVarios.Controls.Add(this.mtxtVarios);
            this.gbVarios.Controls.Add(this.cmbVarios);
            this.gbVarios.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVarios.Location = new System.Drawing.Point(15, 185);
            this.gbVarios.Name = "gbVarios";
            this.gbVarios.Size = new System.Drawing.Size(493, 63);
            this.gbVarios.TabIndex = 280;
            this.gbVarios.TabStop = false;
            this.gbVarios.Text = "Varios";
            // 
            // ibtnAggVarios
            // 
            this.ibtnAggVarios.BackColor = System.Drawing.Color.YellowGreen;
            this.ibtnAggVarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAggVarios.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAggVarios.IconColor = System.Drawing.Color.Black;
            this.ibtnAggVarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAggVarios.IconSize = 17;
            this.ibtnAggVarios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnAggVarios.Location = new System.Drawing.Point(327, 22);
            this.ibtnAggVarios.Name = "ibtnAggVarios";
            this.ibtnAggVarios.Size = new System.Drawing.Size(139, 26);
            this.ibtnAggVarios.TabIndex = 279;
            this.ibtnAggVarios.Text = "Agregar";
            this.ibtnAggVarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAggVarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAggVarios.UseVisualStyleBackColor = false;
            this.ibtnAggVarios.Click += new System.EventHandler(this.ibtnAggVarios_Click);
            // 
            // nudVarios
            // 
            this.nudVarios.Enabled = false;
            this.nudVarios.Location = new System.Drawing.Point(270, 22);
            this.nudVarios.Name = "nudVarios";
            this.nudVarios.Size = new System.Drawing.Size(38, 23);
            this.nudVarios.TabIndex = 277;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(50, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 254;
            // 
            // mtxtVarios
            // 
            this.mtxtVarios.Enabled = false;
            this.mtxtVarios.Location = new System.Drawing.Point(197, 22);
            this.mtxtVarios.Mask = "$###.##";
            this.mtxtVarios.Name = "mtxtVarios";
            this.mtxtVarios.Size = new System.Drawing.Size(57, 23);
            this.mtxtVarios.TabIndex = 274;
            // 
            // cmbVarios
            // 
            this.cmbVarios.Enabled = false;
            this.cmbVarios.FormattingEnabled = true;
            this.cmbVarios.Items.AddRange(new object[] {
            "Parqueo",
            "Hospedaje",
            "Otros"});
            this.cmbVarios.Location = new System.Drawing.Point(25, 22);
            this.cmbVarios.Name = "cmbVarios";
            this.cmbVarios.Size = new System.Drawing.Size(155, 23);
            this.cmbVarios.TabIndex = 268;
            this.cmbVarios.SelectedIndexChanged += new System.EventHandler(this.cmbVarios_SelectedIndexChanged);
            // 
            // pCamion
            // 
            this.pCamion.AutoSize = true;
            this.pCamion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pCamion.Location = new System.Drawing.Point(50, 44);
            this.pCamion.Name = "pCamion";
            this.pCamion.Size = new System.Drawing.Size(0, 0);
            this.pCamion.TabIndex = 254;
            // 
            // gbCamion
            // 
            this.gbCamion.BackColor = System.Drawing.Color.White;
            this.gbCamion.Controls.Add(this.ibtnAggCamion);
            this.gbCamion.Controls.Add(this.mtxtCamion);
            this.gbCamion.Controls.Add(this.cmbCamion);
            this.gbCamion.Controls.Add(this.nudCamion);
            this.gbCamion.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCamion.Location = new System.Drawing.Point(15, 26);
            this.gbCamion.Name = "gbCamion";
            this.gbCamion.Size = new System.Drawing.Size(493, 63);
            this.gbCamion.TabIndex = 274;
            this.gbCamion.TabStop = false;
            this.gbCamion.Text = "Camión";
            // 
            // ibtnAggCamion
            // 
            this.ibtnAggCamion.BackColor = System.Drawing.Color.YellowGreen;
            this.ibtnAggCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAggCamion.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAggCamion.IconColor = System.Drawing.Color.Black;
            this.ibtnAggCamion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAggCamion.IconSize = 17;
            this.ibtnAggCamion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnAggCamion.Location = new System.Drawing.Point(327, 22);
            this.ibtnAggCamion.Name = "ibtnAggCamion";
            this.ibtnAggCamion.Size = new System.Drawing.Size(139, 26);
            this.ibtnAggCamion.TabIndex = 273;
            this.ibtnAggCamion.Text = "Agregar";
            this.ibtnAggCamion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAggCamion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAggCamion.UseVisualStyleBackColor = false;
            this.ibtnAggCamion.Click += new System.EventHandler(this.ibtnAggCamion_Click);
            // 
            // mtxtCamion
            // 
            this.mtxtCamion.Enabled = false;
            this.mtxtCamion.Location = new System.Drawing.Point(197, 25);
            this.mtxtCamion.Mask = "$000.00";
            this.mtxtCamion.Name = "mtxtCamion";
            this.mtxtCamion.Size = new System.Drawing.Size(57, 23);
            this.mtxtCamion.TabIndex = 271;
            // 
            // cmbCamion
            // 
            this.cmbCamion.Enabled = false;
            this.cmbCamion.FormattingEnabled = true;
            this.cmbCamion.Items.AddRange(new object[] {
            "Batería",
            "Llantas",
            "Cambio de aceite"});
            this.cmbCamion.Location = new System.Drawing.Point(25, 24);
            this.cmbCamion.Name = "cmbCamion";
            this.cmbCamion.Size = new System.Drawing.Size(155, 23);
            this.cmbCamion.TabIndex = 265;
            this.cmbCamion.SelectedIndexChanged += new System.EventHandler(this.cmbCamion_SelectedIndexChanged);
            // 
            // nudCamion
            // 
            this.nudCamion.Enabled = false;
            this.nudCamion.Location = new System.Drawing.Point(270, 26);
            this.nudCamion.Name = "nudCamion";
            this.nudCamion.Size = new System.Drawing.Size(38, 23);
            this.nudCamion.TabIndex = 274;
            // 
            // ibtnLimpiar
            // 
            this.ibtnLimpiar.BackColor = System.Drawing.Color.Red;
            this.ibtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.ibtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.ibtnLimpiar.IconColor = System.Drawing.SystemColors.Control;
            this.ibtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLimpiar.IconSize = 17;
            this.ibtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnLimpiar.Location = new System.Drawing.Point(19, 286);
            this.ibtnLimpiar.Name = "ibtnLimpiar";
            this.ibtnLimpiar.Size = new System.Drawing.Size(283, 26);
            this.ibtnLimpiar.TabIndex = 270;
            this.ibtnLimpiar.Text = "Limpiar todo";
            this.ibtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLimpiar.UseVisualStyleBackColor = false;
            this.ibtnLimpiar.Visible = false;
            this.ibtnLimpiar.Click += new System.EventHandler(this.ibtnLimpiar_Click);
            // 
            // ibtnEditar
            // 
            this.ibtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnEditar.IconColor = System.Drawing.Color.Black;
            this.ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEditar.IconSize = 17;
            this.ibtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnEditar.Location = new System.Drawing.Point(19, 254);
            this.ibtnEditar.Name = "ibtnEditar";
            this.ibtnEditar.Size = new System.Drawing.Size(283, 26);
            this.ibtnEditar.TabIndex = 269;
            this.ibtnEditar.Text = "Editar";
            this.ibtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEditar.UseVisualStyleBackColor = true;
            this.ibtnEditar.Visible = false;
            this.ibtnEditar.Click += new System.EventHandler(this.ibtnEditar_Click);
            // 
            // ibtnGuardar
            // 
            this.ibtnGuardar.BackColor = System.Drawing.Color.White;
            this.ibtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnGuardar.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.ibtnGuardar.IconColor = System.Drawing.Color.Black;
            this.ibtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGuardar.IconSize = 17;
            this.ibtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnGuardar.Location = new System.Drawing.Point(19, 222);
            this.ibtnGuardar.Name = "ibtnGuardar";
            this.ibtnGuardar.Size = new System.Drawing.Size(283, 26);
            this.ibtnGuardar.TabIndex = 244;
            this.ibtnGuardar.Text = "Calcular utilidades";
            this.ibtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnGuardar.UseVisualStyleBackColor = false;
            this.ibtnGuardar.Click += new System.EventHandler(this.ibtnGuardar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valorFlete,
            this.totalGastos,
            this.utilidadNeta,
            this.porcentajeUtilidad});
            this.dgvdata.Location = new System.Drawing.Point(40, 414);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(880, 59);
            this.dgvdata.TabIndex = 250;
            // 
            // valorFlete
            // 
            this.valorFlete.HeaderText = "Valor de flete";
            this.valorFlete.Name = "valorFlete";
            this.valorFlete.ReadOnly = true;
            this.valorFlete.Width = 209;
            // 
            // totalGastos
            // 
            this.totalGastos.HeaderText = "Total de gastos";
            this.totalGastos.Name = "totalGastos";
            this.totalGastos.ReadOnly = true;
            this.totalGastos.Width = 209;
            // 
            // utilidadNeta
            // 
            this.utilidadNeta.HeaderText = "Utilidad neta";
            this.utilidadNeta.Name = "utilidadNeta";
            this.utilidadNeta.ReadOnly = true;
            this.utilidadNeta.Width = 209;
            // 
            // porcentajeUtilidad
            // 
            this.porcentajeUtilidad.HeaderText = "% de Utilidad";
            this.porcentajeUtilidad.Name = "porcentajeUtilidad";
            this.porcentajeUtilidad.ReadOnly = true;
            this.porcentajeUtilidad.Width = 208;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(51, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 45);
            this.label9.TabIndex = 246;
            this.label9.Text = "Calculo de gastos";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, -1);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(962, 551);
            this.label10.TabIndex = 245;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.FormattingEnabled = true;
            this.lbTotal.ItemHeight = 15;
            this.lbTotal.Location = new System.Drawing.Point(19, 26);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(283, 184);
            this.lbTotal.TabIndex = 272;
            // 
            // gblist
            // 
            this.gblist.BackColor = System.Drawing.Color.White;
            this.gblist.Controls.Add(this.lbTotal);
            this.gblist.Controls.Add(this.ibtnLimpiar);
            this.gblist.Controls.Add(this.ibtnGuardar);
            this.gblist.Controls.Add(this.ibtnEditar);
            this.gblist.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gblist.Location = new System.Drawing.Point(600, 69);
            this.gblist.Name = "gblist";
            this.gblist.Size = new System.Drawing.Size(320, 324);
            this.gblist.TabIndex = 273;
            this.gblist.TabStop = false;
            this.gblist.Text = "Total de gastos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 54);
            this.panel1.TabIndex = 274;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(13, 13);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 247;
            this.iconPictureBox1.TabStop = false;
            // 
            // ibtnFinalizar
            // 
            this.ibtnFinalizar.BackColor = System.Drawing.Color.DarkGreen;
            this.ibtnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnFinalizar.ForeColor = System.Drawing.Color.White;
            this.ibtnFinalizar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ibtnFinalizar.IconColor = System.Drawing.Color.White;
            this.ibtnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnFinalizar.IconSize = 17;
            this.ibtnFinalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnFinalizar.Location = new System.Drawing.Point(758, 488);
            this.ibtnFinalizar.Name = "ibtnFinalizar";
            this.ibtnFinalizar.Size = new System.Drawing.Size(162, 28);
            this.ibtnFinalizar.TabIndex = 273;
            this.ibtnFinalizar.Text = "Guardar y finalizar flete";
            this.ibtnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFinalizar.UseVisualStyleBackColor = false;
            this.ibtnFinalizar.Click += new System.EventHandler(this.ibtnFinalizar_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 546);
            this.Controls.Add(this.ibtnFinalizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gblist);
            this.Controls.Add(this.gbGastos);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "Calculo de Utilidades";
            this.gbGastos.ResumeLayout(false);
            this.gbGastos.PerformLayout();
            this.gbProd.ResumeLayout(false);
            this.gbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProd)).EndInit();
            this.gbVarios.ResumeLayout(false);
            this.gbVarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVarios)).EndInit();
            this.gbCamion.ResumeLayout(false);
            this.gbCamion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.gblist.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGastos;
        private System.Windows.Forms.ComboBox cmbVarios;
        private System.Windows.Forms.ComboBox cmbCamion;
        private System.Windows.Forms.ComboBox cmbProd;
        private FontAwesome.Sharp.IconButton ibtnGuardar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pCamion;
        private FontAwesome.Sharp.IconButton ibtnLimpiar;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private System.Windows.Forms.MaskedTextBox mtxtCamion;
        private System.Windows.Forms.ListBox lbTotal;
        private System.Windows.Forms.GroupBox gblist;
        private System.Windows.Forms.MaskedTextBox mtxtVarios;
        private System.Windows.Forms.MaskedTextBox mtxtProd;
        private System.Windows.Forms.NumericUpDown nudVarios;
        private System.Windows.Forms.NumericUpDown nudProd;
        private System.Windows.Forms.NumericUpDown nudCamion;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton ibtnAggVarios;
        private FontAwesome.Sharp.IconButton ibtnAggProd;
        private FontAwesome.Sharp.IconButton ibtnAggCamion;
        private System.Windows.Forms.GroupBox gbCamion;
        private System.Windows.Forms.GroupBox gbProd;
        private System.Windows.Forms.GroupBox gbVarios;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadNeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeUtilidad;
    }
}