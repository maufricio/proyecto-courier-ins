namespace CapaPresentacion.Modales
{
    partial class mdfletesprogramado
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
            this.labelqueja = new System.Windows.Forms.Label();
            this.dgvfleteprogramado = new System.Windows.Forms.DataGridView();
            this.IdFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfleteprogramado)).BeginInit();
            this.SuspendLayout();
            // 
            // labelqueja
            // 
            this.labelqueja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelqueja.Location = new System.Drawing.Point(23, 17);
            this.labelqueja.Name = "labelqueja";
            this.labelqueja.Size = new System.Drawing.Size(302, 38);
            this.labelqueja.TabIndex = 22;
            this.labelqueja.Text = "Fletes Programados";
            this.labelqueja.Click += new System.EventHandler(this.labelqueja_Click);
            // 
            // dgvfleteprogramado
            // 
            this.dgvfleteprogramado.AllowUserToAddRows = false;
            this.dgvfleteprogramado.AllowUserToDeleteRows = false;
            this.dgvfleteprogramado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfleteprogramado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFlete,
            this.IdCliente,
            this.IdMotorista,
            this.Placa,
            this.IdEstado});
            this.dgvfleteprogramado.Location = new System.Drawing.Point(23, 69);
            this.dgvfleteprogramado.Name = "dgvfleteprogramado";
            this.dgvfleteprogramado.ReadOnly = true;
            this.dgvfleteprogramado.RowHeadersWidth = 51;
            this.dgvfleteprogramado.RowTemplate.Height = 24;
            this.dgvfleteprogramado.Size = new System.Drawing.Size(754, 365);
            this.dgvfleteprogramado.TabIndex = 21;
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
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Cliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 250;
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
            this.IdEstado.Width = 125;
            // 
            // mdfletesprogramado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelqueja);
            this.Controls.Add(this.dgvfleteprogramado);
            this.Name = "mdfletesprogramado";
            this.Text = "mdfletesprogramado";
            this.Load += new System.EventHandler(this.mdfletesprogramado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfleteprogramado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelqueja;
        private System.Windows.Forms.DataGridView dgvfleteprogramado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
    }
}