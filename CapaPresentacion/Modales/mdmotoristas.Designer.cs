namespace CapaPresentacion.Modales
{
    partial class mdmotoristas
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
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscarmotorista = new FontAwesome.Sharp.IconButton();
            this.txtbmotorista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvmotorista = new System.Windows.Forms.DataGridView();
            this.IdMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmotorista)).BeginInit();
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
            this.cbobusqueda.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Location = new System.Drawing.Point(91, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 106;
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
            this.btnlimpiarbuscador.TabIndex = 105;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscarmotorista
            // 
            this.btnbuscarmotorista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbuscarmotorista.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarmotorista.IconColor = System.Drawing.Color.Black;
            this.btnbuscarmotorista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarmotorista.IconSize = 18;
            this.btnbuscarmotorista.Location = new System.Drawing.Point(545, 58);
            this.btnbuscarmotorista.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarmotorista.Name = "btnbuscarmotorista";
            this.btnbuscarmotorista.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnbuscarmotorista.Size = new System.Drawing.Size(52, 28);
            this.btnbuscarmotorista.TabIndex = 104;
            this.btnbuscarmotorista.UseVisualStyleBackColor = false;
            this.btnbuscarmotorista.Click += new System.EventHandler(this.btnbuscarmotorista_Click);
            // 
            // txtbmotorista
            // 
            this.txtbmotorista.Location = new System.Drawing.Point(382, 61);
            this.txtbmotorista.Name = "txtbmotorista";
            this.txtbmotorista.Size = new System.Drawing.Size(156, 22);
            this.txtbmotorista.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 31);
            this.label2.TabIndex = 102;
            this.label2.Text = "Lista de Motoristas";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(-6, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 98);
            this.label1.TabIndex = 101;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvmotorista
            // 
            this.dgvmotorista.AllowUserToAddRows = false;
            this.dgvmotorista.AllowUserToDeleteRows = false;
            this.dgvmotorista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvmotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmotorista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMotorista,
            this.NombreMotorista,
            this.Correo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmotorista.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvmotorista.Location = new System.Drawing.Point(12, 110);
            this.dgvmotorista.MultiSelect = false;
            this.dgvmotorista.Name = "dgvmotorista";
            this.dgvmotorista.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmotorista.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvmotorista.RowHeadersWidth = 51;
            this.dgvmotorista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvmotorista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvmotorista.RowTemplate.Height = 24;
            this.dgvmotorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmotorista.Size = new System.Drawing.Size(655, 328);
            this.dgvmotorista.TabIndex = 108;
            this.dgvmotorista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmotorista_CellDoubleClick);
            // 
            // IdMotorista
            // 
            this.IdMotorista.HeaderText = "IdMotorista";
            this.IdMotorista.MinimumWidth = 6;
            this.IdMotorista.Name = "IdMotorista";
            this.IdMotorista.ReadOnly = true;
            this.IdMotorista.Visible = false;
            this.IdMotorista.Width = 125;
            // 
            // NombreMotorista
            // 
            this.NombreMotorista.HeaderText = "Nombre del motorista";
            this.NombreMotorista.MinimumWidth = 6;
            this.NombreMotorista.Name = "NombreMotorista";
            this.NombreMotorista.ReadOnly = true;
            this.NombreMotorista.Width = 250;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo Electronico";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 250;
            // 
            // mdmotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.dgvmotorista);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscarmotorista);
            this.Controls.Add(this.txtbmotorista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mdmotoristas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdmotoristas";
            this.Load += new System.EventHandler(this.mdmotoristas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmotorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscarmotorista;
        private System.Windows.Forms.TextBox txtbmotorista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvmotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}