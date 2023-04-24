using Incidentes.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incidentes.View
{
    public partial class Principal : Form
    {
 
        private GestionEquipos gestionEquipos;
        private GestionIncidentes gestionIncidentes;
        private GestionUsuarios gestionUsuarios;
        private AcercaDe acercaDe;

        public Principal()
        {
            InitializeComponent();
            toolStrip1.Visible = false;

        }
        //public Principal(Usuarios user)
        //{
        //    InitializeComponent();
        //    this.statusUser.Text = "Conectado como: " + user.Usuario;

        //}

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gestionEquipos = null;
            this.gestionUsuarios = null;
            this.gestionIncidentes = null;
            Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionDeOrdenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gestionEquipos = new GestionEquipos();
            this.gestionEquipos.MdiParent = this;
            this.gestionEquipos.Show();
        }

        private void gestionDeIncidentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gestionIncidentes = new GestionIncidentes(); 
            this.gestionIncidentes.MdiParent = this;
            this.gestionIncidentes.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true; // Cancela el evento de cierre
            }

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gestionUsuarios = new GestionUsuarios();
            this.gestionUsuarios.MdiParent = this;
            this.gestionUsuarios.Show();
        }

        private void acercaDeProgramaIncidentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.acercaDe = new AcercaDe();
            this.acercaDe.MdiParent = this;
            this.acercaDe.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void manualDeUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "Manual_Usuario.html"; 
            string filePath = Path.Combine(Application.StartupPath, fileName);

            // Verificar que el archivo exista
            if (File.Exists(filePath))
            {
                // Abrir el archivo en el navegador web predeterminado del usuario.
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("El archivo no se encuentra en la raíz del proyecto.");
            }


        }
    }
}
