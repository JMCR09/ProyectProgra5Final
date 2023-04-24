using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidentes.Controller
{
   public class Equipos
    {
        int opc;
        int placa;
        string tipo;
        string estado;
        string ubicacion;


        public int Opc { get => opc; set => opc = value; }
        public int Placa { get => placa; set => placa = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }


        public Equipos(int opc, int placa, string tipo, string estado, string ubicacion, bool existe)
        {
            this.Opc = opc;
            this.Placa = placa;
            this.Tipo = tipo;
            this.Estado = estado;
            this.Ubicacion = ubicacion;

        }

        public Equipos()
        {
            this.Opc = 0;
            this.Placa = 0;
            this.Tipo = "";
            this.Estado = "";
            this.Ubicacion = "";

        }


    }
}
