using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideoJuegosV2.Modelo;

namespace TiendaVideoJuegosV2.Datos
{
    class SentenciasSQL
    {
        public static String sqlInsertarJuego(TJuego juego)
        {
            return "INSERT INTO `tjuego`(`compania`, `titulo`, `categoria`, `precio`,`formatouno`, `formatodos`, `estado`,`borrado`) VALUES ('"
                    + juego.Compania + "' , '" + juego.Titulo + "' , '" + juego.Categoria + "' , '"
                    + juego.Precio + "' , '" + juego.Formatouno + "' , '" + juego.Formatodos + "' , '" + juego.Estado + "' , '"
                    + juego.Borrado + "')";
        }

        public static String sqlBorrarJuego(String titulo)
        {
            return "delete from `tjuego` WHERE `Titulo` = '" + titulo + "'";
        }

        public static String sqlBuscarJuego(String nombre)
        {
            return "SELECT * FROM `tjuego` WHERE `Titulo` = '"
                    + nombre + "'";
        }

        public static String sqlObtenerJuegos()
        {
            return "SELECT * FROM `tjuego`";

        }

        public static String sqlModificarJuego(TJuego juego, String titulo)
        {
            return "UPDATE `tjuego` SET `titulo`= '" + juego.Titulo + "' ,`compañia`= '" + juego.Compania
                    + "' ,`categoria`= '" + juego.Categoria + "' ,`precio`= '" + juego.Precio + "' ,`formatouno`= '"
                    + juego.Formatouno + "' ,`formatodos`= '" + juego.Formatodos + "' ,`estado`= '" + juego.Estado + "' ,`borrado`= '" + juego.Borrado + "'  WHERE `titulo` = '"
                    + titulo + "'";
        }
    }
}
