using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores_Automotriz;
using Entidades_Automotriz;

namespace Presentacion_Automotriz
{
    public partial class FrmPermisos : Form
    {
        Manejador_Usuarios mu;
        public static Usuarios usuario = new Usuarios(0, "", "", "", "", "");
        int fila = 0, col = 0;

        public FrmPermisos()
        {
            InitializeComponent();
            mu = new Manejador_Usuarios();
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (col)
            {
                case 6:
                    {
                        Actualizar();
                    }
                    break;
                case 7:
                    {
                        mu.Borrar(usuario);
                        Actualizar();
                    }
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
            usuario.Idusuario = int.Parse(dtgUsuarios.Rows[fila].Cells[0].Value.ToString());
            usuario.Nombre = dtgUsuarios.Rows[fila].Cells[1].Value.ToString();
            usuario.Apellidop = dtgUsuarios.Rows[fila].Cells[2].Value.ToString();
            usuario.Apellidom = dtgUsuarios.Rows[fila].Cells[3].Value.ToString();
            usuario.Fechan = dtgUsuarios.Rows[fila].Cells[4].Value.ToString();
            usuario.Rfc = dtgUsuarios.Rows[fila].Cells[5].Value.ToString();
        }
        void Actualizar()
        {
            mu.Mostrar(dtgUsuarios);
        }
    }
}
