using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideoJuegosV2.Modelo;

namespace TiendaVideoJuegosV2.Datos
{
    class AccesoJuego : AccesoBD, IntAcceso<TJuego>
    {
        
        public bool insertarJuego(TJuego juego)
        {
            try
            {
                return ejecutarUpdate(SentenciasSQL.sqlInsertarJuego(juego));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool borrarJuego(TJuego juego)
        {
            try
            {
                return ejecutarUpdate(SentenciasSQL.sqlBorrarJuego(juego.Titulo));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public object buscarJuego(string nombre)
        {
            try {
                return ejecutarConsulta(SentenciasSQL.sqlBuscarJuego(nombre), new TJuego()).First();
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public List<object> obtenerJuegos()
        {
            try
            {
                return ejecutarConsulta(SentenciasSQL.sqlObtenerJuegos(), new TJuego());
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public bool modificarJuego(TJuego juego, string titulo)
        {
            try
            {
                return ejecutarUpdate(SentenciasSQL.sqlModificarJuego(juego, titulo));
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
