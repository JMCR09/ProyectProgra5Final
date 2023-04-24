namespace Incidentes.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeOrdenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeIncidentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeProgramaIncidentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusUser = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeOrdenadoresToolStripMenuItem,
            this.gestionDeIncidentesToolStripMenuItem,
            this.gestionDeUsuariosToolStripMenuItem});
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modulosToolStripMenuItem.Text = "Modulos";
            // 
            // gestionDeOrdenadoresToolStripMenuItem
            // 
            this.gestionDeOrdenadoresToolStripMenuItem.Name = "gestionDeOrdenadoresToolStripMenuItem";
            this.gestionDeOrdenadoresToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestionDeOrdenadoresToolStripMenuItem.Text = "Gestion de Equipos";
            this.gestionDeOrdenadoresToolStripMenuItem.Click += new System.EventHandler(this.gestionDeOrdenadoresToolStripMenuItem_Click);
            // 
            // gestionDeIncidentesToolStripMenuItem
            // 
            this.gestionDeIncidentesToolStripMenuItem.Name = "gestionDeIncidentesToolStripMenuItem";
            this.gestionDeIncidentesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestionDeIncidentesToolStripMenuItem.Text = "Gestion de Incidentes";
            this.gestionDeIncidentesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeIncidentesToolStripMenuItem_Click);
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeProgramaIncidentesToolStripMenuItem,
            this.manualDeUsoToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeProgramaIncidentesToolStripMenuItem
            // 
            this.acercaDeProgramaIncidentesToolStripMenuItem.Name = "acercaDeProgramaIncidentesToolStripMenuItem";
            this.acercaDeProgramaIncidentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeProgramaIncidentesToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeProgramaIncidentesToolStripMenuItem.Click += new System.EventHandler(this.acercaDeProgramaIncidentesToolStripMenuItem_Click);
            // 
            // manualDeUsoToolStripMenuItem
            // 
            this.manualDeUsoToolStripMenuItem.Name = "manualDeUsoToolStripMenuItem";
            this.manualDeUsoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualDeUsoToolStripMenuItem.Text = "Manual de Uso";
            this.manualDeUsoToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // statusUser
            // 
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(102, 22);
            this.statusUser.Text = "Conectado como:";
            this.statusUser.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Incidentes.View.Properties.Resources.FondoIMG2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeOrdenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeIncidentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeProgramaIncidentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel statusUser;
    }
}

