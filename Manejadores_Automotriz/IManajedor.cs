using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores_Automotriz
{
    interface IManajedor
    {
        void Borrar(dynamic Entidad);
        void Guardar(dynamic Entidad);
        void Mostrar(DataGridView tabla);
    }
}
