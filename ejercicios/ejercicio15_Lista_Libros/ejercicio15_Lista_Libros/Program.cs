using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15_Lista_Libros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Desarrollar una lista de Libros ordenada por título. La funcionalidad de la lista será la
            //habitual: conocer el número de libros que hay en la lista, insertar un nuevo libro(en la
            //posición que le corresponda), eliminar el libro de una determinada posición y obtener el
            //libro de una determinada posición.También incluirá un método para buscar un libro a
            //partir de una parte de su título(sin distinguir entre mayúsculas y minúsculas); el
            //método devolverá la posición en la que se encuentra el libro(–1 si no se encuentra). 
            ListaLibros lista = new ListaLibros();

            Libros libro1 = new Libros("Cien años de soledad");
            Libros libro2 = new Libros("Don Quijote de la Mancha");
            Libros libro3 = new Libros("1984");

            lista.InsertarLibro(libro1);
            lista.InsertarLibro(libro2);
            lista.InsertarLibro(libro3);

            Console.WriteLine("Número de libros: " + lista.cantidadDeLIbros());

            int posicionBusqueda = lista.BuscarLibroPorTitulo("Quijote");
            if (posicionBusqueda != -1)
            {
                Console.WriteLine("Libro encontrado en la posición " + posicionBusqueda);
                Console.WriteLine(lista.ObtenerLibro(posicionBusqueda));
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }




        }
    }
}
