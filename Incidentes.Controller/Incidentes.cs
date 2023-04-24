using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidentes.Controller
{
    public class Incidentes
    {
        int opc;
        string numIncidente, nivelIncidente, estado, nombreCliente, telefono, descError;
        DateTime fecha;

        public Incidentes(int opc, string numIncidente, string nivelIncidente, string estado, string nombreCliente, string telefono, string descError, DateTime fecha)
        {
            this.Opc = opc;
            this.NumIncidente = numIncidente;
            this.NivelIncidente = nivelIncidente;
            this.Estado = estado;
            this.NombreCliente = nombreCliente;
            this.Telefono = telefono;
            this.DescError = descError;
            this.Fecha = fecha;
        }

        public Incidentes()
        {
            this.Opc = 0;
            this.NumIncidente = "";
            this.NivelIncidente = "";
            this.Estado = "";
            this.NombreCliente = "";
            this.Telefono = "";
            this.DescError = "";
            this.Fecha = DateTime.Now;
        }

        public int Opc { get => opc; set => opc = value; }
        public string NumIncidente { get => numIncidente; set => numIncidente = value; }
        public string NivelIncidente { get => nivelIncidente; set => nivelIncidente = value; }
        public string Estado { get => estado; set => estado = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string DescError { get => descError; set => descError = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
