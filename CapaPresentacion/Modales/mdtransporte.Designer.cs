namespace CapaPresentacion.Modales
{
    partial class mdtransporte
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
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscartransporte = new FontAwesome.Sharp.IconButton();
            this.txtbtransporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtransporte = new System.Windows.Forms.DataGridView();
            this.IdUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransporte)).BeginInit();
            this.SuspendLayout();
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(222, 61);
            this.cbobusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(153, 24);
            this.cbobusqueda.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Location = new System.Drawing.Point(91, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 99;
            this.label11.Text = "Buscar por:";
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
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(605, 58);
            this.btnlimpiarbuscador.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(43, 28);
            this.btnlimpiarbuscador.TabIndex = 98;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscartransporte
            // 
            this.btnbuscartransporte.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbuscartransporte.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscartransporte.IconColor = System.Drawing.Color.Black;
            this.btnbuscartransporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscartransporte.IconSize = 18;
            this.btnbuscartransporte.Location = new System.Drawing.Point(545, 58);
            this.btnbuscartransporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscartransporte.Name = "btnbuscartransporte";
            this.btnbuscartransporte.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnbuscartransporte.Size = new System.Drawing.Size(52, 28);
            this.btnbuscartransporte.TabIndex = 97;
            this.btnbuscartransporte.UseVisualStyleBackColor = false;
            this.btnbuscartransporte.Click += new System.EventHandler(this.btnbuscartransporte_Click);
            // 
            // txtbtransporte
            // 
            this.txtbtransporte.Location = new System.Drawing.Point(382, 61);
            this.txtbtransporte.Name = "txtbtransporte";
            this.txtbtransporte.Size = new System.Drawing.Size(156, 22);
            this.txtbtransporte.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 31);
            this.label2.TabIndex = 95;
            this.label2.Text = "Lista de Transportes";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(-6, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 98);
            this.label1.TabIndex = 94;
            // 
            // dgvtransporte
            // 
            this.dgvtransporte.AllowUserToAddRows = false;
            this.dgvtransporte.AllowUserToDeleteRows = false;
            this.dgvtransporte.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtransporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUnidad,
            this.Placa,
            this.Marca});
            this.dgvtransporte.Location = new System.Drawing.Point(12, 110);
            this.dgvtransporte.MultiSelect = false;
            this.dgvtransporte.Name = "dgvtransporte";
            this.dgvtransporte.ReadOnly = true;
            this.dgvtransporte.RowHeadersWidth = 51;
            this.dgvtransporte.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvtransporte.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvtransporte.RowTemplate.Height = 24;
            this.dgvtransporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtransporte.Size = new System.Drawing.Size(655, 328);
            this.dgvtransporte.TabIndex = 101;
            this.dgvtransporte.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtransporte_CellDoubleClick);
            // 
            // IdUnidad
            // 
            this.IdUnidad.HeaderText = "IdUnidad";
            this.IdUnidad.MinimumWidth = 6;
            this.IdUnidad.Name = "IdUnidad";
            this.IdUnidad.ReadOnly = true;
            this.IdUnidad.Visible = false;
            this.IdUnidad.Width = 125;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 200;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 200;
            // 
            // mdtransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.dgvtransporte);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscartransporte);
            this.Controls.Add(this.txtbtransporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mdtransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdtransporte";
            this.Load += new System.EventHandler(this.mdtransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscartransporte;
        private System.Windows.Forms.TextBox txtbtransporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
    }
}