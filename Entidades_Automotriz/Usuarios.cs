using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Automotriz
{
    public class Usuarios
    {
        public Usuarios(int idusuario, string nombre, string apellidop, string apellidom, string fechan, string rfc)
        {
            Idusuario = idusuario;
            Nombre = nombre;
            Apellidop = apellidop;
            Apellidom = apellidom;
            Fechan = fechan;
            Rfc = rfc;
        }

        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string Apellidom { get; set; }
        public string Fechan { get; set; }
        public string Rfc { get; set; }
}
}
