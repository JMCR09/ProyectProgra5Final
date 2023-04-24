using Incidentes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidentes.Controller
{

    public class IncidentesHelper
    {

        Datos cnGeneral = null;
        Incidentes objIncidente = null;
        DataTable tblDatos = null;

        public IncidentesHelper(Incidentes parobjIncidente)
        {
            objIncidente = parobjIncidente;
        }

        #region //Listar los incidentes
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
                parParameter[0].SqlValue = objIncidente.Opc;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPIncidentes");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); ;
            }
            return tblDatos;

        }
        #endregion

        #region//Actualizar incidentes
        public void Guardar_Actualizar()
        {

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objIncidente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@fecha";
                parParameter[1].SqlDbType = SqlDbType.DateTime;
                parParameter[1].SqlValue = objIncidente.Fecha;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@numIncidente";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 6;
                parParameter[2].SqlValue = objIncidente.NumIncidente;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@nivelIncidente";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 10;
                parParameter[3].SqlValue = objIncidente.Estado;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@estado";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 10;
                parParameter[4].SqlValue = objIncidente.Estado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@nombreCliente";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objIncidente.NombreCliente;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@telefono";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objIncidente.Telefono;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@descError";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 200;
                parParameter[7].SqlValue = objIncidente.DescError;

                cnGeneral.EjecutarSP(parParameter, "SPIncidentes");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        #endregion

        #region//Insertar incidentes
        public void Insertar()
        {

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objIncidente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@fecha";
                parParameter[1].SqlDbType = SqlDbType.DateTime;
                parParameter[1].SqlValue = objIncidente.Fecha;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@numIncidente";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 6;
                parParameter[2].SqlValue = objIncidente.NumIncidente;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@nivelIncidente";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 10;
                parParameter[3].SqlValue = objIncidente.Estado;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@estado";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 10;
                parParameter[4].SqlValue = objIncidente.Estado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@nombreCliente";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objIncidente.NombreCliente;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@telefono";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objIncidente.Telefono;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@descError";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 200;
                parParameter[7].SqlValue = objIncidente.DescError;

                cnGeneral.EjecutarSP(parParameter, "SPIncidentes");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        #endregion

    }
}
