using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Incidentes.Controller;

namespace Incidentes.View
{
    public partial class GestionUsuarios : Form
    {
        private Usuarios usuarios;
        private UsuariosHelper usuariosH;
        private DataTable datos;




        public GestionUsuarios()
        {
            InitializeComponent();
        }



        private void GestionUsuarios_Load(object sender, EventArgs e)
        {

            listar();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (this.mskCedula.ReadOnly)
                actualizar();
            else
               agregar();
               listar();
               limpiar();


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            this.txtNombre.Clear();
            this.mskCedula.Clear();
            this.txtUsuario.Clear();
            this.txtClave.Clear();
            this.cmbPerfil.SelectedIndex = -1;
            this.mskCedula.ReadOnly = false;
        }


        private void listar()
        {
            try
            {
                this.usuarios = new Usuarios();
                this.usuarios.Opc = 1;

                this.usuariosH = new UsuariosHelper(usuarios);
                datos = this.usuariosH.Listar();
                if (datos != null)
                {
                    this.dtgUsuarios.DataSource = this.datos;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void agregar()
        {
            try
            {
                this.usuarios = new Usuarios();
                this.usuarios.Nombre = this.txtNombre.Text;
                this.usuarios.Cedula = this.mskCedula.Text;
                this.usuarios.Usuario = this.txtUsuario.Text;
                this.usuarios.Clave = this.txtClave.Text;
                this.usuarios.Perfil = this.cmbPerfil.Text;
                this.usuarios.Opc = 3;

                this.usuariosH = new UsuariosHelper(usuarios);
                this.usuariosH.Guardar_Actualizar();
                MessageBox.Show("Se guardó el usuario");
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
                this.usuarios = new Usuarios();
                this.usuarios.Nombre = this.txtNombre.Text;
                this.usuarios.Cedula = this.mskCedula.Text;
                this.usuarios.Usuario = this.txtUsuario.Text;
                this.usuarios.Clave = this.txtClave.Text;
                this.usuarios.Perfil = this.cmbPerfil.Text;
                this.usuarios.Opc = 4;

                this.usuariosH = new UsuariosHelper(usuarios);
                this.usuariosH.Guardar_Actualizar();
                MessageBox.Show("Se actualizó el usuario");
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
                this.datos = (DataTable)this.dtgUsuarios.DataSource;
                if (datos == null)
                {
                    MessageBox.Show("No hay usuarios para mostrar");
                }
                else
                {
                    int indice = this.dtgUsuarios.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    this.txtNombre.Text = fila["nombre"].ToString();
                    this.mskCedula.Text = fila["cedula"].ToString();
                    this.txtUsuario.Text = fila["usuario"].ToString();
                    this.txtClave.Text = fila["clave"].ToString();
                    this.cmbPerfil.Text = fila["perfil"].ToString();
                    this.mskCedula.ReadOnly = true;


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
                 this.datos = (DataTable)this.dtgUsuarios.DataSource;
                 if (datos== null)
                    MessageBox.Show("No hay usuarios para eliminar");
                 else
                 {
                     int indice = this.dtgUsuarios.CurrentRow.Index;
                     DataRow fila = datos.Rows[indice];
                     this.usuarios = new Usuarios();
                     this.usuarios.Cedula = fila["cedula"].ToString();
                     this.usuarios.Opc = 5;

                     this.usuariosH = new UsuariosHelper(usuarios);
                     this.usuariosH.Eliminar();
                     listar();
                 }


             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
            
        }
    }
    }
