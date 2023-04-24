using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Incidentes.Model;

namespace Incidentes.Controller
{
    public class EquiposHelper
    {
        Datos cnGeneral = null;
        Equipos objEquipo = null;
        DataTable tblDatos = null;


        public EquiposHelper(Equipos parObjEquipo)
        {
            objEquipo = parObjEquipo;
        }

        #region //Realizo un llamado al SP para saber si existe el equipo
        public bool  BuscarPlaca(int placa)
        {

            try
            {
                //using (SqlConnection conexion = new SqlConnection("Data Source = ProyecProgra5; Initial Catalog = Incidentes; Integrated Security = SSPI"))
                Datos datos = new Datos();
                string conn = datos.Conexion();
               


                using (SqlConnection conexion = new SqlConnection(conn))
                {
                    SqlCommand comando = new SqlCommand("SPBuscarEquipo", conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@valorBusqueda", placa);
                    SqlParameter existeRegistroParam = new SqlParameter("@existeRegistro", System.Data.SqlDbType.Bit);
                    existeRegistroParam.Direction = System.Data.ParameterDirection.Output;
                    comando.Parameters.Add(existeRegistroParam);

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    bool existeRegistro = (bool)existeRegistroParam.Value;
                    return existeRegistro;
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción aquí
                // Por ejemplo, puedes imprimir el mensaje de error en la consola
                Console.WriteLine($"Error al buscar placa: {ex.Message}");
                return false; // O devuelve un valor predeterminado, según lo que sea apropiado para tu caso de uso
            }
        }
        #endregion

        #region //Traigo el tipo de equipo para quemarlo en la variable TXTTipo
        public string SeleccionaTipo(string placa)
        {
            Datos datos = new Datos();
            string conn = datos.Conexion();

            try
            {
                using (SqlConnection conexion = new SqlConnection(conn))
                {
                    SqlCommand comando = new SqlCommand("SELECT TIPO FROM dbo.Equipos WHERE placa = @valorBusqueda", conexion);
                    comando.CommandType = System.Data.CommandType.Text;

                    comando.Parameters.AddWithValue("@valorBusqueda", placa);

                    conexion.Open();
                    var resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        return resultado.ToString();
                    }
                    else
                    {
                        return "No se encontró un tipo para la placa especificada.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción aquí
                // Por ejemplo, puedes imprimir el mensaje de error en la consola
                Console.WriteLine($"Error al buscar placa: {ex.Message}");
                return "Hubo un error al buscar el tipo de la placa especificada.";
            }
        }
        #endregion


        #region//RETORNA TABLA CON LOS EQUIPOS
        public DataTable Listar()
        {
            tblDatos = new DataTable();

            try
            {

                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objEquipo.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPEquipo");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); ;
            }
            return tblDatos;

        }
        #endregion

        //GUARDA EQUIPOS Y ACTUALIZAR

        public void Guardar_Actualizar()
        {



            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[5];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objEquipo.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@placa";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objEquipo.Placa;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@tipo";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objEquipo.Tipo;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@estado";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objEquipo.Estado;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@ubicacion";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objEquipo.Ubicacion;

                cnGeneral.EjecutarSP(parParameter, "SPEquipo");



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public void Eliminar()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objEquipo.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@placa";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objEquipo.Placa;

                cnGeneral.EjecutarSP(parParameter, "SPEquipo");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }





    }
}
