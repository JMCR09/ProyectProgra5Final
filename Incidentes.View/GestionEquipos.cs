using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Incidentes.Controller;

namespace Incidentes.View
{
    public partial class GestionEquipos : Form
    {
        private Equipos equipos;
        private EquiposHelper equiposH;
        private DataTable datos;
       

        public GestionEquipos()
        {
            InitializeComponent();
        }

        private void GestionEquipos_Load(object sender, EventArgs e)
        {
            listar();        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.mskPlaca.ReadOnly)
                actualizar();
            else
            agragar();
            listar();
            limpiar();

        }
        private void limpiar()
        {
            this.mskPlaca.Clear();
            this.cmbTipo.SelectedIndex = -1;
            this.cmbEstado.SelectedIndex = -1;
            this.txtUbicacion.Clear();
            this.mskPlaca.ReadOnly = false;

        }
        private void listar()
        {
            try
            {
                this.equipos = new Equipos();
                this.equipos.Opc = 1;
                this.equiposH = new EquiposHelper(equipos);
                datos = this.equiposH.Listar();

                if (datos != null)
                {
                    this.dtgEquipos.DataSource = this.datos;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


          private void agragar()
          {
             try
             {
                this.equipos = new Equipos();
                this.equipos.Placa = int.Parse(this.mskPlaca.Text);
                this.equipos.Tipo = this.cmbTipo.Text;
                this.equipos.Estado = this.cmbEstado.Text;
                this.equipos.Ubicacion = this.txtUbicacion.Text;
                this.equipos.Opc = 2;

                this.equiposH = new EquiposHelper(equipos);
                this.equiposH.Guardar_Actualizar();
                MessageBox.Show("Se guardo el equipo");

             }
              catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }

          }

        private void actualizar()
        {

            try
            {
                this.equipos = new Equipos();
                this.equipos.Placa = int.Parse(this.mskPlaca.Text);
                this.equipos.Tipo = this.cmbTipo.Text;
                this.equipos.Estado = this.cmbEstado.Text;
                this.equipos.Ubicacion = this.txtUbicacion.Text;
                this.equipos.Opc = 3;

                this.equiposH = new EquiposHelper(equipos);
                this.equiposH.Guardar_Actualizar();
                MessageBox.Show("Se actualizo el equipo");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


       

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.datos = (DataTable)this.dtgEquipos.DataSource;
                if(datos == null)

                MessageBox.Show("No hay equipos para actualizar");
                else
                {

                    int indice = this.dtgEquipos.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    this.mskPlaca.Text = fila["placa"].ToString();
                    this.cmbTipo.Text = fila["tipo"].ToString();
                    this.cmbEstado.Text = fila["estado"].ToString();
                    this.txtUbicacion.Text = fila["ubicacion"].ToString();
                    this.mskPlaca.ReadOnly = true;

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
  
        
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.datos = (DataTable)this.dtgEquipos.DataSource;
                if (datos == null)
                MessageBox.Show("No hay equipos para actualizar");


                else
                {

                    int indice = this.dtgEquipos.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    this.equipos = new Equipos();
                    this.equipos.Placa = int.Parse(fila["placa"].ToString());
                    this.equipos.Opc = 4;

                    this.equiposH = new EquiposHelper(equipos);
                    this.equiposH.Eliminar();

                    listar();

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        
        
        
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mskPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}
