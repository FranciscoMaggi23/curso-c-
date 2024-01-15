using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14_Canciones
{
    internal class Cd
    {
        private Cancion[] canciones;
        private int contador;

        // CD(): constructor predeterminado(creará el array canciones). 
        public Cd() 
        {
            canciones = new Cancion[10];
            contador = 0;
        }
        // numeroCanciones(): devuelve el valor del contador de canciones.
        public int numeroCanciones()
        {
            return contador;    
        }
        // dameCancion(int): devuelve la Cancion que se encuentra en la posición indicada. 
        public Cancion dameCancion(int posicion)
        {   
            //return canciones[indice];
            if (posicion >= 0 && posicion < contador)
            {
                return canciones[posicion];
            }
            else
            {
                Console.WriteLine("Posición inválida.");
                return null;
            }
        }
        // grabaCancion(int, Cancion): cambia la Cancion de la posición indicada por la
        //nueva Cancion proporcionada. 
        public void grabaCancion(int posicion, Cancion nuevaCancion)
        {
            if (posicion >= 0 && posicion < contador)
            {
                canciones[posicion]=nuevaCancion;
            }
            else
            {
                Console.WriteLine("Posición inválida.");
            }
        }
        // agrega(Cancion): agrega al final del array la Cancion proporcionada. 
        public void agrega(Cancion nuevaCancion)
        {
            if (contador < canciones.Length)
            {
                canciones[contador] = nuevaCancion;
                contador++;
            }
            else
            {
                Console.WriteLine("El CD está lleno. No se pudo agregar la canción.");
            }
        }
        // elimina(int): elimina la Cancion que se encuentra en la posición indicada.
        public void elimina(int posicion) 
        {
            if (posicion >= 0 && posicion < contador)
            {
                for (int i = posicion; i < contador - 1; i++)
                {
                    canciones[i] = canciones[i + 1];
                }

                canciones[contador - 1] = null; // Eliminamos la referencia a la última canción
                contador--;

                Console.WriteLine("Canción eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Posición inválida. No se pudo eliminar la canción.");
            }
        }




    }
}
