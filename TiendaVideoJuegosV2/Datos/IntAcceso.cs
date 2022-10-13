using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVideoJuegosV2.Datos
{
    internal interface IntAcceso<TJuego>
    {
        bool insertarJuego(TJuego juego);
        bool borrarJuego(TJuego juego);
        object buscarJuego(String nombre);
        List<object> obtenerJuegos();
        bool modificarJuego(TJuego juego, String titulo);
    }
}
