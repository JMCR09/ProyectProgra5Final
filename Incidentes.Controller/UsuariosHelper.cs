using System;
using System.Data;
using System.Data.SqlClient;
using Incidentes.Controller;
using Incidentes.Model;



namespace Controlador
{
    public class UsuariosHelper
    {

        Datos cnGeneral = null;
        Usuarios objUsuario = null;
        DataTable tblDatos = null;


        public UsuariosHelper(Usuarios parObjUsuario)
        {
            objUsuario = parObjUsuario;
        }


        //RETORA TABLA CON LOS CONTACTOS
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
                parParameter[0].SqlValue = objUsuario.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        //GUARDA Y ACTUALIZAR USUARIO
        public void Guardar_Actualizar()
        {



            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[6];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuario.Opc; ;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = objUsuario.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Cedula";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objUsuario.Cedula;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Usuario";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objUsuario.Usuario;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Clave";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objUsuario.Clave;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@perfil";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objUsuario.Perfil;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");



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
                parParameter[0].SqlValue = objUsuario.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objUsuario.Cedula;



                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }



        public DataTable validarLogin()
        {
            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuario.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objUsuario.Usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@clave";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objUsuario.Clave;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;



        }


    }

}