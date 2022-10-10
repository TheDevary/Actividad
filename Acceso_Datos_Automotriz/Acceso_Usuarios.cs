using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBD;

namespace Acceso_Datos_Automotriz
{
    public class Acceso_Usuarios : IEntidades
    {

        Base b = new Base("localhost", "root", "", "automotriz");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call DeleteUsuario({0})", Entidad.Idusuario));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call InsertUsuario({0},{1},{2},{3},{4},{5})", Entidad.Nombre, Entidad.Apellidop, Entidad.Apellidom, Entidad.Fechan, Entidad.Rfc, Entidad.Idusuario));
        }

        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("call ShowUsuarios()"),"Usuarios");
        }
    }
}
