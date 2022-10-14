using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVideoJuegosV2.Modelo
{
    public class TJuego
    {
        public string CodJuego { get; set; }

        public string Compania { get; set; }

        public string Titulo { get; set; }
        public string Categoria  { get; set; }
        public string Precio { get; set; }
        public string Formatouno { get; set; }
        public string Formatodos { get; set; }
        public string Estado { get; set; }
        public string Borrado { get; set; }

        public TJuego()
        {
        }

        public TJuego(string codJuego, string compania, string titulo, string categoria, string precio, string formatouno, string formatodos, string estado, string borrado)
        {
            CodJuego = codJuego;
            Compania = compania;
            Titulo = titulo;
            Categoria = categoria;
            Precio = precio;
            Formatouno = formatouno;
            Formatodos = formatodos;
            Estado = estado;
            Borrado = "0";
        }

        public TJuego(string compañia, string titulo, string categoria, string precio, string formatouno, string formatodos, string estado, string borrado)
        {
            Compania = compañia;
            Titulo = titulo;
            Categoria = categoria;
            Precio = precio;
            Formatouno = formatouno;
            Formatodos = formatodos;
            Estado = estado;
            Borrado = "0";
        }

        public TJuego(string compania, string titulo, string categoria, string precio, string formatouno, string formatodos, string estado)
        {
            this.Compania = compania;
            Titulo = titulo;
            Categoria = categoria;
            Precio = precio;
            Formatouno = formatouno;
            Formatodos = formatodos;
            Estado = estado;
            Borrado = "0";
        }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
