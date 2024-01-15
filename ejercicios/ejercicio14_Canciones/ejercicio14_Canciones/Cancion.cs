using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14_Canciones
{
    internal class Cancion
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }

        public Cancion(string titulo, string artista)
        {
            Titulo = titulo;
            Artista = artista;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Artista}";
        }
    }
}
