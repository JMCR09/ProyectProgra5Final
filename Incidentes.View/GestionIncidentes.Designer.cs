namespace Incidentes.View
{
    partial class GestionIncidentes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionIncidentes));
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDatosEquipo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoEquipo = new System.Windows.Forms.TextBox();
            this.btbBuscar = new System.Windows.Forms.Button();
            this.txtDigNumPlaca = new System.Windows.Forms.TextBox();
            this.gpbDatosIncidente = new System.Windows.Forms.GroupBox();
            this.txtNumincidente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNivelIncidente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbIncidentes = new System.Windows.Forms.GroupBox();
            this.dtgIncidentes = new System.Windows.Forms.DataGridView();
            this.ctmCambiosIncidentes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbTipoIncidente = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbCerrados = new System.Windows.Forms.RadioButton();
            this.rdbAbiertos = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbRegresar = new System.Windows.Forms.Button();
            this.btbGuardar = new System.Windows.Forms.Button();
            this.gpbDatosEquipo.SuspendLayout();
            this.gpbDatosIncidente.SuspendLayout();
            this.gpbIncidentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIncidentes)).BeginInit();
            this.ctmCambiosIncidentes.SuspendLayout();
            this.gpbTipoIncidente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo para el manejo de incidentes";
            // 
            // gpbDatosEquipo
            // 
            this.gpbDatosEquipo.Controls.Add(this.label2);
            this.gpbDatosEquipo.Controls.Add(this.txtTipoEquipo);
            this.gpbDatosEquipo.Controls.Add(this.btbBuscar);
            this.gpbDatosEquipo.Controls.Add(this.txtDigNumPlaca);
            this.gpbDatosEquipo.Location = new System.Drawing.Point(12, 78);
            this.gpbDatosEquipo.Name = "gpbDatosEquipo";
            this.gpbDatosEquipo.Size = new System.Drawing.Size(333, 110);
            this.gpbDatosEquipo.TabIndex = 1;
            this.gpbDatosEquipo.TabStop = false;
            this.gpbDatosEquipo.Text = "Datos del equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de equipo:";
            // 
            // txtTipoEquipo
            // 
            this.txtTipoEquipo.Enabled = false;
            this.txtTipoEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoEquipo.Location = new System.Drawing.Point(9, 68);
            this.txtTipoEquipo.Name = "txtTipoEquipo";
            this.txtTipoEquipo.Size = new System.Drawing.Size(156, 26);
            this.txtTipoEquipo.TabIndex = 2;
            // 
            // btbBuscar
            // 
            this.btbBuscar.Location = new System.Drawing.Point(180, 19);
            this.btbBuscar.Name = "btbBuscar";
            this.btbBuscar.Size = new System.Drawing.Size(64, 20);
            this.btbBuscar.TabIndex = 0;
            this.btbBuscar.Text = "Buscar equipo";
            this.btbBuscar.UseVisualStyleBackColor = true;
            this.btbBuscar.Click += new System.EventHandler(this.btbBuscar_Click);
            // 
            // txtDigNumPlaca
            // 
            this.txtDigNumPlaca.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigNumPlaca.Location = new System.Drawing.Point(6, 19);
            this.txtDigNumPlaca.Name = "txtDigNumPlaca";
            this.txtDigNumPlaca.Size = new System.Drawing.Size(137, 20);
            this.txtDigNumPlaca.TabIndex = 1;
            this.txtDigNumPlaca.Text = "Digite el numero de placa aquí";
            this.txtDigNumPlaca.Click += new System.EventHandler(this.txtDigNumPlaca_Click);
            this.txtDigNumPlaca.TextChanged += new System.EventHandler(this.txtDigNumPlaca_TextChanged);
            this.txtDigNumPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigNumPlaca_KeyPress);
            // 
            // gpbDatosIncidente
            // 
            this.gpbDatosIncidente.Controls.Add(this.txtNumincidente);
            this.gpbDatosIncidente.Controls.Add(this.label9);
            this.gpbDatosIncidente.Controls.Add(this.txtDesc);
            this.gpbDatosIncidente.Controls.Add(this.label8);
            this.gpbDatosIncidente.Controls.Add(this.mskTelefono);
            this.gpbDatosIncidente.Controls.Add(this.label7);
            this.gpbDatosIncidente.Controls.Add(this.txtNombre);
            this.gpbDatosIncidente.Controls.Add(this.label6);
            this.gpbDatosIncidente.Controls.Add(this.cmbEstado);
            this.gpbDatosIncidente.Controls.Add(this.label5);
            this.gpbDatosIncidente.Controls.Add(this.cmbNivelIncidente);
            this.gpbDatosIncidente.Controls.Add(this.label4);
            this.gpbDatosIncidente.Controls.Add(this.dtmFecha);
            this.gpbDatosIncidente.Controls.Add(this.label3);
            this.gpbDatosIncidente.Location = new System.Drawing.Point(12, 212);
            this.gpbDatosIncidente.Name = "gpbDatosIncidente";
            this.gpbDatosIncidente.Size = new System.Drawing.Size(333, 279);
            this.gpbDatosIncidente.TabIndex = 2;
            this.gpbDatosIncidente.TabStop = false;
            this.gpbDatosIncidente.Text = "Datos Incidente";
            // 
            // txtNumincidente
            // 
            this.txtNumincidente.Enabled = false;
            this.txtNumincidente.Location = new System.Drawing.Point(114, 19);
            this.txtNumincidente.Name = "txtNumincidente";
            this.txtNumincidente.Size = new System.Drawing.Size(130, 20);
            this.txtNumincidente.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Numero de incidente:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(6, 203);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(301, 54);
            this.txtDesc.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Descripción del error:";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(98, 158);
            this.mskTelefono.Mask = "0000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(76, 20);
            this.mskTelefono.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre Cliente:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Abierto",
            "Cerrado"});
            this.cmbEstado.Location = new System.Drawing.Point(99, 100);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // cmbNivelIncidente
            // 
            this.cmbNivelIncidente.FormattingEnabled = true;
            this.cmbNivelIncidente.Items.AddRange(new object[] {
            "Bajo",
            "Medio",
            "Alto"});
            this.cmbNivelIncidente.Location = new System.Drawing.Point(98, 71);
            this.cmbNivelIncidente.Name = "cmbNivelIncidente";
            this.cmbNivelIncidente.Size = new System.Drawing.Size(121, 21);
            this.cmbNivelIncidente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nivel de incidente:";
            // 
            // dtmFecha
            // 
            this.dtmFecha.CustomFormat = "dd/MM/yyyy";
            this.dtmFecha.Enabled = false;
            this.dtmFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFecha.Location = new System.Drawing.Point(98, 45);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(110, 20);
            this.dtmFecha.TabIndex = 1;
            this.dtmFecha.Value = new System.DateTime(2023, 4, 20, 22, 46, 2, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Incidente:";
            // 
            // gpbIncidentes
            // 
            this.gpbIncidentes.Controls.Add(this.dtgIncidentes);
            this.gpbIncidentes.Location = new System.Drawing.Point(351, 78);
            this.gpbIncidentes.Name = "gpbIncidentes";
            this.gpbIncidentes.Size = new System.Drawing.Size(538, 345);
            this.gpbIncidentes.TabIndex = 3;
            this.gpbIncidentes.TabStop = false;
            this.gpbIncidentes.Text = "Incidentes Registrados";
            // 
            // dtgIncidentes
            // 
            this.dtgIncidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIncidentes.ContextMenuStrip = this.ctmCambiosIncidentes;
            this.dtgIncidentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgIncidentes.Location = new System.Drawing.Point(3, 16);
            this.dtgIncidentes.Name = "dtgIncidentes";
            this.dtgIncidentes.Size = new System.Drawing.Size(532, 326);
            this.dtgIncidentes.TabIndex = 0;
            // 
            // ctmCambiosIncidentes
            // 
            this.ctmCambiosIncidentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem});
            this.ctmCambiosIncidentes.Name = "ctmCambiosIncidentes";
            this.ctmCambiosIncidentes.Size = new System.Drawing.Size(127, 26);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // gpbTipoIncidente
            // 
            this.gpbTipoIncidente.Controls.Add(this.rdbTodos);
            this.gpbTipoIncidente.Controls.Add(this.rdbCerrados);
            this.gpbTipoIncidente.Controls.Add(this.rdbAbiertos);
            this.gpbTipoIncidente.Location = new System.Drawing.Point(351, 430);
            this.gpbTipoIncidente.Name = "gpbTipoIncidente";
            this.gpbTipoIncidente.Size = new System.Drawing.Size(538, 61);
            this.gpbTipoIncidente.TabIndex = 4;
            this.gpbTipoIncidente.TabStop = false;
            this.gpbTipoIncidente.Text = "Tipos de Incidente";
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(371, 22);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 2;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.Click += new System.EventHandler(this.rdbTodos_Click);
            // 
            // rdbCerrados
            // 
            this.rdbCerrados.AutoSize = true;
            this.rdbCerrados.Location = new System.Drawing.Point(234, 22);
            this.rdbCerrados.Name = "rdbCerrados";
            this.rdbCerrados.Size = new System.Drawing.Size(67, 17);
            this.rdbCerrados.TabIndex = 1;
            this.rdbCerrados.Text = "Cerrados";
            this.rdbCerrados.UseVisualStyleBackColor = true;
            this.rdbCerrados.Click += new System.EventHandler(this.rdbCerrados_Click);
            // 
            // rdbAbiertos
            // 
            this.rdbAbiertos.AutoSize = true;
            this.rdbAbiertos.Checked = true;
            this.rdbAbiertos.Location = new System.Drawing.Point(92, 22);
            this.rdbAbiertos.Name = "rdbAbiertos";
            this.rdbAbiertos.Size = new System.Drawing.Size(63, 17);
            this.rdbAbiertos.TabIndex = 0;
            this.rdbAbiertos.TabStop = true;
            this.rdbAbiertos.Text = "Abiertos";
            this.rdbAbiertos.UseVisualStyleBackColor = true;
            this.rdbAbiertos.Click += new System.EventHandler(this.rdbAbiertos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Incidentes.View.Properties.Resources.HelpDesk;
            this.pictureBox1.Location = new System.Drawing.Point(15, 497);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btbRegresar
            // 
            this.btbRegresar.Image = global::Incidentes.View.Properties.Resources.close;
            this.btbRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbRegresar.Location = new System.Drawing.Point(638, 506);
            this.btbRegresar.Name = "btbRegresar";
            this.btbRegresar.Size = new System.Drawing.Size(90, 60);
            this.btbRegresar.TabIndex = 6;
            this.btbRegresar.Text = "Regresar";
            this.btbRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbRegresar.UseVisualStyleBackColor = true;
            this.btbRegresar.Click += new System.EventHandler(this.btbRegresar_Click);
            // 
            // btbGuardar
            // 
            this.btbGuardar.Image = global::Incidentes.View.Properties.Resources.apply;
            this.btbGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbGuardar.Location = new System.Drawing.Point(486, 506);
            this.btbGuardar.Name = "btbGuardar";
            this.btbGuardar.Size = new System.Drawing.Size(90, 60);
            this.btbGuardar.TabIndex = 5;
            this.btbGuardar.Text = "Aplicar";
            this.btbGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbGuardar.UseVisualStyleBackColor = true;
            this.btbGuardar.Click += new System.EventHandler(this.btbGuardar_Click);
            // 
            // GestionIncidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btbRegresar);
            this.Controls.Add(this.btbGuardar);
            this.Controls.Add(this.gpbTipoIncidente);
            this.Controls.Add(this.gpbIncidentes);
            this.Controls.Add(this.gpbDatosIncidente);
            this.Controls.Add(this.gpbDatosEquipo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionIncidentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionIncidentes";
            this.Load += new System.EventHandler(this.GestionIncidentes_Load);
            this.gpbDatosEquipo.ResumeLayout(false);
            this.gpbDatosEquipo.PerformLayout();
            this.gpbDatosIncidente.ResumeLayout(false);
            this.gpbDatosIncidente.PerformLayout();
            this.gpbIncidentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIncidentes)).EndInit();
            this.ctmCambiosIncidentes.ResumeLayout(false);
            this.gpbTipoIncidente.ResumeLayout(false);
            this.gpbTipoIncidente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDatosEquipo;
        private System.Windows.Forms.Button btbBuscar;
        private System.Windows.Forms.TextBox txtDigNumPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoEquipo;
        private System.Windows.Forms.GroupBox gpbDatosIncidente;
        private System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNivelIncidente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumincidente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpbIncidentes;
        private System.Windows.Forms.DataGridView dtgIncidentes;
        private System.Windows.Forms.GroupBox gpbTipoIncidente;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbCerrados;
        private System.Windows.Forms.RadioButton rdbAbiertos;
        private System.Windows.Forms.Button btbGuardar;
        private System.Windows.Forms.Button btbRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip ctmCambiosIncidentes;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
    }
}