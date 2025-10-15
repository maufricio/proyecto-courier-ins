namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.dash = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.labelprogramado = new System.Windows.Forms.Label();
            this.dgvfleteprogramado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelqueja = new System.Windows.Forms.Label();
            this.dgvfletetranscurso = new System.Windows.Forms.DataGridView();
            this.IdFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfleteprogramado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfletetranscurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dash,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menuventas,
            this.menureportes});
            this.menu.Location = new System.Drawing.Point(0, 66);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1157, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.IconSize = 50;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(122, 69);
            this.menucompras.Text = "Mis Fletes";
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menucompras.Click += new System.EventHandler(this.menucompras_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 50;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(122, 69);
            this.menuclientes.Text = "Mis Clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 50;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(122, 69);
            this.menuproveedores.Text = "Mis Motoristas";
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 50;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(122, 69);
            this.menureportes.Text = "Reportes Utilidades";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // dash
            // 
            this.dash.AutoSize = false;
            this.dash.IconChar = FontAwesome.Sharp.IconChar.Diamond;
            this.dash.IconColor = System.Drawing.Color.Black;
            this.dash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dash.IconSize = 50;
            this.dash.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(122, 69);
            this.dash.Text = "Inicio";
            this.dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dash.Click += new System.EventHandler(this.dash_Click);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1157, 66);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            this.menutitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menutitulo_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transportes Orellana";
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.labelprogramado);
            this.contenedor.Controls.Add(this.dgvfleteprogramado);
            this.contenedor.Controls.Add(this.labelqueja);
            this.contenedor.Controls.Add(this.dgvfletetranscurso);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 139);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1157, 578);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // labelprogramado
            // 
            this.labelprogramado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprogramado.Location = new System.Drawing.Point(71, 39);
            this.labelprogramado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelprogramado.Name = "labelprogramado";
            this.labelprogramado.Size = new System.Drawing.Size(349, 24);
            this.labelprogramado.TabIndex = 21;
            this.labelprogramado.Text = "Próximos Fletes Programados";
            // 
            // dgvfleteprogramado
            // 
            this.dgvfleteprogramado.AllowUserToAddRows = false;
            this.dgvfleteprogramado.AllowUserToDeleteRows = false;
            this.dgvfleteprogramado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfleteprogramado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvfleteprogramado.Location = new System.Drawing.Point(75, 65);
            this.dgvfleteprogramado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvfleteprogramado.Name = "dgvfleteprogramado";
            this.dgvfleteprogramado.ReadOnly = true;
            this.dgvfleteprogramado.RowHeadersWidth = 51;
            this.dgvfleteprogramado.RowTemplate.Height = 24;
            this.dgvfleteprogramado.Size = new System.Drawing.Size(1051, 173);
            this.dgvfleteprogramado.TabIndex = 20;
            this.dgvfleteprogramado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfleteprogramado_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdFlete";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Motorista";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Placa Vehiculo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // labelqueja
            // 
            this.labelqueja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelqueja.Location = new System.Drawing.Point(71, 275);
            this.labelqueja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelqueja.Name = "labelqueja";
            this.labelqueja.Size = new System.Drawing.Size(344, 20);
            this.labelqueja.TabIndex = 19;
            this.labelqueja.Text = "Fletes en transcurso (Top 5)";
            // 
            // dgvfletetranscurso
            // 
            this.dgvfletetranscurso.AllowUserToAddRows = false;
            this.dgvfletetranscurso.AllowUserToDeleteRows = false;
            this.dgvfletetranscurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfletetranscurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFlete,
            this.IdCliente,
            this.IdMotorista,
            this.Placa,
            this.IdEstado});
            this.dgvfletetranscurso.Location = new System.Drawing.Point(75, 297);
            this.dgvfletetranscurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvfletetranscurso.Name = "dgvfletetranscurso";
            this.dgvfletetranscurso.ReadOnly = true;
            this.dgvfletetranscurso.RowHeadersWidth = 51;
            this.dgvfletetranscurso.RowTemplate.Height = 24;
            this.dgvfletetranscurso.Size = new System.Drawing.Size(1051, 209);
            this.dgvfletetranscurso.TabIndex = 18;
            this.dgvfletetranscurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfletequeja_CellClick);
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
            this.IdMotorista.Width = 250;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa Vehiculo";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 200;
            // 
            // IdEstado
            // 
            this.IdEstado.HeaderText = "Estado";
            this.IdEstado.MinimumWidth = 6;
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            this.IdEstado.Width = 250;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.LogoCanal;
            this.pictureBox1.Location = new System.Drawing.Point(1086, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 50;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(122, 69);
            this.menuventas.Text = "Mis Unidades";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuventas.Click += new System.EventHandler(this.menuventas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 717);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Gestión Transportes Orellana";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfleteprogramado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfletetranscurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelprogramado;
        private System.Windows.Forms.DataGridView dgvfleteprogramado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label labelqueja;
        private System.Windows.Forms.DataGridView dgvfletetranscurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private FontAwesome.Sharp.IconMenuItem dash;
        private FontAwesome.Sharp.IconMenuItem menuventas;
    }
}

