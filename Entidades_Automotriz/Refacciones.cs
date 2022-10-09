using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Automotriz
{
    public class Refacciones
    {
        public Refacciones(string codigob, string nombre, string descripcion, string marca)
        {
            Codigob = codigob;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
        }

        public string Codigob { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
    }
}
