using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14_Canciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Desarrolla una clase CD con los siguientes atributos: 
            // canciones: un array de objetos de la clase Cancion. 
            // contador: la siguiente posición libre del array canciones.
            //y los siguientes métodos: 
            // CD(): constructor predeterminado(creará el array canciones). 
            // numeroCanciones(): devuelve el valor del contador de canciones.
            // dameCancion(int): devuelve la Cancion que se encuentra en la posición indicada. 
            // grabaCancion(int, Cancion): cambia la Cancion de la posición indicada por la
            //nueva Cancion proporcionada. 
            // agrega(Cancion): agrega al final del array la Cancion proporcionada. 
            // elimina(int): elimina la Cancion que se encuentra en la posición indicada.
            // Crear canciones
            Cancion cancion1 = new Cancion("Cancion 1", "Artista 1");
            Cancion cancion2 = new Cancion("Cancion 2", "Artista 2");
            Cancion cancion3 = new Cancion("Cancion 3", "Artista 3");

            // Crear CD
            Cd cd = new Cd();

            // Agregar canciones al CD
            cd.agrega(cancion1);
            cd.agrega(cancion2);
            cd.agrega(cancion3);

            // Mostrar número de canciones en el CD
            Console.WriteLine($"Número de canciones en el CD: {cd.numeroCanciones()}");

            // Mostrar información de cada canción en el CD
            for (int i = 0; i < cd.numeroCanciones(); i++)
            {
                Cancion cancionActual = cd.dameCancion(i);
                Console.WriteLine($"Canción {i + 1}: {cancionActual}");
            }

            // Modificar una canción en el CD
            Cancion nuevaCancion = new Cancion("Nueva Cancion", "Nuevo Artista");
            cd.grabaCancion(1, nuevaCancion);

            // Mostrar información actualizada de cada canción en el CD
            Console.WriteLine("\nDespués de modificar una canción:");
            for (int i = 0; i < cd.numeroCanciones(); i++)
            {
                Cancion cancionActual = cd.dameCancion(i);
                Console.WriteLine($"Canción {i + 1}: {cancionActual}");
            }

            // Eliminar una canción del CD
            cd.elimina(0);

            // Mostrar información actualizada después de eliminar una canción
            Console.WriteLine("\nDespués de eliminar una canción:");
            for (int i = 0; i < cd.numeroCanciones(); i++)
            {
                Cancion cancionActual = cd.dameCancion(i);
                Console.WriteLine($"Canción {i + 1}: {cancionActual}");
            }
        }
    }
}
