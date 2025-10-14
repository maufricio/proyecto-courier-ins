namespace CapaPresentacion.Modales
{
    partial class mdfletesqueja
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
            this.dgvfletequeja = new System.Windows.Forms.DataGridView();
            this.IdFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelqueja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfletequeja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfletequeja
            // 
            this.dgvfletequeja.AllowUserToAddRows = false;
            this.dgvfletequeja.AllowUserToDeleteRows = false;
            this.dgvfletequeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfletequeja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFlete,
            this.IdCliente,
            this.IdMotorista,
            this.Placa,
            this.IdEstado});
            this.dgvfletequeja.Location = new System.Drawing.Point(12, 73);
            this.dgvfletequeja.Name = "dgvfletequeja";
            this.dgvfletequeja.ReadOnly = true;
            this.dgvfletequeja.RowHeadersWidth = 51;
            this.dgvfletequeja.RowTemplate.Height = 24;
            this.dgvfletequeja.Size = new System.Drawing.Size(754, 365);
            this.dgvfletequeja.TabIndex = 19;
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
            // labelqueja
            // 
            this.labelqueja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelqueja.Location = new System.Drawing.Point(12, 21);
            this.labelqueja.Name = "labelqueja";
            this.labelqueja.Size = new System.Drawing.Size(248, 38);
            this.labelqueja.TabIndex = 20;
            this.labelqueja.Text = "Fletes con Queja";
            // 
            // mdfletesqueja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.labelqueja);
            this.Controls.Add(this.dgvfletequeja);
            this.Name = "mdfletesqueja";
            this.Text = "mdfletesqueja";
            this.Load += new System.EventHandler(this.mdfletesqueja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfletequeja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfletequeja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.Label labelqueja;
    }
}