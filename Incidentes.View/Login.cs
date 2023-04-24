using Controlador;
using Incidentes.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Incidentes.Controller;

namespace Incidentes.View
{
    public partial class Login : Form
    {

        Usuarios usuario;
        UsuariosHelper usuarioH;
        DataTable datos;
        Principal principal;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string NombreUsuario
        {
            get { return txtUsuario.Text; }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtUsuario.Text != "" && this.txtClave.Text != "")
                {
                    this.usuario = new Usuarios();
                    this.usuario.Usuario = this.txtUsuario.Text;
                    this.usuario.Clave = this.txtClave.Text;
                    this.usuario.Opc = 1;

                    this.usuarioH = new UsuariosHelper(usuario);
                    datos = this.usuarioH.validarLogin();
                    if (datos.Rows.Count > 0)
                    {
                        DataRow fila = datos.Rows[0];
                        this.usuario.Usuario = fila["nombre"].ToString();
                        this.usuario.Perfil = fila["perfil"].ToString();
                        Principal inicio = new Principal();
                        inicio.statusUser.Text = "Conectado como:" + " " + txtUsuario.Text;
                        inicio.Show();
                        this.Hide();

                        


                    }
                    else MessageBox.Show("Datos de inicio de sesión inválidos");
                }
                else MessageBox.Show("Debe llenar todos los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
