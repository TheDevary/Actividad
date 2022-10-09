using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Acceso_Datos_Automotriz;
using Crud;
namespace Manejadores_Automotriz
{
    public class Manejador_Usuarios : IManajedor
    {
        Acceso_Usuarios au = new Acceso_Usuarios();
        Grafico g = new Grafico();

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("Estás seguro de eliminar: {0}", Entidad.Nombre), "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                au.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            au.Guardar(Entidad);
            g.Mensaje("Usuario Guardado", "¡Atención!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = au.Mostrar().Tables["Usuarios"];
            tabla.Columns.Insert(6, g.Boton("Editar", Color.Blue));
            tabla.Columns.Insert(7, g.Boton("Borra", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
