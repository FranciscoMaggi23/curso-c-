using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15_Lista_Libros
{
    internal class ListaLibros
    {
        private List<Libros> _libros;

        public List<Libros> Libros
        {
            get { return _libros; }
            set { _libros = value; }
        }
        public ListaLibros()
        {
            _libros = new List<Libros>();
        }
        public int cantidadDeLIbros()
        {
            return _libros.Count;
        }

        public void InsertarLibro(Libros nuevoLibro)
        {
            int indice = 0;
            while (indice < _libros.Count && string.Compare(_libros[indice].Titulo, nuevoLibro.Titulo, StringComparison.OrdinalIgnoreCase) < 0)
            {
                indice++;
            }

            _libros.Insert(indice, nuevoLibro);
        }
        public void EliminarLibro(int posicion)
        {
            if (posicion >= 0 && posicion < _libros.Count)
            {
                _libros.RemoveAt(posicion);
            }
        }

        public Libros ObtenerLibro(int posicion)
        {
            if (posicion >= 0 && posicion < _libros.Count)
            {
                return _libros[posicion];
            }
            return null;
        }

        public int BuscarLibroPorTitulo(string parteTitulo)
        {
            for (int i = 0; i < _libros.Count; i++)
            {
                if (_libros[i].Titulo.IndexOf(parteTitulo, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
