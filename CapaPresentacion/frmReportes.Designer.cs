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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ibtnExcel = new FontAwesome.Sharp.IconButton();
            this.gbGastos = new System.Windows.Forms.GroupBox();
            this.cbNoHosp = new System.Windows.Forms.ComboBox();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbNoLlantas = new System.Windows.Forms.ComboBox();
            this.txtHospedaje = new System.Windows.Forms.TextBox();
            this.txtParqueo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbNoAux = new System.Windows.Forms.ComboBox();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.txtAuxilar = new System.Windows.Forms.TextBox();
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAceite = new System.Windows.Forms.TextBox();
            this.txtLlanta = new System.Windows.Forms.TextBox();
            this.txtBateria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVarios = new System.Windows.Forms.CheckBox();
            this.cbProd = new System.Windows.Forms.CheckBox();
            this.cbCamion = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ibtnGuardar = new FontAwesome.Sharp.IconButton();
            this.ibtnPDF = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.gbValorflete = new System.Windows.Forms.GroupBox();
            this.textFleteMonto = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtIdFlete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pCamion = new System.Windows.Forms.Panel();
            this.ibtnEditar = new FontAwesome.Sharp.IconButton();
            this.ibtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.valorFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadNeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeUtilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.gbValorflete.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibtnExcel
            // 
            this.ibtnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnExcel.IconColor = System.Drawing.Color.Black;
            this.ibtnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExcel.IconSize = 15;
            this.ibtnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnExcel.Location = new System.Drawing.Point(649, 446);
            this.ibtnExcel.Name = "ibtnExcel";
            this.ibtnExcel.Size = new System.Drawing.Size(134, 21);
            this.ibtnExcel.TabIndex = 253;
            this.ibtnExcel.Text = "Descargar Excel";
            this.ibtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnExcel.UseVisualStyleBackColor = true;
            // 
            // gbGastos
            // 
            this.gbGastos.BackColor = System.Drawing.Color.White;
            this.gbGastos.Controls.Add(this.ibtnLimpiar);
            this.gbGastos.Controls.Add(this.ibtnEditar);
            this.gbGastos.Controls.Add(this.cbCamion);
            this.gbGastos.Controls.Add(this.label7);
            this.gbGastos.Controls.Add(this.label5);
            this.gbGastos.Controls.Add(this.pCamion);
            this.gbGastos.Controls.Add(this.txtBateria);
            this.gbGastos.Controls.Add(this.cbNoHosp);
            this.gbGastos.Controls.Add(this.label6);
            this.gbGastos.Controls.Add(this.txtOtros);
            this.gbGastos.Controls.Add(this.cbNoLlantas);
            this.gbGastos.Controls.Add(this.label14);
            this.gbGastos.Controls.Add(this.txtLlanta);
            this.gbGastos.Controls.Add(this.txtHospedaje);
            this.gbGastos.Controls.Add(this.txtAceite);
            this.gbGastos.Controls.Add(this.txtParqueo);
            this.gbGastos.Controls.Add(this.label2);
            this.gbGastos.Controls.Add(this.label13);
            this.gbGastos.Controls.Add(this.cbNoAux);
            this.gbGastos.Controls.Add(this.txtGas);
            this.gbGastos.Controls.Add(this.txtAuxilar);
            this.gbGastos.Controls.Add(this.txtMotorista);
            this.gbGastos.Controls.Add(this.label8);
            this.gbGastos.Controls.Add(this.label11);
            this.gbGastos.Controls.Add(this.label12);
            this.gbGastos.Controls.Add(this.cbVarios);
            this.gbGastos.Controls.Add(this.cbProd);
            this.gbGastos.Controls.Add(this.ibtnGuardar);
            this.gbGastos.Location = new System.Drawing.Point(249, 83);
            this.gbGastos.Name = "gbGastos";
            this.gbGastos.Size = new System.Drawing.Size(675, 265);
            this.gbGastos.TabIndex = 252;
            this.gbGastos.TabStop = false;
            this.gbGastos.Text = "Gastos totales";
            // 
            // cbNoHosp
            // 
            this.cbNoHosp.Enabled = false;
            this.cbNoHosp.FormattingEnabled = true;
            this.cbNoHosp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbNoHosp.Location = new System.Drawing.Point(344, 176);
            this.cbNoHosp.Name = "cbNoHosp";
            this.cbNoHosp.Size = new System.Drawing.Size(51, 21);
            this.cbNoHosp.TabIndex = 268;
            // 
            // txtOtros
            // 
            this.txtOtros.Enabled = false;
            this.txtOtros.Location = new System.Drawing.Point(590, 176);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(46, 20);
            this.txtOtros.TabIndex = 267;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(545, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 266;
            this.label14.Text = "Otros:";
            // 
            // cbNoLlantas
            // 
            this.cbNoLlantas.Enabled = false;
            this.cbNoLlantas.FormattingEnabled = true;
            this.cbNoLlantas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbNoLlantas.Location = new System.Drawing.Point(344, 53);
            this.cbNoLlantas.Name = "cbNoLlantas";
            this.cbNoLlantas.Size = new System.Drawing.Size(51, 21);
            this.cbNoLlantas.TabIndex = 265;
            // 
            // txtHospedaje
            // 
            this.txtHospedaje.Enabled = false;
            this.txtHospedaje.Location = new System.Drawing.Point(401, 176);
            this.txtHospedaje.Name = "txtHospedaje";
            this.txtHospedaje.Size = new System.Drawing.Size(46, 20);
            this.txtHospedaje.TabIndex = 264;
            // 
            // txtParqueo
            // 
            this.txtParqueo.Enabled = false;
            this.txtParqueo.Location = new System.Drawing.Point(131, 176);
            this.txtParqueo.Name = "txtParqueo";
            this.txtParqueo.Size = new System.Drawing.Size(46, 20);
            this.txtParqueo.TabIndex = 263;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 262;
            this.label2.Text = "Hospedaje:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(68, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 261;
            this.label13.Text = "Parqueo:";
            // 
            // cbNoAux
            // 
            this.cbNoAux.Enabled = false;
            this.cbNoAux.FormattingEnabled = true;
            this.cbNoAux.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbNoAux.Location = new System.Drawing.Point(344, 114);
            this.cbNoAux.Name = "cbNoAux";
            this.cbNoAux.Size = new System.Drawing.Size(51, 21);
            this.cbNoAux.TabIndex = 260;
            // 
            // txtGas
            // 
            this.txtGas.Enabled = false;
            this.txtGas.Location = new System.Drawing.Point(590, 114);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(46, 20);
            this.txtGas.TabIndex = 259;
            // 
            // txtAuxilar
            // 
            this.txtAuxilar.Enabled = false;
            this.txtAuxilar.Location = new System.Drawing.Point(401, 114);
            this.txtAuxilar.Name = "txtAuxilar";
            this.txtAuxilar.Size = new System.Drawing.Size(46, 20);
            this.txtAuxilar.TabIndex = 258;
            // 
            // txtMotorista
            // 
            this.txtMotorista.Enabled = false;
            this.txtMotorista.Location = new System.Drawing.Point(131, 114);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.Size = new System.Drawing.Size(46, 20);
            this.txtMotorista.TabIndex = 257;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(505, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 256;
            this.label8.Text = "Combustible:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(230, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 15);
            this.label11.TabIndex = 255;
            this.label11.Text = "Sueldo ayudantes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 15);
            this.label12.TabIndex = 254;
            this.label12.Text = "Sueldo motorista:";
            // 
            // txtAceite
            // 
            this.txtAceite.Enabled = false;
            this.txtAceite.Location = new System.Drawing.Point(590, 53);
            this.txtAceite.Name = "txtAceite";
            this.txtAceite.Size = new System.Drawing.Size(46, 20);
            this.txtAceite.TabIndex = 253;
            // 
            // txtLlanta
            // 
            this.txtLlanta.Enabled = false;
            this.txtLlanta.Location = new System.Drawing.Point(401, 53);
            this.txtLlanta.Name = "txtLlanta";
            this.txtLlanta.Size = new System.Drawing.Size(46, 20);
            this.txtLlanta.TabIndex = 252;
            // 
            // txtBateria
            // 
            this.txtBateria.Enabled = false;
            this.txtBateria.Location = new System.Drawing.Point(131, 53);
            this.txtBateria.Name = "txtBateria";
            this.txtBateria.Size = new System.Drawing.Size(46, 20);
            this.txtBateria.TabIndex = 251;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 250;
            this.label7.Text = "Cambio de aceite:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 249;
            this.label6.Text = "Llantas:";
            // 
            // cbVarios
            // 
            this.cbVarios.AutoSize = true;
            this.cbVarios.Location = new System.Drawing.Point(23, 152);
            this.cbVarios.Name = "cbVarios";
            this.cbVarios.Size = new System.Drawing.Size(55, 17);
            this.cbVarios.TabIndex = 248;
            this.cbVarios.Text = "Varios";
            this.cbVarios.UseVisualStyleBackColor = true;
            this.cbVarios.CheckedChanged += new System.EventHandler(this.cbVarios_CheckedChanged);
            // 
            // cbProd
            // 
            this.cbProd.AutoSize = true;
            this.cbProd.Location = new System.Drawing.Point(25, 90);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(80, 17);
            this.cbProd.TabIndex = 247;
            this.cbProd.Text = "Producción";
            this.cbProd.UseVisualStyleBackColor = true;
            this.cbProd.CheckedChanged += new System.EventHandler(this.cbProd_CheckedChanged);
            // 
            // cbCamion
            // 
            this.cbCamion.AutoSize = true;
            this.cbCamion.Location = new System.Drawing.Point(23, 30);
            this.cbCamion.Name = "cbCamion";
            this.cbCamion.Size = new System.Drawing.Size(113, 17);
            this.cbCamion.TabIndex = 246;
            this.cbCamion.Text = "Unidad de Camión";
            this.cbCamion.UseVisualStyleBackColor = true;
            this.cbCamion.CheckedChanged += new System.EventHandler(this.cbCamion_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 245;
            this.label5.Text = "Batería:";
            // 
            // ibtnGuardar
            // 
            this.ibtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnGuardar.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.ibtnGuardar.IconColor = System.Drawing.Color.Black;
            this.ibtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGuardar.IconSize = 17;
            this.ibtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnGuardar.Location = new System.Drawing.Point(522, 225);
            this.ibtnGuardar.Name = "ibtnGuardar";
            this.ibtnGuardar.Size = new System.Drawing.Size(134, 21);
            this.ibtnGuardar.TabIndex = 244;
            this.ibtnGuardar.Text = "Calcular";
            this.ibtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnGuardar.UseVisualStyleBackColor = true;
            this.ibtnGuardar.Click += new System.EventHandler(this.ibtnGuardar_Click);
            // 
            // ibtnPDF
            // 
            this.ibtnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ibtnPDF.IconColor = System.Drawing.Color.Black;
            this.ibtnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPDF.IconSize = 17;
            this.ibtnPDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnPDF.Location = new System.Drawing.Point(789, 446);
            this.ibtnPDF.Name = "ibtnPDF";
            this.ibtnPDF.Size = new System.Drawing.Size(134, 21);
            this.ibtnPDF.TabIndex = 251;
            this.ibtnPDF.Text = "Descargar en PDF";
            this.ibtnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnPDF.UseVisualStyleBackColor = true;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valorFlete,
            this.totalGastos,
            this.utilidadNeta,
            this.porcentajeUtilidad});
            this.dgvdata.Location = new System.Drawing.Point(89, 364);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(834, 59);
            this.dgvdata.TabIndex = 250;
            // 
            // gbValorflete
            // 
            this.gbValorflete.BackColor = System.Drawing.Color.White;
            this.gbValorflete.Controls.Add(this.textFleteMonto);
            this.gbValorflete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValorflete.Location = new System.Drawing.Point(89, 83);
            this.gbValorflete.Name = "gbValorflete";
            this.gbValorflete.Size = new System.Drawing.Size(154, 53);
            this.gbValorflete.TabIndex = 249;
            this.gbValorflete.TabStop = false;
            this.gbValorflete.Text = "Valor de flete";
            // 
            // textFleteMonto
            // 
            this.textFleteMonto.Enabled = false;
            this.textFleteMonto.Location = new System.Drawing.Point(13, 20);
            this.textFleteMonto.Name = "textFleteMonto";
            this.textFleteMonto.Size = new System.Drawing.Size(129, 21);
            this.textFleteMonto.TabIndex = 217;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(736, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 248;
            this.label26.Text = "No. Flete:";
            // 
            // txtIdFlete
            // 
            this.txtIdFlete.Enabled = false;
            this.txtIdFlete.Location = new System.Drawing.Point(795, 57);
            this.txtIdFlete.Name = "txtIdFlete";
            this.txtIdFlete.Size = new System.Drawing.Size(129, 20);
            this.txtIdFlete.TabIndex = 247;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(333, 37);
            this.label9.TabIndex = 246;
            this.label9.Text = "Calculo de utilidades";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 6);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(932, 507);
            this.label10.TabIndex = 245;
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
            // ibtnEditar
            // 
            this.ibtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnEditar.IconColor = System.Drawing.Color.Black;
            this.ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEditar.IconSize = 17;
            this.ibtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnEditar.Location = new System.Drawing.Point(382, 225);
            this.ibtnEditar.Name = "ibtnEditar";
            this.ibtnEditar.Size = new System.Drawing.Size(134, 21);
            this.ibtnEditar.TabIndex = 269;
            this.ibtnEditar.Text = "Editar";
            this.ibtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEditar.UseVisualStyleBackColor = true;
            this.ibtnEditar.Visible = false;
            this.ibtnEditar.Click += new System.EventHandler(this.ibtnEditar_Click);
            // 
            // ibtnLimpiar
            // 
            this.ibtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.ibtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLimpiar.IconSize = 17;
            this.ibtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnLimpiar.Location = new System.Drawing.Point(242, 225);
            this.ibtnLimpiar.Name = "ibtnLimpiar";
            this.ibtnLimpiar.Size = new System.Drawing.Size(134, 21);
            this.ibtnLimpiar.TabIndex = 270;
            this.ibtnLimpiar.Text = "Limpiar todo";
            this.ibtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLimpiar.UseVisualStyleBackColor = true;
            this.ibtnLimpiar.Visible = false;
            this.ibtnLimpiar.Click += new System.EventHandler(this.ibtnLimpiar_Click);
            // 
            // valorFlete
            // 
            this.valorFlete.HeaderText = "Valor de flete";
            this.valorFlete.Name = "valorFlete";
            this.valorFlete.ReadOnly = true;
            this.valorFlete.Width = 198;
            // 
            // totalGastos
            // 
            this.totalGastos.HeaderText = "Total de gastos";
            this.totalGastos.Name = "totalGastos";
            this.totalGastos.ReadOnly = true;
            this.totalGastos.Width = 198;
            // 
            // utilidadNeta
            // 
            this.utilidadNeta.HeaderText = "Utilidad neta";
            this.utilidadNeta.Name = "utilidadNeta";
            this.utilidadNeta.ReadOnly = true;
            this.utilidadNeta.Width = 198;
            // 
            // porcentajeUtilidad
            // 
            this.porcentajeUtilidad.HeaderText = "% de Utilidad";
            this.porcentajeUtilidad.Name = "porcentajeUtilidad";
            this.porcentajeUtilidad.ReadOnly = true;
            this.porcentajeUtilidad.Width = 197;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 519);
            this.Controls.Add(this.ibtnExcel);
            this.Controls.Add(this.gbGastos);
            this.Controls.Add(this.ibtnPDF);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.gbValorflete);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtIdFlete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.gbGastos.ResumeLayout(false);
            this.gbGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.gbValorflete.ResumeLayout(false);
            this.gbValorflete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnExcel;
        private System.Windows.Forms.GroupBox gbGastos;
        private System.Windows.Forms.ComboBox cbNoHosp;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbNoLlantas;
        private System.Windows.Forms.TextBox txtHospedaje;
        private System.Windows.Forms.TextBox txtParqueo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbNoAux;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.TextBox txtAuxilar;
        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAceite;
        private System.Windows.Forms.TextBox txtLlanta;
        private System.Windows.Forms.TextBox txtBateria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbVarios;
        private System.Windows.Forms.CheckBox cbProd;
        private System.Windows.Forms.CheckBox cbCamion;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton ibtnGuardar;
        private FontAwesome.Sharp.IconButton ibtnPDF;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.GroupBox gbValorflete;
        private System.Windows.Forms.TextBox textFleteMonto;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtIdFlete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pCamion;
        private FontAwesome.Sharp.IconButton ibtnLimpiar;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadNeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeUtilidad;
    }
}