using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Incidentes.Controller;



namespace Incidentes.View
{
    public partial class GestionIncidentes : Form
    {
        private DataTable datos;
        private Equipos equipos;
        private EquiposHelper equiposH;
        private IncidentesHelper incidentesH;
        private Controller.Incidentes incidentes;

        bool flag = false;


        public GestionIncidentes()
        {
            InitializeComponent();
        }



        private void GestionIncidentes_Load(object sender, EventArgs e)
        {
            cmbEstado.SelectedIndex = 0;
            listar();
        }

        //Listar incidentes --Jose Miguel Salas Chacon
        private void listar()
        {
            
            try
            {
                this.incidentes = new Controller.Incidentes();

                this.incidentes.Opc = 1;
                this.incidentesH = new IncidentesHelper(incidentes);
                datos = this.incidentesH.Listar();

                if (datos != null)
                {
                    this.dtgIncidentes.DataSource = this.datos;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtDigNumPlaca_TextChanged(object sender, EventArgs e)
        {



            txtDigNumPlaca.Font = new Font("Arial", 12, FontStyle.Regular);

            if (string.IsNullOrEmpty(txtDigNumPlaca.Text))
            {
                txtDigNumPlaca.Font = new Font("Arial", 8, FontStyle.Regular);
            }
            else
            {

            }
        }

        //Borrar el texto con el evento clic --Jose Miguel Salas Chacon
        private void txtDigNumPlaca_Click(object sender, EventArgs e)
        {
            this.txtDigNumPlaca.Text = "";
        }

        private void btbBuscar_Click(object sender, EventArgs e)
        {
            BuscarPlaca();

        }

        //Busca la placa del equipo y concatena --Jose Miguel Salas Chacon
        private void BuscarPlaca()
        {

            try
            {
                string DatoDigitado = txtDigNumPlaca.Text;
                //MessageBox.Show(DatoDigitado);


                //IF
                if(DatoDigitado == "Digite el numero de placa aquí" || string.IsNullOrEmpty(DatoDigitado))
                {
                    MessageBox.Show("No ha ingresado el numero de placa");

                }

                else
                {

                    //MessageBox.Show(DatoDigitado);
                    this.equipos = new Equipos();
                    this.equipos.Placa = int.Parse(DatoDigitado);

                    this.equiposH = new EquiposHelper(equipos);
                    bool resultado = this.equiposH.BuscarPlaca(int.Parse(DatoDigitado));


                    if (resultado == true)
                    {

                        this.equipos = new Equipos();
                        this.equiposH = new EquiposHelper(equipos);
                        this.equiposH.SeleccionaTipo(DatoDigitado);
                        txtTipoEquipo.Text = this.equiposH.SeleccionaTipo(DatoDigitado);

                        // Obtener el tipo de equipo y la primer letra
                        string tipoEquipo = this.equiposH.SeleccionaTipo(DatoDigitado);
                        char primeraLetra = tipoEquipo[0];

                        // Generar cuatro números aleatorios
                        Random rnd = new Random();
                        int aleatorio = rnd.Next(1000, 9999);

                        // Concatenar la primer letra, el símbolo "-" y los cuatro números aleatorios
                        string resultadoFinal = $"{primeraLetra}-{aleatorio}";


                        // Asignar el resultado final al atributo Text del TextBox
                        txtNumincidente.Text = resultadoFinal;

                    }
                    else
                    {
                        MessageBox.Show("El equipo no esta registrado");
                    }

                    
                }
                //End IF

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btbRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Al darle clic me muestra los incidentes abiertos --Jose Miguel Salas Chacon
        private void rdbAbiertos_Click(object sender, EventArgs e)
        {
            try
            {
                this.incidentes = new Controller.Incidentes();

                this.incidentes.Opc = 1;
                this.incidentesH = new IncidentesHelper(incidentes);
                datos = this.incidentesH.Listar();

                if (datos != null)
                {
                    this.dtgIncidentes.DataSource = this.datos;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Al darle clic me muestra los incidentes Cerrados --Jose Miguel Salas Chacon
        private void rdbCerrados_Click(object sender, EventArgs e)
        {
            try
            {
                this.incidentes = new Controller.Incidentes();

                this.incidentes.Opc = 2;
                this.incidentesH = new IncidentesHelper(incidentes);
                datos = this.incidentesH.Listar();

                if (datos != null)
                {
                    this.dtgIncidentes.DataSource = this.datos;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //Al darle clic me muestra todos los incidentes --Jose Miguel Salas Chacon
        private void rdbTodos_Click(object sender, EventArgs e)
        {
            try
            {
                this.incidentes = new Controller.Incidentes();

                this.incidentes.Opc = 3;
                this.incidentesH = new IncidentesHelper(incidentes);
                datos = this.incidentesH.Listar();

                if (datos != null)
                {
                    this.dtgIncidentes.DataSource = this.datos;
                }


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
                int indice = this.dtgIncidentes.CurrentRow.Index;
                DataRow fila = datos.Rows[indice];
                
                this.datos = (DataTable)this.dtgIncidentes.DataSource;
                string validaEstado = fila["Estado"].ToString();
                
                if(validaEstado == "Cerrado")
                {
                    MessageBox.Show("No se puede actualizar un incidente cerrado");
                }
                else
                {
                    if (datos == null)
                        MessageBox.Show("No hay contactos para mostrar");
                    else
                    {
                        //int indice = this.dtgIncidentes.CurrentRow.Index;
                        //DataRow fila = datos.Rows[indice];
                        this.cmbEstado.Enabled = true;

                        this.txtNumincidente.Text = fila["NumIncidente"].ToString();
                        this.cmbNivelIncidente.Text = fila["NivelIncidente"].ToString();
                        this.cmbEstado.Text = fila["Estado"].ToString();
                        this.txtNombre.Text = fila["NombreCliente"].ToString();
                        this.mskTelefono.Text = fila["Telefono"].ToString();
                        this.txtDesc.Text = fila["DescError"].ToString();
                        flag = true;


                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
     
    }

        //Dispara las opciones del boton aceptar --Jose Miguel Salas Chacon
        private void btbGuardar_Click(object sender, EventArgs e)
        {
           
            //Reviso si hay algo para insertar o actualizar
          if(txtNumincidente.Text.Length == 0)
            {
                MessageBox.Show("Debe buscar un equipo para registrar un incidente");
            }
          
          if (flag == true)
            {
                actualizar();
                MessageBox.Show("Se actualizó el registro de forma éxitosa");
                listar();
                Limpiar();
                flag = false;
                this.cmbEstado.Enabled = false;
                
            }
          else
            {
                insertarIncidente();
                Limpiar();
            }


        }

        private void Limpiar()
        {
            this.txtNumincidente.Text = "";
            this.cmbNivelIncidente.SelectedIndex = -1;
            this.cmbNivelIncidente.Text = "";
            this.txtNombre.Text = "";
            this.mskTelefono.Text = "";
            this.txtDesc.Text = "";
            this.cmbEstado.Text = "Abierto";

        }

        /*
         * Se envia la instruccion actualizar a la base de datos posterior de 
           cargar los registros y modidificarlos --Jose Miguel Salas Chacon
         */

        private void insertarIncidente()
        {
            try
            {
                this.incidentes = new Controller.Incidentes();
                this.incidentes.NumIncidente = this.txtNumincidente.Text;
                this.incidentes.Fecha = this.dtmFecha.Value;
                this.incidentes.NivelIncidente = this.cmbNivelIncidente.Text;
                this.incidentes.Estado = this.cmbEstado.Text;
                this.incidentes.NombreCliente = this.txtNombre.Text;
                this.incidentes.Telefono = this.mskTelefono.Text;
                this.incidentes.DescError = this.txtDesc.Text;
                this.incidentes.Opc = 4;

                this.incidentesH = new IncidentesHelper(incidentes);
                this.incidentesH.Insertar();

                MessageBox.Show("Se registró el incidente de forma éxitosa");

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
                this.incidentes = new Controller.Incidentes();
                this.incidentes.NumIncidente = this.txtNumincidente.Text;
                this.incidentes.Fecha = this.dtmFecha.Value;
                this.incidentes.NivelIncidente = this.cmbNivelIncidente.Text;
                this.incidentes.Estado = this.cmbEstado.Text;
                this.incidentes.NombreCliente = this.txtNombre.Text;
                this.incidentes.Telefono = this.mskTelefono.Text;
                this.incidentes.DescError = this.txtDesc.Text;
                this.incidentes.Opc = 5;

                this.incidentesH = new IncidentesHelper(incidentes);
                this.incidentesH.Guardar_Actualizar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtDigNumPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Detener la entrada del carácter
            }
        }
    }
}
