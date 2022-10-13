using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVideoJuegosV2.Modelo
{
    class Errores : Exception
    {
        Exception ex;

        public Errores (Exception e)
        {
            ex = e;
        }
        public override string Message { get; }
    }
}
