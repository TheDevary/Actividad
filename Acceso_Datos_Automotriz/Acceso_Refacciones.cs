﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace Acceso_Datos_Automotriz
{
    class Acceso_Refacciones : IEntidades
    {
        Base b = new Base("localhost", "root", "", "Automotriz");
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }



        public DataSet Mostrar(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
