namespace CapaPresentacion
{
    partial class frmUtilidadesFletes
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.lbltotalvalor = new System.Windows.Forms.Label();
            this.lbltotalgastos = new System.Windows.Forms.Label();
            this.lbltotalutilidad = new System.Windows.Forms.Label();
            this.lblporcentajepromedio = new System.Windows.Forms.Label();
            this.btnrefrescar = new FontAwesome.Sharp.IconButton();
            this.btnGenerarPDF = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UtilidadNeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.IdFlete,
            this.NombreCliente,
            this.Placa,
            this.NombreMotorista,
            this.ValorFlete,
            this.TotalGastos,
            this.UtilidadNeta,
            this.PorcentajeUnidad,
            this.FechaRegistro});
            this.dgvdata.Location = new System.Drawing.Point(12, 233);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(1006, 246);
            this.dgvdata.TabIndex = 0;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.ItemHeight = 15;
            this.cbobusqueda.Location = new System.Drawing.Point(96, 29);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(121, 23);
            this.cbobusqueda.TabIndex = 1;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(223, 29);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(164, 21);
            this.txtbusqueda.TabIndex = 2;
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 18;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(441, 28);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(42, 23);
            this.btnlimpiarbuscador.TabIndex = 229;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(393, 28);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(42, 23);
            this.btnbuscar.TabIndex = 228;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lbltotalvalor
            // 
            this.lbltotalvalor.AutoSize = true;
            this.lbltotalvalor.Location = new System.Drawing.Point(523, 32);
            this.lbltotalvalor.Name = "lbltotalvalor";
            this.lbltotalvalor.Size = new System.Drawing.Size(112, 15);
            this.lbltotalvalor.TabIndex = 230;
            this.lbltotalvalor.Text = "Total valor de fletes";
            // 
            // lbltotalgastos
            // 
            this.lbltotalgastos.AutoSize = true;
            this.lbltotalgastos.Location = new System.Drawing.Point(523, 63);
            this.lbltotalgastos.Name = "lbltotalgastos";
            this.lbltotalgastos.Size = new System.Drawing.Size(73, 15);
            this.lbltotalgastos.TabIndex = 231;
            this.lbltotalgastos.Text = "Total gastos";
            // 
            // lbltotalutilidad
            // 
            this.lbltotalutilidad.AutoSize = true;
            this.lbltotalutilidad.Location = new System.Drawing.Point(523, 92);
            this.lbltotalutilidad.Name = "lbltotalutilidad";
            this.lbltotalutilidad.Size = new System.Drawing.Size(77, 15);
            this.lbltotalutilidad.TabIndex = 232;
            this.lbltotalutilidad.Text = "Total utilidad";
            // 
            // lblporcentajepromedio
            // 
            this.lblporcentajepromedio.AutoSize = true;
            this.lblporcentajepromedio.Location = new System.Drawing.Point(522, 122);
            this.lblporcentajepromedio.Name = "lblporcentajepromedio";
            this.lblporcentajepromedio.Size = new System.Drawing.Size(74, 15);
            this.lblporcentajepromedio.TabIndex = 233;
            this.lblporcentajepromedio.Text = "% promedio";
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnrefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefrescar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.ForeColor = System.Drawing.Color.White;
            this.btnrefrescar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnrefrescar.IconColor = System.Drawing.Color.White;
            this.btnrefrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnrefrescar.IconSize = 18;
            this.btnrefrescar.Location = new System.Drawing.Point(251, 87);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(136, 49);
            this.btnrefrescar.TabIndex = 235;
            this.btnrefrescar.Text = "Recargar Datos";
            this.btnrefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrefrescar.UseVisualStyleBackColor = false;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnGenerarPDF.ForeColor = System.Drawing.Color.White;
            this.btnGenerarPDF.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnGenerarPDF.IconColor = System.Drawing.Color.White;
            this.btnGenerarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarPDF.IconSize = 16;
            this.btnGenerarPDF.Location = new System.Drawing.Point(96, 88);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(136, 48);
            this.btnGenerarPDF.TabIndex = 234;
            this.btnGenerarPDF.Text = "Generar Reporte";
            this.btnGenerarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarPDF.UseVisualStyleBackColor = false;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 236;
            this.label2.Text = "Utilidades de Fletes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 237;
            this.label1.Text = "Buscar por:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnrefrescar);
            this.groupBox1.Controls.Add(this.cbobusqueda);
            this.groupBox1.Controls.Add(this.btnGenerarPDF);
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.btnlimpiarbuscador);
            this.groupBox1.Controls.Add(this.lbltotalvalor);
            this.groupBox1.Controls.Add(this.lblporcentajepromedio);
            this.groupBox1.Controls.Add(this.lbltotalgastos);
            this.groupBox1.Controls.Add(this.lbltotalutilidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 158);
            this.groupBox1.TabIndex = 238;
            this.groupBox1.TabStop = false;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Width = 45;
            // 
            // IdFlete
            // 
            this.IdFlete.HeaderText = "Id";
            this.IdFlete.Name = "IdFlete";
            this.IdFlete.Width = 50;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Width = 150;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Unidad";
            this.Placa.Name = "Placa";
            // 
            // NombreMotorista
            // 
            this.NombreMotorista.HeaderText = "Motorista";
            this.NombreMotorista.Name = "NombreMotorista";
            this.NombreMotorista.Width = 125;
            // 
            // ValorFlete
            // 
            this.ValorFlete.HeaderText = "Valor del Flete";
            this.ValorFlete.Name = "ValorFlete";
            // 
            // TotalGastos
            // 
            this.TotalGastos.HeaderText = "Total Gastos";
            this.TotalGastos.Name = "TotalGastos";
            // 
            // UtilidadNeta
            // 
            this.UtilidadNeta.HeaderText = "Utilidad Neta";
            this.UtilidadNeta.Name = "UtilidadNeta";
            // 
            // PorcentajeUnidad
            // 
            this.PorcentajeUnidad.HeaderText = "% de rentabilidad";
            this.PorcentajeUnidad.Name = "PorcentajeUnidad";
            this.PorcentajeUnidad.Width = 85;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            // 
            // frmUtilidadesFletes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvdata);
            this.Name = "frmUtilidadesFletes";
            this.Text = "frmUtilidadesFletes";
            this.Load += new System.EventHandler(this.frmUtilidadesFletes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.Label lbltotalvalor;
        private System.Windows.Forms.Label lbltotalgastos;
        private System.Windows.Forms.Label lbltotalutilidad;
        private System.Windows.Forms.Label lblporcentajepromedio;
        private FontAwesome.Sharp.IconButton btnrefrescar;
        private FontAwesome.Sharp.IconButton btnGenerarPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorFlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn UtilidadNeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}