using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidentes.Controller
{
    public class Usuarios
    {
        int opc;
        string nombre;
        string cedula;
        string usuario;
        string clave;
        string perfil;

        public Usuarios(int opc, string nombre, string cedula, string usuarios, string clave, string perfil)
        {
            this.Opc = opc;
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Usuario = usuarios;
            this.Clave = clave;
            this.Perfil = perfil;
        }

        public Usuarios()
        {
            this.Opc = 0;
            this.Nombre = "";
            this.Cedula = "";
            this.Usuario = "";
            this.Clave = "";
            this.Perfil = "";
        }

        public int Opc { get => opc; set => opc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Perfil { get => perfil; set => perfil = value; }
    }

}
